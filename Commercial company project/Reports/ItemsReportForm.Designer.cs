namespace Commercial_company_project.Reports
{
    partial class ItemsReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.reportStoredDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.ToTimePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.FromTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.itemNameItemIDDataSet = new Commercial_company_project.ItemNameItemIDDataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Commercial_company_project.ItemNameItemIDDataSetTableAdapters.ItemsTableAdapter();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportStoredDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNameItemIDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "شاةثب",
            "يبؤسيب",
            "سيبسي"});
            this.checkedListBox2.Location = new System.Drawing.Point(1076, 282);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBox2.Size = new System.Drawing.Size(281, 463);
            this.checkedListBox2.TabIndex = 82;
            this.checkedListBox2.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox2_ItemCheck);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(1247, 17);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel3.TabIndex = 84;
            this.gunaLabel3.Text = "حدد الصنف";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaLabel10.Location = new System.Drawing.Point(46, 132);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaLabel10.Size = new System.Drawing.Size(0, 29);
            this.gunaLabel10.TabIndex = 99;
            this.gunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaLabel11.Location = new System.Drawing.Point(448, 132);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaLabel11.Size = new System.Drawing.Size(227, 29);
            this.gunaLabel11.TabIndex = 98;
            this.gunaLabel11.Text = " وحدات القياس المتاحة : ";
            this.gunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaLabel8.Location = new System.Drawing.Point(41, 169);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gunaLabel8.Size = new System.Drawing.Size(158, 29);
            this.gunaLabel8.TabIndex = 97;
            this.gunaLabel8.Text = ".............................";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaLabel9.Location = new System.Drawing.Point(570, 169);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaLabel9.Size = new System.Drawing.Size(91, 29);
            this.gunaLabel9.TabIndex = 96;
            this.gunaLabel9.Text = "باركود : ";
            this.gunaLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaLabel5.Location = new System.Drawing.Point(730, 169);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaLabel5.Size = new System.Drawing.Size(158, 29);
            this.gunaLabel5.TabIndex = 95;
            this.gunaLabel5.Text = ".............................";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaLabel7.Location = new System.Drawing.Point(1221, 169);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaLabel7.Size = new System.Drawing.Size(130, 29);
            this.gunaLabel7.TabIndex = 94;
            this.gunaLabel7.Text = "إسم الصنف : ";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaLabel4.Location = new System.Drawing.Point(727, 121);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaLabel4.Size = new System.Drawing.Size(158, 29);
            this.gunaLabel4.TabIndex = 93;
            this.gunaLabel4.Text = ".............................";
            this.gunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaLabel2.Location = new System.Drawing.Point(1206, 121);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gunaLabel2.Size = new System.Drawing.Size(148, 29);
            this.gunaLabel2.TabIndex = 92;
            this.gunaLabel2.Text = "تاريخ التقرير : ";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportStoredDataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.reportStoredDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.reportStoredDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportStoredDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.reportStoredDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportStoredDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reportStoredDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportStoredDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.reportStoredDataGridView.ColumnHeadersHeight = 32;
            this.reportStoredDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column2,
            this.Column1,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reportStoredDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.reportStoredDataGridView.EnableHeadersVisualStyles = false;
            this.reportStoredDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reportStoredDataGridView.Location = new System.Drawing.Point(30, 232);
            this.reportStoredDataGridView.Name = "reportStoredDataGridView";
            this.reportStoredDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reportStoredDataGridView.RowHeadersVisible = false;
            this.reportStoredDataGridView.RowHeadersWidth = 51;
            this.reportStoredDataGridView.RowTemplate.Height = 24;
            this.reportStoredDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportStoredDataGridView.Size = new System.Drawing.Size(1032, 543);
            this.reportStoredDataGridView.TabIndex = 91;
            this.reportStoredDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.reportStoredDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.reportStoredDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.reportStoredDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.reportStoredDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.reportStoredDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.reportStoredDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.reportStoredDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reportStoredDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.reportStoredDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reportStoredDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.reportStoredDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.reportStoredDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.reportStoredDataGridView.ThemeStyle.HeaderStyle.Height = 32;
            this.reportStoredDataGridView.ThemeStyle.ReadOnly = false;
            this.reportStoredDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.reportStoredDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.reportStoredDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.reportStoredDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.reportStoredDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.reportStoredDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.reportStoredDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.BaseColor = System.Drawing.Color.White;
            this.ToTimePicker.BorderColor = System.Drawing.Color.Silver;
            this.ToTimePicker.CustomFormat = null;
            this.ToTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ToTimePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ToTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToTimePicker.ForeColor = System.Drawing.Color.Black;
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToTimePicker.Location = new System.Drawing.Point(332, 20);
            this.ToTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.ToTimePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ToTimePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ToTimePicker.OnPressedColor = System.Drawing.Color.Black;
            this.ToTimePicker.Size = new System.Drawing.Size(179, 30);
            this.ToTimePicker.TabIndex = 90;
            this.ToTimePicker.Text = "10/4/2023";
            this.ToTimePicker.Value = new System.DateTime(2023, 10, 4, 1, 24, 10, 11);
            // 
            // FromTimePicker1
            // 
            this.FromTimePicker1.BaseColor = System.Drawing.Color.White;
            this.FromTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.FromTimePicker1.CustomFormat = null;
            this.FromTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.FromTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FromTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FromTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.FromTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromTimePicker1.Location = new System.Drawing.Point(602, 21);
            this.FromTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromTimePicker1.Name = "FromTimePicker1";
            this.FromTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.FromTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FromTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FromTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.FromTimePicker1.Size = new System.Drawing.Size(170, 30);
            this.FromTimePicker1.TabIndex = 89;
            this.FromTimePicker1.Text = "10/4/2023";
            this.FromTimePicker1.Value = new System.DateTime(2023, 10, 4, 1, 24, 10, 11);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(527, 23);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(37, 28);
            this.gunaLabel1.TabIndex = 88;
            this.gunaLabel1.Text = "إلى";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(788, 23);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(33, 28);
            this.gunaLabel6.TabIndex = 87;
            this.gunaLabel6.Text = "من";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.itemsBindingSource;
            this.comboBox2.DisplayMember = "ItemName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1013, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(218, 24);
            this.comboBox2.TabIndex = 86;
            this.comboBox2.ValueMember = "ItemID";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(123, 17);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(180, 34);
            this.gunaButton1.TabIndex = 85;
            this.gunaButton1.Text = "عرض التقرير";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel12.Location = new System.Drawing.Point(1246, 232);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(103, 28);
            this.gunaLabel12.TabIndex = 100;
            this.gunaLabel12.Text = "حدد المخزن";
            // 
            // itemNameItemIDDataSet
            // 
            this.itemNameItemIDDataSet.DataSetName = "ItemNameItemIDDataSet";
            this.itemNameItemIDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.itemNameItemIDDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "الأصناف الموجودة";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "المخزن";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "إسم المورد";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "الكمية";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "السعر";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // ItemsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 787);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.reportStoredDataGridView);
            this.Controls.Add(this.ToTimePicker);
            this.Controls.Add(this.FromTimePicker1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.checkedListBox2);
            this.Name = "ItemsReportForm";
            this.Text = "ItemsReportForm";
            this.Load += new System.EventHandler(this.ItemsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportStoredDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemNameItemIDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaDataGridView reportStoredDataGridView;
        private Guna.UI.WinForms.GunaDateTimePicker ToTimePicker;
        private Guna.UI.WinForms.GunaDateTimePicker FromTimePicker1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private System.Windows.Forms.ComboBox comboBox2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private ItemNameItemIDDataSet itemNameItemIDDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private ItemNameItemIDDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}