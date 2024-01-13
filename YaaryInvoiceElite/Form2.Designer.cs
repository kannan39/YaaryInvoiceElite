namespace YaaryInvoiceElite
{
    partial class LocationForm
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
            lblFormHeading = new Label();
            lblFromLocation = new Label();
            txtFromLocation = new TextBox();
            lblToLocation = new Label();
            lblDistanceTxt = new Label();
            lblDistanceValue = new Label();
            lblFareText = new Label();
            lblFareValue = new Label();
            btnGenerateToken = new Button();
            comboBoxToLocation = new ComboBox();
            SuspendLayout();
            // 
            // lblFormHeading
            // 
            lblFormHeading.AutoSize = true;
            lblFormHeading.Location = new Point(154, 31);
            lblFormHeading.Name = "lblFormHeading";
            lblFormHeading.Size = new Size(66, 15);
            lblFormHeading.TabIndex = 0;
            lblFormHeading.Text = "Print Token";
            // 
            // lblFromLocation
            // 
            lblFromLocation.AutoSize = true;
            lblFromLocation.Location = new Point(97, 87);
            lblFromLocation.Name = "lblFromLocation";
            lblFromLocation.Size = new Size(35, 15);
            lblFromLocation.TabIndex = 1;
            lblFromLocation.Text = "From";
            // 
            // txtFromLocation
            // 
            txtFromLocation.Enabled = false;
            txtFromLocation.ImeMode = ImeMode.Off;
            txtFromLocation.Location = new Point(202, 87);
            txtFromLocation.Name = "txtFromLocation";
            txtFromLocation.Size = new Size(149, 23);
            txtFromLocation.TabIndex = 2;
            txtFromLocation.Text = "Kilambakkam";
            txtFromLocation.TextChanged += txtFromLocation_TextChanged;
            // 
            // lblToLocation
            // 
            lblToLocation.AllowDrop = true;
            lblToLocation.AutoSize = true;
            lblToLocation.Location = new Point(97, 142);
            lblToLocation.Name = "lblToLocation";
            lblToLocation.Size = new Size(19, 15);
            lblToLocation.TabIndex = 3;
            lblToLocation.Text = "To";
            lblToLocation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDistanceTxt
            // 
            lblDistanceTxt.AutoSize = true;
            lblDistanceTxt.Location = new Point(102, 211);
            lblDistanceTxt.Name = "lblDistanceTxt";
            lblDistanceTxt.Size = new Size(52, 15);
            lblDistanceTxt.TabIndex = 5;
            lblDistanceTxt.Text = "Distance";
            lblDistanceTxt.Click += label1_Click;
            // 
            // lblDistanceValue
            // 
            lblDistanceValue.AutoSize = true;
            lblDistanceValue.Location = new Point(202, 211);
            lblDistanceValue.Name = "lblDistanceValue";
            lblDistanceValue.Size = new Size(0, 15);
            lblDistanceValue.TabIndex = 6;
            lblDistanceValue.TextAlign = ContentAlignment.TopRight;
            // 
            // lblFareText
            // 
            lblFareText.AutoSize = true;
            lblFareText.Location = new Point(104, 259);
            lblFareText.Name = "lblFareText";
            lblFareText.Size = new Size(29, 15);
            lblFareText.TabIndex = 7;
            lblFareText.Text = "Fare";
            lblFareText.Click += label1_Click_1;
            // 
            // lblFareValue
            // 
            lblFareValue.AutoSize = true;
            lblFareValue.Location = new Point(202, 259);
            lblFareValue.Name = "lblFareValue";
            lblFareValue.Size = new Size(0, 15);
            lblFareValue.TabIndex = 8;
            // 
            // btnGenerateToken
            // 
            btnGenerateToken.Location = new Point(104, 310);
            btnGenerateToken.Name = "btnGenerateToken";
            btnGenerateToken.Size = new Size(105, 23);
            btnGenerateToken.TabIndex = 9;
            btnGenerateToken.Text = "Generate Token";
            btnGenerateToken.UseVisualStyleBackColor = true;
            btnGenerateToken.Click += btnGenerateToken_Click;
            // 
            // comboBoxToLocation
            // 
            comboBoxToLocation.AutoCompleteCustomSource.AddRange(new string[] { "Pammal", "Ramapuram ", "Guindy" });
            comboBoxToLocation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxToLocation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxToLocation.FormattingEnabled = true;
            comboBoxToLocation.Items.AddRange(new object[] { "Pammal", "Ramapuram ", "Guindy" });
            comboBoxToLocation.Location = new Point(202, 135);
            comboBoxToLocation.Name = "comboBoxToLocation";
            comboBoxToLocation.Size = new Size(149, 23);
            comboBoxToLocation.TabIndex = 10;
            // 
            // LocationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxToLocation);
            Controls.Add(btnGenerateToken);
            Controls.Add(lblFareValue);
            Controls.Add(lblFareText);
            Controls.Add(lblDistanceValue);
            Controls.Add(lblDistanceTxt);
            Controls.Add(lblToLocation);
            Controls.Add(txtFromLocation);
            Controls.Add(lblFromLocation);
            Controls.Add(lblFormHeading);
            Name = "LocationForm";
            Text = "LocationForm";
            Load += LocationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormHeading;
        private Label lblFromLocation;
        private TextBox txtFromLocation;
        private Label lblToLocation;
        private Label lblDistanceTxt;
        private Label lblDistanceValue;
        private Label lblFareText;
        private Label lblFareValue;
        private Button btnGenerateToken;
        private ComboBox comboBoxToLocation;
    }
}