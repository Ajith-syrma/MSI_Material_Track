using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices.JavaScript;
namespace MSI
{
   
    class DbConnection
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["conn"].ToString());
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataTable dt;
        
        public List<Material_status> DbConnect(string barcode, int labelid, string emp_id)
        {
            var listMaterialstatus = new List<Material_status>();
            try
            {
                Material_status objMatstatus;
                cmd = new SqlCommand("pro_getMaterialstatus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Alternate_Material_no", barcode);
                cmd.Parameters.AddWithValue("@ProductID", labelid);
                cmd.Parameters.AddWithValue("@user_id",emp_id);
                //cmd.Parameters.AddWithValue("@Work_Orderno", Work_Orderno);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    objMatstatus = new Material_status();
                    //objMatstatus.Fg_Name = Convert.ToString(dr["Fg_Name"]);
                    objMatstatus.ProductID = Convert.ToString(dr["ProductID"]);
                    objMatstatus.Material_no = Convert.ToString(dr["Material_no"]);
                    objMatstatus.status = Convert.ToString(dr["Status1"]);
                    listMaterialstatus.Add(objMatstatus);
                }
                return listMaterialstatus;
            }
            catch (Exception ex)
            {
                return listMaterialstatus;
                MessageBox.Show("Error :" + ex.Message.ToString());
            }

        }

        public List<BarcodeDetails> GetMaterialscanDetails()
        {
            var list = new List<BarcodeDetails>();
            try
            {
                
                BarcodeDetails objBar;
                cmd = new SqlCommand("pro_getPrintedValueMsiMaterialTrack", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@labelmasterid", labelid);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    objBar = new BarcodeDetails();
                    objBar.Fg_Name = Convert.ToString(dr["Fg_Name"]);
                    objBar.Material_number = Convert.ToString(dr["Material_number"]);
                    objBar.Customer_Material = Convert.ToString(dr["Customer_Material"]);
                    objBar.Description = Convert.ToString(dr["Description"]);
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
                cmd = new SqlCommand("getLabelTypeMsi", con);
                cmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    objType = new labeltype();
                    objType.labelmasterid = Convert.ToInt32(dr["ProductID"]);
                    objType.labelname = Convert.ToString(dr["Fg_Name"]);
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


        public void mat_input_status(string ProductID, string Materialno,string empid)
        {
            
            try
            {
                cmd = new SqlCommand("pro_Mat_Track_input_status", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", ProductID);
                cmd.Parameters.AddWithValue("@Material_no", Materialno);
                cmd.Parameters.AddWithValue("@user_id", empid);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error", "Database not connected");
            }
        }

        //public BarcodeDetails GetProductDetails(int labelid)
        //{
        //    var barCodeDetils = new BarcodeDetails();
        //    try
        //    {
        //        string result = string.Empty;
        //        cmd = new SqlCommand("get_ProductNoEssencoreSSD", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@labelid", labelid);
        //        //cmd.Parameters.AddWithValue("@WorkOrderNo", workorderno);
        //        adapter = new SqlDataAdapter(cmd);
        //        dt = new DataTable();
        //        adapter.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            barCodeDetils.SyrmaSGSPartno = dt.Rows[0]["SyrmaSGSPartno"].ToString();
        //            barCodeDetils.WorkOrderNo = dt.Rows[0]["WorkOrderNo"].ToString();
        //            barCodeDetils.CustomerPartNo = dt.Rows[0]["CustomerPartNo"].ToString();
        //            barCodeDetils.Bar_Description = dt.Rows[0]["Bar_Description"].ToString();
        //            barCodeDetils.WeekDetails = Convert.ToInt32(dt.Rows[0]["WeekDetails"].ToString());
        //            barCodeDetils.ProductNo = dt.Rows[0]["productno"].ToString();
        //        }
        //        //con.Open();
        //        //result = Convert.ToString(cmd.ExecuteScalar());
        //        //con.Close();
        //        return barCodeDetils;
        //    }
        //    catch (Exception ex)
        //    {
        //        return barCodeDetils;
        //        MessageBox.Show("Error :" + ex.Message.ToString());
        //    }
        //}
    }
}
