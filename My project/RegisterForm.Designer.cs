namespace My_project
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.UserEmailField = new System.Windows.Forms.TextBox();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.RegBtn = new System.Windows.Forms.Button();
            this.LinkToAuth = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UserLoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLoginField.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLoginField.ForeColor = System.Drawing.Color.White;
            this.UserLoginField.Location = new System.Drawing.Point(37, 63);
            this.UserLoginField.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(180, 25);
            this.UserLoginField.TabIndex = 1;
            this.UserLoginField.Enter += new System.EventHandler(this.Text_BoxEnter);
            this.UserLoginField.Leave += new System.EventHandler(this.Text_BoxLeave);
            // 
            // UserEmailField
            // 
            this.UserEmailField.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UserEmailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmailField.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEmailField.ForeColor = System.Drawing.Color.White;
            this.UserEmailField.Location = new System.Drawing.Point(37, 103);
            this.UserEmailField.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.UserEmailField.Name = "UserEmailField";
            this.UserEmailField.Size = new System.Drawing.Size(180, 25);
            this.UserEmailField.TabIndex = 2;
            this.UserEmailField.Enter += new System.EventHandler(this.Text_BoxEnter);
            this.UserEmailField.Leave += new System.EventHandler(this.Text_BoxLeave);
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UserPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordField.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.White;
            this.UserPasswordField.Location = new System.Drawing.Point(37, 143);
            this.UserPasswordField.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(180, 25);
            this.UserPasswordField.TabIndex = 3;
            this.UserPasswordField.Enter += new System.EventHandler(this.Text_BoxEnter);
            this.UserPasswordField.Leave += new System.EventHandler(this.Text_BoxLeave);
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.DimGray;
            this.RegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.RegBtn.Location = new System.Drawing.Point(46, 188);
            this.RegBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(162, 32);
            this.RegBtn.TabIndex = 5;
            this.RegBtn.Text = "Зарегистрироваться";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // LinkToAuth
            // 
            this.LinkToAuth.AutoSize = true;
            this.LinkToAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkToAuth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkToAuth.LinkColor = System.Drawing.Color.White;
            this.LinkToAuth.Location = new System.Drawing.Point(74, 246);
            this.LinkToAuth.Name = "LinkToAuth";
            this.LinkToAuth.Size = new System.Drawing.Size(98, 19);
            this.LinkToAuth.TabIndex = 11;
            this.LinkToAuth.TabStop = true;
            this.LinkToAuth.Text = "Авторизация";
            this.LinkToAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToAuth_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(260, 299);
            this.Controls.Add(this.LinkToAuth);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserEmailField);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.Enter += new System.EventHandler(this.Text_BoxEnter);
            this.Leave += new System.EventHandler(this.Text_BoxLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.TextBox UserEmailField;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.LinkLabel LinkToAuth;
    }
}