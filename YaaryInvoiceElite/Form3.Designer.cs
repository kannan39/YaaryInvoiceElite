namespace YaaryInvoiceElite
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            lblTokenNoValue = new Label();
            From = new Label();
            lblFromLocationValue = new Label();
            label3 = new Label();
            lblToLocationValue = new Label();
            Distance = new Label();
            lblDistanceValue = new Label();
            label4 = new Label();
            lblFareValue = new Label();
            label5 = new Label();
            label6 = new Label();
            btnPrint = new Button();
            lblForm2SelectedArea = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 47);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 0;
            label1.Text = "Tamilnadu Auto Association";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 126);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Token No";
            // 
            // lblTokenNoValue
            // 
            lblTokenNoValue.AutoSize = true;
            lblTokenNoValue.Location = new Point(252, 126);
            lblTokenNoValue.Name = "lblTokenNoValue";
            lblTokenNoValue.Size = new Size(38, 15);
            lblTokenNoValue.TabIndex = 2;
            lblTokenNoValue.Text = "label3";
            // 
            // From
            // 
            From.AutoSize = true;
            From.Location = new Point(118, 172);
            From.Name = "From";
            From.Size = new Size(35, 15);
            From.TabIndex = 3;
            From.Text = "From";
            // 
            // lblFromLocationValue
            // 
            lblFromLocationValue.AutoSize = true;
            lblFromLocationValue.Location = new Point(252, 172);
            lblFromLocationValue.Name = "lblFromLocationValue";
            lblFromLocationValue.Size = new Size(38, 15);
            lblFromLocationValue.TabIndex = 4;
            lblFromLocationValue.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 217);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 5;
            label3.Text = "To";
            // 
            // lblToLocationValue
            // 
            lblToLocationValue.AutoSize = true;
            lblToLocationValue.Location = new Point(252, 217);
            lblToLocationValue.Name = "lblToLocationValue";
            lblToLocationValue.Size = new Size(38, 15);
            lblToLocationValue.TabIndex = 6;
            lblToLocationValue.Text = "label4";
            // 
            // Distance
            // 
            Distance.AutoSize = true;
            Distance.Location = new Point(118, 264);
            Distance.Name = "Distance";
            Distance.Size = new Size(52, 15);
            Distance.TabIndex = 7;
            Distance.Text = "Distance";
            // 
            // lblDistanceValue
            // 
            lblDistanceValue.AutoSize = true;
            lblDistanceValue.Location = new Point(252, 264);
            lblDistanceValue.Name = "lblDistanceValue";
            lblDistanceValue.Size = new Size(38, 15);
            lblDistanceValue.TabIndex = 8;
            lblDistanceValue.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 320);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 9;
            label4.Text = "Fare";
            // 
            // lblFareValue
            // 
            lblFareValue.AutoSize = true;
            lblFareValue.Location = new Point(252, 320);
            lblFareValue.Name = "lblFareValue";
            lblFareValue.Size = new Size(38, 15);
            lblFareValue.TabIndex = 10;
            lblFareValue.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 375);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 11;
            label5.Text = "Booking Fees";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(254, 376);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "5 Rupees";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(121, 445);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 13;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblForm2SelectedArea
            // 
            lblForm2SelectedArea.AutoSize = true;
            lblForm2SelectedArea.Location = new Point(474, 136);
            lblForm2SelectedArea.Name = "lblForm2SelectedArea";
            lblForm2SelectedArea.Size = new Size(38, 15);
            lblForm2SelectedArea.TabIndex = 14;
            lblForm2SelectedArea.Text = "label7";
            lblForm2SelectedArea.Visible = false;
            lblForm2SelectedArea.Click += lblForm2SelectedArea_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 525);
            Controls.Add(lblForm2SelectedArea);
            Controls.Add(btnPrint);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblFareValue);
            Controls.Add(label4);
            Controls.Add(lblDistanceValue);
            Controls.Add(Distance);
            Controls.Add(lblToLocationValue);
            Controls.Add(label3);
            Controls.Add(lblFromLocationValue);
            Controls.Add(From);
            Controls.Add(lblTokenNoValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblTokenNoValue;
        private Label From;
        private Label lblFromLocationValue;
        private Label label3;
        private Label lblToLocationValue;
        private Label Distance;
        private Label lblDistanceValue;
        private Label label4;
        private Label lblFareValue;
        private Label label5;
        private Label label6;
        private Button btnPrint;
        private Label lblForm2SelectedArea;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}