using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sxlib;
using sxlib.Specialized;

namespace Synapse_X_Infinity
{
    public partial class StartUp : Form
    {
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

        public bool Attached;
        public bool Loaded;
        public static string sxDirectory = Directory.GetCurrentDirectory();

        public void checkFiles()
        {
            string sxDirectory = Directory.GetCurrentDirectory();
            if (!Directory.Exists(sxDirectory + "\\auth") || !Directory.Exists(sxDirectory + "\\bin"))
            {
                MessageBox.Show("It seems that you do not have any signature or it is your first time using SynapseX, please open the original file before using our UI.", "Synapse X Infinity | Error");
                Environment.Exit(2);
            }
        }

        public StartUp()
        {
            InitializeComponent();
            checkFiles();
            
            SynxF.Lib = SxLib.InitializeWinForms(this, sxDirectory);
            SynxF.Lib.Load();
            SynxF.Lib.LoadEvent += sxLoadEvent;
        }

        private void sxLoadEvent(SxLibBase.SynLoadEvents Event, object Param)
        {
            switch (Event)
            {
                // Importants

                case SxLibBase.SynLoadEvents.CHECKING_WL:
                    this.bunifuProgressBar1.Value = 16;
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(198, 252, 3);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(198, 252, 3);

                    return;

                case SxLibBase.SynLoadEvents.DOWNLOADING_DATA:
                    this.bunifuProgressBar1.Value = 32;
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(252, 127, 3);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(252, 127, 3);
                    return;

                case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
                    this.bunifuProgressBar1.Value = 48;
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(252, 227, 3);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(252, 227, 3);
                    return;

                case SxLibBase.SynLoadEvents.CHECKING_DATA:
                    this.bunifuProgressBar1.Value = 64;
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(252, 173, 3);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(252, 173, 3);
                    return;

                case SxLibBase.SynLoadEvents.CHANGING_WL:
                    this.bunifuProgressBar1.Value = 80;
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(248, 252, 3);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(248, 252, 3);
                    return;

                case SxLibBase.SynLoadEvents.READY:
                    this.bunifuProgressBar1.Value = 100;
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(86, 252, 3);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(86, 252, 3);
                    return;

                // others

                case SxLibBase.SynLoadEvents.NOT_LOGGED_IN:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 0, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 0, 0);
                    MessageBox.Show("[ERROR]: You are not logged in SynapseX.");
                    return;

                case SxLibBase.SynLoadEvents.UNAUTHORIZED_HWID:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 0, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 0, 0);
                    MessageBox.Show("[ERROR]: Unauthorized Hwid Detected.");
                    return;

                case SxLibBase.SynLoadEvents.FAILED_TO_DOWNLOAD:
                    this.bunifuProgressBar1.ProgressColorLeft = Color.FromArgb(255, 0, 0);
                    this.bunifuProgressBar1.ProgressColorRight = Color.FromArgb(255, 0, 0);
                    MessageBox.Show("[ERROR]: Failed To Download SynapseX.");
                    return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }
    }
}
