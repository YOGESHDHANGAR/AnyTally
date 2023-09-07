using bharatplantdesktop.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace bharatplantdesktop.DAL
{
    internal class purchasesDetailsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Single Select
        public DataTable SingleSelect(purchasesDetailsBLL purchasesdetailsbll)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable SaleDetailSingleSelectDt = new DataTable();
            try
            {
                String sql = "SELECT i.id as Item_Id ,i.name as Item_Name, sd.quantity as Quantity, sd.rate as Rate, i.unit as per, sd.amount as Amount from tbl_purchases_details sd " +
                             "INNER JOIN tbl_items i ON sd.item_id = i.id " +
                             "where sd.serial=@serial";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@serial", purchasesdetailsbll.serial);
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
        public bool Insert(purchasesDetailsBLL purchasesdetailsbll)
        {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_purchases_details (item_id, quantity, rate, amount, serial, party_id, added_date, added_by) VALUES (@item_id, @quantity, @rate, @amount, @serial, @party_id, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@item_id", purchasesdetailsbll.item_id);
                cmd.Parameters.AddWithValue("@quantity", purchasesdetailsbll.quantity);
                cmd.Parameters.AddWithValue("@rate", purchasesdetailsbll.rate);
                cmd.Parameters.AddWithValue("@amount", purchasesdetailsbll.amount);
                cmd.Parameters.AddWithValue("@serial", purchasesdetailsbll.serial);
                cmd.Parameters.AddWithValue("@party_id", purchasesdetailsbll.party_id);
                cmd.Parameters.AddWithValue("@added_date", purchasesdetailsbll.added_date);
                cmd.Parameters.AddWithValue("@added_by", purchasesdetailsbll.added_by);

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
        public bool Update(purchasesDetailsBLL purchasesdetailsbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_purchases_details SET item_id = @item_id, quantity = @quantity, rate = @rate, amount = @amount, party_id = @party_id WHERE serial = @serial AND id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@item_id", purchasesdetailsbll.item_id);
                cmd.Parameters.AddWithValue("@quantity", purchasesdetailsbll.quantity);
                cmd.Parameters.AddWithValue("@rate", purchasesdetailsbll.rate);
                cmd.Parameters.AddWithValue("@amount", purchasesdetailsbll.amount);
                cmd.Parameters.AddWithValue("@party_id", purchasesdetailsbll.party_id);
                cmd.Parameters.AddWithValue("@serial", purchasesdetailsbll.serial);
                cmd.Parameters.AddWithValue("@id", purchasesdetailsbll.id);

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
        public bool Delete(purchasesDetailsBLL purchasesdetailsbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_purchases_details WHERE serial = @serial";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@serial", purchasesdetailsbll.serial);

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
