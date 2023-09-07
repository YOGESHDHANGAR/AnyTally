using bharatplantdesktop.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace bharatplantdesktop.DAL
{
    internal class salesDetailsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Single Select
        public DataTable SingleSelect(salesDetailsBLL salesdetailsbll)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable SaleDetailSingleSelectDt = new DataTable();
            try
            {
                String sql = "SELECT i.id as Item_Id ,i.name as Item_Name, sd.quantity as Quantity, sd.rate as Rate, i.unit as per, sd.amount as Amount from tbl_sales_details sd " +
                             "INNER JOIN tbl_items i ON sd.item_id = i.id " +
                             "where sd.serial=@serial";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@serial", salesdetailsbll.serial);
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
        public bool Insert(salesDetailsBLL salesdetailsbll) {

            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_sales_details (item_id, quantity, rate, amount, serial, party_id, added_date, added_by) VALUES (@item_id, @quantity, @rate, @amount, @serial, @party_id, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@item_id", salesdetailsbll.item_id);
                cmd.Parameters.AddWithValue("@quantity", salesdetailsbll.quantity);
                cmd.Parameters.AddWithValue("@rate", salesdetailsbll.rate);
                cmd.Parameters.AddWithValue("@amount", salesdetailsbll.amount);
                cmd.Parameters.AddWithValue("@serial", salesdetailsbll.serial);
                cmd.Parameters.AddWithValue("@party_id", salesdetailsbll.party_id);
                cmd.Parameters.AddWithValue("@added_date", salesdetailsbll.added_date);
                cmd.Parameters.AddWithValue("@added_by", salesdetailsbll.added_by);

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
        public bool Update(salesDetailsBLL salesdetailsbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_sales_details SET item_id = @item_id, quantity = @quantity, rate = @rate, amount = @amount, party_id = @party_id WHERE serial = @serial AND id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@item_id", salesdetailsbll.item_id);
                cmd.Parameters.AddWithValue("@quantity", salesdetailsbll.quantity);
                cmd.Parameters.AddWithValue("@rate", salesdetailsbll.rate);
                cmd.Parameters.AddWithValue("@amount", salesdetailsbll.amount);
                cmd.Parameters.AddWithValue("@party_id", salesdetailsbll.party_id);
                cmd.Parameters.AddWithValue("@serial", salesdetailsbll.serial);
                cmd.Parameters.AddWithValue("@id", salesdetailsbll.id);

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
        public bool Delete(salesDetailsBLL salesdetailsbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_sales_details WHERE serial = @serial";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@serial", salesdetailsbll.serial);

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
