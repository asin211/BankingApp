namespace BankingApp
{
    partial class CustomerForm
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
            this.panelWindowContainer = new System.Windows.Forms.Panel();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.showCustomersInfoListBox = new System.Windows.Forms.ListBox();
            this.staffLabel = new System.Windows.Forms.Label();
            this.customerDetailsDisplayLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.comboBoxIsStaff = new System.Windows.Forms.ComboBox();
            this.welcomeAdminLabel = new System.Windows.Forms.Label();
            this.panelWindowContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWindowContainer
            // 
            this.panelWindowContainer.BackColor = System.Drawing.Color.Moccasin;
            this.panelWindowContainer.Controls.Add(this.customerPhoneTextBox);
            this.panelWindowContainer.Controls.Add(this.phoneLabel);
            this.panelWindowContainer.Controls.Add(this.deleteCustomerButton);
            this.panelWindowContainer.Controls.Add(this.updateCustomerButton);
            this.panelWindowContainer.Controls.Add(this.addCustomerButton);
            this.panelWindowContainer.Controls.Add(this.exitButton);
            this.panelWindowContainer.Controls.Add(this.logoLabel);
            this.panelWindowContainer.Controls.Add(this.showCustomersInfoListBox);
            this.panelWindowContainer.Controls.Add(this.staffLabel);
            this.panelWindowContainer.Controls.Add(this.customerDetailsDisplayLabel);
            this.panelWindowContainer.Controls.Add(this.customerNameTextBox);
            this.panelWindowContainer.Controls.Add(this.customerNameLabel);
            this.panelWindowContainer.Controls.Add(this.comboBoxIsStaff);
            this.panelWindowContainer.Controls.Add(this.welcomeAdminLabel);
            this.panelWindowContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWindowContainer.Location = new System.Drawing.Point(2, 2);
            this.panelWindowContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelWindowContainer.Name = "panelWindowContainer";
            this.panelWindowContainer.Size = new System.Drawing.Size(1129, 773);
            this.panelWindowContainer.TabIndex = 1;
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneTextBox.Location = new System.Drawing.Point(194, 341);
            this.customerPhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(237, 29);
            this.customerPhoneTextBox.TabIndex = 18;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(65, 344);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(66, 24);
            this.phoneLabel.TabIndex = 17;
            this.phoneLabel.Text = "Phone";
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerButton.Location = new System.Drawing.Point(388, 616);
            this.deleteCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(143, 45);
            this.deleteCustomerButton.TabIndex = 16;
            this.deleteCustomerButton.Text = "Delete";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomerButton.Location = new System.Drawing.Point(219, 616);
            this.updateCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(143, 45);
            this.updateCustomerButton.TabIndex = 15;
            this.updateCustomerButton.Text = "Update";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.Location = new System.Drawing.Point(48, 616);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(143, 45);
            this.addCustomerButton.TabIndex = 14;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1022, 70);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(73, 33);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.logoLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.logoLabel.Location = new System.Drawing.Point(57, 63);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(189, 46);
            this.logoLabel.TabIndex = 11;
            this.logoLabel.Text = "Citi Bank";
            // 
            // showCustomersInfoListBox
            // 
            this.showCustomersInfoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCustomersInfoListBox.FormattingEnabled = true;
            this.showCustomersInfoListBox.HorizontalScrollbar = true;
            this.showCustomersInfoListBox.ItemHeight = 20;
            this.showCustomersInfoListBox.Location = new System.Drawing.Point(507, 231);
            this.showCustomersInfoListBox.Margin = new System.Windows.Forms.Padding(2);
            this.showCustomersInfoListBox.Name = "showCustomersInfoListBox";
            this.showCustomersInfoListBox.ScrollAlwaysVisible = true;
            this.showCustomersInfoListBox.Size = new System.Drawing.Size(584, 364);
            this.showCustomersInfoListBox.TabIndex = 10;
            this.showCustomersInfoListBox.SelectedIndexChanged += new System.EventHandler(this.showCustomersInfoListBox_SelectedIndexChanged);
            // 
            // staffLabel
            // 
            this.staffLabel.AutoSize = true;
            this.staffLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLabel.Location = new System.Drawing.Point(68, 421);
            this.staffLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.staffLabel.Name = "staffLabel";
            this.staffLabel.Size = new System.Drawing.Size(47, 22);
            this.staffLabel.TabIndex = 9;
            this.staffLabel.Text = "Staff";
            // 
            // customerDetailsDisplayLabel
            // 
            this.customerDetailsDisplayLabel.AutoSize = true;
            this.customerDetailsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDetailsDisplayLabel.Location = new System.Drawing.Point(43, 188);
            this.customerDetailsDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerDetailsDisplayLabel.Name = "customerDetailsDisplayLabel";
            this.customerDetailsDisplayLabel.Size = new System.Drawing.Size(213, 29);
            this.customerDetailsDisplayLabel.TabIndex = 7;
            this.customerDetailsDisplayLabel.Text = "Customer Details";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(193, 270);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(237, 29);
            this.customerNameTextBox.TabIndex = 3;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(62, 271);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(61, 24);
            this.customerNameLabel.TabIndex = 2;
            this.customerNameLabel.Text = "Name";
            // 
            // comboBoxIsStaff
            // 
            this.comboBoxIsStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIsStaff.FormattingEnabled = true;
            this.comboBoxIsStaff.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBoxIsStaff.Location = new System.Drawing.Point(194, 416);
            this.comboBoxIsStaff.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxIsStaff.Name = "comboBoxIsStaff";
            this.comboBoxIsStaff.Size = new System.Drawing.Size(233, 32);
            this.comboBoxIsStaff.TabIndex = 1;
            // 
            // welcomeAdminLabel
            // 
            this.welcomeAdminLabel.AutoSize = true;
            this.welcomeAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeAdminLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.welcomeAdminLabel.Location = new System.Drawing.Point(654, 70);
            this.welcomeAdminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeAdminLabel.Name = "welcomeAdminLabel";
            this.welcomeAdminLabel.Size = new System.Drawing.Size(241, 33);
            this.welcomeAdminLabel.TabIndex = 0;
            this.welcomeAdminLabel.Text = "Welcome Admin";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 776);
            this.Controls.Add(this.panelWindowContainer);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panelWindowContainer.ResumeLayout(false);
            this.panelWindowContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWindowContainer;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.ListBox showCustomersInfoListBox;
        private System.Windows.Forms.Label staffLabel;
        private System.Windows.Forms.Label customerDetailsDisplayLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.ComboBox comboBoxIsStaff;
        private System.Windows.Forms.Label welcomeAdminLabel;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
    }
}