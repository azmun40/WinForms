namespace My_project
{
    partial class AuthForm
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
            this.RegBtn = new System.Windows.Forms.Button();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkToReg = new System.Windows.Forms.LinkLabel();
            this.ChangeLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.DimGray;
            this.RegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.ForeColor = System.Drawing.Color.FloralWhite;
            this.RegBtn.Location = new System.Drawing.Point(95, 181);
            this.RegBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(83, 32);
            this.RegBtn.TabIndex = 9;
            this.RegBtn.Text = "Войти";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.AuthBtn_Click);
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UserPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordField.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.White;
            this.UserPasswordField.Location = new System.Drawing.Point(52, 135);
            this.UserPasswordField.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(180, 25);
            this.UserPasswordField.TabIndex = 8;
            this.UserPasswordField.Enter += new System.EventHandler(this.Text_BoxEnter);
            this.UserPasswordField.Leave += new System.EventHandler(this.Text_BoxLeave);
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UserLoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLoginField.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLoginField.ForeColor = System.Drawing.Color.White;
            this.UserLoginField.Location = new System.Drawing.Point(52, 80);
            this.UserLoginField.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(180, 25);
            this.UserLoginField.TabIndex = 7;
            this.UserLoginField.Enter += new System.EventHandler(this.Text_BoxEnter);
            this.UserLoginField.Leave += new System.EventHandler(this.Text_BoxLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Авторизация";
            // 
            // LinkToReg
            // 
            this.LinkToReg.AutoSize = true;
            this.LinkToReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkToReg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkToReg.LinkColor = System.Drawing.Color.White;
            this.LinkToReg.Location = new System.Drawing.Point(69, 231);
            this.LinkToReg.Name = "LinkToReg";
            this.LinkToReg.Size = new System.Drawing.Size(144, 19);
            this.LinkToReg.TabIndex = 10;
            this.LinkToReg.TabStop = true;
            this.LinkToReg.Text = "Зарегистрироваться";
            this.LinkToReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToReg_LinkClicked);
            // 
            // ChangeLink
            // 
            this.ChangeLink.ActiveLinkColor = System.Drawing.Color.Red;
            this.ChangeLink.AutoSize = true;
            this.ChangeLink.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLink.LinkColor = System.Drawing.Color.White;
            this.ChangeLink.Location = new System.Drawing.Point(92, 266);
            this.ChangeLink.Name = "ChangeLink";
            this.ChangeLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChangeLink.Size = new System.Drawing.Size(102, 17);
            this.ChangeLink.TabIndex = 11;
            this.ChangeLink.TabStop = true;
            this.ChangeLink.Text = "Редактировать";
            this.ChangeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeLink_LinkClicked);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(284, 313);
            this.Controls.Add(this.ChangeLink);
            this.Controls.Add(this.LinkToReg);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkToReg;
        private System.Windows.Forms.LinkLabel ChangeLink;
    }
}