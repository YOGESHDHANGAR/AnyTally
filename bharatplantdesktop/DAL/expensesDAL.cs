using bharatplantdesktop.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace bharatplantdesktop.DAL
{
    internal class expensesDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data from Database
        public DataTable Select()
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * from tbl_expenses";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        #endregion
        #region Insert Data in Database
        public bool Insert(expensesBLL expensesbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_expenses (date, expense_type, amount, added_date, added_by) VALUES (@date, @expense_type ,@amount, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@date", expensesbll.date);
                cmd.Parameters.AddWithValue("@expense_type", expensesbll.expense_type);
                cmd.Parameters.AddWithValue("@amount", expensesbll.amount);
                cmd.Parameters.AddWithValue("@added_date", expensesbll.added_date);
                cmd.Parameters.AddWithValue("@added_by", expensesbll.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }
        #endregion
        #region Update data in Database
        public bool Update(expensesBLL expensesbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_expenses SET date=@date, expense_type=@expense_type, added_date=@added_date, added_by=@added_by WHERE serial=@serial";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@date", expensesbll.date);
                cmd.Parameters.AddWithValue("@expense_type", expensesbll.expense_type);
                cmd.Parameters.AddWithValue("@added_date", expensesbll.added_date);
                cmd.Parameters.AddWithValue("@added_by", expensesbll.added_by);
                cmd.Parameters.AddWithValue("@serial", expensesbll.serial);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;

        }
        #endregion
        #region Delete Data from DAtabase
        public bool Delete(expensesBLL expensesbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_expenses WHERE serial=@serial";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@serial", expensesbll.serial);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }
        #endregion
        #region Search User on Database usingKeywords
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM tbl_expenses WHERE id LIKE '%" + keywords + "%' OR username LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region Get Latest Id
        public int GetLatestSerial()
        {
            int latestSerial = 0;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT MAX(serial) as latestSerial FROM tbl_expenses";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() && !reader.IsDBNull(reader.GetOrdinal("latestSerial")))
                {
                    latestSerial = Convert.ToInt32(reader["latestSerial"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return latestSerial;
        }
        #endregion
    }
}
