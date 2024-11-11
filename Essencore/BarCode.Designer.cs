namespace Essencore
{
    partial class frmBarcode
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBarcode = new Label();
            label1 = new Label();
            txtPCBSerialNo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCustomerPartNo = new TextBox();
            label4 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            txtCustomerSerialNo = new TextBox();
            label6 = new Label();
            rtbInstruction = new RichTextBox();
            printDialog1 = new PrintDialog();
            dgvBarcodeDetails = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnClear = new Button();
            cmbProductType = new ComboBox();
            lblProductNo = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            lblWeekNumber = new Label();
            label11 = new Label();
            label12 = new Label();
            lbluserid = new Label();
            cmbWorkOrderNo = new ComboBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBarcodeDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.BackColor = SystemColors.ActiveCaption;
            lblBarcode.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = SystemColors.ActiveCaptionText;
            lblBarcode.Location = new Point(764, 13);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(180, 37);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "Essencore";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 125);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 1;
            label1.Text = "Syrma SGS Part No :";
            // 
            // txtPCBSerialNo
            // 
            txtPCBSerialNo.Location = new Point(26, 549);
            txtPCBSerialNo.Margin = new Padding(3, 4, 3, 4);
            txtPCBSerialNo.Name = "txtPCBSerialNo";
            txtPCBSerialNo.Size = new Size(476, 27);
            txtPCBSerialNo.TabIndex = 6;
            txtPCBSerialNo.KeyDown += txtPCBSerialNo_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 199);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 5;
            label2.Text = "Work Order No :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 273);
            label3.Name = "label3";
            label3.Size = new Size(180, 21);
            label3.TabIndex = 7;
            label3.Text = "Customer Part No :";
            // 
            // txtCustomerPartNo
            // 
            txtCustomerPartNo.Location = new Point(21, 300);
            txtCustomerPartNo.Margin = new Padding(3, 4, 3, 4);
            txtCustomerPartNo.Name = "txtCustomerPartNo";
            txtCustomerPartNo.Size = new Size(481, 27);
            txtCustomerPartNo.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 523);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(23, 383);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(479, 27);
            txtDescription.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 356);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 11;
            label5.Text = "Description :";
            // 
            // txtCustomerSerialNo
            // 
            txtCustomerSerialNo.Location = new Point(24, 464);
            txtCustomerSerialNo.Margin = new Padding(3, 4, 3, 4);
            txtCustomerSerialNo.Name = "txtCustomerSerialNo";
            txtCustomerSerialNo.Size = new Size(478, 27);
            txtCustomerSerialNo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 437);
            label6.Name = "label6";
            label6.Size = new Size(189, 21);
            label6.TabIndex = 13;
            label6.Text = "Customer serial no:";
            // 
            // rtbInstruction
            // 
            rtbInstruction.Location = new Point(26, 665);
            rtbInstruction.Margin = new Padding(3, 4, 3, 4);
            rtbInstruction.Name = "rtbInstruction";
            rtbInstruction.Size = new Size(476, 116);
            rtbInstruction.TabIndex = 15;
            rtbInstruction.Text = "";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // dgvBarcodeDetails
            // 
            dgvBarcodeDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarcodeDetails.Location = new Point(537, 149);
            dgvBarcodeDetails.Margin = new Padding(3, 4, 3, 4);
            dgvBarcodeDetails.Name = "dgvBarcodeDetails";
            dgvBarcodeDetails.RowHeadersWidth = 62;
            dgvBarcodeDetails.Size = new Size(1208, 632);
            dgvBarcodeDetails.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 523);
            label7.Name = "label7";
            label7.Size = new Size(132, 21);
            label7.TabIndex = 17;
            label7.Text = "PCB Serial no:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 628);
            label8.Name = "label8";
            label8.Size = new Size(119, 21);
            label8.TabIndex = 18;
            label8.Text = "Instruction";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 12F);
            label9.Location = new Point(474, 101);
            label9.Name = "label9";
            label9.Size = new Size(92, 26);
            label9.TabIndex = 19;
            label9.Text = "Report";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(26, 789);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(476, 41);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // cmbProductType
            // 
            cmbProductType.FormattingEnabled = true;
            cmbProductType.Location = new Point(26, 149);
            cmbProductType.Margin = new Padding(3, 4, 3, 4);
            cmbProductType.Name = "cmbProductType";
            cmbProductType.Size = new Size(476, 28);
            cmbProductType.TabIndex = 21;
            cmbProductType.SelectedIndexChanged += cmbProductType_SelectedIndexChanged;
            // 
            // lblProductNo
            // 
            lblProductNo.AutoSize = true;
            lblProductNo.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductNo.Location = new Point(26, 584);
            lblProductNo.Name = "lblProductNo";
            lblProductNo.Size = new Size(0, 21);
            lblProductNo.TabIndex = 23;
            lblProductNo.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SyrmaSgs;
            pictureBox1.Location = new Point(1571, 48);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 67);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AllowDrop = true;
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(269, 13);
            label10.Name = "label10";
            label10.Size = new Size(121, 18);
            label10.TabIndex = 25;
            label10.Text = "08 August 2024";
            // 
            // lblWeekNumber
            // 
            lblWeekNumber.AutoSize = true;
            lblWeekNumber.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeekNumber.Location = new Point(566, 13);
            lblWeekNumber.Name = "lblWeekNumber";
            lblWeekNumber.Size = new Size(61, 18);
            lblWeekNumber.TabIndex = 27;
            lblWeekNumber.Text = "12:53:18";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(731, 53);
            label11.Name = "label11";
            label11.Size = new Size(254, 37);
            label11.TabIndex = 28;
            label11.Text = "Label Printing";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Showcard Gothic", 12F);
            label12.Location = new Point(1320, 48);
            label12.Name = "label12";
            label12.Size = new Size(87, 26);
            label12.TabIndex = 29;
            label12.Text = "User ID";
            // 
            // lbluserid
            // 
            lbluserid.AllowDrop = true;
            lbluserid.AutoSize = true;
            lbluserid.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbluserid.Location = new Point(1406, 49);
            lbluserid.Name = "lbluserid";
            lbluserid.Size = new Size(87, 23);
            lbluserid.TabIndex = 30;
            lbluserid.Text = "0000000";
            // 
            // cmbWorkOrderNo
            // 
            cmbWorkOrderNo.FormattingEnabled = true;
            cmbWorkOrderNo.Location = new Point(26, 234);
            cmbWorkOrderNo.Margin = new Padding(3, 4, 3, 4);
            cmbWorkOrderNo.Name = "cmbWorkOrderNo";
            cmbWorkOrderNo.Size = new Size(476, 28);
            cmbWorkOrderNo.TabIndex = 31;
            cmbWorkOrderNo.SelectedIndexChanged += cmbWorkOrderNo_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1432, 789);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(313, 41);
            btnExit.TabIndex = 32;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmBarcode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1791, 843);
            Controls.Add(btnExit);
            Controls.Add(cmbWorkOrderNo);
            Controls.Add(lbluserid);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lblWeekNumber);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(lblProductNo);
            Controls.Add(cmbProductType);
            Controls.Add(btnClear);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvBarcodeDetails);
            Controls.Add(rtbInstruction);
            Controls.Add(txtCustomerSerialNo);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(txtCustomerPartNo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPCBSerialNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblBarcode);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBarcode";
            Text = "BarCode";
            Load += frmBarcode_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBarcodeDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBarcode;
        private Label label1;
        private TextBox txtPCBSerialNo;
        private Label label2;
        private Label label3;
        private TextBox txtCustomerPartNo;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
        private TextBox txtCustomerSerialNo;
        private Label label6;
        private RichTextBox rtbInstruction;
        private PrintDialog printDialog1;
        private DataGridView dgvBarcodeDetails;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnClear;
        private ComboBox cmbProductType;
        private Label lblProductNo;
        private PictureBox pictureBox1;
        private Label label10;
        private Label lblWeekNumber;
        private Label label11;
        private Label label12;
        private Label lbluserid;
        private ComboBox cmbWorkOrderNo;
        private Button btnExit;
    }
}
