using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace MSI
{
   
    class DbConnection
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"].ToString());
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        public string DbConnect(string barcode,int labelid,string emp_id,string Work_Orderno)
        {
            try
            {
                cmd = new SqlCommand("pro_getCustomerSerialNoSSD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pcbserialno", barcode);
                cmd.Parameters.AddWithValue("@labelmasterid", labelid);
                cmd.Parameters.AddWithValue("@user_id",emp_id);
                cmd.Parameters.AddWithValue("@Work_Orderno", Work_Orderno);
                con.Open();
                var reader = cmd.ExecuteScalar();
                con.Close();
                return reader.ToString();
            }
            catch (Exception ex)
            {
                return string.Empty;
                MessageBox.Show("Error : " + ex.Message.ToString());
            }
        }

        public List<BarcodeDetails> GetBarcodeDetails(int labelid)
        {
            var list = new List<BarcodeDetails>();
            try
            {
                
                BarcodeDetails objBar;
                cmd = new SqlCommand("pro_getPrintedValueEssencoreSSD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@labelmasterid", labelid);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    objBar = new BarcodeDetails();
                    objBar.CustomerSerialNo = Convert.ToString(dr["CustomerSerialNo"]);
                    objBar.PCBSerialNo = Convert.ToString(dr["PCBSerialNo"]);
                    objBar.ProductNo = Convert.ToString(dr["productno"]);
                    list.Add(objBar);
                }
                return list;
            }
            catch(Exception ex)
            {
                return list;
                MessageBox.Show("Error", "Database not connected");
            }
        }

        public List<labeltype> GetLabels() {
            var lstType = new List<labeltype>();
            try
            {
                
                labeltype objType = new labeltype();
                cmd = new SqlCommand("getLabelTypeEssencoreSSD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    objType = new labeltype();
                    objType.labelmasterid = Convert.ToInt32(dr["labelmasterid"]);
                    objType.labelname = Convert.ToString(dr["labeltype"]);
                    lstType.Add(objType);
                }
                return lstType;
            }
            catch (Exception ex)
            {
                return lstType;
                MessageBox.Show("Error :" + ex.Message.ToString());
            }

        }

        public List<string> getWorkOrderDetails(int labelid) {
            var listWorkOrderNos = new List<string>();
            try
            {
                cmd=new SqlCommand("get_WorkOrderDetailsSSD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@labelID",labelid);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        listWorkOrderNos.Add(dr["WorkOrderNo"].ToString());
                    }
                }
                return listWorkOrderNos;
            }
            catch (Exception ex) {
                return listWorkOrderNos ;
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public BarcodeDetails GetProductDetails(int labelid,string workorderno)
        {
            var barCodeDetils = new BarcodeDetails();
            try
            {
                string result = string.Empty;
                cmd = new SqlCommand("get_ProductNoEssencoreSSD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@labelid", labelid);
                cmd.Parameters.AddWithValue("@WorkOrderNo", workorderno);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    barCodeDetils.SyrmaSGSPartno = dt.Rows[0]["SyrmaSGSPartno"].ToString();
                    barCodeDetils.WorkOrderNo = dt.Rows[0]["WorkOrderNo"].ToString();
                    barCodeDetils.CustomerPartNo = dt.Rows[0]["CustomerPartNo"].ToString();
                    barCodeDetils.Bar_Description = dt.Rows[0]["Bar_Description"].ToString();
                    barCodeDetils.WeekDetails = Convert.ToInt32(dt.Rows[0]["WeekDetails"].ToString());
                    barCodeDetils.ProductNo = dt.Rows[0]["productno"].ToString();
                }
                //con.Open();
                //result = Convert.ToString(cmd.ExecuteScalar());
                //con.Close();
                return barCodeDetils;
            }
            catch (Exception ex)
            {
                return barCodeDetils;
                MessageBox.Show("Error :" + ex.Message.ToString());
            }
        }
    }
}
