namespace PtmScreenCapture.Forms
{
    partial class UserRoleForm
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
            this.userRoleDG = new System.Windows.Forms.DataGridView();
            this.CodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newUserRoleBtn = new System.Windows.Forms.Button();
            this.editUserRoleBtn = new System.Windows.Forms.Button();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userRoleDG)).BeginInit();
            this.SuspendLayout();
            // 
            // userRoleDG
            // 
            this.userRoleDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userRoleDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeCol,
            this.NameCol,
            this.IdCol});
            this.userRoleDG.Location = new System.Drawing.Point(12, 97);
            this.userRoleDG.Name = "userRoleDG";
            this.userRoleDG.RowTemplate.Height = 25;
            this.userRoleDG.Size = new System.Drawing.Size(671, 150);
            this.userRoleDG.TabIndex = 0;
            this.userRoleDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userRoleDG_CellContentClick);
            this.userRoleDG.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.userRoleDG_RowEnter);
            this.userRoleDG.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.userRoleDG_RowLeave);
            this.userRoleDG.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.userRoleDG_UserDeletingRow);
            // 
            // CodeCol
            // 
            this.CodeCol.HeaderText = "Code";
            this.CodeCol.Name = "CodeCol";
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            // 
            // newUserRoleBtn
            // 
            this.newUserRoleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newUserRoleBtn.Location = new System.Drawing.Point(12, 59);
            this.newUserRoleBtn.Name = "newUserRoleBtn";
            this.newUserRoleBtn.Size = new System.Drawing.Size(75, 32);
            this.newUserRoleBtn.TabIndex = 1;
            this.newUserRoleBtn.Text = "Add";
            this.newUserRoleBtn.UseVisualStyleBackColor = true;
            this.newUserRoleBtn.Click += new System.EventHandler(this.newUserRoleBtn_Click);
            // 
            // editUserRoleBtn
            // 
            this.editUserRoleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editUserRoleBtn.Location = new System.Drawing.Point(102, 59);
            this.editUserRoleBtn.Name = "editUserRoleBtn";
            this.editUserRoleBtn.Size = new System.Drawing.Size(75, 32);
            this.editUserRoleBtn.TabIndex = 2;
            this.editUserRoleBtn.Text = "Edit";
            this.editUserRoleBtn.UseVisualStyleBackColor = true;
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.Visible = false;
            // 
            // UserRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editUserRoleBtn);
            this.Controls.Add(this.newUserRoleBtn);
            this.Controls.Add(this.userRoleDG);
            this.Name = "UserRoleForm";
            this.Text = "UserRoleForm";
            ((System.ComponentModel.ISupportInitialize)(this.userRoleDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewTextBoxColumn CodeCol;
        private DataGridViewTextBoxColumn NameCol;
        private Button newUserRoleBtn;
        private Button editUserRoleBtn;
        private DataGridView userRoleDG;
        private DataGridViewTextBoxColumn IdCol;
    }
}