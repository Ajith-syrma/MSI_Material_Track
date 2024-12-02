namespace MSI
{
    partial class LoginForm
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
            employee_id = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            password = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // employee_id
            // 
            employee_id.Location = new Point(241, 282);
            employee_id.Margin = new Padding(1, 3, 1, 3);
            employee_id.Name = "employee_id";
            employee_id.Size = new Size(175, 31);
            employee_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Emoji", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(641, 44);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.MaximumSize = new Size(500, 500);
            label1.Name = "label1";
            label1.Size = new Size(369, 53);
            label1.TabIndex = 2;
            label1.Text = "MSI Material Track";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 281);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.MaximumSize = new Size(500, 500);
            label3.Name = "label3";
            label3.Size = new Size(138, 29);
            label3.TabIndex = 4;
            label3.Text = "Employee ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 361);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.MaximumSize = new Size(500, 500);
            label4.Name = "label4";
            label4.Size = new Size(111, 29);
            label4.TabIndex = 5;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // password
            // 
            password.Location = new Point(241, 361);
            password.Margin = new Padding(1, 3, 1, 3);
            password.Name = "password";
            password.Size = new Size(175, 31);
            password.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(158, 518);
            button1.Name = "button1";
            button1.Size = new Size(146, 48);
            button1.TabIndex = 8;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = Properties.Resources.Login_Page;
            ClientSize = new Size(1178, 668);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(employee_id);
            Margin = new Padding(1, 3, 1, 3);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox employee_id;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox password;
        private Button button1;
    }
}