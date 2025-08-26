namespace projectAlpha
{
    partial class Customer_Form
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnrRemoveCustomer = new System.Windows.Forms.Button();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerCnic = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerProofile = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCustomerPhoneNo = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.PanelCustomerForm = new System.Windows.Forms.Panel();
            this.PanelCustomerForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddCustomer.Location = new System.Drawing.Point(266, 446);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(110, 52);
            this.btnAddCustomer.TabIndex = 37;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(411, 446);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(116, 52);
            this.btnUpdateCustomer.TabIndex = 36;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnrRemoveCustomer
            // 
            this.btnrRemoveCustomer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrRemoveCustomer.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrRemoveCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnrRemoveCustomer.Location = new System.Drawing.Point(557, 446);
            this.btnrRemoveCustomer.Name = "btnrRemoveCustomer";
            this.btnrRemoveCustomer.Size = new System.Drawing.Size(117, 52);
            this.btnrRemoveCustomer.TabIndex = 35;
            this.btnrRemoveCustomer.Text = "Remove";
            this.btnrRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnrRemoveCustomer.Click += new System.EventHandler(this.btnrRemoveCustomer_Click);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFatherName.Location = new System.Drawing.Point(382, 180);
            this.txtFatherName.Multiline = true;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(242, 40);
            this.txtFatherName.TabIndex = 33;
            this.txtFatherName.TabStop = false;
            this.txtFatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFatherName_KeyPress);
            // 
            // txtCnic
            // 
            this.txtCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCnic.Location = new System.Drawing.Point(382, 237);
            this.txtCnic.Multiline = true;
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(242, 40);
            this.txtCnic.TabIndex = 32;
            this.txtCnic.TabStop = false;
            this.txtCnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnic_KeyPress);
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.AutoSize = true;
            this.lblCustomerAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerAddress.Location = new System.Drawing.Point(203, 295);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(99, 26);
            this.lblCustomerAddress.TabIndex = 31;
            this.lblCustomerAddress.Text = "Address";
            // 
            // lblCustomerCnic
            // 
            this.lblCustomerCnic.AutoSize = true;
            this.lblCustomerCnic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerCnic.Location = new System.Drawing.Point(203, 251);
            this.lblCustomerCnic.Name = "lblCustomerCnic";
            this.lblCustomerCnic.Size = new System.Drawing.Size(60, 26);
            this.lblCustomerCnic.TabIndex = 30;
            this.lblCustomerCnic.Text = "Cnic";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFatherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFatherName.Location = new System.Drawing.Point(203, 194);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(150, 26);
            this.lblFatherName.TabIndex = 29;
            this.lblFatherName.Text = "Father Name";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerName.Location = new System.Drawing.Point(203, 142);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(75, 26);
            this.lblCustomerName.TabIndex = 28;
            this.lblCustomerName.Text = "Name";
            // 
            // lblCustomerProofile
            // 
            this.lblCustomerProofile.AutoSize = true;
            this.lblCustomerProofile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerProofile.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerProofile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerProofile.Location = new System.Drawing.Point(278, 9);
            this.lblCustomerProofile.Name = "lblCustomerProofile";
            this.lblCustomerProofile.Size = new System.Drawing.Size(226, 48);
            this.lblCustomerProofile.TabIndex = 27;
            this.lblCustomerProofile.Text = "Customer Profile";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(382, 128);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(242, 40);
            this.txtCustomerName.TabIndex = 26;
            this.txtCustomerName.TabStop = false;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(26, 595);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(137, 52);
            this.btnLogOut.TabIndex = 25;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrder.Location = new System.Drawing.Point(11, 313);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(165, 52);
            this.btnOrder.TabIndex = 23;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProducts.Location = new System.Drawing.Point(11, 243);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(165, 52);
            this.btnProducts.TabIndex = 22;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.Location = new System.Drawing.Point(11, 170);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 52);
            this.btnHome.TabIndex = 21;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(203, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 26);
            this.label7.TabIndex = 38;
            // 
            // lblCustomerPhoneNo
            // 
            this.lblCustomerPhoneNo.AutoSize = true;
            this.lblCustomerPhoneNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerPhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerPhoneNo.Location = new System.Drawing.Point(203, 346);
            this.lblCustomerPhoneNo.Name = "lblCustomerPhoneNo";
            this.lblCustomerPhoneNo.Size = new System.Drawing.Size(117, 26);
            this.lblCustomerPhoneNo.TabIndex = 39;
            this.lblCustomerPhoneNo.Text = "Phone No";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.Location = new System.Drawing.Point(382, 295);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 40);
            this.txtAddress.TabIndex = 40;
            this.txtAddress.TabStop = false;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhoneNo.Location = new System.Drawing.Point(382, 348);
            this.txtPhoneNo.Multiline = true;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(242, 40);
            this.txtPhoneNo.TabIndex = 41;
            this.txtPhoneNo.TabStop = false;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            // 
            // PanelCustomerForm
            // 
            this.PanelCustomerForm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PanelCustomerForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCustomerForm.Controls.Add(this.btnLogOut);
            this.PanelCustomerForm.Controls.Add(this.btnHome);
            this.PanelCustomerForm.Controls.Add(this.btnProducts);
            this.PanelCustomerForm.Controls.Add(this.btnOrder);
            this.PanelCustomerForm.Location = new System.Drawing.Point(1, -2);
            this.PanelCustomerForm.Name = "PanelCustomerForm";
            this.PanelCustomerForm.Size = new System.Drawing.Size(202, 706);
            this.PanelCustomerForm.TabIndex = 42;
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1137, 696);
            this.Controls.Add(this.PanelCustomerForm);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblCustomerPhoneNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnrRemoveCustomer);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerCnic);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerProofile);
            this.Controls.Add(this.txtCustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Form";
            this.Load += new System.EventHandler(this.Customer_Form_Load);
            this.PanelCustomerForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnrRemoveCustomer;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerCnic;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerProofile;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCustomerPhoneNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Panel PanelCustomerForm;
    }
}