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

namespace PtmScreenCapture
{
    public partial class UsersForm : Form
    {
        private BindingList<User> userList;
        private BindingSource bindingSource;
        private int prevRowIndex = 0;

        public UsersForm()
        {
            InitializeComponent();
            InitData();
        }

        private async void InitData()
        {
            userList = new BindingList<User>();

            var users = await RestApiService.GetEntityListAsync<User>();
            users.ForEach(user =>
            {
                userList.Add(user);               
            });

            bindingSource = new BindingSource(userList, null);
            usersDG.DataSource = bindingSource;
            var columns = usersDG.Columns;
            for (int i = 0; i < columns.Count; i++)
            {
                var column = columns[i];
                var columnName = column.Name;
                switch (columnName)
                {
                    case "Login":

                            break;

                    case "UserName":
                        column.HeaderText = "Пользователь";
                        break;

                    

                    default:
                        column.Visible = false;
                        break;
                }
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void usersDG_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var messageResult = MessageBox.Show("You deleting a record. Are you sure?", "Deleting User Role", MessageBoxButtons.OKCancel);
            if (messageResult == DialogResult.OK)
            {
                // Delete is confirmed. Deleting from database

            }
            else e.Cancel = true;
        }

        private void usersDG_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Check for the previous row has to be saved


            var currentRow = usersDG.Rows[e.RowIndex];

            //prevValuesList = new List<object>();

            //for (int i = 0; i < currentRow.Cells.Count; i++)
            //{
            //    prevValuesList.Add(currentRow.Cells[i].Value);

            //    //    if (currentRow.Cells[i].Value != null)

            //    //else prevValuesList.Add("");
            //}
        }

        private void usersDG_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            // If raw was changed/added - save into database
            bool isAdded = false;
            bool isChanged = false;

            prevRowIndex = e.RowIndex;

            //if (prevValuesList[0] == null) isAdded = true;

            //var currentRow = userRoleDG.Rows[e.RowIndex];
            //for (int i = 0; i < currentRow.Cells.Count; i++)
            //{
            //    if (currentRow.Cells[i].EditedFormattedValue == null) return;

            //    if (!currentRow.Cells[i].EditedFormattedValue.Equals(prevValuesList[i]))
            //    {
            //        isChanged = true;
            //        break;
            //    }
            //}

            //if (isChanged)
            //{
            //    UserRole userRole = new UserRole()
            //    {
            //        Code = currentRow.Cells[0].EditedFormattedValue.ToString(),
            //        Name = currentRow.Cells[1].EditedFormattedValue.ToString(),
            //    };
            //    if (currentRow.Cells[2].FormattedValue != null)
            //        userRole.Id = currentRow.Cells[2].EditedFormattedValue.ToString();
            //    else userRole.Id = "";

            //    if (isAdded)
            //    {
            //        await RestApiService.InsertMongoDocAsync<UserRole>(userRole);
            //    }
            //    else
            //    {
            //        await RestApiService.UpdateMongoDocAsync<UserRole>(userRole);
            //    }
            //}
        }
    }
}
