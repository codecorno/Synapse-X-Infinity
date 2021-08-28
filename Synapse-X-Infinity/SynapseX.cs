using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;

namespace Synapse_X_Infinity
{
    public partial class SynapseX : Form
    {
        public bool attached;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParan, int lParan);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ZeusMoveForm(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LoadScripts(string path)
        {
            listBox1.Items.Clear();

            DirectoryInfo dinfo = new DirectoryInfo(Application.StartupPath + path);
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            FileInfo[] Files1 = dinfo.GetFiles("*.lua");

            foreach (FileInfo file in Files)
            {
                listBox1.Items.Add(file.Name);
            }

            foreach (FileInfo file in Files1)
            {
                listBox1.Items.Add(file.Name);
            }
        }

        public void SetAceText(string Text)
        {
            webBrowser1.Document.InvokeScript("SetText", new object[] { Text });
        }

        public string GetAceText()
        {
            HtmlDocument document = webBrowser1.Document;
            string scriptName = "GetText";
            object obj = document.InvokeScript(scriptName, new string[0]);
            string Text = obj.ToString();
            return Text;
        }

        public SynapseX()
        {
            InitializeComponent();
            SynxF.Lib.AttachEvent += sxAttachEvent;
            LoadScripts(@"\scripts\");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SynapseX_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(string.Format("file:///{0}ace/AceEditor.html", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void sxAttachEvent(SxLibBase.SynAttachEvents Event, object whatever)
        {
            switch (Event)
            {
                case SxLibBase.SynAttachEvents.CHECKING:
                    this.bunifuProgressBar1.Value = 20;
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 128, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 128, 0);
                    break;

                case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 208, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 208, 0);
                    this.bunifuProgressBar1.Value = 40;
                    break;

                case SxLibBase.SynAttachEvents.SCANNING:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 251, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 251, 0);
                    this.bunifuProgressBar1.Value = 60;
                    break;

                case SxLibBase.SynAttachEvents.INJECTING:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(195, 255, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(195, 255, 0);
                    this.bunifuProgressBar1.Value = 80;
                    break;

                case SxLibBase.SynAttachEvents.READY:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(86, 252, 3);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(86, 252, 3);
                    this.bunifuProgressBar1.Value = 100;
                    this.bunifuProgressBar1.Value = 0;
                    break;

                case SxLibBase.SynAttachEvents.FAILED_TO_FIND:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 128, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 128, 0);
                    this.bunifuProgressBar1.Value = 100;
                    break;

                case SxLibBase.SynAttachEvents.NOT_RUNNING_LATEST_VER_UPDATING:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 128, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 128, 0);
                    this.bunifuProgressBar1.Value = 100;
                    break;

                case SxLibBase.SynAttachEvents.NOT_INJECTED:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 128, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 128, 0);
                    this.bunifuProgressBar1.Value = 100;
                    break;

                case SxLibBase.SynAttachEvents.ALREADY_INJECTED:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 128, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 128, 0);
                    this.bunifuProgressBar1.Value = 100;
                    break;

            }
        }

        private void bunifuButton6_Click(object sender, EventArgs e) // Attach Button
        {
            SynxF.Lib.Attach();
            SynxF.Lib.AttachEvent += sxAttachEvent;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists("scripts"))
            {
                Directory.CreateDirectory("scripts");
            }

            object item = listBox1.SelectedItem;

            if (item != null)
            {
                string path = @"\scripts\";
                string script = File.ReadAllText(Application.StartupPath + @"\scripts\" + item.ToString());

                SetAceText(script);
                LoadScriptsLoop.Start();
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            if (SynxF.OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string MainText = File.ReadAllText(SynxF.OpenFile.FileName);
                    SynxF.Lib.Execute(MainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message, "Synapse X - Error Report");
                }
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e){SetAceText("");}

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SynxF.Lib.Execute(GetAceText());
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (SynxF.OpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string MainText = File.ReadAllText(SynxF.OpenFile.FileName);
                    SetAceText(MainText);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message, "Synapse X - Error Report");
                }
            }
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            if (SynxF.SaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(SynxF.SaveFile.OpenFile());
                    writer.WriteLine(GetAceText());
                    writer.Dispose();
                    writer.Close();
                }
                catch (Exception ex) { MessageBox.Show("[Error]: " + ex.Message, "Synapse X - Error Report"); };
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadScripts(@"\scripts\");
        }
    }
}
