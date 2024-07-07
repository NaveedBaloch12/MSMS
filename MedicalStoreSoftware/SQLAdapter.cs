using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStoreSoftware
{
    class SQLAdapter
    {
        string ConnectionString, Command;
        SQLAdapter(string connectionString, string command)
        {
            ConnectionString = connectionString;
            Command = command;
        }

        public SQLAdapter(string ConnectionString)
        {
            // TODO: Complete member initialization
            this.ConnectionString = ConnectionString;
        }
        
        public void SQLDataHandler(string Query)
        {
            try
            {

                SqlConnection Con = new SqlConnection(ConnectionString);
                Con.Open();
                SqlCommand Cmd = new SqlCommand(Query, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }


        public bool ReadData(string Query)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                conn.Close();
            }
        }

        public void DisplayDGV(DataGridView dataGridView, string Query)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand Commond = new SqlCommand(Query, con);
            SqlDataAdapter sd = new SqlDataAdapter(Commond);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.Sort(dataGridView.Columns[1], ListSortDirection.Ascending);

        }

        public void UpdateData(string prdID, int Change)
        {
            try
            {
                string Query = "UPDATE Products SET M_Quantity = M_Quantity - " + Change + " WHERE M_ID = " + prdID;
                SqlConnection Con = new SqlConnection(ConnectionString);
                Con.Open();
                SqlCommand Cmd = new SqlCommand(Query, Con);
                Cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}
