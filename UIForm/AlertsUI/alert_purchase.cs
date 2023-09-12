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
    public partial class alert_purchase : Form
    {
        public alert_purchase()
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

        private void alert_purchase_Load(object sender, EventArgs e)
        {
            string type = frm_Purchase_AND_Sale.AlertPurchase;
            lb_alert.Text = type;
        }
    }
}
