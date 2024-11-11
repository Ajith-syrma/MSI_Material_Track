using System.Drawing;
using System.IO;
using System;
using System.Text;
using System.Runtime.InteropServices;
using BarTender;
using System.Globalization;
using System.Diagnostics.Eventing.Reader;


namespace Essencore
{
    public partial class frmBarcode : Form
    {
        private StringBuilder barcodeData = new StringBuilder();
        DbConnection getConn = new DbConnection();
        private System.Windows.Forms.Timer blinkTimer;
        private bool isBlinking;
        private Color originalColor;
        private string emp_id;

        public frmBarcode(string emp_id)
        {
            InitializeComponent();
            DisplayWeekNumber();
            this.emp_id = emp_id;
            lbluserid.Text = this.emp_id;

            this.KeyPreview = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }


        private void DisplayWeekNumber()
        {
            //----Get the current date----//
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);


            label10.Text = $"DATE: {currentDate}";
            label10.Font = new Font("Showcard Gothic", 12f);

            //----Get the current week number ----//
            DateTime currentweekdate = DateTime.Now;
            CultureInfo culture = CultureInfo.CurrentCulture;
            int weekNumber = culture.Calendar.GetWeekOfYear(
                currentweekdate,
                CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday);
            lblWeekNumber.Text = $"Week Number: {weekNumber}";
            lblWeekNumber.Font = new Font("Showcard Gothic", 12f);
        }


        //----Db coonection for serial and product number without duplicates----//
        private void ProcessBarcode(string barcode, int labelid, string emp_id)
        {
            if (cmbProductType.SelectedIndex != 0 && !string.IsNullOrEmpty(cmbWorkOrderNo.SelectedValue.ToString()))
            {
                var bcode = getConn.DbConnect(barcode, labelid, emp_id);

                if (bcode != "Duplicate" && bcode != "NotFound")
                {

                    rtbInstruction.Text = "Print Started";
                    rtbInstruction.Font = new Font("Showcard Gothic", 12f);
                    rtbInstruction.BackColor = Color.LightGoldenrodYellow;
                    DataBindings();
                    printLabelBarcode(lblProductNo.Text.ToString(), bcode.ToString());


                    rtbInstruction.BackColor = Color.Empty;
                    txtCustomerSerialNo.Text = bcode.ToString();
                }
                else if (bcode == "Duplicate")
                {

                    txtPCBSerialNo.BackColor = Color.OrangeRed;

                    blinkTimer = new System.Windows.Forms.Timer
                    {
                        Interval = 500 // Set the interval to 500 milliseconds (0.5 seconds)
                    };
                    blinkTimer.Tick += (s, args) => BlinkTextBox();
                    blinkTimer.Start();
                    rtbInstruction.Text = "Duplicate";
                    rtbInstruction.BackColor = Color.OrangeRed;
                    rtbInstruction.Font = new Font("Showcard Gothic", 12f);
                }
                else if (bcode == "NotFound")
                {
                    rtbInstruction.Text = "PCB Serial Not Found!" + Environment.NewLine + "or Product Type Mismatch!"
                                                  + Environment.NewLine + "Please Enter or Select valid value";
                    rtbInstruction.BackColor = Color.Gray;
                    rtbInstruction.Font = new Font("Showcard Gothic", 12f);
                }
            }
            else if (cmbProductType.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select the Product Type");
            }
            else if (cmbWorkOrderNo.SelectedValue.ToString() == "Select")
            {
                MessageBox.Show("Please Enter the WorkOrder Number ");
            }


        }

