using AutoCursor.Library;
using AutoCursor.WindowsForms.Extensions;
using System.Diagnostics;

namespace AutoCursor.WindowsForms
{
    public partial class AppForm : Form
    {
        private readonly WindowsCursor _cursor;
        private readonly WindowsLastInput _lastInput;
        private readonly MorningGreetings _morning;

        private int _interval = 122;
        private int _tick = 0;

        public AppForm()
        {
            InitializeComponent();
            _cursor = new WindowsCursor();
            _lastInput = new WindowsLastInput();
            _morning = new MorningGreetings();
        }

        private void Error(Exception ex)
        {
            MessageBox.Show(ex.GetMessage(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Minimize()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void SetProcessing(bool start)
        {
            _interval = Convert.ToInt32(intervalNumericUpDown.Value);
            _lastInput.SetIdleThreshold(Convert.ToUInt32(_interval));
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
            Minimize();
        }

        private void AppForm_Shown(object sender, EventArgs e)
        {
            Start();

            MessageBox.Show(_morning.GetRandomGreeting(), "👻❤️🐒", MessageBoxButtons.OK, MessageBoxIcon.None);

            Minimize();
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
            if (_tick == _interval)
            {
                _tick = 0;
                if (!_lastInput.IsIdle())
                {
                    return;
                }
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
