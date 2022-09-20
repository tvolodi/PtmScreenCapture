namespace PtmScreenCapture
{
    partial class UsersForm
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
            this.usersDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usersDG)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDG
            // 
            this.usersDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDG.Location = new System.Drawing.Point(12, 47);
            this.usersDG.Name = "usersDG";
            this.usersDG.RowTemplate.Height = 25;
            this.usersDG.Size = new System.Drawing.Size(776, 150);
            this.usersDG.TabIndex = 0;
            this.usersDG.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDG_RowEnter);
            this.usersDG.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDG_RowLeave);
            this.usersDG.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.usersDG_UserDeletingRow);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersDG);
            this.Name = "UsersForm";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView usersDG;
    }
}