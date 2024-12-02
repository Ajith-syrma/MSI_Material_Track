namespace MSI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxBarcode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcode).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBarcode
            // 
            pictureBoxBarcode.Location = new Point(223, 112);
            pictureBoxBarcode.Margin = new Padding(4, 5, 4, 5);
            pictureBoxBarcode.Name = "pictureBoxBarcode";
            pictureBoxBarcode.Size = new Size(677, 108);
            pictureBoxBarcode.TabIndex = 1;
            pictureBoxBarcode.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1143, 750);
            Controls.Add(pictureBoxBarcode);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarcode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxBarcode;
    }
}