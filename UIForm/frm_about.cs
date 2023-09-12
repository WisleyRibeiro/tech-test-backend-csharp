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
    public partial class frm_about : Form
    {
        public frm_about()
        {
            InitializeComponent();
        }

        private void OpenURL(string url)
        {
            try
            {
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o URL: " + ex.Message);
            }
        }
        private void btn_chose_user_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_whats_Click(object sender, EventArgs e)
        {
            OpenURL("https://api.whatsapp.com/send?phone=5531971044156&text=Ol%C3%A1%20Wisley!%20Podemos%20conversar?%20%F0%9F%98%81");
        }

        private void btn_linkedin_Click(object sender, EventArgs e)
        {
            OpenURL("https://www.linkedin.com/in/wisley-ribeiro-lopes/");
        }
    }
}
