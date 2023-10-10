namespace Commercial_company_project.Screens.Transfer
{
    partial class TransferForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOhamedDataSet20 = new Commercial_company_project.MOhamedDataSet20();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ToStorecomboBox = new System.Windows.Forms.ComboBox();
            this.storesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mOhamedDataSet21 = new Commercial_company_project.MOhamedDataSet21();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.QuantityTextBox = new Guna.UI.WinForms.GunaLineTextBox();
            this.transferDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.SPermissionSAlahiaDateTimePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.SPermissionSuppliercomboBox = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOhamedDataSet22 = new Commercial_company_project.MOhamedDataSet22();
            this.SPermissionProductionTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.storecomboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOhamedDataSet23 = new Commercial_company_project.MOhamedDataSet23();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.transferutton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.storesTableAdapter = new Commercial_company_project.MOhamedDataSet20TableAdapters.StoresTableAdapter();
            this.storesTableAdapter1 = new Commercial_company_project.MOhamedDataSet21TableAdapters.StoresTableAdapter();
            this.suppliersTableAdapter = new Commercial_company_project.MOhamedDataSet22TableAdapters.SuppliersTableAdapter();
            this.itemsTableAdapter = new Commercial_company_project.MOhamedDataSet23TableAdapters.ItemsTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStorecomboBox = new System.Windows.Forms.ComboBox();
            this.mOhamedDataSet24 = new Commercial_company_project.MOhamedDataSet24();
            this.storesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.storesTableAdapter2 = new Commercial_company_project.MOhamedDataSet24TableAdapters.StoresTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet20)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FromStorecomboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(738, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(588, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "من";
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this.mOhamedDataSet20;
            // 
            // mOhamedDataSet20
            // 
            this.mOhamedDataSet20.DataSetName = "MOhamedDataSet20";
            this.mOhamedDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Bernard MT Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.Location = new System.Drawing.Point(505, 36);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(395, 44);
            this.gunaLabel11.TabIndex = 68;
            this.gunaLabel11.Text = "تحويل الأصناف بين المخازن";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ToStorecomboBox);
            this.groupBox2.Controls.Add(this.gunaLabel3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(588, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "إلى";
            // 
            // ToStorecomboBox
            // 
            this.ToStorecomboBox.DataSource = this.storesBindingSource1;
            this.ToStorecomboBox.DisplayMember = "StoreName";
            this.ToStorecomboBox.FormattingEnabled = true;
            this.ToStorecomboBox.Location = new System.Drawing.Point(33, 37);
            this.ToStorecomboBox.Name = "ToStorecomboBox";
            this.ToStorecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToStorecomboBox.Size = new System.Drawing.Size(297, 28);
            this.ToStorecomboBox.TabIndex = 80;
            this.ToStorecomboBox.ValueMember = "StoreID";
            // 
            // storesBindingSource1
            // 
            this.storesBindingSource1.DataMember = "Stores";
            this.storesBindingSource1.DataSource = this.mOhamedDataSet21;
            // 
            // mOhamedDataSet21
            // 
            this.mOhamedDataSet21.DataSetName = "MOhamedDataSet21";
            this.mOhamedDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(398, 38);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(88, 28);
            this.gunaLabel3.TabIndex = 75;
            this.gunaLabel3.Text = "إلى مخزن";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.BackColor = System.Drawing.Color.White;
            this.QuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTextBox.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.QuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.QuantityTextBox.LineColor = System.Drawing.Color.Gainsboro;
            this.QuantityTextBox.Location = new System.Drawing.Point(863, 273);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.PasswordChar = '\0';
            this.QuantityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QuantityTextBox.SelectedText = "";
            this.QuantityTextBox.Size = new System.Drawing.Size(318, 30);
            this.QuantityTextBox.TabIndex = 84;
            // 
            // transferDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.transferDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.transferDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transferDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.transferDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transferDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.transferDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transferDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.transferDataGridView.ColumnHeadersHeight = 32;
            this.transferDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transferDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.transferDataGridView.EnableHeadersVisualStyles = false;
            this.transferDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.transferDataGridView.Location = new System.Drawing.Point(17, 476);
            this.transferDataGridView.Name = "transferDataGridView";
            this.transferDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transferDataGridView.RowHeadersVisible = false;
            this.transferDataGridView.RowHeadersWidth = 51;
            this.transferDataGridView.RowTemplate.Height = 24;
            this.transferDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transferDataGridView.Size = new System.Drawing.Size(1309, 347);
            this.transferDataGridView.TabIndex = 83;
            this.transferDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.transferDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.transferDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.transferDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.transferDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.transferDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.transferDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.transferDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.transferDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.transferDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.transferDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.transferDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.transferDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.transferDataGridView.ThemeStyle.HeaderStyle.Height = 32;
            this.transferDataGridView.ThemeStyle.ReadOnly = false;
            this.transferDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.transferDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.transferDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.transferDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.transferDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.transferDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.transferDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(1257, 224);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(67, 28);
            this.gunaLabel9.TabIndex = 82;
            this.gunaLabel9.Text = "الصنف";
            this.gunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(1269, 275);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(57, 28);
            this.gunaLabel10.TabIndex = 81;
            this.gunaLabel10.Text = "الكمية";
            this.gunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SPermissionSAlahiaDateTimePicker
            // 
            this.SPermissionSAlahiaDateTimePicker.BaseColor = System.Drawing.Color.White;
            this.SPermissionSAlahiaDateTimePicker.BorderColor = System.Drawing.Color.Silver;
            this.SPermissionSAlahiaDateTimePicker.CustomFormat = null;
            this.SPermissionSAlahiaDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.SPermissionSAlahiaDateTimePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SPermissionSAlahiaDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SPermissionSAlahiaDateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.SPermissionSAlahiaDateTimePicker.Location = new System.Drawing.Point(66, 332);
            this.SPermissionSAlahiaDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.SPermissionSAlahiaDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.SPermissionSAlahiaDateTimePicker.Name = "SPermissionSAlahiaDateTimePicker";
            this.SPermissionSAlahiaDateTimePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.SPermissionSAlahiaDateTimePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SPermissionSAlahiaDateTimePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SPermissionSAlahiaDateTimePicker.OnPressedColor = System.Drawing.Color.Black;
            this.SPermissionSAlahiaDateTimePicker.Size = new System.Drawing.Size(297, 30);
            this.SPermissionSAlahiaDateTimePicker.TabIndex = 79;
            this.SPermissionSAlahiaDateTimePicker.Text = "Wednesday, October 4, 2023";
            this.SPermissionSAlahiaDateTimePicker.Value = new System.DateTime(2023, 10, 4, 1, 24, 10, 11);
            // 
            // SPermissionSuppliercomboBox
            // 
            this.SPermissionSuppliercomboBox.DataSource = this.suppliersBindingSource;
            this.SPermissionSuppliercomboBox.DisplayMember = "SupplierName";
            this.SPermissionSuppliercomboBox.FormattingEnabled = true;
            this.SPermissionSuppliercomboBox.Location = new System.Drawing.Point(66, 221);
            this.SPermissionSuppliercomboBox.Name = "SPermissionSuppliercomboBox";
            this.SPermissionSuppliercomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SPermissionSuppliercomboBox.Size = new System.Drawing.Size(297, 24);
            this.SPermissionSuppliercomboBox.TabIndex = 78;
            this.SPermissionSuppliercomboBox.ValueMember = "SupplierID";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.mOhamedDataSet22;
            // 
            // mOhamedDataSet22
            // 
            this.mOhamedDataSet22.DataSetName = "MOhamedDataSet22";
            this.mOhamedDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SPermissionProductionTimePicker1
            // 
            this.SPermissionProductionTimePicker1.BaseColor = System.Drawing.Color.White;
            this.SPermissionProductionTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.SPermissionProductionTimePicker1.CustomFormat = null;
            this.SPermissionProductionTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.SPermissionProductionTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SPermissionProductionTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SPermissionProductionTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.SPermissionProductionTimePicker1.Location = new System.Drawing.Point(863, 334);
            this.SPermissionProductionTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.SPermissionProductionTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.SPermissionProductionTimePicker1.Name = "SPermissionProductionTimePicker1";
            this.SPermissionProductionTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.SPermissionProductionTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SPermissionProductionTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SPermissionProductionTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.SPermissionProductionTimePicker1.Size = new System.Drawing.Size(318, 30);
            this.SPermissionProductionTimePicker1.TabIndex = 77;
            this.SPermissionProductionTimePicker1.Text = "Wednesday, October 4, 2023";
            this.SPermissionProductionTimePicker1.Value = new System.DateTime(2023, 10, 4, 1, 24, 10, 11);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(464, 220);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(50, 28);
            this.gunaLabel2.TabIndex = 76;
            this.gunaLabel2.Text = "مورد";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storecomboBox
            // 
            this.storecomboBox.DataSource = this.itemsBindingSource;
            this.storecomboBox.DisplayMember = "ItemName";
            this.storecomboBox.FormattingEnabled = true;
            this.storecomboBox.Location = new System.Drawing.Point(863, 224);
            this.storecomboBox.Name = "storecomboBox";
            this.storecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.storecomboBox.Size = new System.Drawing.Size(318, 24);
            this.storecomboBox.TabIndex = 74;
            this.storecomboBox.ValueMember = "ItemID";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.mOhamedDataSet23;
            // 
            // mOhamedDataSet23
            // 
            this.mOhamedDataSet23.DataSetName = "MOhamedDataSet23";
            this.mOhamedDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(392, 336);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(132, 28);
            this.gunaLabel1.TabIndex = 73;
            this.gunaLabel1.Text = "تاريخ الصلاحية";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(1221, 334);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(108, 28);
            this.gunaLabel6.TabIndex = 70;
            this.gunaLabel6.Text = "تاريخ الإنتاج";
            // 
            // transferutton
            // 
            this.transferutton.AnimationHoverSpeed = 0.07F;
            this.transferutton.AnimationSpeed = 0.03F;
            this.transferutton.BaseColor = System.Drawing.Color.Green;
            this.transferutton.BorderColor = System.Drawing.Color.Black;
            this.transferutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.transferutton.FocusedColor = System.Drawing.Color.Empty;
            this.transferutton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferutton.ForeColor = System.Drawing.Color.White;
            this.transferutton.Image = null;
            this.transferutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.transferutton.ImageSize = new System.Drawing.Size(20, 20);
            this.transferutton.Location = new System.Drawing.Point(538, 402);
            this.transferutton.Name = "transferutton";
            this.transferutton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.transferutton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.transferutton.OnHoverForeColor = System.Drawing.Color.White;
            this.transferutton.OnHoverImage = null;
            this.transferutton.OnPressedColor = System.Drawing.Color.Black;
            this.transferutton.Size = new System.Drawing.Size(348, 53);
            this.transferutton.TabIndex = 69;
            this.transferutton.Text = "تحويل";
            this.transferutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.transferutton.Click += new System.EventHandler(this.transferutton_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(1240, 149);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(84, 28);
            this.gunaLabel4.TabIndex = 85;
            this.gunaLabel4.Text = "من مخزن";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // storesTableAdapter1
            // 
            this.storesTableAdapter1.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الصنف";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "من مخزن";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "إلى مخزن";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "تاريخ التحويل";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الكمية";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "إنتاج";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "صلاحية";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // FromStorecomboBox
            // 
            this.FromStorecomboBox.DataSource = this.storesBindingSource2;
            this.FromStorecomboBox.DisplayMember = "StoreName";
            this.FromStorecomboBox.FormattingEnabled = true;
            this.FromStorecomboBox.Location = new System.Drawing.Point(125, 34);
            this.FromStorecomboBox.Name = "FromStorecomboBox";
            this.FromStorecomboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromStorecomboBox.Size = new System.Drawing.Size(318, 28);
            this.FromStorecomboBox.TabIndex = 81;
            this.FromStorecomboBox.ValueMember = "StoreID";
            // 
            // mOhamedDataSet24
            // 
            this.mOhamedDataSet24.DataSetName = "MOhamedDataSet24";
            this.mOhamedDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storesBindingSource2
            // 
            this.storesBindingSource2.DataMember = "Stores";
            this.storesBindingSource2.DataSource = this.mOhamedDataSet24;
            // 
            // storesTableAdapter2
            // 
            this.storesTableAdapter2.ClearBeforeFill = true;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 846);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.transferDataGridView);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.SPermissionSAlahiaDateTimePicker);
            this.Controls.Add(this.SPermissionSuppliercomboBox);
            this.Controls.Add(this.SPermissionProductionTimePicker1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.storecomboBox);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.transferutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet20)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ToStorecomboBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox QuantityTextBox;
        private Guna.UI.WinForms.GunaDataGridView transferDataGridView;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaDateTimePicker SPermissionSAlahiaDateTimePicker;
        private System.Windows.Forms.ComboBox SPermissionSuppliercomboBox;
        private Guna.UI.WinForms.GunaDateTimePicker SPermissionProductionTimePicker1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ComboBox storecomboBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaButton transferutton;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private MOhamedDataSet20 mOhamedDataSet20;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private MOhamedDataSet20TableAdapters.StoresTableAdapter storesTableAdapter;
        private MOhamedDataSet21 mOhamedDataSet21;
        private System.Windows.Forms.BindingSource storesBindingSource1;
        private MOhamedDataSet21TableAdapters.StoresTableAdapter storesTableAdapter1;
        private MOhamedDataSet22 mOhamedDataSet22;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private MOhamedDataSet22TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private MOhamedDataSet23 mOhamedDataSet23;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private MOhamedDataSet23TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox FromStorecomboBox;
        private MOhamedDataSet24 mOhamedDataSet24;
        private System.Windows.Forms.BindingSource storesBindingSource2;
        private MOhamedDataSet24TableAdapters.StoresTableAdapter storesTableAdapter2;
    }
}