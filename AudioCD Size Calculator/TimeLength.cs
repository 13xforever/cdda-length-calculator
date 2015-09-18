using System;
using System.Linq;

namespace AudioCD_Size_Calculator
{
	internal class TimeLength
	{
		private static readonly byte[] cddaHeader = {0x52, 0x49, 0x46, 0x46, 0x24, 0x00, 0x00, 0x00, 0x43, 0x44, 0x44, 0x41, 0x66, 0x6D, 0x74, 0x20};

		public TimeLength() { }

		public TimeLength(int frames)
		{
			Frames = frames;
			Normalize();
		}

		public TimeLength(int hours, int minutes, int seconds, int frames)
		{
			Hours = hours;
			Minutes = minutes;
			Seconds = seconds;
			Frames = frames;
			Normalize();
		}

		public int Hours { get; set; }
		public int Minutes { get; set; }
		public int Seconds { get; set; }
		public int Frames { get; set; }

		public override string ToString()
		{
			if (Hours > 0)
				return $"{Hours:0}:{Minutes:00}:{Seconds:00}.{Frames:00}";
			if (Minutes > 0)
				return $"{Minutes:0}:{Seconds:00}.{Frames:00}";
			return $"{Seconds:0}.{Frames:00}";
		}

		public static TimeLength operator +(TimeLength t1, TimeLength t2)
		{
			return new TimeLength
			{
				Hours = t1.Hours + t2.Hours,
				Minutes = t1.Minutes + t2.Minutes,
				Seconds = t1.Seconds + t2.Seconds,
				Frames = t1.Frames + t2.Frames,
			}.Normalize();
		}

		private TimeLength Normalize()
		{
			Seconds += Frames / 75;
			Minutes += Seconds / 60;
			Hours += Minutes / 60;

			Frames %= 75;
			Seconds %= 60;
			Minutes %= 60;

			return this;
		}

		public static TimeLength Parse(byte[] riffHeader)
		{
			if (riffHeader == null)
				throw new ArgumentNullException();

			if (riffHeader.Length != 0x2c)
				throw new ArgumentException("CDDA RIFF data length mismatch");

			if (!riffHeader.Take(cddaHeader.Length).SequenceEqual(cddaHeader))
				throw new ArgumentException("CDDA RIFF header mismatch");

			var frames = BitConverter.ToInt32(riffHeader, 0x20);
			return new TimeLength(frames);
		}

		public static TimeLength Parse(string timeLength)
		{
			if (timeLength == null)
				throw new ArgumentNullException();
			if (timeLength.Length < 1)
				throw new ArgumentException();

			int h = 0, m = 0, s = 0, f;
			var parts = timeLength.Split(':', '.');
			if (parts.Length == 4)
			{
				int.TryParse(parts[0], out h);
				int.TryParse(parts[1], out m);
				int.TryParse(parts[2], out s);
				int.TryParse(parts[3], out f);
			}
			else if (parts.Length == 3)
			{
				int.TryParse(parts[0], out m);
				int.TryParse(parts[1], out s);
				int.TryParse(parts[2], out f);
			}
			else if (parts.Length == 2)
			{
				int.TryParse(parts[0], out s);
				int.TryParse(parts[1], out f);
			}
			else if (parts.Length == 1)
				int.TryParse(parts[0], out f);
			else
				throw new FormatException();

			return new TimeLength(h, m, s, f);
		}
	}
}