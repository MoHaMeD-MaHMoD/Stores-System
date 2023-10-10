namespace Commercial_company_project.Screens.Items
{
    partial class EditItem
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
            this.BarCodeTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SearchItemButton = new Guna.UI.WinForms.GunaButton();
            this.NameTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.itemDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.ItemcheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.EditItemButton = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.DeleteButton = new Guna.UI.WinForms.GunaButton();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementUnit1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementUnit2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementUnit3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BarCodeTextBox
            // 
            this.BarCodeTextBox.BaseColor = System.Drawing.Color.White;
            this.BarCodeTextBox.BorderColor = System.Drawing.Color.Silver;
            this.BarCodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BarCodeTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.BarCodeTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BarCodeTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.BarCodeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BarCodeTextBox.Location = new System.Drawing.Point(228, 44);
            this.BarCodeTextBox.Name = "BarCodeTextBox";
            this.BarCodeTextBox.PasswordChar = '\0';
            this.BarCodeTextBox.SelectedText = "";
            this.BarCodeTextBox.Size = new System.Drawing.Size(164, 32);
            this.BarCodeTextBox.TabIndex = 9;
            this.BarCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(688, 48);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(102, 28);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "إسم الصنف";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Lato", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(408, 48);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(74, 28);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "الباركود";
            // 
            // SearchItemButton
            // 
            this.SearchItemButton.AnimationHoverSpeed = 0.07F;
            this.SearchItemButton.AnimationSpeed = 0.03F;
            this.SearchItemButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SearchItemButton.BorderColor = System.Drawing.Color.Black;
            this.SearchItemButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchItemButton.FocusedColor = System.Drawing.Color.Empty;
            this.SearchItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchItemButton.ForeColor = System.Drawing.Color.White;
            this.SearchItemButton.Image = null;
            this.SearchItemButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchItemButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SearchItemButton.Location = new System.Drawing.Point(116, 44);
            this.SearchItemButton.Name = "SearchItemButton";
            this.SearchItemButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.SearchItemButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchItemButton.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchItemButton.OnHoverImage = null;
            this.SearchItemButton.OnPressedColor = System.Drawing.Color.Black;
            this.SearchItemButton.Size = new System.Drawing.Size(94, 32);
            this.SearchItemButton.TabIndex = 11;
            this.SearchItemButton.Text = "بحث";
            this.SearchItemButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchItemButton.Click += new System.EventHandler(this.SearchItemButton_Click);
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.BaseColor = System.Drawing.Color.White;
            this.NameTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.NameTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.NameTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NameTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.NameTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTextBox1.Location = new System.Drawing.Point(504, 46);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.PasswordChar = '\0';
            this.NameTextBox1.SelectedText = "";
            this.NameTextBox1.Size = new System.Drawing.Size(164, 32);
            this.NameTextBox1.TabIndex = 12;
            this.NameTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // itemDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.itemDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.itemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.itemDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.itemDataGridView.ColumnHeadersHeight = 32;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemCodeDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.measurementUnit1DataGridViewTextBoxColumn,
            this.measurementUnit2DataGridViewTextBoxColumn,
            this.measurementUnit3DataGridViewTextBoxColumn});
            this.itemDataGridView.DataSource = this.itemsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemDataGridView.EnableHeadersVisualStyles = false;
            this.itemDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.itemDataGridView.Location = new System.Drawing.Point(45, 117);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersVisible = false;
            this.itemDataGridView.RowHeadersWidth = 51;
            this.itemDataGridView.RowTemplate.Height = 24;
            this.itemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataGridView.Size = new System.Drawing.Size(745, 413);
            this.itemDataGridView.TabIndex = 13;
            this.itemDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.itemDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.itemDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.itemDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.itemDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.itemDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.itemDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.itemDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.itemDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.itemDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.itemDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.itemDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.itemDataGridView.ThemeStyle.HeaderStyle.Height = 32;
            this.itemDataGridView.ThemeStyle.ReadOnly = false;
            this.itemDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.itemDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.itemDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.itemDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.itemDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.itemDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.itemDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.itemDataGridView.SelectionChanged += new System.EventHandler(this.itemDataGridView_SelectionChanged);
            // 
            // ItemcheckedListBox
            // 
            this.ItemcheckedListBox.FormattingEnabled = true;
            this.ItemcheckedListBox.Items.AddRange(new object[] {
            "    قطعة",
            "    كيلوغرام",
            "    لتر\t",
            "    برميل",
            "    كرتونة",
            "    صندوق",
            "    طبق",
            "    كيس",
            "    علبة",
            "    دستة"});
            this.ItemcheckedListBox.Location = new System.Drawing.Point(843, 90);
            this.ItemcheckedListBox.Name = "ItemcheckedListBox";
            this.ItemcheckedListBox.Size = new System.Drawing.Size(148, 191);
            this.ItemcheckedListBox.TabIndex = 15;
            // 
            // EditItemButton
            // 
            this.EditItemButton.AnimationHoverSpeed = 0.07F;
            this.EditItemButton.AnimationSpeed = 0.03F;
            this.EditItemButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EditItemButton.BorderColor = System.Drawing.Color.Black;
            this.EditItemButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditItemButton.FocusedColor = System.Drawing.Color.Empty;
            this.EditItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditItemButton.ForeColor = System.Drawing.Color.White;
            this.EditItemButton.Image = null;
            this.EditItemButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditItemButton.ImageSize = new System.Drawing.Size(20, 20);
            this.EditItemButton.Location = new System.Drawing.Point(843, 335);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EditItemButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EditItemButton.OnHoverForeColor = System.Drawing.Color.White;
            this.EditItemButton.OnHoverImage = null;
            this.EditItemButton.OnPressedColor = System.Drawing.Color.Black;
            this.EditItemButton.Size = new System.Drawing.Size(153, 42);
            this.EditItemButton.TabIndex = 16;
            this.EditItemButton.Text = "تعديل";
            this.EditItemButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::Commercial_company_project.Properties.Resources.refresh;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(45, 44);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(48, 32);
            this.gunaButton1.TabIndex = 14;
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AnimationHoverSpeed = 0.07F;
            this.DeleteButton.AnimationSpeed = 0.03F;
            this.DeleteButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeleteButton.BorderColor = System.Drawing.Color.Black;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButton.FocusedColor = System.Drawing.Color.Empty;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Image = null;
            this.DeleteButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.DeleteButton.Location = new System.Drawing.Point(843, 403);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.DeleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.DeleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.DeleteButton.OnHoverImage = null;
            this.DeleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.DeleteButton.Size = new System.Drawing.Size(153, 42);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "حذف";
            this.DeleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // progDBDataSet3
        
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            // 
            // itemsTableAdapter
            // 
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCodeDataGridViewTextBoxColumn
            // 
            this.itemCodeDataGridViewTextBoxColumn.DataPropertyName = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.HeaderText = "ItemCode";
            this.itemCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemCodeDataGridViewTextBoxColumn.Name = "itemCodeDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // measurementUnit1DataGridViewTextBoxColumn
            // 
            this.measurementUnit1DataGridViewTextBoxColumn.DataPropertyName = "MeasurementUnit1";
            this.measurementUnit1DataGridViewTextBoxColumn.HeaderText = "MeasurementUnit1";
            this.measurementUnit1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measurementUnit1DataGridViewTextBoxColumn.Name = "measurementUnit1DataGridViewTextBoxColumn";
            // 
            // measurementUnit2DataGridViewTextBoxColumn
            // 
            this.measurementUnit2DataGridViewTextBoxColumn.DataPropertyName = "MeasurementUnit2";
            this.measurementUnit2DataGridViewTextBoxColumn.HeaderText = "MeasurementUnit2";
            this.measurementUnit2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measurementUnit2DataGridViewTextBoxColumn.Name = "measurementUnit2DataGridViewTextBoxColumn";
            // 
            // measurementUnit3DataGridViewTextBoxColumn
            // 
            this.measurementUnit3DataGridViewTextBoxColumn.DataPropertyName = "MeasurementUnit3";
            this.measurementUnit3DataGridViewTextBoxColumn.HeaderText = "MeasurementUnit3";
            this.measurementUnit3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.measurementUnit3DataGridViewTextBoxColumn.Name = "measurementUnit3DataGridViewTextBoxColumn";
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 542);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditItemButton);
            this.Controls.Add(this.ItemcheckedListBox);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.NameTextBox1);
            this.Controls.Add(this.SearchItemButton);
            this.Controls.Add(this.BarCodeTextBox);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "EditItem";
            this.Text = "EditItem";
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox BarCodeTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton SearchItemButton;
        private Guna.UI.WinForms.GunaTextBox NameTextBox1;
        private Guna.UI.WinForms.GunaDataGridView itemDataGridView;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.CheckedListBox ItemcheckedListBox;
        private Guna.UI.WinForms.GunaButton EditItemButton;
        private Guna.UI.WinForms.GunaButton DeleteButton;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnit1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnit2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementUnit3DataGridViewTextBoxColumn;
    }
}