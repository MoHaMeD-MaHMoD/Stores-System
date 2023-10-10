namespace Commercial_company_project.Screens.Stores
{
    partial class StoresForm
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
            this.storecomboBox = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOhamedDataSet7 = new Commercial_company_project.MOhamedDataSet7();
            this.responsiblePersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.searchBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.storeDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeButtonDelete = new Guna.UI.WinForms.GunaButton();
            this.storeEditButton = new Guna.UI.WinForms.GunaButton();
            this.storeAddressTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.storeSaveButton = new Guna.UI.WinForms.GunaButton();
            this.storeNameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.mOhamedDataSet6 = new Commercial_company_project.MOhamedDataSet6();
            this.responsiblePersonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.responsiblePersonTableAdapter = new Commercial_company_project.MOhamedDataSet6TableAdapters.ResponsiblePersonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsiblePersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsiblePersonBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // storecomboBox
            // 
            this.storecomboBox.DataSource = this.suppliersBindingSource;
            this.storecomboBox.DisplayMember = "SupplierName";
            this.storecomboBox.FormattingEnabled = true;
            this.storecomboBox.Location = new System.Drawing.Point(933, 186);
            this.storecomboBox.Name = "storecomboBox";
            this.storecomboBox.Size = new System.Drawing.Size(202, 24);
            this.storecomboBox.TabIndex = 0;
            this.storecomboBox.ValueMember = "SupplierID";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.mOhamedDataSet7;
            // 
            // mOhamedDataSet7
            // 
            this.mOhamedDataSet7.DataSetName = "MOhamedDataSet7";
            this.mOhamedDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responsiblePersonBindingSource
            // 
            this.responsiblePersonBindingSource.DataMember = "ResponsiblePerson";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.ForestGreen;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::Commercial_company_project.Properties.Resources.refresh;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(61, 116);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(48, 32);
            this.gunaButton1.TabIndex = 47;
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AnimationHoverSpeed = 0.07F;
            this.searchBtn.AnimationSpeed = 0.03F;
            this.searchBtn.BaseColor = System.Drawing.Color.Green;
            this.searchBtn.BorderColor = System.Drawing.Color.Black;
            this.searchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtn.FocusedColor = System.Drawing.Color.Empty;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = null;
            this.searchBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.searchBtn.Location = new System.Drawing.Point(149, 115);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBtn.OnHoverImage = null;
            this.searchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.searchBtn.Size = new System.Drawing.Size(93, 34);
            this.searchBtn.TabIndex = 46;
            this.searchBtn.Text = "بحث";
            this.searchBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(280, 120);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(178, 32);
            this.gunaTextBox1.TabIndex = 45;
            this.gunaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // storeDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.storeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.storeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.storeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.storeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.storeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.storeDataGridView.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.storeDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.storeDataGridView.EnableHeadersVisualStyles = false;
            this.storeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.storeDataGridView.Location = new System.Drawing.Point(23, 165);
            this.storeDataGridView.Name = "storeDataGridView";
            this.storeDataGridView.RowHeadersVisible = false;
            this.storeDataGridView.RowHeadersWidth = 51;
            this.storeDataGridView.RowTemplate.Height = 24;
            this.storeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storeDataGridView.Size = new System.Drawing.Size(856, 340);
            this.storeDataGridView.TabIndex = 41;
            this.storeDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.storeDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.storeDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.storeDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.storeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.storeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.storeDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.storeDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.storeDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.storeDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.storeDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.storeDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.storeDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.storeDataGridView.ThemeStyle.HeaderStyle.Height = 32;
            this.storeDataGridView.ThemeStyle.ReadOnly = false;
            this.storeDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.storeDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.storeDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.storeDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.storeDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.storeDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.storeDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.storeDataGridView.SelectionChanged += new System.EventHandler(this.storeDataGridView_SelectionChanged);
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            // 
            // storeButtonDelete
            // 
            this.storeButtonDelete.AnimationHoverSpeed = 0.07F;
            this.storeButtonDelete.AnimationSpeed = 0.03F;
            this.storeButtonDelete.BaseColor = System.Drawing.Color.Brown;
            this.storeButtonDelete.BorderColor = System.Drawing.Color.Black;
            this.storeButtonDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.storeButtonDelete.FocusedColor = System.Drawing.Color.Empty;
            this.storeButtonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeButtonDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.storeButtonDelete.Image = null;
            this.storeButtonDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.storeButtonDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.storeButtonDelete.Location = new System.Drawing.Point(933, 463);
            this.storeButtonDelete.Name = "storeButtonDelete";
            this.storeButtonDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.storeButtonDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.storeButtonDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.storeButtonDelete.OnHoverImage = null;
            this.storeButtonDelete.OnPressedColor = System.Drawing.Color.Black;
            this.storeButtonDelete.Size = new System.Drawing.Size(95, 42);
            this.storeButtonDelete.TabIndex = 40;
            this.storeButtonDelete.Text = "حذف";
            this.storeButtonDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.storeButtonDelete.Click += new System.EventHandler(this.storeButtonDelete_Click);
            // 
            // storeEditButton
            // 
            this.storeEditButton.AnimationHoverSpeed = 0.07F;
            this.storeEditButton.AnimationSpeed = 0.03F;
            this.storeEditButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.storeEditButton.BorderColor = System.Drawing.Color.Black;
            this.storeEditButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.storeEditButton.FocusedColor = System.Drawing.Color.Empty;
            this.storeEditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeEditButton.ForeColor = System.Drawing.Color.White;
            this.storeEditButton.Image = null;
            this.storeEditButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.storeEditButton.ImageSize = new System.Drawing.Size(20, 20);
            this.storeEditButton.Location = new System.Drawing.Point(1074, 463);
            this.storeEditButton.Name = "storeEditButton";
            this.storeEditButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.storeEditButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.storeEditButton.OnHoverForeColor = System.Drawing.Color.White;
            this.storeEditButton.OnHoverImage = null;
            this.storeEditButton.OnPressedColor = System.Drawing.Color.Black;
            this.storeEditButton.Size = new System.Drawing.Size(95, 42);
            this.storeEditButton.TabIndex = 39;
            this.storeEditButton.Text = "تعديل";
            this.storeEditButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.storeEditButton.Click += new System.EventHandler(this.storeEditButton_Click);
            // 
            // storeAddressTextBox
            // 
            this.storeAddressTextBox.BaseColor = System.Drawing.Color.White;
            this.storeAddressTextBox.BorderColor = System.Drawing.Color.Silver;
            this.storeAddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.storeAddressTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.storeAddressTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.storeAddressTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.storeAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.storeAddressTextBox.Location = new System.Drawing.Point(933, 301);
            this.storeAddressTextBox.Name = "storeAddressTextBox";
            this.storeAddressTextBox.PasswordChar = '\0';
            this.storeAddressTextBox.SelectedText = "";
            this.storeAddressTextBox.Size = new System.Drawing.Size(202, 32);
            this.storeAddressTextBox.TabIndex = 38;
            this.storeAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(1191, 305);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(121, 28);
            this.gunaLabel7.TabIndex = 37;
            this.gunaLabel7.Text = "عنوان المخزن";
            // 
            // storeSaveButton
            // 
            this.storeSaveButton.AnimationHoverSpeed = 0.07F;
            this.storeSaveButton.AnimationSpeed = 0.03F;
            this.storeSaveButton.BaseColor = System.Drawing.Color.Green;
            this.storeSaveButton.BorderColor = System.Drawing.Color.Black;
            this.storeSaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.storeSaveButton.FocusedColor = System.Drawing.Color.Empty;
            this.storeSaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeSaveButton.ForeColor = System.Drawing.Color.White;
            this.storeSaveButton.Image = null;
            this.storeSaveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.storeSaveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.storeSaveButton.Location = new System.Drawing.Point(1209, 463);
            this.storeSaveButton.Name = "storeSaveButton";
            this.storeSaveButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.storeSaveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.storeSaveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.storeSaveButton.OnHoverImage = null;
            this.storeSaveButton.OnPressedColor = System.Drawing.Color.Black;
            this.storeSaveButton.Size = new System.Drawing.Size(95, 42);
            this.storeSaveButton.TabIndex = 36;
            this.storeSaveButton.Text = "إضافة";
            this.storeSaveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.storeSaveButton.Click += new System.EventHandler(this.storeSaveButton_Click);
            // 
            // storeNameTextBox
            // 
            this.storeNameTextBox.BaseColor = System.Drawing.Color.White;
            this.storeNameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.storeNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.storeNameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.storeNameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.storeNameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.storeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.storeNameTextBox.Location = new System.Drawing.Point(933, 244);
            this.storeNameTextBox.Name = "storeNameTextBox";
            this.storeNameTextBox.PasswordChar = '\0';
            this.storeNameTextBox.SelectedText = "";
            this.storeNameTextBox.Size = new System.Drawing.Size(202, 32);
            this.storeNameTextBox.TabIndex = 35;
            this.storeNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(1204, 248);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(103, 28);
            this.gunaLabel2.TabIndex = 34;
            this.gunaLabel2.Text = "إسم المخزن";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Bernard MT Condensed", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(524, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(203, 44);
            this.gunaLabel1.TabIndex = 33;
            this.gunaLabel1.Text = "إدارة المخازن";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(1174, 186);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(130, 28);
            this.gunaLabel3.TabIndex = 48;
            this.gunaLabel3.Text = "مسؤول المخزن";
            this.gunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(500, 121);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(103, 28);
            this.gunaLabel4.TabIndex = 49;
            this.gunaLabel4.Text = "إسم المخزن";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mOhamedDataSet6
            // 
            this.mOhamedDataSet6.DataSetName = "MOhamedDataSet6";
            this.mOhamedDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // responsiblePersonBindingSource1
            // 
            this.responsiblePersonBindingSource1.DataMember = "ResponsiblePerson";
            this.responsiblePersonBindingSource1.DataSource = this.mOhamedDataSet6;
            // 
            // responsiblePersonTableAdapter
            // 
            this.responsiblePersonTableAdapter.ClearBeforeFill = true;
            // 
            // StoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 528);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.storeDataGridView);
            this.Controls.Add(this.storeButtonDelete);
            this.Controls.Add(this.storeEditButton);
            this.Controls.Add(this.storeAddressTextBox);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.storeSaveButton);
            this.Controls.Add(this.storeNameTextBox);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.storecomboBox);
            this.Name = "StoresForm";
            this.Text = "StoresForm";
            this.Load += new System.EventHandler(this.StoresForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsiblePersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOhamedDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsiblePersonBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox storecomboBox;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton searchBtn;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaDataGridView storeDataGridView;
        private Guna.UI.WinForms.GunaButton storeButtonDelete;
        private Guna.UI.WinForms.GunaButton storeEditButton;
        private Guna.UI.WinForms.GunaTextBox storeAddressTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaButton storeSaveButton;
        private Guna.UI.WinForms.GunaTextBox storeNameTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.BindingSource responsiblePersonBindingSource;

        private System.Windows.Forms.BindingSource storesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleDataGridViewTextBoxColumn;
        private MOhamedDataSet6 mOhamedDataSet6;
        private System.Windows.Forms.BindingSource responsiblePersonBindingSource1;
        private MOhamedDataSet6TableAdapters.ResponsiblePersonTableAdapter responsiblePersonTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private MOhamedDataSet7 mOhamedDataSet7;
    }
}