        private void BlinkTextBox()
        {
            if (isBlinking)
            {
                txtPCBSerialNo.BackColor = Color.OrangeRed;
            }
            else
            {
                txtPCBSerialNo.BackColor = Color.Empty;

            }
            if (txtPCBSerialNo.Text == string.Empty)
            {
                blinkTimer.Stop();
                txtPCBSerialNo.BackColor = Color.Empty;
                txtDescription.Text = string.Empty;
            }

            isBlinking = !isBlinking;
        }


        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtCustomerSerialNo.Text = string.Empty;
            txtPCBSerialNo.Focus();
            txtPCBSerialNo.Text = string.Empty;
            txtCustomerPartNo.Text = string.Empty;
            cmbWorkOrderNo.Text = "Select";
            txtDescription.Text = string.Empty;
            cmbProductType.SelectedIndex = 0;
            rtbInstruction.Text = string.Empty;
            rtbInstruction.BackColor = Color.Empty;
            txtPCBSerialNo.BackColor = Color.Empty;
        }


        public void printLabelBarcode(string productno, string cus_serialno)
        {
            try
            {

                //string labelFormatPath = @"D:\QR_CODE.btw";
                string labelFormatPath = @"D:\QREssencoreNew.btw";

                var product_no = string.IsNullOrEmpty(productno) ? string.Empty : productno;
                var cus_no = string.IsNullOrEmpty(cus_serialno) ? string.Empty : cus_serialno;
                if (product_no != string.Empty && cus_no != string.Empty)
                {

                    var externalValues = new Dictionary<string, string>
        {
            { "SerialNumber", cus_serialno },
            //{ "ProductNumber", productno },
            { "QR_value1", cus_serialno.Trim().Substring(0,5) },
            { "QR_value2", cus_serialno.Trim().Substring(cus_serialno.Length-5) },

        };

                    PrintLabel(labelFormatPath, externalValues);
                    txtPCBSerialNo.Text = string.Empty;
                    txtPCBSerialNo.Focus();
                }
                else
                {
                    MessageBox.Show("Database not connected. Please check with admin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void PrintLabel(string labelFormatPath, Dictionary<string, string> values)
        {

            BarTender.Application btApp = null;
            BarTender.Format btFormat = null;


            try
            {

                btApp = new BarTender.Application();
                btFormat = btApp.Formats.Open(labelFormatPath, false, "");

                foreach (var param in values)
                {
                    btFormat.SetNamedSubStringValue(param.Key, param.Value);
                }

                btFormat.PrintOut(false, false);
                btFormat.Close(BtSaveOptions.btDoNotSaveChanges);

                rtbInstruction.Text = "Print Successfully Completed";
                rtbInstruction.Font = new Font("Showcard Gothic", 12f);
                rtbInstruction.BackColor = Color.Gray;

            }
            catch (COMException comEx)
            {
                MessageBox.Show("COM Error: " + comEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Quit the BarTender application
                if (btApp != null)
                {
                    btApp.Quit(BtSaveOptions.btDoNotSaveChanges);
                    Marshal.ReleaseComObject(btApp);
                }

                if (btFormat != null)
                {
                    Marshal.ReleaseComObject(btFormat);
                }
            }


        }

        private void txtPCBSerialNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Process the barcode
                //  ProcessBarcode(barcodeData.ToString());
                int labelid = Convert.ToInt32(cmbProductType.SelectedValue);
                ProcessBarcode(txtPCBSerialNo.Text, labelid, this.emp_id);

                barcodeData.Clear();
            }
            else
            {
                // Append the keystroke to the barcode data
                barcodeData.Append((char)e.KeyValue);
            }
        }

        public void DataBindings()
        {
            try
            {

                string productNo = lblProductNo.Text.ToString();
                int labelid = Convert.ToInt32(cmbProductType.SelectedValue);
                var barcodedetails = getConn.GetBarcodeDetails(labelid);
                dgvBarcodeDetails.DataSource = barcodedetails;
                dgvBarcodeDetails.Columns["ProductNo"].Width = 350;
                dgvBarcodeDetails.Columns["CustomerSerialNo"].Width = 395;
                dgvBarcodeDetails.Columns["PCBSerialNo"].Width = 395;
                dgvBarcodeDetails.Columns["SyrmaSGSPartno"].Visible = false;
                dgvBarcodeDetails.Columns["WorkOrderNo"].Visible = false;
                dgvBarcodeDetails.Columns["CustomerPartNo"].Visible = false;
                dgvBarcodeDetails.Columns["Bar_Description"].Visible = false;
                dgvBarcodeDetails.Columns["WeekDetails"].Visible = false;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void frmBarcode_Load(object sender, EventArgs e)
        {
            try
            {
                txtPCBSerialNo.Focus();
                cmbProductType.Items.Insert(0, "Select ProductType");

                var lstLabelDetails = getConn.GetLabels();
                cmbProductType.DataSource = lstLabelDetails;
                cmbProductType.DisplayMember = "labelname";
                cmbProductType.ValueMember = "labelmasterid";
                cmbProductType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database not connected.");
            }

        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductType.SelectedIndex != 0)
                {
                    int labelid = Convert.ToInt32(cmbProductType.SelectedValue.ToString());
                    var listNos = getConn.getWorkOrderDetails(labelid);
                    if (listNos != null && listNos.Count > 0)
                    {
                        cmbWorkOrderNo.DataSource = listNos;
                    }
                }
                else
                {
                    //txtSyrmaPartNo.Text = string.Empty;
                }
                if (isBlinking)
                    blinkTimer.Stop();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message.ToString()); }
        }

        public void getFGDetails()
        {
            int labelid = Convert.ToInt32(cmbProductType.SelectedValue);
            var productdetails = getConn.GetProductDetails(labelid, cmbWorkOrderNo.SelectedValue.ToString());
            if (productdetails.WorkOrderNo != null)
            {
                //txtWorkorderNo.Text = productdetails.WorkOrderNo;
                txtCustomerPartNo.Text = productdetails.CustomerPartNo;
                txtDescription.Text = productdetails.ProductNo;
                lblProductNo.Text = productdetails.ProductNo;
                DataBindings();
                txtPCBSerialNo.Focus();
            }
            else
            {
                dgvBarcodeDetails.Columns.Clear();
                //txtWorkorderNo.Text = string.Empty;
                txtCustomerPartNo.Text = string.Empty;
                txtDescription.Text = string.Empty;
                lblProductNo.Text = string.Empty;
            }
        }

        private void cmbWorkOrderNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbWorkOrderNo.SelectedValue.ToString() != "Select" && cmbWorkOrderNo.Text != string.Empty)
                    getFGDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}













