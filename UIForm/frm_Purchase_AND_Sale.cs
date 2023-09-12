using MobiStore.BLLClasses;
using MobiStore.BLLClasses.DALdados;
using MobiStore.UIForm.AlertsUI;
using System;
using System.Data;
using System.Windows.Forms;

namespace MobiStore.UIForm
{
    public partial class frm_Purchase_AND_Sale : Form
    {
        private readonly productsDAL pDAL = new productsDAL();
        private readonly DataTable transactionDT = new DataTable();

        public frm_Purchase_AND_Sale()
        {
            InitializeComponent();
        }

        public static string AlertPurchase;

        private void frm_Purchase_AND_Sale_Load(object sender, EventArgs e)
        {
            string type = frm_user_dashboard.transactionType;
            lb_top.Text = type;

            InitializeTransactionDataTable();
        }

        private void InitializeTransactionDataTable()
        {
            transactionDT.Columns.Add("Nome do Produto");
            transactionDT.Columns.Add("Valor");
            transactionDT.Columns.Add("Quantidade");
            transactionDT.Columns.Add("Total");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_user_dashboard frm_User_Dashboard = new frm_user_dashboard();
            frm_User_Dashboard.Show();
            this.Close();
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = text_search.Text;

            if (string.IsNullOrEmpty(keyword))
            {
                ClearProductFields();
                return;
            }

            DataTable dt = pDAL.Search(keyword);

            if (dt.Rows.Count > 0)
            {
                UpdateProductComboBox(dt);
            }
            else
            {
                AlertPurchase = "Nenhum produto correspondente encontrado.";
                alert_purchase alert_Purchase = new alert_purchase();
                alert_Purchase.Show();
                ClearProductFields();
            }
        }

        private void ClearProductFields()
        {
            text_name.Items.Clear();
            text_name.ResetText();
            text_name.DropDownStyle = ComboBoxStyle.DropDown;
            text_quantidade.Text = "";
            text_inventary.Text = "";
            text_value.Text = "";
        }

        private void UpdateProductComboBox(DataTable dt)
        {
            text_name.Items.Clear();
            text_name.DropDownStyle = ComboBoxStyle.DropDown;

            foreach (DataRow row in dt.Rows)
            {
                string productName = row["name"].ToString();
                text_name.Items.Add(productName);
            }

            text_name.DroppedDown = true;
        }

        private void text_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = text_name.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedProductName))
            {
                DataTable dt = pDAL.Search(selectedProductName);

                if (dt.Rows.Count > 0)
                {
                    UpdateProductInfoFields(dt);
                }
            }
        }

        private void UpdateProductInfoFields(DataTable dt)
        {
            DataRow row = dt.Rows[0];

            text_quantidade.Text = "";
            text_inventary.Text = row["qty"].ToString();
            text_value.Text = row["rate"].ToString();
        }

        private void restore()
        {
            text_search.Text = "";
            text_name.Text = "";
            text_inventary.Text = "0.00";
            text_value.Text = "0.00";
            text_quantidade.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string productName = text_name.Text;

            if (string.IsNullOrEmpty(productName))
            {
                AlertPurchase = "Favor digitar o nome do produto!";
                alert_purchase alert_Purchase = new alert_purchase();
                alert_Purchase.Show();
                return;
            }

            if (!decimal.TryParse(text_value.Text, out decimal rate) || rate <= 0)
            {
                AlertPurchase = "Valor do produto inválido!";
                alert_purchase alert_Purchase = new alert_purchase();
                alert_Purchase.Show();
                return;
            }

            if (!decimal.TryParse(text_quantidade.Text, out decimal qty) || qty <= 0)
            {
                AlertPurchase = "Valor de quantidade inválido!";
                alert_purchase alert_Purchase = new alert_purchase();
                alert_Purchase.Show();
                return;
            }

            decimal total = rate * qty;
            decimal subTotal = decimal.Parse(text_subtotal.Text);
            subTotal = subTotal + total;

            transactionDT.Rows.Add(productName, rate, qty, total);
            dgvUser.DataSource = transactionDT;

            text_subtotal.Text = subTotal.ToString();
            restore();
        }

        #region KeyPress
        private void text_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void text_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void text_desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void text_imposto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void text_total_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
        #endregion

        private void text_desconto_TextChanged(object sender, EventArgs e)
        {
            string subTotalText = text_subtotal.Text;
            string discountText = text_desconto.Text;

            if (!decimal.TryParse(subTotalText, out decimal subTotal) || !decimal.TryParse(discountText, out decimal discount))
            {
                AlertPurchase = "Valor de desconto inválido!";
                alert_purchase alert_Purchase = new alert_purchase();
                alert_Purchase.Show();
                return;
            }

            decimal grandTotal = ((100 - discount) / 100) * subTotal;
            text_total_geral.Text = grandTotal.ToString("0.00");
        }

        private void text_imposto_TextChanged(object sender, EventArgs e)
        {
            if (text_subtotal.Text == "0")
            {
                AlertPurchase = "Ops! Parece que você se esqueceu de adicionar produtos";
                alert_purchase alert_Purchase = new alert_purchase();
                alert_Purchase.Show();
                return;
            }

            if (!decimal.TryParse(text_subtotal.Text, out decimal subTotal) || !decimal.TryParse(text_imposto.Text, out decimal imposto))
            {
                AlertPurchase = "Ops! Valor de imposto inválido";
                alert_purchase alert_Purchase = new alert_purchase();
                alert_Purchase.Show();
                return;
            }

            decimal TotalGeralComImposto = ((100 + imposto) / 100) * subTotal;
            text_total_geral.Text = TotalGeralComImposto.ToString("0.00");
        }

        private void text_total_pago_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(text_total_geral.Text, out decimal grandTotal) && decimal.TryParse(text_desconto.Text, out decimal paidAmount))
            {
                decimal returnAmount = paidAmount - grandTotal;
                text_troco.Text = returnAmount.ToString();
            }
            else
            {
                AlertPurchase = "Valor inválido";
                alert_purchase alert_Purchase = new alert_purchase();
                alert_Purchase.Show();
            }
        }
    }
}
