namespace Shutdowner
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.ArmButton = new System.Windows.Forms.Button();
			this.DisarmButton = new System.Windows.Forms.Button();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.OutputTextBox = new System.Windows.Forms.TextBox();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.AbortButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// DateTimePicker
			// 
			this.DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DateTimePicker.CustomFormat = "dd/MM/yyyy hh:mm:ss";
			this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker.Location = new System.Drawing.Point(108, 12);
			this.DateTimePicker.Name = "DateTimePicker";
			this.DateTimePicker.Size = new System.Drawing.Size(213, 20);
			this.DateTimePicker.TabIndex = 0;
			// 
			// ArmButton
			// 
			this.ArmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ArmButton.Location = new System.Drawing.Point(0, 0);
			this.ArmButton.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
			this.ArmButton.Name = "ArmButton";
			this.ArmButton.Size = new System.Drawing.Size(151, 23);
			this.ArmButton.TabIndex = 1;
			this.ArmButton.Text = "Arm";
			this.ArmButton.UseVisualStyleBackColor = true;
			this.ArmButton.Click += new System.EventHandler(this.ArmButton_Click);
			// 
			// DisarmButton
			// 
			this.DisarmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DisarmButton.Location = new System.Drawing.Point(157, 0);
			this.DisarmButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.DisarmButton.Name = "DisarmButton";
			this.DisarmButton.Size = new System.Drawing.Size(152, 23);
			this.DisarmButton.TabIndex = 2;
			this.DisarmButton.Text = "Disarm";
			this.DisarmButton.UseVisualStyleBackColor = true;
			this.DisarmButton.Click += new System.EventHandler(this.DisarmButton_Click);
			// 
			// Timer
			// 
			this.Timer.Interval = 1000;
			this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// OutputTextBox
			// 
			this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OutputTextBox.Location = new System.Drawing.Point(12, 68);
			this.OutputTextBox.Multiline = true;
			this.OutputTextBox.Name = "OutputTextBox";
			this.OutputTextBox.ReadOnly = true;
			this.OutputTextBox.Size = new System.Drawing.Size(309, 163);
			this.OutputTextBox.TabIndex = 3;
			// 
			// ProgressBar
			// 
			this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgressBar.Location = new System.Drawing.Point(12, 237);
			this.ProgressBar.MarqueeAnimationSpeed = 30;
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(309, 23);
			this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.ProgressBar.TabIndex = 4;
			this.ProgressBar.Visible = false;
			// 
			// AbortButton
			// 
			this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AbortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AbortButton.Location = new System.Drawing.Point(12, 266);
			this.AbortButton.Name = "AbortButton";
			this.AbortButton.Size = new System.Drawing.Size(309, 40);
			this.AbortButton.TabIndex = 5;
			this.AbortButton.Text = "ABORT";
			this.AbortButton.UseVisualStyleBackColor = true;
			this.AbortButton.Visible = false;
			this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.ArmButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.DisarmButton, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 24);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Shutdown time";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 318);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.AbortButton);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.OutputTextBox);
			this.Controls.Add(this.DateTimePicker);
			this.Name = "MainForm";
			this.Text = "Shutdowner";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker DateTimePicker;
		private System.Windows.Forms.Button ArmButton;
		private System.Windows.Forms.Button DisarmButton;
		private System.Windows.Forms.Timer Timer;
		private System.Windows.Forms.TextBox OutputTextBox;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Button AbortButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
	}
}

