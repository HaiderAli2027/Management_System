namespace projectAlpha
{
    partial class Product_Form
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.lblManageProducts = new System.Windows.Forms.Label();
            this.btnProductQuantity = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblPoductLineName = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.ComBoxProductLine = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelForElectronics = new System.Windows.Forms.Panel();
            this.txtProduct_E_Warrenty = new System.Windows.Forms.TextBox();
            this.lblProduct_E_Warrenty = new System.Windows.Forms.Label();
            this.txtProduct_E_Size = new System.Windows.Forms.TextBox();
            this.lblProduct_E_Size = new System.Windows.Forms.Label();
            this.txtProduct_E_Colour = new System.Windows.Forms.TextBox();
            this.txtProduct_E_Model = new System.Windows.Forms.TextBox();
            this.lblProduct_E_Colour = new System.Windows.Forms.Label();
            this.lblProduct_E_Model = new System.Windows.Forms.Label();
            this.panelForVehicles = new System.Windows.Forms.Panel();
            this.txtProduct_V_ChasisNo = new System.Windows.Forms.TextBox();
            this.lblProduct_V_ChasisNo = new System.Windows.Forms.Label();
            this.txtProduct_V_EngineNo = new System.Windows.Forms.TextBox();
            this.lblProduct_V_EngineNo = new System.Windows.Forms.Label();
            this.panelManageProduct = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelForElectronics.SuspendLayout();
            this.panelForVehicles.SuspendLayout();
            this.panelManageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOrder.Location = new System.Drawing.Point(14, 281);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(165, 52);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(26, 621);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(137, 52);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(385, 234);
            this.txtProductQuantity.Multiline = true;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(242, 40);
            this.txtProductQuantity.TabIndex = 7;
            this.txtProductQuantity.TabStop = false;
            this.txtProductQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductQuantity_KeyPress);
            // 
            // lblManageProducts
            // 
            this.lblManageProducts.AutoSize = true;
            this.lblManageProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblManageProducts.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblManageProducts.Location = new System.Drawing.Point(562, 23);
            this.lblManageProducts.Name = "lblManageProducts";
            this.lblManageProducts.Size = new System.Drawing.Size(230, 48);
            this.lblManageProducts.TabIndex = 8;
            this.lblManageProducts.Text = "Manage Products";
            // 
            // btnProductQuantity
            // 
            this.btnProductQuantity.AutoSize = true;
            this.btnProductQuantity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProductQuantity.Location = new System.Drawing.Point(220, 243);
            this.btnProductQuantity.Name = "btnProductQuantity";
            this.btnProductQuantity.Size = new System.Drawing.Size(101, 26);
            this.btnProductQuantity.TabIndex = 9;
            this.btnProductQuantity.Text = "Quantity";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductPrice.Location = new System.Drawing.Point(212, 289);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(174, 26);
            this.lblProductPrice.TabIndex = 10;
            this.lblProductPrice.Text = "Purchase Price";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductType.Location = new System.Drawing.Point(220, 340);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(152, 26);
            this.lblProductType.TabIndex = 11;
            this.lblProductType.Text = "Product Type";
            this.lblProductType.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPoductLineName
            // 
            this.lblPoductLineName.AutoSize = true;
            this.lblPoductLineName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPoductLineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoductLineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPoductLineName.Location = new System.Drawing.Point(220, 106);
            this.lblPoductLineName.Name = "lblPoductLineName";
            this.lblPoductLineName.Size = new System.Drawing.Size(209, 26);
            this.lblPoductLineName.TabIndex = 12;
            this.lblPoductLineName.Text = "ProductLine Name";
            this.lblPoductLineName.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(385, 326);
            this.txtProductType.Multiline = true;
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(242, 40);
            this.txtProductType.TabIndex = 13;
            this.txtProductType.TabStop = false;
            this.txtProductType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductType_KeyPress);
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(385, 280);
            this.txtProductPrice.Multiline = true;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.ShortcutsEnabled = false;
            this.txtProductPrice.Size = new System.Drawing.Size(242, 40);
            this.txtProductPrice.TabIndex = 14;
            this.txtProductPrice.TabStop = false;
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            // 
            // ComBoxProductLine
            // 
            this.ComBoxProductLine.FormattingEnabled = true;
            this.ComBoxProductLine.Location = new System.Drawing.Point(498, 104);
            this.ComBoxProductLine.Name = "ComBoxProductLine";
            this.ComBoxProductLine.Size = new System.Drawing.Size(202, 28);
            this.ComBoxProductLine.TabIndex = 15;
            this.ComBoxProductLine.TabStop = false;
            this.ComBoxProductLine.SelectedIndexChanged += new System.EventHandler(this.ComBoxProductLine_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.Location = new System.Drawing.Point(373, 629);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 52);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(498, 629);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 52);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(246, 629);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 52);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelForElectronics
            // 
            this.panelForElectronics.Controls.Add(this.txtProduct_E_Warrenty);
            this.panelForElectronics.Controls.Add(this.lblProduct_E_Warrenty);
            this.panelForElectronics.Controls.Add(this.txtProduct_E_Size);
            this.panelForElectronics.Controls.Add(this.lblProduct_E_Size);
            this.panelForElectronics.Location = new System.Drawing.Point(217, 462);
            this.panelForElectronics.Name = "panelForElectronics";
            this.panelForElectronics.Size = new System.Drawing.Size(420, 114);
            this.panelForElectronics.TabIndex = 21;
            this.panelForElectronics.Visible = false;
            // 
            // txtProduct_E_Warrenty
            // 
            this.txtProduct_E_Warrenty.Location = new System.Drawing.Point(168, 49);
            this.txtProduct_E_Warrenty.Multiline = true;
            this.txtProduct_E_Warrenty.Name = "txtProduct_E_Warrenty";
            this.txtProduct_E_Warrenty.Size = new System.Drawing.Size(242, 40);
            this.txtProduct_E_Warrenty.TabIndex = 28;
            this.txtProduct_E_Warrenty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_E_Warrenty_KeyPress);
            // 
            // lblProduct_E_Warrenty
            // 
            this.lblProduct_E_Warrenty.AutoSize = true;
            this.lblProduct_E_Warrenty.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProduct_E_Warrenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct_E_Warrenty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProduct_E_Warrenty.Location = new System.Drawing.Point(9, 49);
            this.lblProduct_E_Warrenty.Name = "lblProduct_E_Warrenty";
            this.lblProduct_E_Warrenty.Size = new System.Drawing.Size(108, 26);
            this.lblProduct_E_Warrenty.TabIndex = 27;
            this.lblProduct_E_Warrenty.Text = "Warrenty";
            // 
            // txtProduct_E_Size
            // 
            this.txtProduct_E_Size.Location = new System.Drawing.Point(168, 3);
            this.txtProduct_E_Size.Multiline = true;
            this.txtProduct_E_Size.Name = "txtProduct_E_Size";
            this.txtProduct_E_Size.Size = new System.Drawing.Size(242, 40);
            this.txtProduct_E_Size.TabIndex = 22;
            this.txtProduct_E_Size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_E_Size_KeyPress);
            // 
            // lblProduct_E_Size
            // 
            this.lblProduct_E_Size.AutoSize = true;
            this.lblProduct_E_Size.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProduct_E_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct_E_Size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProduct_E_Size.Location = new System.Drawing.Point(9, 3);
            this.lblProduct_E_Size.Name = "lblProduct_E_Size";
            this.lblProduct_E_Size.Size = new System.Drawing.Size(59, 26);
            this.lblProduct_E_Size.TabIndex = 22;
            this.lblProduct_E_Size.Text = "Size";
            // 
            // txtProduct_E_Colour
            // 
            this.txtProduct_E_Colour.Location = new System.Drawing.Point(385, 416);
            this.txtProduct_E_Colour.Multiline = true;
            this.txtProduct_E_Colour.Name = "txtProduct_E_Colour";
            this.txtProduct_E_Colour.Size = new System.Drawing.Size(242, 40);
            this.txtProduct_E_Colour.TabIndex = 26;
            this.txtProduct_E_Colour.TabStop = false;
            this.txtProduct_E_Colour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_E_Colour_KeyPress);
            // 
            // txtProduct_E_Model
            // 
            this.txtProduct_E_Model.Location = new System.Drawing.Point(385, 370);
            this.txtProduct_E_Model.Multiline = true;
            this.txtProduct_E_Model.Name = "txtProduct_E_Model";
            this.txtProduct_E_Model.Size = new System.Drawing.Size(242, 40);
            this.txtProduct_E_Model.TabIndex = 25;
            this.txtProduct_E_Model.TabStop = false;
            this.txtProduct_E_Model.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_E_Model_KeyPress);
            // 
            // lblProduct_E_Colour
            // 
            this.lblProduct_E_Colour.AutoSize = true;
            this.lblProduct_E_Colour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProduct_E_Colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct_E_Colour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProduct_E_Colour.Location = new System.Drawing.Point(226, 430);
            this.lblProduct_E_Colour.Name = "lblProduct_E_Colour";
            this.lblProduct_E_Colour.Size = new System.Drawing.Size(82, 26);
            this.lblProduct_E_Colour.TabIndex = 24;
            this.lblProduct_E_Colour.Text = "Colour";
            // 
            // lblProduct_E_Model
            // 
            this.lblProduct_E_Model.AutoSize = true;
            this.lblProduct_E_Model.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProduct_E_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct_E_Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProduct_E_Model.Location = new System.Drawing.Point(226, 380);
            this.lblProduct_E_Model.Name = "lblProduct_E_Model";
            this.lblProduct_E_Model.Size = new System.Drawing.Size(76, 26);
            this.lblProduct_E_Model.TabIndex = 23;
            this.lblProduct_E_Model.Text = "Model";
            // 
            // panelForVehicles
            // 
            this.panelForVehicles.Controls.Add(this.txtProduct_V_ChasisNo);
            this.panelForVehicles.Controls.Add(this.lblProduct_V_ChasisNo);
            this.panelForVehicles.Controls.Add(this.txtProduct_V_EngineNo);
            this.panelForVehicles.Controls.Add(this.lblProduct_V_EngineNo);
            this.panelForVehicles.Location = new System.Drawing.Point(217, 465);
            this.panelForVehicles.Name = "panelForVehicles";
            this.panelForVehicles.Size = new System.Drawing.Size(420, 111);
            this.panelForVehicles.TabIndex = 29;
            this.panelForVehicles.Visible = false;
            // 
            // txtProduct_V_ChasisNo
            // 
            this.txtProduct_V_ChasisNo.Location = new System.Drawing.Point(168, 49);
            this.txtProduct_V_ChasisNo.Multiline = true;
            this.txtProduct_V_ChasisNo.Name = "txtProduct_V_ChasisNo";
            this.txtProduct_V_ChasisNo.Size = new System.Drawing.Size(242, 40);
            this.txtProduct_V_ChasisNo.TabIndex = 25;
            this.txtProduct_V_ChasisNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_V_ChasisNo_KeyPress);
            // 
            // lblProduct_V_ChasisNo
            // 
            this.lblProduct_V_ChasisNo.AutoSize = true;
            this.lblProduct_V_ChasisNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProduct_V_ChasisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct_V_ChasisNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProduct_V_ChasisNo.Location = new System.Drawing.Point(3, 61);
            this.lblProduct_V_ChasisNo.Name = "lblProduct_V_ChasisNo";
            this.lblProduct_V_ChasisNo.Size = new System.Drawing.Size(122, 26);
            this.lblProduct_V_ChasisNo.TabIndex = 23;
            this.lblProduct_V_ChasisNo.Text = "Chasis No";
            // 
            // txtProduct_V_EngineNo
            // 
            this.txtProduct_V_EngineNo.Location = new System.Drawing.Point(168, 0);
            this.txtProduct_V_EngineNo.Multiline = true;
            this.txtProduct_V_EngineNo.Name = "txtProduct_V_EngineNo";
            this.txtProduct_V_EngineNo.Size = new System.Drawing.Size(242, 40);
            this.txtProduct_V_EngineNo.TabIndex = 22;
            this.txtProduct_V_EngineNo.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            this.txtProduct_V_EngineNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_V_EngineNo_KeyPress);
            // 
            // lblProduct_V_EngineNo
            // 
            this.lblProduct_V_EngineNo.AutoSize = true;
            this.lblProduct_V_EngineNo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProduct_V_EngineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct_V_EngineNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProduct_V_EngineNo.Location = new System.Drawing.Point(3, 10);
            this.lblProduct_V_EngineNo.Name = "lblProduct_V_EngineNo";
            this.lblProduct_V_EngineNo.Size = new System.Drawing.Size(123, 26);
            this.lblProduct_V_EngineNo.TabIndex = 22;
            this.lblProduct_V_EngineNo.Text = "Engine No";
            // 
            // panelManageProduct
            // 
            this.panelManageProduct.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelManageProduct.Controls.Add(this.btnHome);
            this.panelManageProduct.Controls.Add(this.btnCustomer);
            this.panelManageProduct.Controls.Add(this.btnOrder);
            this.panelManageProduct.Controls.Add(this.btnLogOut);
            this.panelManageProduct.Location = new System.Drawing.Point(1, 8);
            this.panelManageProduct.Name = "panelManageProduct";
            this.panelManageProduct.Size = new System.Drawing.Size(210, 719);
            this.panelManageProduct.TabIndex = 24;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProductName.Location = new System.Drawing.Point(221, 197);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 26);
            this.lblProductName.TabIndex = 25;
            this.lblProductName.Text = "Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(385, 188);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(242, 40);
            this.txtProductName.TabIndex = 26;
            this.txtProductName.TabStop = false;
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(688, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(581, 578);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(862, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 52);
            this.button1.TabIndex = 31;
            this.button1.Text = "Show all data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelForVehicles);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProduct_E_Colour);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProduct_E_Colour);
            this.Controls.Add(this.txtProduct_E_Model);
            this.Controls.Add(this.panelManageProduct);
            this.Controls.Add(this.panelForElectronics);
            this.Controls.Add(this.lblProduct_E_Model);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.ComBoxProductLine);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductType);
            this.Controls.Add(this.lblPoductLineName);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.btnProductQuantity);
            this.Controls.Add(this.lblManageProducts);
            this.Controls.Add(this.txtProductQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_Form";
            this.Load += new System.EventHandler(this.Product_Form_Load);
            this.panelForElectronics.ResumeLayout(false);
            this.panelForElectronics.PerformLayout();
            this.panelForVehicles.ResumeLayout(false);
            this.panelForVehicles.PerformLayout();
            this.panelManageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label lblManageProducts;
        private System.Windows.Forms.Label btnProductQuantity;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblPoductLineName;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.ComboBox ComBoxProductLine;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelForElectronics;
        private System.Windows.Forms.Label lblProduct_E_Colour;
        private System.Windows.Forms.Label lblProduct_E_Model;
        private System.Windows.Forms.TextBox txtProduct_E_Size;
        private System.Windows.Forms.Label lblProduct_E_Size;
        private System.Windows.Forms.Panel panelForVehicles;
        private System.Windows.Forms.TextBox txtProduct_V_ChasisNo;
        private System.Windows.Forms.Label lblProduct_V_ChasisNo;
        private System.Windows.Forms.TextBox txtProduct_V_EngineNo;
        private System.Windows.Forms.Label lblProduct_V_EngineNo;
        private System.Windows.Forms.TextBox txtProduct_E_Warrenty;
        private System.Windows.Forms.Label lblProduct_E_Warrenty;
        private System.Windows.Forms.TextBox txtProduct_E_Colour;
        private System.Windows.Forms.TextBox txtProduct_E_Model;
        private System.Windows.Forms.Panel panelManageProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}