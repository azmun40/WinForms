namespace My_project
{
    partial class PingPong
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
            this.components = new System.ComponentModel.Container();
            this.Platform = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.GamePanel = new System.Windows.Forms.Panel();
            this.Score = new System.Windows.Forms.Label();
            this.LabelLose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.GamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.Crimson;
            this.Platform.Location = new System.Drawing.Point(284, 420);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(236, 27);
            this.Platform.TabIndex = 0;
            this.Platform.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Black;
            this.Ball.Location = new System.Drawing.Point(98, 119);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(50, 50);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.Platform);
            this.GamePanel.Controls.Add(this.LabelLose);
            this.GamePanel.Controls.Add(this.Ball);
            this.GamePanel.Controls.Add(this.Score);
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(800, 450);
            this.GamePanel.TabIndex = 2;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.Location = new System.Drawing.Point(625, 47);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(85, 24);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score : 0";
            // 
            // LabelLose
            // 
            this.LabelLose.AutoSize = true;
            this.LabelLose.Font = new System.Drawing.Font("Sitka Text", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLose.Location = new System.Drawing.Point(297, 172);
            this.LabelLose.Name = "LabelLose";
            this.LabelLose.Size = new System.Drawing.Size(144, 40);
            this.LabelLose.TabIndex = 2;
            this.LabelLose.Text = "You lose!";
            this.LabelLose.Visible = false;
            // 
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GamePanel);
            this.Name = "PingPong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingPong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PingPong_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label LabelLose;
    }
}