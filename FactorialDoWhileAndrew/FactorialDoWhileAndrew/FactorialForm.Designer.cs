namespace FactorialDoWhileAndrew
{
    partial class frmFactorialDoWhle
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lstFactorialNumbers = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(97, 87);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(179, 24);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter the number:";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.Yellow;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(176, 148);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(171, 52);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiply.Location = new System.Drawing.Point(97, 249);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(382, 24);
            this.lblMultiply.TabIndex = 2;
            this.lblMultiply.Text = "Multiply the following numbers together:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(282, 92);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 4;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnswer.Location = new System.Drawing.Point(494, 388);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 6;
            // 
            // lstFactorialNumbers
            // 
            this.lstFactorialNumbers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstFactorialNumbers.Location = new System.Drawing.Point(497, 212);
            this.lstFactorialNumbers.Name = "lstFactorialNumbers";
            this.lstFactorialNumbers.Size = new System.Drawing.Size(190, 134);
            this.lstFactorialNumbers.TabIndex = 7;
            // 
            // frmFactorialDoWhle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFactorialNumbers);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmFactorialDoWhle";
            this.Text = "Factorial By Andrew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label lblMultiply;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ProgressBar lstFactorialNumbers;
    }
}

