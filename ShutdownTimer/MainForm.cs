using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShutdownTimer
{
    public partial class MainForm : Form
    {
        int hh;
        int s1;
        int mm;
        int s2;
        Timer t = new Timer();

        public MainForm()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        static void ExecuteCommand(string command)
        {
            int exit;
            
            ProcessStartInfo processInfo;
            Process process;
            processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            //process.WaitForExit();

            // *** Read the streams ***
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            exit = process.ExitCode;

            Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
            Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
            Console.WriteLine("ExitCode: " + exit.ToString(), "ExecuteCommand");
            process.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int timer = Convert.ToInt32(textBox1.Text) * 60;
                string time = Convert.ToString(timer);
                timer1.Start();
                ExecuteCommand("shutdown.exe /s /t " + time);
                timeConverter();
                textBox1.Clear();
                button2.Enabled = true;
                label2.Text = "";
            }
            catch 
            {
                label2.Text = "Please Insert Time";
            }
        }

         public void timeConverter ()
            {
                int time = Convert.ToInt32(textBox1.Text) * 60;
                hh = time / 3600;
                s1 = time % 3600;
                mm = s1 / 60;
                s2 = s1 % 60;
             Console.WriteLine("{0} Hours, {1} Minutes, {2} Seconds", hh, mm, s2);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExecuteCommand("shutdown.exe /a");
            hourLabel.Text = ("00");
            minuteLabel.Text = ("00");
            secondLabel.Text = ("00");
            timer1.Stop();
            MessageBox.Show("Shutdown Aborted");

            Close();
        }

        private void thisIsTrialProgramNoWarrentyIdGivenFromDeveloperUseItInYourOwnRiskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s2 = s2 - 1;
            if (s2 == -1)
            {
                mm = mm - 1;
                s2 = 59;
            }
            if (mm == -1)
            {
                hh = hh - 1;
                mm = 59;
            }
            hourLabel.Text = Convert.ToString(hh).PadLeft(2, '0');
            minuteLabel.Text = Convert.ToString(mm).PadLeft(2, '0');
            secondLabel.Text = Convert.ToString(s2).PadLeft(2, '0');
        }

        
    }
}
