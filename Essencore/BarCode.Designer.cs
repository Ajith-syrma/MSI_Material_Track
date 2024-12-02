namespace MSI
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
            printDialog1 = new PrintDialog();
            label1 = new Label();
            label2 = new Label();
            txtPCBSerialNo = new TextBox();
            label4 = new Label();
            rtbInstruction = new RichTextBox();
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
            lblBarcode = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBarcodeDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(954, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 26);
            label1.TabIndex = 1;
            label1.Text = "Syrma SGS Part No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(963, 249);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 26);
            label2.TabIndex = 5;
            label2.Text = "Work Order No :";
            // 
            // txtPCBSerialNo
            // 
            txtPCBSerialNo.Location = new Point(757, 389);
            txtPCBSerialNo.Margin = new Padding(4, 5, 4, 5);
            txtPCBSerialNo.Name = "txtPCBSerialNo";
            txtPCBSerialNo.Size = new Size(593, 31);
            txtPCBSerialNo.TabIndex = 6;
            txtPCBSerialNo.KeyDown += txtPCBSerialNo_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 653);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 26);
            label4.TabIndex = 9;
            // 
            // rtbInstruction
            // 
            rtbInstruction.Location = new Point(757, 466);
            rtbInstruction.Margin = new Padding(4, 5, 4, 5);
            rtbInstruction.Name = "rtbInstruction";
            rtbInstruction.Size = new Size(594, 261);
            rtbInstruction.TabIndex = 15;
            rtbInstruction.Text = "";
            // 
            // dgvBarcodeDetails
            // 
            dgvBarcodeDetails.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBarcodeDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarcodeDetails.Location = new Point(25, 737);
            dgvBarcodeDetails.Margin = new Padding(4, 5, 4, 5);
            dgvBarcodeDetails.Name = "dgvBarcodeDetails";
            dgvBarcodeDetails.RowHeadersWidth = 62;
            dgvBarcodeDetails.Size = new Size(1801, 317);
            dgvBarcodeDetails.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(963, 358);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(158, 26);
            label7.TabIndex = 17;
            label7.Text = "PCB Serial no:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(978, 435);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(143, 26);
            label8.TabIndex = 18;
            label8.Text = "Instruction";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 12F);
            label9.Location = new Point(29, 700);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 30);
            label9.TabIndex = 19;
            label9.Text = "Report";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(34, 1122);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(594, 52);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // cmbProductType
            // 
            cmbProductType.FormattingEnabled = true;
            cmbProductType.Location = new Point(757, 180);
            cmbProductType.Margin = new Padding(4, 5, 4, 5);
            cmbProductType.Name = "cmbProductType";
            cmbProductType.Size = new Size(593, 33);
            cmbProductType.TabIndex = 21;
            cmbProductType.SelectedIndexChanged += cmbProductType_SelectedIndexChanged;
            // 
            // lblProductNo
            // 
            lblProductNo.AutoSize = true;
            lblProductNo.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductNo.Location = new Point(33, 730);
            lblProductNo.Margin = new Padding(4, 0, 4, 0);
            lblProductNo.Name = "lblProductNo";
            lblProductNo.Size = new Size(0, 26);
            lblProductNo.TabIndex = 23;
            lblProductNo.Visible = false;
            // 
            // label10
            // 
            label10.AllowDrop = true;
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(39, 17);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(145, 23);
            label10.TabIndex = 25;
            label10.Text = "08 August 2024";
            // 
            // lblWeekNumber
            // 
            lblWeekNumber.AutoSize = true;
            lblWeekNumber.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeekNumber.Location = new Point(307, 17);
            lblWeekNumber.Margin = new Padding(4, 0, 4, 0);
            lblWeekNumber.Name = "lblWeekNumber";
            lblWeekNumber.Size = new Size(72, 23);
            lblWeekNumber.TabIndex = 27;
            lblWeekNumber.Text = "12:53:18";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(972, 67);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(203, 44);
            label11.TabIndex = 28;
            label11.Text = "Tracking ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Showcard Gothic", 12F);
            label12.Location = new Point(1361, 15);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(101, 30);
            label12.TabIndex = 29;
            label12.Text = "User ID";
            // 
            // lbluserid
            // 
            lbluserid.AllowDrop = true;
            lbluserid.AutoSize = true;
            lbluserid.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbluserid.Location = new Point(1469, 17);
            lbluserid.Margin = new Padding(4, 0, 4, 0);
            lbluserid.Name = "lbluserid";
            lbluserid.Size = new Size(111, 29);
            lbluserid.TabIndex = 30;
            lbluserid.Text = "0000000";
            // 
            // cmbWorkOrderNo
            // 
            cmbWorkOrderNo.FormattingEnabled = true;
            cmbWorkOrderNo.Location = new Point(757, 280);
            cmbWorkOrderNo.Margin = new Padding(4, 5, 4, 5);
            cmbWorkOrderNo.Name = "cmbWorkOrderNo";
            cmbWorkOrderNo.Size = new Size(593, 33);
            cmbWorkOrderNo.TabIndex = 31;
            cmbWorkOrderNo.SelectedIndexChanged += cmbWorkOrderNo_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(1444, 1132);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(391, 52);
            btnExit.TabIndex = 32;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.SyrmaSgs;
            pictureBox2.Location = new Point(1613, 33);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 83);
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.BackColor = SystemColors.ActiveCaption;
            lblBarcode.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.ForeColor = SystemColors.ActiveCaptionText;
            lblBarcode.Location = new Point(930, 17);
            lblBarcode.Margin = new Padding(4, 0, 4, 0);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(274, 44);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "MSI   Material";
            lblBarcode.Click += lblBarcode_Click;
            // 
            // frmBarcode
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1839, 1050);
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
            Controls.Add(label4);
            Controls.Add(txtPCBSerialNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblBarcode);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmBarcode";
            Text = "BarCode";
            Load += frmBarcode_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBarcodeDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PrintDialog printDialog1;
        private Label label1;
        private Label label2;
        private TextBox txtPCBSerialNo;
        private Label label4;
        private RichTextBox rtbInstruction;
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
        private Label lblBarcode;
    }
}
