using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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
            try
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
            catch
            {
                if (!Directory.Exists(Application.StartupPath + path))
                {
                    Directory.CreateDirectory(Application.StartupPath + path);
                }
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
          //SynxF.Lib.AttachEvent += sxAttachEvent;
            LoadScriptsLoop.Enabled = true;
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

            timer1.Enabled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    Environment.Exit(0);
                    break;
            }

            base.OnFormClosing(e);
        }

        private void sxAttachEvent(SxLibBase.SynAttachEvents Event, object whatever)
        {
            switch (Event)
            {
                case SxLibBase.SynAttachEvents.CHECKING:
                    this.statusProgress.Value = 20;
                    this.statusProgress.ProgressColor = Color.FromArgb(255, 128, 0);
                    break;

                case SxLibBase.SynAttachEvents.INJECTING:
                    this.statusProgress.ProgressColor = Color.FromArgb(195, 255, 0);
                    this.statusProgress.Value = 40;
                    break;

                case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
                    this.statusProgress.ProgressColor = Color.FromArgb(255, 208, 0);
                    this.statusProgress.Value = 60;
                    break;

                case SxLibBase.SynAttachEvents.SCANNING:
                    this.statusProgress.ProgressColor = Color.FromArgb(255, 251, 0);
                    this.statusProgress.Value = 80;
                    break;

                case SxLibBase.SynAttachEvents.READY:
                    this.statusProgress.ProgressColor = Color.FromArgb(86, 252, 3);
                    this.statusProgress.Value = 100;
                    break;

                case SxLibBase.SynAttachEvents.FAILED_TO_FIND:
                    this.statusProgress.ProgressColor = Color.FromArgb(255, 128, 0);
                    this.statusProgress.Value = 100;
                    break;

                case SxLibBase.SynAttachEvents.NOT_RUNNING_LATEST_VER_UPDATING:
                    this.statusProgress.ProgressColor = Color.FromArgb(255, 128, 0);
                    this.statusProgress.Value = 100;
                    break;

                case SxLibBase.SynAttachEvents.NOT_INJECTED:
                    this.statusProgress.ProgressColor = Color.FromArgb(255, 128, 0);
                    this.statusProgress.Value = 100;
                    break;

                case SxLibBase.SynAttachEvents.ALREADY_INJECTED:
                    this.statusProgress.ProgressColor = Color.FromArgb(255, 128, 0);
                    this.statusProgress.Value = 100;
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
                LoadScripts(path);
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            var testBeta = MessageBox.Show("Do you want to test the alpha version of the Infinity Dashboard?", "Synapse X Alpha Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (testBeta == DialogResult.Yes)
            {
                this.Visible = false;
                var SynapseXLoader = new SynapseXbeta();
                SynapseXLoader.Show();
            }

        }
    }
}
