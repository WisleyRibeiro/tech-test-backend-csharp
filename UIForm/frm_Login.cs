using MobiStore.BLLClasses;
using MobiStore.BLLClasses.DALdados;
using MobiStore.UIForm.AlertsUI;
using System;
using System.Windows.Forms;

namespace MobiStore.UIForm
{
    public partial class frm_Login : Form
    {
        public static string alertType;
        // Instância das classes BLL e DAL
        private readonly loginBLL l = new loginBLL();
        private readonly loginDAL dal = new loginDAL();

        public frm_Login()
        {
            InitializeComponent();
        }

        // Lidar com o clique no botão de fechar
        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Lidar com o clique no botão de login
        private void btn_login_Click(object sender, EventArgs e)
        {
            // Obter valores dos campos de entrada
            l.Username = text_user.Text.Trim();
            l.Password = text_pass.Text.Trim();
            l.User_type = set_user_type.Text.Trim();

            // Verificar o login
            bool success = dal.loginCheck(l);

            if (success)
            {
                // Redirecionar com base no tipo de usuário
                switch (l.User_type)
                {
                    case "Administrador":
                        {
                            frmAdminDashboard admin = new frmAdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "Comum":
                        {
                            frm_user_dashboard user = new frm_user_dashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            alertType = "Tipo de usuáio inválido";
                            frm_alert frm_Alert = new frm_alert();
                            frm_Alert.Show();
                        }
                        break;
                }
            }
            else
            {
                alertType = "Usuário ou senha incorretos!";
                frm_alert frm_Alert = new frm_alert();
                frm_Alert.Show();
            }
        }
    }
}
