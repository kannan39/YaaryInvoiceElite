namespace YaaryInvoiceElite
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            btn_Login = new Button();
            lbl_InvalidCred = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(307, 40);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 107);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 154);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(182, 107);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(142, 23);
            txt_UserName.TabIndex = 3;
            txt_UserName.UseWaitCursor = true;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(181, 146);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(143, 23);
            txt_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(182, 201);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(75, 23);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += button1_Click;
            // 
            // lbl_InvalidCred
            // 
            lbl_InvalidCred.AutoSize = true;
            lbl_InvalidCred.Location = new Point(78, 264);
            lbl_InvalidCred.Name = "lbl_InvalidCred";
            lbl_InvalidCred.Size = new Size(38, 15);
            lbl_InvalidCred.TabIndex = 6;
            lbl_InvalidCred.Text = "label4";
            lbl_InvalidCred.Visible = false;
            // 
            // printDocument2
            // 

            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_InvalidCred);
            Controls.Add(btn_Login);
            Controls.Add(txt_Password);
            Controls.Add(txt_UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Button btn_Login;
        private Label lbl_InvalidCred;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}