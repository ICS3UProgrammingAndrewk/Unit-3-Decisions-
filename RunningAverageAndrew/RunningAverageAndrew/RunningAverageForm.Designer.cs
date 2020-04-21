namespace RunningAverageAndrew
{
    partial class frmRunningAverage
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.BtnCalculator = new System.Windows.Forms.Button();
            this.txtAvrage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(97, 80);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(267, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter a number (From 0 to 100):";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(97, 177);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(171, 24);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type \" -1 \" to exit";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnswer.Location = new System.Drawing.Point(98, 367);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(16, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "...";
            // 
            // BtnCalculator
            // 
            this.BtnCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCalculator.Location = new System.Drawing.Point(251, 245);
            this.BtnCalculator.Name = "BtnCalculator";
            this.BtnCalculator.Size = new System.Drawing.Size(163, 48);
            this.BtnCalculator.TabIndex = 3;
            this.BtnCalculator.Text = "Calculate";
            this.BtnCalculator.UseVisualStyleBackColor = false;
            this.BtnCalculator.Click += new System.EventHandler(this.BtnCalculator_Click);
            // 
            // txtAvrage
            // 
            this.txtAvrage.Location = new System.Drawing.Point(452, 73);
            this.txtAvrage.Name = "txtAvrage";
            this.txtAvrage.Size = new System.Drawing.Size(100, 20);
            this.txtAvrage.TabIndex = 4;
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.txtAvrage);
            this.Controls.Add(this.BtnCalculator);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average By Andrew K.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button BtnCalculator;
        private System.Windows.Forms.TextBox txtAvrage;
    }
}

