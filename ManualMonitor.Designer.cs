namespace GarbageDetector
{
    partial class ManualMonitor
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
            this.disp1 = new System.Windows.Forms.PictureBox();
            this.disp2 = new System.Windows.Forms.PictureBox();
            this.disp3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.disp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp3)).BeginInit();
            this.SuspendLayout();
            // 
            // disp1
            // 
            this.disp1.Location = new System.Drawing.Point(12, 21);
            this.disp1.Name = "disp1";
            this.disp1.Size = new System.Drawing.Size(274, 280);
            this.disp1.TabIndex = 0;
            this.disp1.TabStop = false;
            // 
            // disp2
            // 
            this.disp2.Location = new System.Drawing.Point(318, 21);
            this.disp2.Name = "disp2";
            this.disp2.Size = new System.Drawing.Size(274, 280);
            this.disp2.TabIndex = 1;
            this.disp2.TabStop = false;
            // 
            // disp3
            // 
            this.disp3.Location = new System.Drawing.Point(617, 21);
            this.disp3.Name = "disp3";
            this.disp3.Size = new System.Drawing.Size(274, 280);
            this.disp3.TabIndex = 2;
            this.disp3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManualMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.disp3);
            this.Controls.Add(this.disp2);
            this.Controls.Add(this.disp1);
            this.Name = "ManualMonitor";
            this.Text = "ManualMonitor";
            ((System.ComponentModel.ISupportInitialize)(this.disp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disp3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox disp1;
        private System.Windows.Forms.PictureBox disp2;
        private System.Windows.Forms.PictureBox disp3;
        private System.Windows.Forms.Button button1;
    }
}