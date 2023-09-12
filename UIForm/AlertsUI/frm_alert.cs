using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobiStore.UIForm.AlertsUI
{
    public partial class frm_alert : Form
    {
        public frm_alert()
        {
            InitializeComponent();
        }

        private void frm_alert_Load(object sender, EventArgs e)
        {
            string type = frm_Login.alertType;
            lb_alert.Text = type;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
