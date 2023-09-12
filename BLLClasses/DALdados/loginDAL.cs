using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobiStore.BLLClasses.DALdados
{
    internal class loginDAL
    {
        static string myConnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public bool loginCheck(loginBLL l)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myConnstring);

            try
            {
                conn.Open();
                string sql = "SELECT * FROM tbl_users WHERE user_name=@user_name AND password=@password AND user_type=@user_type";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user_name", l.Username);
                cmd.Parameters.AddWithValue("@password", l.Password);
                cmd.Parameters.AddWithValue("@user_type", l.User_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucess;
        }
    }
}
