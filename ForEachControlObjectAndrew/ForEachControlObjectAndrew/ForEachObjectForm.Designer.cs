namespace ForEachControlObjectAndrew
{
    partial class frmForEachObject
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
            this.BtnChangeColour = new System.Windows.Forms.Button();
            this.btnColour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnChangeColour
            // 
            this.BtnChangeColour.BackColor = System.Drawing.Color.White;
            this.BtnChangeColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeColour.Location = new System.Drawing.Point(154, 77);
            this.BtnChangeColour.Name = "BtnChangeColour";
            this.BtnChangeColour.Size = new System.Drawing.Size(189, 84);
            this.BtnChangeColour.TabIndex = 0;
            this.BtnChangeColour.Text = "Change Colour";
            this.BtnChangeColour.UseVisualStyleBackColor = false;
            this.BtnChangeColour.Click += new System.EventHandler(this.BtnChangeColour_Click);
            // 
            // btnColour
            // 
            this.btnColour.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColour.Location = new System.Drawing.Point(154, 286);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(189, 83);
            this.btnColour.TabIndex = 2;
            this.btnColour.Text = "Change Colour";
            this.btnColour.UseVisualStyleBackColor = false;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // frmForEachObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.btnColour);
            this.Controls.Add(this.BtnChangeColour);
            this.Name = "frmForEachObject";
            this.Text = "For...Each Object By Andrew";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnChangeColour;
        private System.Windows.Forms.Button btnColour;
    }
}

