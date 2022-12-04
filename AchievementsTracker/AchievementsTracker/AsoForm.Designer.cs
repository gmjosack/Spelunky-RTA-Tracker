namespace AchievementsTracker
{
    partial class AsoForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.asoStep = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.asoStep)).BeginInit();
            this.SuspendLayout();
            // 
            // asoStep
            // 
            this.asoStep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asoStep.Image = global::AchievementsTracker.Properties.Resources.aso_00_tutorial;
            this.asoStep.Location = new System.Drawing.Point(40, 40);
            this.asoStep.Name = "asoStep";
            this.asoStep.Size = new System.Drawing.Size(80, 80);
            this.asoStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.asoStep.TabIndex = 0;
            this.asoStep.TabStop = false;
            // 
            // AsoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(668, 302);
            this.Controls.Add(this.asoStep);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Icon = global::AchievementsTracker.Properties.Resources.icon;
            this.Name = "AsoForm";
            this.Text = "All Shortcuts + Olmec";
            this.Load += new System.EventHandler(this.AsoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.asoStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox asoStep;
    }
}