namespace AudioCD_Size_Calculator
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.deviceSelectionBox = new System.Windows.Forms.ComboBox();
			this.deviceRefreshButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.trackList = new System.Windows.Forms.ListView();
			this.label2 = new System.Windows.Forms.Label();
			this.totalLenghtBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.trackNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// deviceSelectionBox
			// 
			this.deviceSelectionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.deviceSelectionBox.FormattingEnabled = true;
			this.deviceSelectionBox.Location = new System.Drawing.Point(13, 13);
			this.deviceSelectionBox.Name = "deviceSelectionBox";
			this.deviceSelectionBox.Size = new System.Drawing.Size(200, 21);
			this.deviceSelectionBox.TabIndex = 0;
			this.deviceSelectionBox.SelectedIndexChanged += new System.EventHandler(this.deviceSelectionBox_SelectedIndexChanged);
			// 
			// deviceRefreshButton
			// 
			this.deviceRefreshButton.Location = new System.Drawing.Point(219, 13);
			this.deviceRefreshButton.Name = "deviceRefreshButton";
			this.deviceRefreshButton.Size = new System.Drawing.Size(21, 21);
			this.deviceRefreshButton.TabIndex = 1;
			this.deviceRefreshButton.Text = "↻";
			this.deviceRefreshButton.UseVisualStyleBackColor = true;
			this.deviceRefreshButton.Click += new System.EventHandler(this.deviceRefreshButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Audio CD Tracks";
			// 
			// trackList
			// 
			this.trackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trackNumber,
            this.length});
			this.trackList.Location = new System.Drawing.Point(13, 58);
			this.trackList.Name = "trackList";
			this.trackList.Size = new System.Drawing.Size(227, 314);
			this.trackList.TabIndex = 3;
			this.trackList.UseCompatibleStateImageBehavior = false;
			this.trackList.View = System.Windows.Forms.View.Details;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 389);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Total Length";
			// 
			// totalLenghtBox
			// 
			this.totalLenghtBox.Location = new System.Drawing.Point(12, 406);
			this.totalLenghtBox.Name = "totalLenghtBox";
			this.totalLenghtBox.ReadOnly = true;
			this.totalLenghtBox.Size = new System.Drawing.Size(228, 22);
			this.totalLenghtBox.TabIndex = 5;
			this.totalLenghtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.totalLenghtBox.WordWrap = false;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(12, 435);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(102, 23);
			this.addButton.TabIndex = 6;
			this.addButton.Text = "Add Current CD";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(175, 434);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(65, 23);
			this.resetButton.TabIndex = 7;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// trackNumber
			// 
			this.trackNumber.Text = "#";
			// 
			// length
			// 
			this.length.Text = "Length";
			this.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.length.Width = 143;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 471);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.totalLenghtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.trackList);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.deviceRefreshButton);
			this.Controls.Add(this.deviceSelectionBox);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "Audio CD Size Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox deviceSelectionBox;
		private System.Windows.Forms.Button deviceRefreshButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView trackList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox totalLenghtBox;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.ColumnHeader trackNumber;
		private System.Windows.Forms.ColumnHeader length;
	}
}

