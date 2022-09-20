namespace PtmScreenCapture
{
    partial class AdminForm
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
            this.docListDG = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRolesBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.docListDG)).BeginInit();
            this.SuspendLayout();
            // 
            // docListDG
            // 
            this.docListDG.AllowUserToOrderColumns = true;
            this.docListDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docListDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.CodeCol,
            this.NameCol});
            this.docListDG.Location = new System.Drawing.Point(12, 123);
            this.docListDG.Name = "docListDG";
            this.docListDG.RowTemplate.Height = 25;
            this.docListDG.Size = new System.Drawing.Size(394, 150);
            this.docListDG.TabIndex = 0;
            this.docListDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // CodeCol
            // 
            this.CodeCol.HeaderText = "Code";
            this.CodeCol.Name = "CodeCol";
            this.CodeCol.ReadOnly = true;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            // 
            // userRolesBtn
            // 
            this.userRolesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userRolesBtn.Location = new System.Drawing.Point(637, 97);
            this.userRolesBtn.Name = "userRolesBtn";
            this.userRolesBtn.Size = new System.Drawing.Size(151, 43);
            this.userRolesBtn.TabIndex = 1;
            this.userRolesBtn.Text = "Роли";
            this.userRolesBtn.UseVisualStyleBackColor = true;
            this.userRolesBtn.Click += new System.EventHandler(this.userRolesBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersBtn.Location = new System.Drawing.Point(641, 183);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(147, 50);
            this.usersBtn.TabIndex = 2;
            this.usersBtn.Text = "Пользователи";
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersBtn);
            this.Controls.Add(this.userRolesBtn);
            this.Controls.Add(this.docListDG);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.docListDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView docListDG;
        private Button userRolesBtn;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn CodeCol;
        private DataGridViewTextBoxColumn NameCol;
        private Button usersBtn;
    }
}