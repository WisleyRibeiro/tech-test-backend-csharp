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
    public partial class frm_User : Form
    {
        public static string userdashboard;
        public frm_User()
        {
            InitializeComponent();
        }

        public static string AlertUser;

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void img_close_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();
            frmAdminDashboard.Show();
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            if (text_First_Name.Text == "" || text_Last_Name.Text == "" || text_user_name.Text == "" || text_pass.Text == "" || text_pass2.Text == "" || set_user_type.Text == "")
            {
                AlertUser = "Existem campos obrigatórios (•) não preenchidos!";
                alert_user alert_user = new alert_user();
                alert_user.Show();
            }
            else
            {
                string pass1 = text_pass.Text;
                string pass2 = text_pass2.Text;

                if (pass1 == pass2)
                {
                    u.first_name = text_First_Name.Text;
                    u.last_name = text_Last_Name.Text;
                    u.email = text_mail.Text;
                    u.user_name = text_user_name.Text;
                    u.password = text_pass.Text;
                    u.contact = text_contact.Text;
                    u.address = text_adress.Text;
                    u.gender = set_gener.Text;
                    u.user_type = set_user_type.Text;
                    u.added_date = DateTime.Now;
                    u.added_by = 1;

                    bool success = dal.Insert(u);

                    if (success)
                    {
                        AlertUser = "Usuário cadastrado com sucesso! :)";
                        alert_user alert_user = new alert_user();
                        alert_user.Show();
                        clear();
                    }
                    else
                    {
                        AlertUser = "Ops, algo deu errado ao tentar cadastrar este usuário :(";
                        alert_user alert_user = new alert_user();
                        alert_user.Show();
                    }

                    DataTable dt = dal.Select();
                    dgvUser.DataSource = dt;
                }
                else
                {
                    AlertUser = "As senhas não conferem!";
                    alert_user alert_user = new alert_user();
                    alert_user.Show();
                    text_pass.Text = "";
                    text_pass2.Text = "";
                }
            }

        }

        private void frm_User_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUser.DataSource = dt;
            dgvUser.Columns[0].HeaderText = "ID do Usuário:";
            dgvUser.Columns[1].HeaderText = "Primeiro Nome:";
            dgvUser.Columns[2].HeaderText = "Sobrenome:";
            dgvUser.Columns[3].HeaderText = "E-mail:";
            dgvUser.Columns[4].HeaderText = "Nick Name:";
            dgvUser.Columns[5].HeaderText = "Senha:";
            dgvUser.Columns[6].HeaderText = "Contato:";
            dgvUser.Columns[7].HeaderText = "Endereço:";
            dgvUser.Columns[8].HeaderText = "Gênero:";
            dgvUser.Columns[9].HeaderText = "Tipo de Usuário:";
            dgvUser.Columns[10].HeaderText = "Data/hora de cadastro:";
            dgvUser.Columns[11].HeaderText = "Cadastrado por:";

        }

        private void clear()
        {
            text_ID.Text = "";
            text_First_Name.Text = "";
            text_Last_Name.Text = "";
            text_mail.Text = "";
            text_user_name.Text = "";
            text_pass.Text = "";
            text_pass2.Text = "";
            text_contact.Text = "";
            text_adress.Text = "";
            set_gener.Text = "";
            set_user_type.Text = "";
        }

        private void dgvUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            text_ID.Text = dgvUser.Rows[rowIndex].Cells[0].Value.ToString();
            text_First_Name.Text = dgvUser.Rows[rowIndex].Cells[1].Value.ToString();
            text_Last_Name.Text = dgvUser.Rows[rowIndex].Cells[2].Value.ToString();
            text_mail.Text = dgvUser.Rows[rowIndex].Cells[3].Value.ToString();
            text_user_name.Text = dgvUser.Rows[rowIndex].Cells[4].Value.ToString();
            text_pass.Text = dgvUser.Rows[rowIndex].Cells[5].Value.ToString();
            text_contact.Text = dgvUser.Rows[rowIndex].Cells[6].Value.ToString();
            text_adress.Text = dgvUser.Rows[rowIndex].Cells[7].Value.ToString();
            set_gener.Text = dgvUser.Rows[rowIndex].Cells[8].Value.ToString();
            set_user_type.Text = dgvUser.Rows[rowIndex].Cells[9].Value.ToString();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (text_ID.Text == "")
            {
                AlertUser = "Por favor, selecione um usuário antes";
                alert_user alert_user = new alert_user();
                alert_user.Show();
            }
            else
            {
                u.id = Convert.ToInt32(text_ID.Text);
                u.first_name = text_First_Name.Text;
                u.last_name = text_Last_Name.Text;
                u.email = text_mail.Text;
                u.user_name = text_user_name.Text;
                u.password = text_pass.Text;
                u.contact = text_contact.Text;
                u.address = text_adress.Text;
                u.gender = set_gener.Text;
                u.user_type = set_user_type.Text;
                u.added_date = DateTime.Now;
                u.added_by = 1;

                bool success = dal.Update(u);
                if (success)
                {
                    AlertUser = "Dados atualizados com sucesso :)";
                    alert_user alert_user = new alert_user();
                    alert_user.Show();
                    clear();
                }
                else
                {
                    AlertUser = "Não foi possível atualizar informações :(";
                    alert_user alert_user = new alert_user();
                    alert_user.Show();
                }
                DataTable dt = dal.Select();
                dgvUser.DataSource = dt;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (text_ID.Text == "")
            {
                AlertUser = "Por favor, selecione um usuário antes";
                alert_user alert_user = new alert_user();
                alert_user.Show();
            }
            else
            {
                u.id = Convert.ToInt32(text_ID.Text);

                bool success = dal.Delete(u);
                if (success)
                {
                    AlertUser = "Usuário apagado com sucesso :)";
                    alert_user alert_user = new alert_user();
                    alert_user.Show();
                    clear();
                }
                else
                {
                    AlertUser = "Não foi possível deletar este usuário :(";
                    alert_user alert_user = new alert_user();
                    alert_user.Show();
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
                    AlertUser = "Nenhum resultado correspondente encontrado.\"";
                    alert_user alert_user = new alert_user();
                    alert_user.Show();
                }
            }
            else
            {
                DataTable dt = dal.Search();
                dgvUser.DataSource = dt;
            }
        }
    }
}
