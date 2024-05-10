using AutoCursor.Library;
using AutoCursor.WindowsForms.Extensions;
using System.Diagnostics;

namespace AutoCursor.WindowsForms
{
    public partial class AppForm : Form
    {
        private readonly WindowsCursor _cursor;

        private int _interval = 300;
        private int _tick = 0;

        public AppForm()
        {
            InitializeComponent();
            _cursor = new WindowsCursor();
        }

        private void Error(Exception ex)
        {
            MessageBox.Show(ex.GetMessage(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SetProcessing(bool start)
        {
            _interval = Convert.ToInt32(intervalNumericUpDown.Value);
            toolStripProgressBar.Maximum = _interval;

            stopButton.Enabled = start;
            stopToolStripMenuItem.Enabled = start;
            timer.Enabled = start;

            intervalNumericUpDown.Enabled = !start;
            startButton.Enabled = !start;
            startToolStripMenuItem.Enabled = !start;
            xNumericUpDown.Enabled = !start;
            yNumericUpDown.Enabled = !start;

            if (!start)
            {
                _tick = 0;
                toolStripProgressBar.Value = 0;
            }
        }

        private void Start()
        {
            try
            {
                SetProcessing(true);
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void Stop()
        {
            try
            {
                SetProcessing(false);
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_tick == intervalNumericUpDown.Value)
            {
                _tick = 0;
                _cursor.Click(Convert.ToInt32(xNumericUpDown.Value), Convert.ToInt32(yNumericUpDown.Value));
            }
            else
            {
                _tick++;
                toolStripProgressBar.Value = _tick;
            }
        }
    }
}
