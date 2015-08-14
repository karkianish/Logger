using System;
using System.IO;
using System.Windows.Forms;

namespace Logger
{
    public partial class Logger : Form
    {

        int m_DefaultInterval = 10000;
        string m_Path = @"C:\Users\Anish\Desktop\log";
        string m_FileName = "log.txt";

        public Logger()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = m_DefaultInterval;
            textBoxTimerInterval.Text = (timer1.Interval / 1000).ToString();
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
            ResetTimer();
        }

        private void ResetTimer()
        {
            //throw new NotImplementedException();
        }

        private void SaveToFile()
        {
            //todo fix overriding of the old file
            string f = Path.Combine(m_Path, m_FileName);
            if (!Directory.Exists(m_Path))
            {
                Directory.CreateDirectory(m_Path);
                if(!File.Exists(f))
                {
                    File.Create(f);
                }
            }
            
            using (StreamWriter streamWriter = new StreamWriter(f))
            {
                streamWriter.Write(DateTime.Now);
                streamWriter.WriteLine(rtbNotes.Text);
            }
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
