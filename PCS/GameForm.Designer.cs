namespace PCS
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.pnlSetupControls = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlGamePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSolution = new System.Windows.Forms.Button();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.pnlSetupControls.SuspendLayout();
            this.pnlGamePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(67, 8);
            this.txtSize.MaxLength = 2;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(22, 20);
            this.txtSize.TabIndex = 1;
            this.txtSize.TextChanged += new System.EventHandler(this.TxtSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 104);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(67, 34);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(129, 20);
            this.txtSeed.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seed:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(92, 11);
            this.lblSize.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(12, 13);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "x";
            // 
            // pnlSetupControls
            // 
            this.pnlSetupControls.Controls.Add(this.lblErrorMsg);
            this.pnlSetupControls.Controls.Add(this.btnCreate);
            this.pnlSetupControls.Controls.Add(this.label1);
            this.pnlSetupControls.Controls.Add(this.txtSize);
            this.pnlSetupControls.Controls.Add(this.txtSeed);
            this.pnlSetupControls.Controls.Add(this.label2);
            this.pnlSetupControls.Controls.Add(this.lblSize);
            this.pnlSetupControls.Controls.Add(this.btnStart);
            this.pnlSetupControls.Location = new System.Drawing.Point(12, 27);
            this.pnlSetupControls.Name = "pnlSetupControls";
            this.pnlSetupControls.Size = new System.Drawing.Size(217, 170);
            this.pnlSetupControls.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(111, 104);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(85, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create Puzzle";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // pnlGamePanel
            // 
            this.pnlGamePanel.AutoSize = true;
            this.pnlGamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGamePanel.Controls.Add(this.panel1);
            this.pnlGamePanel.Controls.Add(this.btnBack);
            this.pnlGamePanel.Controls.Add(this.btnSolution);
            this.pnlGamePanel.Location = new System.Drawing.Point(12, 27);
            this.pnlGamePanel.Name = "pnlGamePanel";
            this.pnlGamePanel.Size = new System.Drawing.Size(154, 53);
            this.pnlGamePanel.TabIndex = 11;
            this.pnlGamePanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Location = new System.Drawing.Point(84, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 19);
            this.panel1.TabIndex = 5;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(3, 1);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(57, 13);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Time: 0:00";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnSolution
            // 
            this.btnSolution.Location = new System.Drawing.Point(3, 3);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(75, 23);
            this.btnSolution.TabIndex = 3;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            this.btnSolution.Click += new System.EventHandler(this.BtnSolution_Click);
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Interval = 1000;
            this.tmrGameTimer.Tick += new System.EventHandler(this.TmrGameTimer_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(722, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSave,
            this.msLoad,
            this.msExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // msSave
            // 
            this.msSave.Name = "msSave";
            this.msSave.Size = new System.Drawing.Size(100, 22);
            this.msSave.Text = "Save";
            this.msSave.Click += new System.EventHandler(this.MsSave_Click);
            // 
            // msLoad
            // 
            this.msLoad.Name = "msLoad";
            this.msLoad.Size = new System.Drawing.Size(100, 22);
            this.msLoad.Text = "Load";
            this.msLoad.Click += new System.EventHandler(this.MsLoad_Click);
            // 
            // msExit
            // 
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(100, 22);
            this.msExit.Text = "Exit";
            this.msExit.Click += new System.EventHandler(this.MsExit_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorMsg.Location = new System.Drawing.Point(16, 65);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(95, 13);
            this.lblErrorMsg.TabIndex = 12;
            this.lblErrorMsg.Text = "Enter a board size.";
            this.lblErrorMsg.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 340);
            this.Controls.Add(this.pnlSetupControls);
            this.Controls.Add(this.pnlGamePanel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCS";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.pnlSetupControls.ResumeLayout(false);
            this.pnlSetupControls.PerformLayout();
            this.pnlGamePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Panel pnlSetupControls;
        private System.Windows.Forms.Panel pnlGamePanel;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msSave;
        private System.Windows.Forms.ToolStripMenuItem msLoad;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrorMsg;
    }
}

