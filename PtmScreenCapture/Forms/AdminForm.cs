using PtmScreenCapture.Forms;
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
    public partial class AdminForm : Form
    {
        public UserRoleForm UserRoleForm;
        public UsersForm UsersForm;

        public AdminForm()
        {
            InitializeComponent();
            UserRoleForm = new UserRoleForm();
            UsersForm = new UsersForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void userRolesBtn_Click(object sender, EventArgs e)
        {
            UserRoleForm.Show();
            //var userRoles = await RestApiService.GetUserRolesAsync();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            UsersForm.Show();
        }
    }
}
