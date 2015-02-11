using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MTS
{
    public partial class frm_Login : Form
    {
        public string UserID;//用户ID
        public string Password;//密码

        public frm_Login()
        {
            InitializeComponent();
        }

        private void but_Ok_Click(object sender, EventArgs e)
        {
            UserID = tex_UserID.Text;
            Password = tex_Password.Text;
        }        
    }
}
