using MobiStore.UIForm;

namespace MobiStore
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Close();
        }

        private void btn_chose_user_Click_1(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            this.Close();
        }

        private void btn_created_user_Click(object sender, EventArgs e)
        {
            frm_User user = new frm_User();
            user.Show();
            this.Close();
        }

        private void btn_categorias_Click(object sender, EventArgs e)
        {
            frm_categorias frm_Categorias = new frm_categorias();
            frm_Categorias.Show();
            this.Close();
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            frm_products products = new frm_products();
            products.Show();
            this.Close();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            frm_about frm_About = new frm_about();
            frm_About.Show();
        }
    }
}