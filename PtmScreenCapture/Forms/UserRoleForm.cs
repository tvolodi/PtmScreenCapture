using PtmScreenCapture.Models;
using PtmScreenCapture.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PtmScreenCapture.Forms
{
    public partial class UserRoleForm : Form
    {
        private List<UserRole> userRoles = new List<UserRole>();
        private List<object> prevValuesList;

        public UserRoleForm()
        {
            InitializeComponent();
            initData();
        }

        private async void initData()
        {
            userRoles = await RestApiService.GetEntityListAsync<UserRole>();
            userRoles.ForEach(role =>
            {
                string[] row = {role.Code, role.Name, role.Id};
                userRoleDG.Rows.Add(role);
            });
            
        }

        private void newUserRoleBtn_Click(object sender, EventArgs e)
        {

        }

        private void userRoleDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void userRoleDG_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            // If raw was changed/added - save into database
            bool isAdded = false;
            bool isChanged = false;

            if (prevValuesList[0] == null) isAdded = true;

            var currentRow = userRoleDG.Rows[e.RowIndex];
            for(int i = 0; i < currentRow.Cells.Count; i++)
            {
                if(currentRow.Cells[i].EditedFormattedValue == null) return;

                if (!currentRow.Cells[i].EditedFormattedValue.Equals(prevValuesList[i]))
                {
                    isChanged = true;
                    break;
                }
            }

            if(isChanged)
            {                
                UserRole userRole = new UserRole()
                {
                    Code = currentRow.Cells[0].EditedFormattedValue.ToString(),
                    Name = currentRow.Cells[1].EditedFormattedValue.ToString(),                    
                };
                if (currentRow.Cells[2].FormattedValue != null)
                    userRole.Id = currentRow.Cells[2].EditedFormattedValue.ToString();
                else userRole.Id = "";

                if (isAdded)
                {                    
                    await RestApiService.InsertMongoDocAsync<UserRole>(userRole);
                } else
                {
                    await RestApiService.UpdateMongoDocAsync<UserRole>(userRole);
                }
            }    

            //for(int i = 0; i < userRoles.Count; i++) {
            //var currentRow = userRoleDG.Rows[e.RowIndex];
            //if (currentRow.Cells[0].Value != null)
            //{
            //    if(currentRow.Cells[0].Value.ToString() != prevUserRole.Code ||
            //       currentRow.Cells[1].Value.ToString() != prevUserRole.Name)
            //}
        }

        private void userRoleDG_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var messageResult = MessageBox.Show("You deleting a record. Are you sure?", "Deleting User Role", MessageBoxButtons.OKCancel);
            if (messageResult == DialogResult.OK)
            {
                // Delete is confirmed. Deleting from database

            }
            else e.Cancel = true; 
        }

        private void userRoleDG_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = userRoleDG.Rows[e.RowIndex];

            prevValuesList = new List<object>();

            for (int i = 0; i < currentRow.Cells.Count; i++)
            {
                prevValuesList.Add(currentRow.Cells[i].Value);

                //    if (currentRow.Cells[i].Value != null)
                    
                //else prevValuesList.Add("");
            }


            //    prevUserRole = new UserRole();
            //if (currentRow.Cells[0].Value == null)
            //{
            //    // For a new row
            //    prevUserRole.Code = "";
            //    prevUserRole.Name = "";
            //} else
            //{
            //    prevUserRole.Code = currentRow.Cells[0].Value.ToString();
            //    prevUserRole.Name = currentRow.Cells[1].Value.ToString();
            //}
        }
    }
}
