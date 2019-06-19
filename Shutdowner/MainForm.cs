using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shutdowner
{
	public partial class MainForm : Form
	{
		private bool armed;
		private bool shuttingDown;

		private void Arm()
		{
			armed = true;
			ProgressBar.Visible = true;
			DateTimePicker.Enabled = false;
			ArmButton.Enabled = false;
			DisarmButton.Enabled = true;
		}

		private void Disarm()
		{
			armed = false;
			ProgressBar.Visible = false;
			DateTimePicker.Enabled = true;
			ArmButton.Enabled = true;
			DisarmButton.Enabled = false;
		}

		private void WriteLine(string line)
		{
			OutputTextBox.AppendText(Environment.NewLine + line);
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// Prevent windows from sleeping when program is running
			NativeMethods.SetThreadExecutionState(NativeMethods.ES_CONTINUOUS | NativeMethods.ES_SYSTEM_REQUIRED);

			armed = false;
			shuttingDown = false;
			OutputTextBox.AppendText("Hello and welcome!");
		}

		private void ArmButton_Click(object sender, EventArgs e)
		{
			if (armed)
			{
				WriteLine("Already armed.");
				return;
			}

			if (DateTimePicker.Value <= DateTime.Now)
			{
				WriteLine("Choose a shutdown time in the future.");
				return;
			}

			Arm();

			WriteLine("Set to shutdown at " + DateTimePicker.Value.ToLongTimeString() + ", " + DateTimePicker.Value.ToLongDateString() + ".");
		}

		private void DisarmButton_Click(object sender, EventArgs e)
		{
			if (!armed)
			{
				WriteLine("Already not armed.");
				return;
			}

			Disarm();

			WriteLine("Shutdown disarmed.");
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (armed && !shuttingDown)
			{
				if (DateTimePicker.Value < DateTime.Now)
				{
					WriteLine("Shutting down in 30 seconds!");
					shuttingDown = true;
					AbortButton.Visible = true;
					DisarmButton.Enabled = false;
					Process.Start("shutdown", "/s /t 30");
				}
			}
		}

		private void AbortButton_Click(object sender, EventArgs e)
		{
			if (!shuttingDown)
			{
				WriteLine("Already not shutting down.");
				return;
			}

			WriteLine("Aborting shutdown!");
			shuttingDown = false;
			AbortButton.Visible = false;
			Process.Start("shutdown", "/a");

			Disarm();
		}
	}
}
