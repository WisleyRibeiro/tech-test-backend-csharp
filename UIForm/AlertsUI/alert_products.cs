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
    public partial class alert_products : Form
    {
        public alert_products()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alert_products_Load(object sender, EventArgs e)
        {
            string type = frm_products.alertType;
            lb_alert.Text = type;
        }
    }
}
