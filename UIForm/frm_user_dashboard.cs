using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobiStore.UIForm
{
    public partial class frm_user_dashboard : Form
    {
        public frm_user_dashboard()
        {
            InitializeComponent();
        }
        public static string transactionType;

        private void button5_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Close();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            transactionType = "Compras";
            frm_Purchase_AND_Sale Sale = new frm_Purchase_AND_Sale();
            Sale.Show();
            this.Close();
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            transactionType = "Vendas";
            frm_Purchase_AND_Sale Sale = new frm_Purchase_AND_Sale();
            Sale.Show();
            this.Close();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            frm_about frm_About = new frm_about();
            frm_About.Show();
        }
    }
}
