namespace PtmScreenCapture
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.storyCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.screenshotBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Location = new System.Drawing.Point(417, 23);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(112, 52);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.Location = new System.Drawing.Point(417, 103);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(111, 46);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBtn.Location = new System.Drawing.Point(24, 103);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(86, 46);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Старт";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopBtn.Location = new System.Drawing.Point(282, 104);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(84, 45);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Стоп";
            this.stopBtn.UseVisualStyleBackColor = true;
            // 
            // storyCB
            // 
            this.storyCB.FormattingEnabled = true;
            this.storyCB.Location = new System.Drawing.Point(24, 45);
            this.storyCB.Name = "storyCB";
            this.storyCB.Size = new System.Drawing.Size(369, 29);
            this.storyCB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "История/задача";
            // 
            // screenshotBtn
            // 
            this.screenshotBtn.Location = new System.Drawing.Point(160, 105);
            this.screenshotBtn.Name = "screenshotBtn";
            this.screenshotBtn.Size = new System.Drawing.Size(75, 45);
            this.screenshotBtn.TabIndex = 6;
            this.screenshotBtn.Text = "Снимок";
            this.screenshotBtn.UseVisualStyleBackColor = true;
            this.screenshotBtn.Click += new System.EventHandler(this.screenshotBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 162);
            this.Controls.Add(this.screenshotBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storyCB);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.loginBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "PTM Screen Capture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginBtn;
        private Button logoutBtn;
        private Button startBtn;
        private Button stopBtn;
        private ComboBox storyCB;
        private Label label1;
        private Button screenshotBtn;
    }
}