﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiStore.BLLClasses.DALdados
{
    internal class transactionDetailDAL
    {
        static string myConnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region Inserir Transações de dados

        public bool InsertTransactionDetail(transactionDetailBLL td)
        {
            bool isSucess = false;

            SqlConnection conn = new SqlConnection(myConnstring);
            try
            {
                string sql = "INSERT INTO tbl_transaction_details( product_id, rate, qty, total, dea_cust_id, added_date, added_by) VALUES(@product_id, @rate, @qty, @total, @dea_cust_id, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
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

        #endregion
    }
}
