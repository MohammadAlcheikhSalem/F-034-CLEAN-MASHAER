namespace GarbageDetector
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ContactLbl = new System.Windows.Forms.LinkLabel();
            this.SignUpLbl = new System.Windows.Forms.LinkLabel();
            this.ForgotLbl = new System.Windows.Forms.LinkLabel();
            this.SigninBtn = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.RPassChk = new System.Windows.Forms.CheckBox();
            this.RUserChk = new System.Windows.Forms.CheckBox();
            this.UserLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(222, 270);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(87, 29);
            this.CloseBtn.TabIndex = 23;
            this.CloseBtn.Text = "Cancel";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ContactLbl
            // 
            this.ContactLbl.AutoSize = true;
            this.ContactLbl.BackColor = System.Drawing.Color.Transparent;
            this.ContactLbl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ContactLbl.Location = new System.Drawing.Point(161, 411);
            this.ContactLbl.Name = "ContactLbl";
            this.ContactLbl.Size = new System.Drawing.Size(59, 13);
            this.ContactLbl.TabIndex = 22;
            this.ContactLbl.TabStop = true;
            this.ContactLbl.Text = "Contact us";
            // 
            // SignUpLbl
            // 
            this.SignUpLbl.AutoSize = true;
            this.SignUpLbl.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLbl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.SignUpLbl.Location = new System.Drawing.Point(145, 388);
            this.SignUpLbl.Name = "SignUpLbl";
            this.SignUpLbl.Size = new System.Drawing.Size(89, 13);
            this.SignUpLbl.TabIndex = 21;
            this.SignUpLbl.TabStop = true;
            this.SignUpLbl.Text = "Sign up new user";
            this.SignUpLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLbl_LinkClicked);
            // 
            // ForgotLbl
            // 
            this.ForgotLbl.AutoSize = true;
            this.ForgotLbl.BackColor = System.Drawing.Color.Transparent;
            this.ForgotLbl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ForgotLbl.Location = new System.Drawing.Point(145, 228);
            this.ForgotLbl.Name = "ForgotLbl";
            this.ForgotLbl.Size = new System.Drawing.Size(110, 13);
            this.ForgotLbl.TabIndex = 20;
            this.ForgotLbl.TabStop = true;
            this.ForgotLbl.Text = "I forgot my password";
            // 
            // SigninBtn
            // 
            this.SigninBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SigninBtn.Location = new System.Drawing.Point(103, 270);
            this.SigninBtn.Name = "SigninBtn";
            this.SigninBtn.Size = new System.Drawing.Size(87, 29);
            this.SigninBtn.TabIndex = 19;
            this.SigninBtn.Text = "Sign In";
            this.SigninBtn.UseVisualStyleBackColor = true;
            this.SigninBtn.Click += new System.EventHandler(this.SigninBtn_Click);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(103, 190);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(206, 20);
            this.PassBox.TabIndex = 18;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(103, 147);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(206, 20);
            this.UserBox.TabIndex = 17;
            // 
            // RPassChk
            // 
            this.RPassChk.AutoSize = true;
            this.RPassChk.BackColor = System.Drawing.Color.Transparent;
            this.RPassChk.Font = new System.Drawing.Font("Tahoma", 8F);
            this.RPassChk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RPassChk.Location = new System.Drawing.Point(103, 349);
            this.RPassChk.Name = "RPassChk";
            this.RPassChk.Size = new System.Drawing.Size(143, 17);
            this.RPassChk.TabIndex = 16;
            this.RPassChk.Text = "Remember my password";
            this.RPassChk.UseVisualStyleBackColor = false;
            // 
            // RUserChk
            // 
            this.RUserChk.AutoSize = true;
            this.RUserChk.BackColor = System.Drawing.Color.Transparent;
            this.RUserChk.Font = new System.Drawing.Font("Tahoma", 8F);
            this.RUserChk.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.RUserChk.Location = new System.Drawing.Point(103, 326);
            this.RUserChk.Name = "RUserChk";
            this.RUserChk.Size = new System.Drawing.Size(94, 17);
            this.RUserChk.TabIndex = 15;
            this.RUserChk.Text = "Remember me";
            this.RUserChk.UseVisualStyleBackColor = false;
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserLbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UserLbl.Location = new System.Drawing.Point(12, 146);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(88, 19);
            this.UserLbl.TabIndex = 14;
            this.UserLbl.Text = "User Name:";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.BackColor = System.Drawing.Color.Transparent;
            this.PassLbl.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLbl.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PassLbl.Location = new System.Drawing.Point(12, 191);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(77, 19);
            this.PassLbl.TabIndex = 13;
            this.PassLbl.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "CLEAN-MASHAER";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(334, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ContactLbl);
            this.Controls.Add(this.SignUpLbl);
            this.Controls.Add(this.ForgotLbl);
            this.Controls.Add(this.SigninBtn);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.RPassChk);
            this.Controls.Add(this.RUserChk);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.PassLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.LinkLabel ContactLbl;
        private System.Windows.Forms.LinkLabel SignUpLbl;
        private System.Windows.Forms.LinkLabel ForgotLbl;
        private System.Windows.Forms.Button SigninBtn;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.CheckBox RPassChk;
        private System.Windows.Forms.CheckBox RUserChk;
        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Label label1;
    }
}

