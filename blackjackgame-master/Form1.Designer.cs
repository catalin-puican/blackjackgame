namespace Blackjack
{
    partial class Form1
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
            System.Windows.Forms.TabPage welcomeTab;
            this.startButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.dealerButton = new System.Windows.Forms.Button();
            this.playerButton = new System.Windows.Forms.Button();
            this.playerLabel = new System.Windows.Forms.Label();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.standButon = new System.Windows.Forms.Button();
            this.hitButon = new System.Windows.Forms.Button();
            welcomeTab = new System.Windows.Forms.TabPage();
            welcomeTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.gameTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeTab
            // 
            welcomeTab.BackColor = System.Drawing.Color.Chartreuse;
            welcomeTab.Controls.Add(this.startButton);
            welcomeTab.Location = new System.Drawing.Point(4, 22);
            welcomeTab.Name = "welcomeTab";
            welcomeTab.Padding = new System.Windows.Forms.Padding(3);
            welcomeTab.Size = new System.Drawing.Size(1045, 565);
            welcomeTab.TabIndex = 0;
            welcomeTab.Text = "Welcome";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(403, 259);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(245, 77);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(welcomeTab);
            this.tabControl1.Controls.Add(this.gameTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // gameTab
            // 
            this.gameTab.BackColor = System.Drawing.Color.Green;
            this.gameTab.Controls.Add(this.dealerButton);
            this.gameTab.Controls.Add(this.playerButton);
            this.gameTab.Controls.Add(this.playerLabel);
            this.gameTab.Controls.Add(this.dealerLabel);
            this.gameTab.Controls.Add(this.standButon);
            this.gameTab.Controls.Add(this.hitButon);
            this.gameTab.Location = new System.Drawing.Point(4, 22);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(1045, 565);
            this.gameTab.TabIndex = 1;
            this.gameTab.Text = "Gametab";
            // 
            // dealerButton
            // 
            this.dealerButton.Location = new System.Drawing.Point(584, 107);
            this.dealerButton.Name = "dealerButton";
            this.dealerButton.Size = new System.Drawing.Size(135, 43);
            this.dealerButton.TabIndex = 20;
            this.dealerButton.Text = "Dealer Cards";
            this.dealerButton.UseVisualStyleBackColor = true;
            this.dealerButton.Click += new System.EventHandler(this.dealerButton_Click);
            // 
            // playerButton
            // 
            this.playerButton.Location = new System.Drawing.Point(128, 107);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(135, 43);
            this.playerButton.TabIndex = 19;
            this.playerButton.Text = "Player Cards";
            this.playerButton.UseVisualStyleBackColor = true;
            this.playerButton.Click += new System.EventHandler(this.playerButton_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(125, 168);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(79, 13);
            this.playerLabel.TabIndex = 18;
            this.playerLabel.Text = "Player Score: 0";
            // 
            // dealerLabel
            // 
            this.dealerLabel.AutoSize = true;
            this.dealerLabel.Location = new System.Drawing.Point(581, 168);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(81, 13);
            this.dealerLabel.TabIndex = 17;
            this.dealerLabel.Text = "Dealer Score: 0";
            // 
            // standButon
            // 
            this.standButon.Location = new System.Drawing.Point(128, 435);
            this.standButon.Name = "standButon";
            this.standButon.Size = new System.Drawing.Size(135, 43);
            this.standButon.TabIndex = 16;
            this.standButon.Text = "Stand";
            this.standButon.UseVisualStyleBackColor = true;
            this.standButon.Click += new System.EventHandler(this.standButon_Click);
            // 
            // hitButon
            // 
            this.hitButon.Location = new System.Drawing.Point(128, 374);
            this.hitButon.Name = "hitButon";
            this.hitButon.Size = new System.Drawing.Size(135, 43);
            this.hitButon.TabIndex = 15;
            this.hitButon.Text = "Hit";
            this.hitButon.UseVisualStyleBackColor = true;
            this.hitButon.Click += new System.EventHandler(this.hitButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 591);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            welcomeTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.gameTab.ResumeLayout(false);
            this.gameTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gameTab;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button hitButon;
        private System.Windows.Forms.Button standButon;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Button dealerButton;
        private System.Windows.Forms.Button playerButton;
    }
}

