namespace projectAlpha
{
    partial class Order
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.ComBoxProductLineid = new System.Windows.Forms.ComboBox();
            this.lblProductLineId = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCustomerCnic = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerCnic = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvinvoice = new System.Windows.Forms.DataGridView();
            this.lblProducttype = new System.Windows.Forms.Label();
            this.txtProducttype = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtCustomerid = new System.Windows.Forms.TextBox();
            this.txtProductid = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 644);
            this.panel1.TabIndex = 40;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(13, 536);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(165, 52);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.Location = new System.Drawing.Point(14, 141);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 52);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomer.Location = new System.Drawing.Point(14, 209);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(165, 52);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProduct.Location = new System.Drawing.Point(14, 281);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(165, 52);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button5.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(25, 650);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 52);
            this.button5.TabIndex = 6;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCustomerSearch.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomerSearch.Location = new System.Drawing.Point(505, 92);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(110, 44);
            this.btnCustomerSearch.TabIndex = 36;
            this.btnCustomerSearch.Text = "Search";
            this.btnCustomerSearch.UseVisualStyleBackColor = false;
            this.btnCustomerSearch.Click += new System.EventHandler(this.btnCustomerSearch_Click);
            // 
            // ComBoxProductLineid
            // 
            this.ComBoxProductLineid.FormattingEnabled = true;
            this.ComBoxProductLineid.Location = new System.Drawing.Point(435, 234);
            this.ComBoxProductLineid.Name = "ComBoxProductLineid";
            this.ComBoxProductLineid.Size = new System.Drawing.Size(202, 28);
            this.ComBoxProductLineid.TabIndex = 33;
            // 
            // lblProductLineId
            // 
            this.lblProductLineId.AutoSize = true;
            this.lblProductLineId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProductLineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLineId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductLineId.Location = new System.Drawing.Point(227, 236);
            this.lblProductLineId.Name = "lblProductLineId";
            this.lblProductLineId.Size = new System.Drawing.Size(170, 26);
            this.lblProductLineId.TabIndex = 30;
            this.lblProductLineId.Text = "ProductLine ID";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerId.Location = new System.Drawing.Point(227, 320);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(142, 26);
            this.lblCustomerId.TabIndex = 29;
            this.lblCustomerId.Text = "Customer Id";
            // 
            // lblCustomerCnic
            // 
            this.lblCustomerCnic.AutoSize = true;
            this.lblCustomerCnic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCustomerCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCnic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerCnic.Location = new System.Drawing.Point(227, 53);
            this.lblCustomerCnic.Name = "lblCustomerCnic";
            this.lblCustomerCnic.Size = new System.Drawing.Size(180, 26);
            this.lblCustomerCnic.TabIndex = 28;
            this.lblCustomerCnic.Text = "Customer CNIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(218, -112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Name";
            // 
            // txtCustomerCnic
            // 
            this.txtCustomerCnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerCnic.Location = new System.Drawing.Point(430, 53);
            this.txtCustomerCnic.Multiline = true;
            this.txtCustomerCnic.Name = "txtCustomerCnic";
            this.txtCustomerCnic.Size = new System.Drawing.Size(242, 36);
            this.txtCustomerCnic.TabIndex = 29;
            this.txtCustomerCnic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerCnic_KeyPress);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckOut.Location = new System.Drawing.Point(556, 537);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(116, 51);
            this.btnCheckOut.TabIndex = 43;
            this.btnCheckOut.Text = "Show all";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(399, 537);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 51);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvinvoice
            // 
            this.dgvinvoice.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvinvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinvoice.Location = new System.Drawing.Point(678, 12);
            this.dgvinvoice.Name = "dgvinvoice";
            this.dgvinvoice.RowHeadersWidth = 62;
            this.dgvinvoice.RowTemplate.Height = 28;
            this.dgvinvoice.Size = new System.Drawing.Size(695, 619);
            this.dgvinvoice.TabIndex = 46;
            this.dgvinvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinvoice_CellContentClick);
            // 
            // lblProducttype
            // 
            this.lblProducttype.AutoSize = true;
            this.lblProducttype.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProducttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducttype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProducttype.Location = new System.Drawing.Point(227, 142);
            this.lblProducttype.Name = "lblProducttype";
            this.lblProducttype.Size = new System.Drawing.Size(152, 26);
            this.lblProducttype.TabIndex = 47;
            this.lblProducttype.Text = "Product Type";
            // 
            // txtProducttype
            // 
            this.txtProducttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProducttype.Location = new System.Drawing.Point(430, 142);
            this.txtProducttype.Multiline = true;
            this.txtProducttype.Name = "txtProducttype";
            this.txtProducttype.Size = new System.Drawing.Size(242, 36);
            this.txtProducttype.TabIndex = 48;
            this.txtProducttype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducttype_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(505, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 49;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductId.Location = new System.Drawing.Point(227, 374);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(121, 26);
            this.lblProductId.TabIndex = 50;
            this.lblProductId.Text = "Product Id";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(227, 426);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(122, 26);
            this.lblPrice.TabIndex = 51;
            this.lblPrice.Text = "Sale Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuantity.Location = new System.Drawing.Point(227, 474);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(101, 26);
            this.lblQuantity.TabIndex = 52;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtCustomerid
            // 
            this.txtCustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCustomerid.Location = new System.Drawing.Point(430, 310);
            this.txtCustomerid.Multiline = true;
            this.txtCustomerid.Name = "txtCustomerid";
            this.txtCustomerid.Size = new System.Drawing.Size(242, 36);
            this.txtCustomerid.TabIndex = 53;
            this.txtCustomerid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerid_KeyPress);
            // 
            // txtProductid
            // 
            this.txtProductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProductid.Location = new System.Drawing.Point(430, 364);
            this.txtProductid.Multiline = true;
            this.txtProductid.Name = "txtProductid";
            this.txtProductid.Size = new System.Drawing.Size(242, 36);
            this.txtProductid.TabIndex = 54;
            this.txtProductid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductid_KeyPress);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSalePrice.Location = new System.Drawing.Point(430, 416);
            this.txtSalePrice.Multiline = true;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(242, 36);
            this.txtSalePrice.TabIndex = 55;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalePrice_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(430, 464);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(242, 36);
            this.txtQuantity.TabIndex = 56;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(233, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 51);
            this.button2.TabIndex = 57;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1385, 643);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.txtProductid);
            this.Controls.Add(this.txtCustomerid);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProducttype);
            this.Controls.Add(this.lblProducttype);
            this.Controls.Add(this.dgvinvoice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.txtCustomerCnic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.ComBoxProductLineid);
            this.Controls.Add(this.lblProductLineId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.lblCustomerCnic);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.ComboBox ComBoxProductLineid;
        private System.Windows.Forms.Label lblProductLineId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCustomerCnic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtCustomerCnic;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvinvoice;
        private System.Windows.Forms.Label lblProducttype;
        private System.Windows.Forms.TextBox txtProducttype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtCustomerid;
        private System.Windows.Forms.TextBox txtProductid;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button button2;
    }
}