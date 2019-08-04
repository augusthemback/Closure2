using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Closure2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClosureForm());
        }

		// Method for aborting any active delayed shutdown
		public static void AbortPrevious(string path, string abortCommand) {
			WriteAndRun(path, abortCommand);
		}


		// Method for displaying message
		public static DialogResult DisplayWarning(string message) {
			return MessageBox.Show(message, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}

		// Method for starting the set shutdown delay
		public static void StartDelay(string path, string command) {
			WriteAndRun(path, command);
		}

		// Method for writing to file and running file
		private static void WriteAndRun(string path, string command) {
			File.WriteAllText(path, command);
			System.Diagnostics.Process.Start(path);
		}

		// Method for converting the set delay to seconds
		public static int ConvertToSeconds(int hours, int minutes, int seconds) {
			int minuteMultiplier = 60;
			int hourMultiplier = 3600;

			int sum = (hours * hourMultiplier) + (minutes * minuteMultiplier) + seconds;

			return sum;
		}
    }
}
