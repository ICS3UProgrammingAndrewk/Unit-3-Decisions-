namespace Rock_PaperSicAndrew
{
    partial class frmRps
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
            this.radComputerRock = new System.Windows.Forms.RadioButton();
            this.radComputePaper = new System.Windows.Forms.RadioButton();
            this.radComputerScissor = new System.Windows.Forms.RadioButton();
            this.radPlayRock = new System.Windows.Forms.RadioButton();
            this.radPlayPaper = new System.Windows.Forms.RadioButton();
            this.radPlayScissor = new System.Windows.Forms.RadioButton();
            this.grbplayerChoice = new System.Windows.Forms.GroupBox();
            this.grbComputer = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grbplayerChoice.SuspendLayout();
            this.grbComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // radComputerRock
            // 
            this.radComputerRock.AutoSize = true;
            this.radComputerRock.Location = new System.Drawing.Point(68, 23);
            this.radComputerRock.Name = "radComputerRock";
            this.radComputerRock.Size = new System.Drawing.Size(51, 17);
            this.radComputerRock.TabIndex = 0;
            this.radComputerRock.TabStop = true;
            this.radComputerRock.Text = "Rock";
            this.radComputerRock.UseVisualStyleBackColor = true;
            // 
            // radComputePaper
            // 
            this.radComputePaper.AutoSize = true;
            this.radComputePaper.Location = new System.Drawing.Point(68, 72);
            this.radComputePaper.Name = "radComputePaper";
            this.radComputePaper.Size = new System.Drawing.Size(53, 17);
            this.radComputePaper.TabIndex = 1;
            this.radComputePaper.TabStop = true;
            this.radComputePaper.Text = "Paper";
            this.radComputePaper.UseVisualStyleBackColor = true;
            // 
            // radComputerScissor
            // 
            this.radComputerScissor.AutoSize = true;
            this.radComputerScissor.Location = new System.Drawing.Point(68, 114);
            this.radComputerScissor.Name = "radComputerScissor";
            this.radComputerScissor.Size = new System.Drawing.Size(64, 17);
            this.radComputerScissor.TabIndex = 2;
            this.radComputerScissor.TabStop = true;
            this.radComputerScissor.Text = "Scissors";
            this.radComputerScissor.UseVisualStyleBackColor = true;
            // 
            // radPlayRock
            // 
            this.radPlayRock.AutoSize = true;
            this.radPlayRock.Location = new System.Drawing.Point(49, 32);
            this.radPlayRock.Name = "radPlayRock";
            this.radPlayRock.Size = new System.Drawing.Size(51, 17);
            this.radPlayRock.TabIndex = 3;
            this.radPlayRock.TabStop = true;
            this.radPlayRock.Text = "Rock";
            this.radPlayRock.UseVisualStyleBackColor = true;
            // 
            // radPlayPaper
            // 
            this.radPlayPaper.AutoSize = true;
            this.radPlayPaper.Location = new System.Drawing.Point(49, 78);
            this.radPlayPaper.Name = "radPlayPaper";
            this.radPlayPaper.Size = new System.Drawing.Size(53, 17);
            this.radPlayPaper.TabIndex = 4;
            this.radPlayPaper.TabStop = true;
            this.radPlayPaper.Text = "Paper";
            this.radPlayPaper.UseVisualStyleBackColor = true;
            // 
            // radPlayScissor
            // 
            this.radPlayScissor.AutoSize = true;
            this.radPlayScissor.Location = new System.Drawing.Point(49, 117);
            this.radPlayScissor.Name = "radPlayScissor";
            this.radPlayScissor.Size = new System.Drawing.Size(64, 17);
            this.radPlayScissor.TabIndex = 5;
            this.radPlayScissor.TabStop = true;
            this.radPlayScissor.Text = "Scissors";
            this.radPlayScissor.UseVisualStyleBackColor = true;
            // 
            // grbplayerChoice
            // 
            this.grbplayerChoice.Controls.Add(this.radPlayScissor);
            this.grbplayerChoice.Controls.Add(this.radPlayPaper);
            this.grbplayerChoice.Controls.Add(this.radPlayRock);
            this.grbplayerChoice.Location = new System.Drawing.Point(85, 244);
            this.grbplayerChoice.Name = "grbplayerChoice";
            this.grbplayerChoice.Size = new System.Drawing.Size(189, 167);
            this.grbplayerChoice.TabIndex = 6;
            this.grbplayerChoice.TabStop = false;
            this.grbplayerChoice.Text = "playerChoice";
            // 
            // grbComputer
            // 
            this.grbComputer.Controls.Add(this.radComputerScissor);
            this.grbComputer.Controls.Add(this.radComputePaper);
            this.grbComputer.Controls.Add(this.radComputerRock);
            this.grbComputer.Location = new System.Drawing.Point(86, 46);
            this.grbComputer.Name = "grbComputer";
            this.grbComputer.Size = new System.Drawing.Size(188, 149);
            this.grbComputer.TabIndex = 7;
            this.grbComputer.TabStop = false;
            this.grbComputer.Text = "computerChoice";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPlay.Location = new System.Drawing.Point(374, 216);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(103, 50);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmRps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputer);
            this.Controls.Add(this.grbplayerChoice);
            this.Name = "frmRps";
            this.Text = " Rock, Paper or scissors By Andrew K.";
            this.grbplayerChoice.ResumeLayout(false);
            this.grbplayerChoice.PerformLayout();
            this.grbComputer.ResumeLayout(false);
            this.grbComputer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radComputerRock;
        private System.Windows.Forms.RadioButton radComputePaper;
        private System.Windows.Forms.RadioButton radComputerScissor;
        private System.Windows.Forms.RadioButton radPlayRock;
        private System.Windows.Forms.RadioButton radPlayPaper;
        private System.Windows.Forms.RadioButton radPlayScissor;
        private System.Windows.Forms.GroupBox grbplayerChoice;
        private System.Windows.Forms.GroupBox grbComputer;
        private System.Windows.Forms.Button btnPlay;
    }
}

