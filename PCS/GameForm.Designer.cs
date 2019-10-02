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
            this.chkTimeAttack = new System.Windows.Forms.CheckBox();
            this.btnBest = new System.Windows.Forms.Button();
            this.pnlSetupControls = new System.Windows.Forms.Panel();
            this.pnlGamePanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSolution = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlSetupControls.SuspendLayout();
            this.pnlGamePanel.SuspendLayout();
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
            // chkTimeAttack
            // 
            this.chkTimeAttack.AutoSize = true;
            this.chkTimeAttack.Location = new System.Drawing.Point(14, 60);
            this.chkTimeAttack.Name = "chkTimeAttack";
            this.chkTimeAttack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTimeAttack.Size = new System.Drawing.Size(85, 17);
            this.chkTimeAttack.TabIndex = 6;
            this.chkTimeAttack.Text = "Timed Mode";
            this.chkTimeAttack.UseVisualStyleBackColor = true;
            // 
            // btnBest
            // 
            this.btnBest.Location = new System.Drawing.Point(121, 104);
            this.btnBest.Name = "btnBest";
            this.btnBest.Size = new System.Drawing.Size(75, 23);
            this.btnBest.TabIndex = 7;
            this.btnBest.Text = "Best Times";
            this.btnBest.UseVisualStyleBackColor = true;
            this.btnBest.Visible = false;
            this.btnBest.Click += new System.EventHandler(this.BtnBest_Click);
            // 
            // pnlSetupControls
            // 
            this.pnlSetupControls.Controls.Add(this.label1);
            this.pnlSetupControls.Controls.Add(this.txtSize);
            this.pnlSetupControls.Controls.Add(this.btnBest);
            this.pnlSetupControls.Controls.Add(this.txtSeed);
            this.pnlSetupControls.Controls.Add(this.chkTimeAttack);
            this.pnlSetupControls.Controls.Add(this.label2);
            this.pnlSetupControls.Controls.Add(this.lblSize);
            this.pnlSetupControls.Controls.Add(this.btnStart);
            this.pnlSetupControls.Location = new System.Drawing.Point(12, 12);
            this.pnlSetupControls.Name = "pnlSetupControls";
            this.pnlSetupControls.Size = new System.Drawing.Size(217, 152);
            this.pnlSetupControls.TabIndex = 9;
            // 
            // pnlGamePanel
            // 
            this.pnlGamePanel.Controls.Add(this.btnBack);
            this.pnlGamePanel.Controls.Add(this.btnSolution);
            this.pnlGamePanel.Controls.Add(this.lblTimer);
            this.pnlGamePanel.Location = new System.Drawing.Point(12, 12);
            this.pnlGamePanel.Name = "pnlGamePanel";
            this.pnlGamePanel.Size = new System.Drawing.Size(353, 366);
            this.pnlGamePanel.TabIndex = 11;
            this.pnlGamePanel.Visible = false;
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
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(84, 8);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(57, 13);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "Time: 0:00";
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Enabled = true;
            this.tmrGameTimer.Interval = 1000;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 403);
            this.Controls.Add(this.pnlGamePanel);
            this.Controls.Add(this.pnlSetupControls);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.pnlSetupControls.ResumeLayout(false);
            this.pnlSetupControls.PerformLayout();
            this.pnlGamePanel.ResumeLayout(false);
            this.pnlGamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.CheckBox chkTimeAttack;
        private System.Windows.Forms.Button btnBest;
        private System.Windows.Forms.Panel pnlSetupControls;
        private System.Windows.Forms.Panel pnlGamePanel;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.Button btnBack;
    }
}

