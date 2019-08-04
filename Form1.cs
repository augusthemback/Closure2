using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Closure2
{
    public partial class ClosureForm : Form
    {
		// Fields
		private readonly string path = "ClosureBatch.bat";
		private readonly string command = "SHUTDOWN -s -t ";
		private readonly string abortCommand = "SHUTDOWN -a";
		private int delay;

		// Constructor
		public ClosureForm() {
            InitializeComponent();
        }

		// InstantShutdownBtn click method
        private void InstantShutdownBtn_Click(object sender, EventArgs e) {
			Program.StartDelay(path, command + 60);
        }

		// DelayedShutdownBtn click method
		private void DelayedShutdownBtn_Click(object sender, EventArgs e) {

			// Calculates delay
			delay = Program.ConvertToSeconds((int)HoursSlider.Value, (int)MinutesSlider.Value, (int)SecondsSlider.Value);

			// If delay wasn't set
			if(delay == 0) {

				// Show error message and return if user cancels
				if (Program.DisplayWarning("<Warning>\nDelay is currently set to 0 seconds.") == DialogResult.Cancel)
					return;
			}

			// Start delay
			Program.StartDelay(path, command + delay);
		}

		// Form load method
		private void ClosureForm_Load(object sender, EventArgs e) {
			Program.AbortPrevious(path, abortCommand);
		}
	}
}
