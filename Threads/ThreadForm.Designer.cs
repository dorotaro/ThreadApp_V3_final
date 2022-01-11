namespace ThreadApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private async void InitializeComponent()
		{
			System.Windows.Forms.ColumnHeader RandomString;
			this.button1 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.ID = new System.Windows.Forms.ColumnHeader();
			this.DateAdded = new System.Windows.Forms.ColumnHeader();
			this.ThreadId = new System.Windows.Forms.ColumnHeader();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.button2 = new System.Windows.Forms.Button();
			RandomString = new System.Windows.Forms.ColumnHeader();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// RandomString
			// 
			RandomString.DisplayIndex = 2;
			RandomString.Text = "Random String";
			RandomString.Width = 120;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(411, 82);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 36);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Start_threading_button);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            RandomString,
            this.DateAdded,
            this.ThreadId});
			this.listView1.Location = new System.Drawing.Point(-1, 206);
			this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(801, 346);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// ID
			// 
			this.ID.Text = "ID";
			// 
			// DateAdded
			// 
			this.DateAdded.DisplayIndex = 3;
			this.DateAdded.Text = "Date Added";
			this.DateAdded.Width = 100;
			// 
			// ThreadId
			// 
			this.ThreadId.DisplayIndex = 1;
			this.ThreadId.Text = "Thead ID";
			this.ThreadId.Width = 100;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(194, 82);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(539, 82);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 36);
			this.button2.TabIndex = 3;
			this.button2.Text = "Stop";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Stop_threading_button);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 562);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Button button1;
		private ListView listView1;
		private NumericUpDown numericUpDown1;
		private Button button2;
		private ColumnHeader ID;
		private ColumnHeader DateAdded;
		private ColumnHeader ThreadId;
	}
}