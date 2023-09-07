using bharatplantdesktop.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace bharatplantdesktop.DAL
{
    internal class receiptsDetailsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Single Select
        public DataTable SingleSelect(receiptsDetailsBLL receiptsdetailsbll)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable SaleDetailSingleSelectDt = new DataTable();
            try
            {
                String sql = "SELECT pm.id as transaction_mode_id ,pm.name as Receipt_Mode, pd.amount as Amount from tbl_receipts_details pd " +
                             "INNER JOIN tbl_transaction_modes pm ON pd.transaction_mode_id = pm.id " +
                             "where pd.serial=@serial";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@serial", receiptsdetailsbll.serial);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(SaleDetailSingleSelectDt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return SaleDetailSingleSelectDt;
        }
        #endregion

        #region Insert Method for Transaction Detail
        public bool Insert(receiptsDetailsBLL receiptsdetailsbll)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_receipts_details (transaction_mode_id, amount, serial, party_id, added_date, added_by) VALUES (@transaction_mode_id, @amount, @serial, @party_id, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@transaction_mode_id", receiptsdetailsbll.transaction_mode_id);
                cmd.Parameters.AddWithValue("@amount", receiptsdetailsbll.amount);
                cmd.Parameters.AddWithValue("@serial", receiptsdetailsbll.serial);
                cmd.Parameters.AddWithValue("@party_id", receiptsdetailsbll.party_id);
                cmd.Parameters.AddWithValue("@added_date", receiptsdetailsbll.added_date);
                cmd.Parameters.AddWithValue("@added_by", receiptsdetailsbll.added_by);

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

        #region Update Method for Transaction Detail
        public bool Update(receiptsDetailsBLL receiptsdetailsbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_receipts_details SET transaction_mode_id = @transaction_mode_id, amount = @amount, party_id = @party_id WHERE serial = @serial AND id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@transaction_mode_id", receiptsdetailsbll.transaction_mode_id);
                cmd.Parameters.AddWithValue("@amount", receiptsdetailsbll.amount);
                cmd.Parameters.AddWithValue("@party_id", receiptsdetailsbll.party_id);
                cmd.Parameters.AddWithValue("@serial", receiptsdetailsbll.serial);
                cmd.Parameters.AddWithValue("@id", receiptsdetailsbll.id);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
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

        #region Delete Method for Transaction Detail
        public bool Delete(receiptsDetailsBLL receiptsdetailsbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_receipts_details WHERE serial = @serial";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@serial", receiptsdetailsbll.serial);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
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
