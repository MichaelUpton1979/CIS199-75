namespace Program1
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
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.carpetPriceLabel = new System.Windows.Forms.Label();
            this.carpetPriceTextBox = new System.Windows.Forms.TextBox();
            this.paddingLabel = new System.Windows.Forms.Label();
            this.paddingTextBox = new System.Windows.Forms.TextBox();
            this.firstRoomLabel = new System.Windows.Forms.Label();
            this.firstRoomTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.yardsLabel = new System.Windows.Forms.Label();
            this.yardsOutputLabel = new System.Windows.Forms.Label();
            this.carpetOutputLabel = new System.Windows.Forms.Label();
            this.paddingOutputLabel = new System.Windows.Forms.Label();
            this.laborOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.carpetLabel = new System.Windows.Forms.Label();
            this.paddingCostLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Enabled = false;
            this.widthLabel.Location = new System.Drawing.Point(53, 39);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(194, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Enter the max width of the room (in feet)";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(263, 32);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(69, 20);
            this.widthTextBox.TabIndex = 0;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Enabled = false;
            this.lengthLabel.Location = new System.Drawing.Point(53, 65);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(198, 13);
            this.lengthLabel.TabIndex = 0;
            this.lengthLabel.Text = "Enter the max length of the room (in feet)";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(263, 58);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(69, 20);
            this.lengthTextBox.TabIndex = 1;
            // 
            // carpetPriceLabel
            // 
            this.carpetPriceLabel.AutoSize = true;
            this.carpetPriceLabel.Enabled = false;
            this.carpetPriceLabel.Location = new System.Drawing.Point(53, 91);
            this.carpetPriceLabel.Name = "carpetPriceLabel";
            this.carpetPriceLabel.Size = new System.Drawing.Size(173, 13);
            this.carpetPriceLabel.TabIndex = 0;
            this.carpetPriceLabel.Text = "Enter the carpet price (per sq. yard)";
            // 
            // carpetPriceTextBox
            // 
            this.carpetPriceTextBox.Location = new System.Drawing.Point(263, 84);
            this.carpetPriceTextBox.Name = "carpetPriceTextBox";
            this.carpetPriceTextBox.Size = new System.Drawing.Size(69, 20);
            this.carpetPriceTextBox.TabIndex = 2;
            // 
            // paddingLabel
            // 
            this.paddingLabel.AutoSize = true;
            this.paddingLabel.Enabled = false;
            this.paddingLabel.Location = new System.Drawing.Point(53, 117);
            this.paddingLabel.Name = "paddingLabel";
            this.paddingLabel.Size = new System.Drawing.Size(183, 13);
            this.paddingLabel.TabIndex = 0;
            this.paddingLabel.Text = "Enter layers of padding to use (1 or 2)";
            // 
            // paddingTextBox
            // 
            this.paddingTextBox.Location = new System.Drawing.Point(263, 110);
            this.paddingTextBox.Name = "paddingTextBox";
            this.paddingTextBox.Size = new System.Drawing.Size(69, 20);
            this.paddingTextBox.TabIndex = 3;
            // 
            // firstRoomLabel
            // 
            this.firstRoomLabel.AutoSize = true;
            this.firstRoomLabel.Enabled = false;
            this.firstRoomLabel.Location = new System.Drawing.Point(53, 143);
            this.firstRoomLabel.Name = "firstRoomLabel";
            this.firstRoomLabel.Size = new System.Drawing.Size(191, 13);
            this.firstRoomLabel.TabIndex = 0;
            this.firstRoomLabel.Text = "Is this the first room? (1 = YES, 0 = NO)";
            // 
            // firstRoomTextBox
            // 
            this.firstRoomTextBox.Location = new System.Drawing.Point(263, 136);
            this.firstRoomTextBox.Name = "firstRoomTextBox";
            this.firstRoomTextBox.Size = new System.Drawing.Size(69, 20);
            this.firstRoomTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(244, 162);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(105, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Estimate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // yardsLabel
            // 
            this.yardsLabel.AutoSize = true;
            this.yardsLabel.Enabled = false;
            this.yardsLabel.Location = new System.Drawing.Point(53, 199);
            this.yardsLabel.Name = "yardsLabel";
            this.yardsLabel.Size = new System.Drawing.Size(93, 13);
            this.yardsLabel.TabIndex = 0;
            this.yardsLabel.Text = "Sq. yards needed:";
            // 
            // yardsOutputLabel
            // 
            this.yardsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yardsOutputLabel.Enabled = false;
            this.yardsOutputLabel.Location = new System.Drawing.Point(263, 192);
            this.yardsOutputLabel.Name = "yardsOutputLabel";
            this.yardsOutputLabel.Size = new System.Drawing.Size(69, 20);
            this.yardsOutputLabel.TabIndex = 0;
            // 
            // carpetOutputLabel
            // 
            this.carpetOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carpetOutputLabel.Enabled = false;
            this.carpetOutputLabel.Location = new System.Drawing.Point(263, 221);
            this.carpetOutputLabel.Name = "carpetOutputLabel";
            this.carpetOutputLabel.Size = new System.Drawing.Size(69, 20);
            this.carpetOutputLabel.TabIndex = 0;
            // 
            // paddingOutputLabel
            // 
            this.paddingOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paddingOutputLabel.Enabled = false;
            this.paddingOutputLabel.Location = new System.Drawing.Point(263, 250);
            this.paddingOutputLabel.Name = "paddingOutputLabel";
            this.paddingOutputLabel.Size = new System.Drawing.Size(69, 20);
            this.paddingOutputLabel.TabIndex = 0;
            // 
            // laborOutputLabel
            // 
            this.laborOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborOutputLabel.Enabled = false;
            this.laborOutputLabel.Location = new System.Drawing.Point(263, 279);
            this.laborOutputLabel.Name = "laborOutputLabel";
            this.laborOutputLabel.Size = new System.Drawing.Size(69, 20);
            this.laborOutputLabel.TabIndex = 0;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutputLabel.Enabled = false;
            this.totalOutputLabel.Location = new System.Drawing.Point(263, 309);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(69, 20);
            this.totalOutputLabel.TabIndex = 0;
            // 
            // carpetLabel
            // 
            this.carpetLabel.AutoSize = true;
            this.carpetLabel.Enabled = false;
            this.carpetLabel.Location = new System.Drawing.Point(53, 228);
            this.carpetLabel.Name = "carpetLabel";
            this.carpetLabel.Size = new System.Drawing.Size(65, 13);
            this.carpetLabel.TabIndex = 0;
            this.carpetLabel.Text = "Carpet Cost:";
            // 
            // paddingCostLabel
            // 
            this.paddingCostLabel.AutoSize = true;
            this.paddingCostLabel.Enabled = false;
            this.paddingCostLabel.Location = new System.Drawing.Point(53, 257);
            this.paddingCostLabel.Name = "paddingCostLabel";
            this.paddingCostLabel.Size = new System.Drawing.Size(70, 13);
            this.paddingCostLabel.TabIndex = 0;
            this.paddingCostLabel.Text = "Padding Cost";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Enabled = false;
            this.laborLabel.Location = new System.Drawing.Point(53, 286);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(61, 13);
            this.laborLabel.TabIndex = 0;
            this.laborLabel.Text = "Labor Cost:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Enabled = false;
            this.totalLabel.Location = new System.Drawing.Point(53, 316);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 13);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 345);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.paddingCostLabel);
            this.Controls.Add(this.carpetLabel);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.laborOutputLabel);
            this.Controls.Add(this.paddingOutputLabel);
            this.Controls.Add(this.carpetOutputLabel);
            this.Controls.Add(this.yardsOutputLabel);
            this.Controls.Add(this.yardsLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.firstRoomTextBox);
            this.Controls.Add(this.firstRoomLabel);
            this.Controls.Add(this.paddingTextBox);
            this.Controls.Add(this.paddingLabel);
            this.Controls.Add(this.carpetPriceTextBox);
            this.Controls.Add(this.carpetPriceLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthLabel);
            this.Name = "Form1";
            this.Text = "Carpet Cost Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label carpetPriceLabel;
        private System.Windows.Forms.TextBox carpetPriceTextBox;
        private System.Windows.Forms.Label paddingLabel;
        private System.Windows.Forms.TextBox paddingTextBox;
        private System.Windows.Forms.Label firstRoomLabel;
        private System.Windows.Forms.TextBox firstRoomTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label yardsLabel;
        private System.Windows.Forms.Label yardsOutputLabel;
        private System.Windows.Forms.Label carpetOutputLabel;
        private System.Windows.Forms.Label paddingOutputLabel;
        private System.Windows.Forms.Label laborOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label carpetLabel;
        private System.Windows.Forms.Label paddingCostLabel;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label totalLabel;
    }
}

