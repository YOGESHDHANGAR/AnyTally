﻿using bharatplantdesktop.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace bharatplantdesktop.DAL
{
    internal class purchasesDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data from Database
        public DataTable Select(DateTime? txtFilterPeriodFrom = null, DateTime? txtFilterPeriodTo = null, int selectedFilterPartyId = 0, int selectedFilterUserId = 0)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT s.serial as Serial,  s.date as Date, p.name AS Party, s.voucher as Voucher, s.narration as Narration,  u.name AS Created_By, s.total_amount as Total_Amount " +
                             "FROM tbl_purchases s " +
                             "INNER JOIN tbl_partys p ON s.party_id = p.id " +
                             "INNER JOIN tbl_users u ON s.added_by = u.id ";

                if (selectedFilterPartyId != 0 || selectedFilterUserId != 0 || txtFilterPeriodFrom.HasValue || txtFilterPeriodTo.HasValue)
                {
                    sql += "WHERE ";
                    List<string> conditions = new List<string>();
                    if (selectedFilterPartyId != 0)
                    {
                        conditions.Add("s.party_id = @SelectedFilterPartyId");
                    }
                    if (selectedFilterUserId != 0)
                    {
                        conditions.Add("s.added_by = @SelectedFilterUserId");
                    }
                    if (txtFilterPeriodFrom.HasValue)
                    {
                        conditions.Add("s.date >= @txtFilterPeriodFrom");
                    }
                    if (txtFilterPeriodTo.HasValue)
                    {
                        conditions.Add("s.date <= @txtFilterPeriodTo");
                    }
                    sql += string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SelectedFilterPartyId", selectedFilterPartyId);
                cmd.Parameters.AddWithValue("@SelectedFilterUserId", selectedFilterUserId);
                if (txtFilterPeriodFrom.HasValue)
                {
                    cmd.Parameters.AddWithValue("@txtFilterPeriodFrom", txtFilterPeriodFrom.Value);
                }
                if (txtFilterPeriodTo.HasValue)
                {
                    cmd.Parameters.AddWithValue("@txtFilterPeriodTo", txtFilterPeriodTo.Value);
                }

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
        public DataTable SingleSelect(purchasesBLL purchasesbll)
        {

            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable purchasesingleSelectDt = new DataTable();
            try
            {
                String sql = "SELECT * from tbl_purchases where serial=@serial";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@serial", purchasesbll.serial);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(purchasesingleSelectDt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return purchasesingleSelectDt;
        }

        #endregion

        #region Select Data from Database
        public Dictionary<int, string> SelectAllforAutoSuggestion()
        {
            Dictionary<int, string> purchasesData = new Dictionary<int, string>();

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT serial, narration FROM tbl_purchases";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int purchaseserial = Convert.ToInt32(reader["serial"]);
                    string saleNarration = reader["narration"].ToString();
                    purchasesData.Add(purchaseserial, saleNarration);
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
            return purchasesData;
        }
        #endregion

        #region Insert Data in Database
        public bool Insert(purchasesBLL purchasesbll, out int purchasesId)
        {
            bool isSuccess = false;
            purchasesId = -1;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_purchases (voucher, date, party_id, total_amount,narration, added_by) VALUES (@voucher, @date, @party_id, @total_amount,@narration, @added_by); SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@voucher", purchasesbll.voucher);
                cmd.Parameters.AddWithValue("@date", purchasesbll.date);
                cmd.Parameters.AddWithValue("@party_id", purchasesbll.party_id);
                cmd.Parameters.AddWithValue("@total_amount", purchasesbll.total_amount);
                cmd.Parameters.AddWithValue("@narration", purchasesbll.narration);
                cmd.Parameters.AddWithValue("@added_by", purchasesbll.added_by);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedId))
                {
                    purchasesId = insertedId;
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

        #region Update Data in Database
        public bool Update(purchasesBLL purchasesbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_purchases SET voucher = @voucher, date = @date, party_id = @party_id, total_amount = @total_amount, narration = @narration, added_by = @added_by WHERE serial = @serial";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@voucher", purchasesbll.voucher);
                cmd.Parameters.AddWithValue("@date", purchasesbll.date);
                cmd.Parameters.AddWithValue("@party_id", purchasesbll.party_id);
                cmd.Parameters.AddWithValue("@total_amount", purchasesbll.total_amount);
                cmd.Parameters.AddWithValue("@narration", purchasesbll.narration);
                cmd.Parameters.AddWithValue("@added_by", purchasesbll.added_by);
                cmd.Parameters.AddWithValue("@serial", purchasesbll.serial);

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

        #region Delete Data from DAtabase
        public bool Delete(purchasesBLL purchasesbll)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_purchases WHERE serial=@serial";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@serial", purchasesbll.serial);
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

        #region Get Latest Serial
        public int GetLatestSerial()
        {
            int latestSerial = 0;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT IDENT_CURRENT('tbl_purchases') as latestSerial";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    latestSerial = Convert.ToInt32(result);
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

            return latestSerial;
        }

        #endregion
    }
}
