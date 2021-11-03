using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TibiaAntyAFK
{
    public partial class Tibia : Form
    {
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_MINIMIZE = 6;
        private const int SW_MAXIMIZE = 3;
        public Tibia()
        {
            InitializeComponent();

            executeLogic();
            timer.Interval = 1000 * 60 * 6;
            timer.Enabled = true;
        }

        private void executeLogic()
        {
            System.Diagnostics.Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] p1 = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process pro in p1)
            {
                if (pro.MainWindowTitle.ToLower().Contains("tibia - "))
                {
                    ShowWindow(pro.MainWindowHandle, SW_MAXIMIZE);
                    SetForegroundWindow(pro.MainWindowHandle);
                    sendKeysToWindow();
                    characterName.Text = pro.MainWindowTitle.Replace("Tibia - ", "");
                    if (hideTibia.Checked)
                    {
                        ShowWindow(pro.MainWindowHandle, SW_MINIMIZE);
                    }
                    break;
                }
            }
            returnToPreviousProcess(currentProcess.MainWindowHandle);
        }

        private void sendKeysToWindow()
        {
            if (top.Checked)
            {
                sendKey("^{UP}");
            }

            if (down.Checked)
            {
                sendKey("^{DOWN}");
            }

            if (left.Checked)
            {
                sendKey("^{LEFT}");
            }

            if (right.Checked)
            {
                sendKey("^{RIGHT}");
            }

            Random random = new Random();
            Int32 newDelay = 1000 * 60 * 6 + random.Next(15 * 1000, 30 * 1000);
            delayLabel.Text = "delay: " + (newDelay/1000).ToString() + " seconds";
            timer.Interval = newDelay;
        }

        private void returnToPreviousProcess(IntPtr mainWindowHandle)
        {
            SetForegroundWindow(mainWindowHandle);
        }

        private void sendKey(String key)
        {
            SendKeys.SendWait(key);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            executeLogic();
        }

        private void executeLogicOnChangedCheckbox(object sender, EventArgs e)
        {
            executeLogic();
        }
    }
}
