using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AudioCD_Size_Calculator
{
	public partial class Form1 : Form
	{
		private DriveInfo[] drives = new DriveInfo[0];
		private TimeLength[] timeLengths = new TimeLength[0];

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			deviceRefreshButton_Click(sender, e);
		}

		private void deviceRefreshButton_Click(object sender, EventArgs e)
		{
			try
			{
				drives = DriveInfo.GetDrives().Where(i => i.DriveType == DriveType.CDRom).ToArray();
				deviceSelectionBox.Items.Clear();
				if (drives.Length == 0)
				{
					deviceSelectionBox.Enabled = false;
					deviceSelectionBox.Items.Add("None");
				}
				else
				{
					deviceSelectionBox.Enabled = true;
					deviceSelectionBox.Items.AddRange(drives.Select(i => $"{i.Name} ({i.VolumeLabel})").ToArray());
					deviceSelectionBox.SelectedIndex = 0;
				}
			}
			catch
			{
				drives = new DriveInfo[0];
				deviceSelectionBox.Enabled = false;
				deviceSelectionBox.Items.Add("Device enumeration error");
			}
		}

		private void deviceSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			trackList.Items.Clear();
			var drive = drives[deviceSelectionBox.SelectedIndex];
			if (!drive.IsReady)
				return;

			var tracks = Directory.GetFiles(drive.RootDirectory.ToString());
			timeLengths = tracks.Select(path => TimeLength.Parse(File.ReadAllBytes(path))).ToArray();
			for (var i = 0; i < tracks.Length; i++)
				trackList.Items.Add((i + 1).ToString()).SubItems.Add(timeLengths[i].ToString());
		}

		private void resetButton_Click(object sender, EventArgs e) { totalLenghtBox.Text = ""; }

		private void addButton_Click(object sender, EventArgs e)
		{
			var result = string.IsNullOrEmpty(totalLenghtBox.Text) ? new TimeLength() : TimeLength.Parse(totalLenghtBox.Text);
			foreach (var len in timeLengths)
				result += len;
			totalLenghtBox.Text = result.ToString();
		}
	}
}
