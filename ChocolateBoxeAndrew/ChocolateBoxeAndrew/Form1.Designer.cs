namespace ChocolateBoxeAndrew
{
    partial class frmChocolateBox
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
            this.lblNumberBox = new System.Windows.Forms.Label();
            this.lblHonorsblemention = new System.Windows.Forms.Label();
            this.BtnGetreward = new System.Windows.Forms.Button();
            this.txtNumberOfBoxes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumberBox
            // 
            this.lblNumberBox.AutoSize = true;
            this.lblNumberBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberBox.Location = new System.Drawing.Point(91, 139);
            this.lblNumberBox.Name = "lblNumberBox";
            this.lblNumberBox.Size = new System.Drawing.Size(310, 24);
            this.lblNumberBox.TabIndex = 0;
            this.lblNumberBox.Text = "Enter the number of boxes sold:";
            // 
            // lblHonorsblemention
            // 
            this.lblHonorsblemention.AutoSize = true;
            this.lblHonorsblemention.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHonorsblemention.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHonorsblemention.Location = new System.Drawing.Point(268, 213);
            this.lblHonorsblemention.Name = "lblHonorsblemention";
            this.lblHonorsblemention.Size = new System.Drawing.Size(0, 24);
            this.lblHonorsblemention.TabIndex = 1;
            // 
            // BtnGetreward
            // 
            this.BtnGetreward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGetreward.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetreward.Location = new System.Drawing.Point(95, 213);
            this.BtnGetreward.Name = "BtnGetreward";
            this.BtnGetreward.Size = new System.Drawing.Size(236, 64);
            this.BtnGetreward.TabIndex = 2;
            this.BtnGetreward.Text = "Get reward";
            this.BtnGetreward.UseVisualStyleBackColor = false;
            this.BtnGetreward.Click += new System.EventHandler(this.BtnGetreward_Click);
            // 
            // txtNumberOfBoxes
            // 
            this.txtNumberOfBoxes.Location = new System.Drawing.Point(407, 144);
            this.txtNumberOfBoxes.Name = "txtNumberOfBoxes";
            this.txtNumberOfBoxes.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfBoxes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Location = new System.Drawing.Point(395, 236);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(0, 13);
            this.lblReward.TabIndex = 6;
            // 
            // frmChocolateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberOfBoxes);
            this.Controls.Add(this.BtnGetreward);
            this.Controls.Add(this.lblHonorsblemention);
            this.Controls.Add(this.lblNumberBox);
            this.Name = "frmChocolateBox";
            this.Text = "Chocolate Box By Andrew K.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberBox;
        private System.Windows.Forms.Label lblHonorsblemention;
        private System.Windows.Forms.Button BtnGetreward;
        private System.Windows.Forms.TextBox txtNumberOfBoxes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReward;
    }
}

