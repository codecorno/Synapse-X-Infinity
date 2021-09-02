
namespace Synapse_X_Infinity
{
    partial class StartUp
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RoundForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.whitelistProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.dataBaseProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.dataPic = new System.Windows.Forms.PictureBox();
            this.wlProgress = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dllProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.folderProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.changingWlProgress = new Bunifu.UI.WinForms.BunifuCircleProgress();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wlProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Synapse_X_Infinity.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(467, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RoundForm
            // 
            this.RoundForm.ElipseRadius = 10;
            this.RoundForm.TargetControl = this;
            // 
            // whitelistProgress
            // 
            this.whitelistProgress.Animated = true;
            this.whitelistProgress.AnimationInterval = 1;
            this.whitelistProgress.AnimationSpeed = 1;
            this.whitelistProgress.BackColor = System.Drawing.Color.Transparent;
            this.whitelistProgress.CircleMargin = 5;
            this.whitelistProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 1E-05F, System.Drawing.FontStyle.Bold);
            this.whitelistProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.whitelistProgress.IsPercentage = false;
            this.whitelistProgress.LineProgressThickness = 2;
            this.whitelistProgress.LineThickness = 2;
            this.whitelistProgress.Location = new System.Drawing.Point(107, 83);
            this.whitelistProgress.Name = "whitelistProgress";
            this.whitelistProgress.ProgressAnimationSpeed = 200;
            this.whitelistProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.whitelistProgress.ProgressColor = System.Drawing.Color.Orange;
            this.whitelistProgress.ProgressColor2 = System.Drawing.Color.Orange;
            this.whitelistProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.whitelistProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.whitelistProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.whitelistProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.whitelistProgress.Size = new System.Drawing.Size(38, 38);
            this.whitelistProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.whitelistProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.whitelistProgress.SubScriptText = "";
            this.whitelistProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.whitelistProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.whitelistProgress.SuperScriptText = "";
            this.whitelistProgress.TabIndex = 16;
            this.whitelistProgress.Text = "30";
            this.whitelistProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.whitelistProgress.Value = 30;
            this.whitelistProgress.ValueByTransition = 30;
            this.whitelistProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // dataBaseProgress
            // 
            this.dataBaseProgress.Animated = true;
            this.dataBaseProgress.AnimationInterval = 1;
            this.dataBaseProgress.AnimationSpeed = 1;
            this.dataBaseProgress.BackColor = System.Drawing.Color.Transparent;
            this.dataBaseProgress.CircleMargin = 5;
            this.dataBaseProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 1E-05F, System.Drawing.FontStyle.Bold);
            this.dataBaseProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataBaseProgress.IsPercentage = false;
            this.dataBaseProgress.LineProgressThickness = 2;
            this.dataBaseProgress.LineThickness = 2;
            this.dataBaseProgress.Location = new System.Drawing.Point(163, 83);
            this.dataBaseProgress.Name = "dataBaseProgress";
            this.dataBaseProgress.ProgressAnimationSpeed = 200;
            this.dataBaseProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.dataBaseProgress.ProgressColor = System.Drawing.Color.Orange;
            this.dataBaseProgress.ProgressColor2 = System.Drawing.Color.Orange;
            this.dataBaseProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.dataBaseProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.dataBaseProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.dataBaseProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dataBaseProgress.Size = new System.Drawing.Size(38, 38);
            this.dataBaseProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dataBaseProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.dataBaseProgress.SubScriptText = "";
            this.dataBaseProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dataBaseProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.dataBaseProgress.SuperScriptText = "";
            this.dataBaseProgress.TabIndex = 18;
            this.dataBaseProgress.Text = "30";
            this.dataBaseProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.dataBaseProgress.Value = 30;
            this.dataBaseProgress.ValueByTransition = 30;
            this.dataBaseProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // dataPic
            // 
            this.dataPic.Image = global::Synapse_X_Infinity.Properties.Resources.database;
            this.dataPic.Location = new System.Drawing.Point(168, 45);
            this.dataPic.Name = "dataPic";
            this.dataPic.Size = new System.Drawing.Size(30, 30);
            this.dataPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dataPic.TabIndex = 19;
            this.dataPic.TabStop = false;
            // 
            // wlProgress
            // 
            this.wlProgress.Image = global::Synapse_X_Infinity.Properties.Resources.whitelist;
            this.wlProgress.Location = new System.Drawing.Point(112, 45);
            this.wlProgress.Name = "wlProgress";
            this.wlProgress.Size = new System.Drawing.Size(30, 30);
            this.wlProgress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wlProgress.TabIndex = 17;
            this.wlProgress.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Synapse_X_Infinity.Properties.Resources.dll;
            this.pictureBox4.Location = new System.Drawing.Point(224, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // dllProgress
            // 
            this.dllProgress.Animated = true;
            this.dllProgress.AnimationInterval = 1;
            this.dllProgress.AnimationSpeed = 1;
            this.dllProgress.BackColor = System.Drawing.Color.Transparent;
            this.dllProgress.CircleMargin = 5;
            this.dllProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 1E-05F, System.Drawing.FontStyle.Bold);
            this.dllProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dllProgress.IsPercentage = false;
            this.dllProgress.LineProgressThickness = 2;
            this.dllProgress.LineThickness = 2;
            this.dllProgress.Location = new System.Drawing.Point(219, 83);
            this.dllProgress.Name = "dllProgress";
            this.dllProgress.ProgressAnimationSpeed = 200;
            this.dllProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.dllProgress.ProgressColor = System.Drawing.Color.Orange;
            this.dllProgress.ProgressColor2 = System.Drawing.Color.Orange;
            this.dllProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.dllProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.dllProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.dllProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dllProgress.Size = new System.Drawing.Size(38, 38);
            this.dllProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dllProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.dllProgress.SubScriptText = "";
            this.dllProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dllProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.dllProgress.SuperScriptText = "";
            this.dllProgress.TabIndex = 20;
            this.dllProgress.Text = "30";
            this.dllProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.dllProgress.Value = 30;
            this.dllProgress.ValueByTransition = 30;
            this.dllProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(282, 45);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // folderProgress
            // 
            this.folderProgress.Animated = true;
            this.folderProgress.AnimationInterval = 1;
            this.folderProgress.AnimationSpeed = 1;
            this.folderProgress.BackColor = System.Drawing.Color.Transparent;
            this.folderProgress.CircleMargin = 5;
            this.folderProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 1E-05F, System.Drawing.FontStyle.Bold);
            this.folderProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.folderProgress.IsPercentage = false;
            this.folderProgress.LineProgressThickness = 2;
            this.folderProgress.LineThickness = 2;
            this.folderProgress.Location = new System.Drawing.Point(277, 83);
            this.folderProgress.Name = "folderProgress";
            this.folderProgress.ProgressAnimationSpeed = 200;
            this.folderProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.folderProgress.ProgressColor = System.Drawing.Color.Orange;
            this.folderProgress.ProgressColor2 = System.Drawing.Color.Orange;
            this.folderProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.folderProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.folderProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.folderProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.folderProgress.Size = new System.Drawing.Size(38, 38);
            this.folderProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.folderProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.folderProgress.SubScriptText = "";
            this.folderProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.folderProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.folderProgress.SuperScriptText = "";
            this.folderProgress.TabIndex = 22;
            this.folderProgress.Text = "30";
            this.folderProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.folderProgress.Value = 30;
            this.folderProgress.ValueByTransition = 30;
            this.folderProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(340, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // changingWlProgress
            // 
            this.changingWlProgress.Animated = true;
            this.changingWlProgress.AnimationInterval = 1;
            this.changingWlProgress.AnimationSpeed = 1;
            this.changingWlProgress.BackColor = System.Drawing.Color.Transparent;
            this.changingWlProgress.CircleMargin = 5;
            this.changingWlProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 1E-05F, System.Drawing.FontStyle.Bold);
            this.changingWlProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changingWlProgress.IsPercentage = false;
            this.changingWlProgress.LineProgressThickness = 2;
            this.changingWlProgress.LineThickness = 2;
            this.changingWlProgress.Location = new System.Drawing.Point(335, 83);
            this.changingWlProgress.Name = "changingWlProgress";
            this.changingWlProgress.ProgressAnimationSpeed = 200;
            this.changingWlProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.changingWlProgress.ProgressColor = System.Drawing.Color.Orange;
            this.changingWlProgress.ProgressColor2 = System.Drawing.Color.Orange;
            this.changingWlProgress.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.changingWlProgress.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.changingWlProgress.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.changingWlProgress.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.changingWlProgress.Size = new System.Drawing.Size(38, 38);
            this.changingWlProgress.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.changingWlProgress.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.changingWlProgress.SubScriptText = "";
            this.changingWlProgress.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.changingWlProgress.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.changingWlProgress.SuperScriptText = "";
            this.changingWlProgress.TabIndex = 24;
            this.changingWlProgress.Text = "30";
            this.changingWlProgress.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.changingWlProgress.Value = 30;
            this.changingWlProgress.ValueByTransition = 30;
            this.changingWlProgress.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(499, 167);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.changingWlProgress);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.folderProgress);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dllProgress);
            this.Controls.Add(this.dataPic);
            this.Controls.Add(this.dataBaseProgress);
            this.Controls.Add(this.wlProgress);
            this.Controls.Add(this.whitelistProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Synapse X Infinity";
            this.Load += new System.EventHandler(this.StartUp_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ZeusMoveForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wlProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox wlProgress;
        private Bunifu.UI.WinForms.BunifuCircleProgress whitelistProgress;
        private System.Windows.Forms.PictureBox dataPic;
        private Bunifu.UI.WinForms.BunifuCircleProgress dataBaseProgress;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.UI.WinForms.BunifuCircleProgress dllProgress;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.UI.WinForms.BunifuCircleProgress folderProgress;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.UI.WinForms.BunifuCircleProgress changingWlProgress;
        private Bunifu.Framework.UI.BunifuElipse RoundForm;
    }
}

