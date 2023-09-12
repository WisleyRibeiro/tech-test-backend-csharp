using MobiStore.BLLClasses;
using MobiStore.BLLClasses.DALdados;
using MobiStore.UIForm.AlertsUI;
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
    public partial class frm_products : Form
    {
        public frm_products()
        {
            InitializeComponent();
        }

        public static string alertType;

        private void img_close_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();
            frmAdminDashboard.Show();
            this.Close();
        }

        productsBLL p = new productsBLL();
        productsDAL pdal = new productsDAL();
        categoriasDAL cDAL = new categoriasDAL();

        public void Clear()
        {
            text_ID.Text = "";
            text_name.Text = "";
            text_description.Text = "";
            text_value.Text = "";
            text_search.Text = "";
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (text_name.Text == "" || set_categoria.Text == "" || text_value.Text == "")
            {
                alertType = "Existem campos obrigatórios (•) não preenchidos!";
                alert_products frm_Alert = new alert_products();
                frm_Alert.Show();
            }
            else
            {
                p.rate = decimal.Parse(text_value.Text);
                if (p.rate <= 0)
                {
                    alertType = "O preço do produto é inválido!";
                    alert_products frm_Alert = new alert_products();
                    frm_Alert.Show();
                }
                else
                {
                    p.name = text_name.Text;
                    p.category = set_categoria.Text;
                    p.description = text_description.Text;
                    p.rate = decimal.Parse(text_value.Text);
                    p.qty = 0;
                    p.added_date = DateTime.Now;

                    bool sucess = pdal.Insert(p);

                    if (sucess == true)
                    {
                        alertType = "Produto cadastrado com sucesso";
                        alert_products frm_Alert = new alert_products();
                        frm_Alert.Show();
                        Clear();
                    }
                    else
                    {
                        alertType = "Não foi possível cadastrar o produto";
                        alert_products frm_Alert = new alert_products();
                        frm_Alert.Show();
                    }
                }
            }
            DataTable dt = pdal.Select();
            dgvUser.DataSource = dt;
        }

        categoriasDAL cdal = new categoriasDAL();

        private void frm_products_Load(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dgvUser.DataSource = dt;
            DataTable categoriasDT = cdal.Select();
            set_categoria.DataSource = categoriasDT;
            set_categoria.DisplayMember = "Title";
            set_categoria.ValueMember = "Title";

            dgvUser.Columns[0].HeaderText = "ID do Produto:";
            dgvUser.Columns[1].HeaderText = "Nome:";
            dgvUser.Columns[2].HeaderText = "Categoria:";
            dgvUser.Columns[3].HeaderText = "Descrição:";
            dgvUser.Columns[4].HeaderText = "Preço:";
            dgvUser.Columns[5].HeaderText = "Quantidade:";
            dgvUser.Columns[6].HeaderText = "Data/Hora de cadastro:";
            dgvUser.Columns[7].HeaderText = "Cadastrado por:";

        }

        private void dgvUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            text_ID.Text = dgvUser.Rows[rowIndex].Cells[0].Value.ToString();
            text_name.Text = dgvUser.Rows[rowIndex].Cells[1].Value.ToString();
            set_categoria.Text = dgvUser.Rows[rowIndex].Cells[2].Value.ToString();
            text_description.Text = dgvUser.Rows[rowIndex].Cells[3].Value.ToString();
            text_value.Text = dgvUser.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (text_ID.Text == "")
            {
                alertType = "Por favor, selecione um usuário antes";
                alert_products frm_Alert = new alert_products();
                frm_Alert.Show();
            }
            else
            {
                p.id = int.Parse(text_ID.Text);
                p.name = text_name.Text;
                p.category = set_categoria.Text;
                p.description = text_description.Text;
                p.rate = decimal.Parse(text_value.Text);
                p.qty = 0;
                p.added_date = DateTime.Now;

                bool Sucess = pdal.Update(p);

                if (Sucess == true)
                {
                    alertType = "Dados atualizados com sucesso :)";
                    alert_products frm_Alert = new alert_products();
                    frm_Alert.Show();
                    Clear();
                }
                else
                {
                    alertType = "Não foi possível atualizar informações :(";
                    alert_products frm_Alert = new alert_products();
                    frm_Alert.Show();
                }
                DataTable dt = pdal.Select();
                dgvUser.DataSource = dt;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (text_ID.Text == "")
            {
                alertType = "Por favor, selecione um usuário antes";
                alert_products frm_Alert = new alert_products();
                frm_Alert.Show();
            }
            else
            {
                p.id = Convert.ToInt32(text_ID.Text);

                bool sucess = pdal.Delete(p);
                if (sucess == true)
                {
                    alertType = "Categoria apagada com sucesso :)";
                    alert_products frm_Alert = new alert_products();
                    frm_Alert.Show();
                    Clear();
                }
                else
                {
                    alertType = "Não foi possível deletar categoria :(";
                    alert_products frm_Alert = new alert_products();
                    frm_Alert.Show();
                }
                DataTable dt = pdal.Select();
                dgvUser.DataSource = dt;
            }
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            string keywords = text_search.Text;
            if (!string.IsNullOrEmpty(keywords))
            {
                DataTable dt = pdal.Search(keywords);
                dgvUser.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    alertType = "Nenhum resultado correspondente encontrado.";
                    alert_products frm_Alert = new alert_products();
                    frm_Alert.Show();
                }
            }
            else
            {
                DataTable dt = pdal.Select();
                dgvUser.DataSource = dt;
            }
        }

        private void text_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
