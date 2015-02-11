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
    public partial class frm_ViewFirst : Form
    {
        public frm_ViewFirst()
        {
            InitializeComponent();
            butOK.DialogResult = DialogResult.OK;
            butCANCEL.DialogResult = DialogResult.Cancel;
        }
        public string number
        {
            get { return texNUM.Text.ToString().Trim(); }
        }
    }
}
