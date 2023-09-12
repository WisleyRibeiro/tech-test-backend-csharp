using MobiStore.BLLClasses;
using MobiStore.BLLClasses.DALdados;
using MobiStore.UIForm.AlertsUI;
using System;
using System.Data;
using System.Windows.Forms;

namespace MobiStore.UIForm
{
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        public static string AlertsCat;

        private void img_close_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();
            frmAdminDashboard.Show();
            this.Hide();
        }

        categoriaBLL c = new categoriaBLL();
        categoriasDAL dal = new categoriasDAL();
        userDAL userDAL = new userDAL();

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (text_title.Text == "" || text_description.Text == "")
            {
                AlertsCat = "Existem campos obrigatórios (•) não preenchidos!";
                alert_categoria frm_Alert = new alert_categoria();
                frm_Alert.Show();
            }
            else
            {
                c.title = text_title.Text;
                c.description = text_description.Text;
                c.added_date = DateTime.Now;

                bool success = dal.Insert(c);

                if (success == true)
                {
                    AlertsCat = "Cadastro realizado com sucesso!";
                    alert_categoria frm_Alert = new alert_categoria();
                    frm_Alert.Show();

                    DataTable dt = dal.Select();
                    dgvUser.DataSource = dt;
                    Clear();
                }
                else
                {
                    AlertsCat = "Não foi possível cadastrar categoria.";
                    alert_categoria frm_Alert = new alert_categoria();
                    frm_Alert.Show();
                }
            }
        }

        public void Clear()
        {
            text_ID.Text = "";
            text_title.Text = "";
            text_description.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUser.DataSource = dt;
            dgvUser.Columns[0].HeaderText = "ID da categoria:";
            dgvUser.Columns[1].HeaderText = "Categoria:";
            dgvUser.Columns[2].HeaderText = "Descrição:";
            dgvUser.Columns[3].HeaderText = "Data/Hora de Cadastro:";
            dgvUser.Columns[4].HeaderText = "Adicionado por:";
        }

        private void dgvUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            text_ID.Text = dgvUser.Rows[rowIndex].Cells[0].Value.ToString();
            text_title.Text = dgvUser.Rows[rowIndex].Cells[1].Value.ToString();
            text_description.Text = dgvUser.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (text_ID.Text == "")
            {
                AlertsCat = "Por favor, selecione um usuário antes";
                alert_categoria frm_Alert = new alert_categoria();
                frm_Alert.Show();
            }
            else
            {
                c.id = Convert.ToInt32(text_ID.Text);
                c.title = text_title.Text;
                c.description = text_description.Text;
                c.added_date = DateTime.Now;

                bool success = dal.Update(c);
                if (success == true)
                {
                    AlertsCat = "Dados atualizados com sucesso :)";
                    alert_categoria frm_Alert = new alert_categoria();
                    frm_Alert.Show();
                    Clear();
                }
                else
                {
                    AlertsCat = "Não foi possível atualizar informações :(";
                    alert_categoria frm_Alert = new alert_categoria();
                    frm_Alert.Show();
                }
                DataTable dt = dal.Select();
                dgvUser.DataSource = dt;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (text_ID.Text == "")
            {
                AlertsCat = "Por favor, selecione um usuário antes";
                alert_categoria frm_Alert = new alert_categoria();
                frm_Alert.Show();
            }
            else
            {
                c.id = Convert.ToInt32(text_ID.Text);

                bool success = dal.Delete(c);
                if (success == true)
                {
                    AlertsCat = "Categoria apagada com sucesso :)";
                    alert_categoria frm_Alert = new alert_categoria();
                    frm_Alert.Show();
                    Clear();
                }
                else
                {
                    AlertsCat = "Não foi possível deletar categoria :(";
                    alert_categoria frm_Alert = new alert_categoria();
                    frm_Alert.Show();
                }
                DataTable dt = dal.Select();
                dgvUser.DataSource = dt;
            }
        }

        private void text_search_TextChanged(object sender, EventArgs e)
        {
            string keywords = text_search.Text;
            if (!string.IsNullOrEmpty(keywords))
            {
                DataTable dt = dal.Search(keywords);
                dgvUser.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    AlertsCat = "Nenhum resultado correspondente encontrado.";
                    alert_categoria frm_Alert = new alert_categoria();
                    frm_Alert.Show();
                }
            }
            else
            {
                DataTable dt = dal.Select();
                dgvUser.DataSource = dt;
            }
        }
    }
}
