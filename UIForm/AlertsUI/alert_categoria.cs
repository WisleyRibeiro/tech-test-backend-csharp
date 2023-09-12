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
    public partial class alert_categoria : Form
    {
        public alert_categoria()
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

        private void alert_categoria_Load(object sender, EventArgs e)
        {
            string type = frm_categorias.AlertsCat;
            lb_alert.Text = type;
        }
    }
}
