using bharatplantdesktop.BLL;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Collections.Generic;

namespace bharatplantdesktop.DAL
{
    internal class partysDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data from Database
        public DataTable Select()
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * from tbl_partys";
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

        #region Single Select Data from Database
        public DataTable SingleSelect(partysBLL partysbll)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable PartySingleSelectDt = new DataTable();
            try
            {
                String sql = "SELECT * from tbl_partys where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", partysbll.id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(PartySingleSelectDt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return PartySingleSelectDt;
        }

        #endregion

        #region Select Data from Database
        public Dictionary<int, string> SelectAllforAutoSuggestion()
        {
            Dictionary<int, string> partyData = new Dictionary<int, string>();

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT id, name FROM tbl_partys"; 
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int partyId = Convert.ToInt32(reader["id"]);
                    string partyName = reader["name"].ToString();
                    partyData.Add(partyId, partyName);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return partyData;
        }
        #endregion

        #region Insert Data in Database
        public bool Insert(partysBLL partysbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "INSERT INTO tbl_partys (name, opening_balance,lena_dena, added_date, added_by) VALUES (@name, @opening_balance ,@lena_dena, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", partysbll.name);
                cmd.Parameters.AddWithValue("@opening_balance", partysbll.opening_balance);
                cmd.Parameters.AddWithValue("@lena_dena", partysbll.lena_dena);
                cmd.Parameters.AddWithValue("@added_date", partysbll.added_date);
                cmd.Parameters.AddWithValue("@added_by", partysbll.added_by);

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
        public bool Update(partysBLL partysbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_partys SET name=@name, username=@username, password=@password,  added_date=@added_date, added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", partysbll.name);
                cmd.Parameters.AddWithValue("@opening_balance", partysbll.opening_balance);
                cmd.Parameters.AddWithValue("@added_date", partysbll.added_date);
                cmd.Parameters.AddWithValue("@added_by", partysbll.added_by);
                cmd.Parameters.AddWithValue("@id", partysbll.id);

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
        public bool Delete(partysBLL partysbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_partys WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", partysbll.id);
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
        

    }
}
