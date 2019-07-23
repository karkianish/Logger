using System;
using System.IO;
using System.Windows.Forms;

namespace Logger
{
    public partial class Logger : Form
    {
    // testing 123

        int m_DefaultInterval = 10000;
        string m_Path = @"C:\Users\Anish\Desktop\log";
        string m_FileName = string.Empty;

        public Logger()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = m_DefaultInterval;
            textBoxTimerInterval.Text = (timer1.Interval / 1000).ToString();
            m_FileName = GetFileName();
        }

        private string GetFileName()
        {
            string todaysDate = DateTime.Now.ToShortDateString().Replace("/", "").Replace(" ", "") + "a";
                 
            string fileName = "log_" +  todaysDate + ".txt";
            return fileName;
        }

        private void OnClick_BtnSet(object sender, EventArgs e)
        {
            int inputInterval = 0;
            bool isANumber_inputInterval = int.TryParse(textBoxTimerInterval.Text, out inputInterval);
            timer1.Interval = isANumber_inputInterval ? inputInterval * 1000 : m_DefaultInterval;
            timer1.Start();
        }

        private void OnClick_BtnSave(object sender, EventArgs e)
        {
            SaveToFile();
            WindowState = FormWindowState.Minimized; 
        }

        private void SaveToFile()
        {
            string filePath = GetFilePath();
            using (StreamWriter streamWriter = File.AppendText(filePath))
            {
                streamWriter.Write(DateTime.Now);
                streamWriter.Write(new string(' ', 5));
                streamWriter.WriteLine(rtbNotes.Text);
            }
        }

        private string GetFilePath()
        {
            string filePath = Path.Combine(m_Path, m_FileName);
            if (!Directory.Exists(m_Path))
            {
                Directory.CreateDirectory(m_Path);
                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                }
            }

            return filePath;
        }


        private void OnClick_BtnSaveAndAddMore(object sender, EventArgs e)
        {
            SaveToFile();
            ResetForm();
        }

        private void ResetForm()
        {
            rtbNotes.Clear();
            rtbNotes.Focus();
        }

        private void OntTick_Timer(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            rtbNotes.Clear();
            rtbNotes.Focus();
        }
    }
}
