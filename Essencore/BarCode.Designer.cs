﻿namespace Essencore
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
            label10 = new Label();
            lblWeekNumber = new Label();
            label11 = new Label();
            label12 = new Label();
            lbluserid = new Label();
            cmbWorkOrderNo = new ComboBox();
            btnExit = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBarcodeDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.BackColor = SystemColors.ActiveCaption;
            lblBarcode.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = SystemColors.ActiveCaptionText;
            lblBarcode.Location = new Point(668, 10);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(138, 30);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "Essencore";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 94);
            label1.Name = "label1";
            label1.Size = new Size(145, 17);
            label1.TabIndex = 1;
            label1.Text = "Syrma SGS Part No :";
            // 
            // txtPCBSerialNo
            // 
            txtPCBSerialNo.Location = new Point(23, 412);
            txtPCBSerialNo.Name = "txtPCBSerialNo";
            txtPCBSerialNo.Size = new Size(416, 23);
            txtPCBSerialNo.TabIndex = 6;
            txtPCBSerialNo.KeyDown += txtPCBSerialNo_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 149);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 5;
            label2.Text = "Work Order No :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 205);
            label3.Name = "label3";
            label3.Size = new Size(146, 17);
            label3.TabIndex = 7;
            label3.Text = "Customer Part No :";
            // 
            // txtCustomerPartNo
            // 
            txtCustomerPartNo.Location = new Point(23, 225);
            txtCustomerPartNo.Name = "txtCustomerPartNo";
            txtCustomerPartNo.Size = new Size(416, 23);
            txtCustomerPartNo.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 392);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(24, 287);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(415, 23);
            txtDescription.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 267);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 11;
            label5.Text = "Description :";
            // 
            // txtCustomerSerialNo
            // 
            txtCustomerSerialNo.Location = new Point(23, 348);
            txtCustomerSerialNo.Name = "txtCustomerSerialNo";
            txtCustomerSerialNo.Size = new Size(416, 23);
            txtCustomerSerialNo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 328);
            label6.Name = "label6";
            label6.Size = new Size(151, 17);
            label6.TabIndex = 13;
            label6.Text = "Customer serial no:";
            // 
            // rtbInstruction
            // 
            rtbInstruction.Location = new Point(23, 491);
            rtbInstruction.Name = "rtbInstruction";
            rtbInstruction.Size = new Size(417, 158);
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
            dgvBarcodeDetails.Location = new Point(458, 112);
            dgvBarcodeDetails.Name = "dgvBarcodeDetails";
            dgvBarcodeDetails.RowHeadersWidth = 62;
            dgvBarcodeDetails.Size = new Size(827, 537);
            dgvBarcodeDetails.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 392);
            label7.Name = "label7";
            label7.Size = new Size(106, 17);
            label7.TabIndex = 17;
            label7.Text = "PCB Serial no:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 471);
            label8.Name = "label8";
            label8.Size = new Size(98, 17);
            label8.TabIndex = 18;
            label8.Text = "Instruction";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 12F);
            label9.Location = new Point(451, 76);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 19;
            label9.Text = "Report";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(24, 673);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(416, 31);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // cmbProductType
            // 
            cmbProductType.FormattingEnabled = true;
            cmbProductType.Location = new Point(24, 112);
            cmbProductType.Name = "cmbProductType";
            cmbProductType.Size = new Size(416, 23);
            cmbProductType.TabIndex = 21;
            cmbProductType.SelectedIndexChanged += cmbProductType_SelectedIndexChanged;
            // 
            // lblProductNo
            // 
            lblProductNo.AutoSize = true;
            lblProductNo.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductNo.Location = new Point(23, 438);
            lblProductNo.Name = "lblProductNo";
            lblProductNo.Size = new Size(0, 17);
            lblProductNo.TabIndex = 23;
            lblProductNo.Visible = false;
            // 
            // label10
            // 
            label10.AllowDrop = true;
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(27, 10);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 25;
            label10.Text = "08 August 2024";
            // 
            // lblWeekNumber
            // 
            lblWeekNumber.AutoSize = true;
            lblWeekNumber.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeekNumber.Location = new Point(215, 10);
            lblWeekNumber.Name = "lblWeekNumber";
            lblWeekNumber.Size = new Size(50, 15);
            lblWeekNumber.TabIndex = 27;
            lblWeekNumber.Text = "12:53:18";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(640, 40);
            label11.Name = "label11";
            label11.Size = new Size(198, 30);
            label11.TabIndex = 28;
            label11.Text = "Label Printing";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Showcard Gothic", 12F);
            label12.Location = new Point(953, 9);
            label12.Name = "label12";
            label12.Size = new Size(70, 20);
            label12.TabIndex = 29;
            label12.Text = "User ID";
            // 
            // lbluserid
            // 
            lbluserid.AllowDrop = true;
            lbluserid.AutoSize = true;
            lbluserid.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbluserid.Location = new Point(1028, 10);
            lbluserid.Name = "lbluserid";
            lbluserid.Size = new Size(71, 18);
            lbluserid.TabIndex = 30;
            lbluserid.Text = "0000000";
            // 
            // cmbWorkOrderNo
            // 
            cmbWorkOrderNo.FormattingEnabled = true;
            cmbWorkOrderNo.Location = new Point(24, 176);
            cmbWorkOrderNo.Name = "cmbWorkOrderNo";
            cmbWorkOrderNo.Size = new Size(416, 23);
            cmbWorkOrderNo.TabIndex = 31;
            cmbWorkOrderNo.SelectedIndexChanged += cmbWorkOrderNo_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1011, 679);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(274, 31);
            btnExit.TabIndex = 32;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.SyrmaSgs;
            pictureBox2.Location = new Point(1129, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 50);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // frmBarcode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1287, 724);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            Controls.Add(cmbWorkOrderNo);
            Controls.Add(lbluserid);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(lblWeekNumber);
            Controls.Add(label10);
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
            Name = "frmBarcode";
            Text = "BarCode";
            Load += frmBarcode_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBarcodeDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label10;
        private Label lblWeekNumber;
        private Label label11;
        private Label label12;
        private Label lbluserid;
        private ComboBox cmbWorkOrderNo;
        private Button btnExit;
        private PictureBox pictureBox2;
    }
}
