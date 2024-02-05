namespace login_crud_dashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label user_accountidLabel;
            System.Windows.Forms.Label user_accountnameLabel;
            System.Windows.Forms.Label user_accountpasswordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.table_useraccountsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.table_useraccountsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.user_accountidTextBox = new System.Windows.Forms.TextBox();
            this.user_accountnameTextBox = new System.Windows.Forms.TextBox();
            this.user_accountpasswordTextBox = new System.Windows.Forms.TextBox();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.cbx_showpass = new System.Windows.Forms.CheckBox();
            this.table_useraccountsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table_useraccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new login_crud_dashboard.Database1DataSet();
            this.table_useraccountsTableAdapter = new login_crud_dashboard.Database1DataSetTableAdapters.table_useraccountsTableAdapter();
            this.tableAdapterManager = new login_crud_dashboard.Database1DataSetTableAdapters.TableAdapterManager();
            this.btn_excel = new System.Windows.Forms.Button();
            user_accountidLabel = new System.Windows.Forms.Label();
            user_accountnameLabel = new System.Windows.Forms.Label();
            user_accountpasswordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_useraccountsBindingNavigator)).BeginInit();
            this.table_useraccountsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_useraccountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_useraccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // user_accountidLabel
            // 
            user_accountidLabel.AutoSize = true;
            user_accountidLabel.Location = new System.Drawing.Point(52, 94);
            user_accountidLabel.Name = "user_accountidLabel";
            user_accountidLabel.Size = new System.Drawing.Size(80, 13);
            user_accountidLabel.TabIndex = 2;
            user_accountidLabel.Text = "user accountid:";
            // 
            // user_accountnameLabel
            // 
            user_accountnameLabel.AutoSize = true;
            user_accountnameLabel.Location = new System.Drawing.Point(52, 120);
            user_accountnameLabel.Name = "user_accountnameLabel";
            user_accountnameLabel.Size = new System.Drawing.Size(98, 13);
            user_accountnameLabel.TabIndex = 4;
            user_accountnameLabel.Text = "user accountname:";
            // 
            // user_accountpasswordLabel
            // 
            user_accountpasswordLabel.AutoSize = true;
            user_accountpasswordLabel.Location = new System.Drawing.Point(54, 146);
            user_accountpasswordLabel.Name = "user_accountpasswordLabel";
            user_accountpasswordLabel.Size = new System.Drawing.Size(117, 13);
            user_accountpasswordLabel.TabIndex = 6;
            user_accountpasswordLabel.Text = "user accountpassword:";
            // 
            // table_useraccountsBindingNavigator
            // 
            this.table_useraccountsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.table_useraccountsBindingNavigator.BindingSource = this.table_useraccountsBindingSource;
            this.table_useraccountsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.table_useraccountsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.table_useraccountsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.table_useraccountsBindingNavigatorSaveItem});
            this.table_useraccountsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.table_useraccountsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.table_useraccountsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.table_useraccountsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.table_useraccountsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.table_useraccountsBindingNavigator.Name = "table_useraccountsBindingNavigator";
            this.table_useraccountsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.table_useraccountsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.table_useraccountsBindingNavigator.TabIndex = 0;
            this.table_useraccountsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // table_useraccountsBindingNavigatorSaveItem
            // 
            this.table_useraccountsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.table_useraccountsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("table_useraccountsBindingNavigatorSaveItem.Image")));
            this.table_useraccountsBindingNavigatorSaveItem.Name = "table_useraccountsBindingNavigatorSaveItem";
            this.table_useraccountsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.table_useraccountsBindingNavigatorSaveItem.Text = "Save Data";
            this.table_useraccountsBindingNavigatorSaveItem.Click += new System.EventHandler(this.table_useraccountsBindingNavigatorSaveItem_Click);
            // 
            // user_accountidTextBox
            // 
            this.user_accountidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_useraccountsBindingSource, "user_accountid", true));
            this.user_accountidTextBox.Location = new System.Drawing.Point(177, 91);
            this.user_accountidTextBox.Name = "user_accountidTextBox";
            this.user_accountidTextBox.ReadOnly = true;
            this.user_accountidTextBox.Size = new System.Drawing.Size(100, 20);
            this.user_accountidTextBox.TabIndex = 3;
            // 
            // user_accountnameTextBox
            // 
            this.user_accountnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_useraccountsBindingSource, "user_accountname", true));
            this.user_accountnameTextBox.Location = new System.Drawing.Point(177, 117);
            this.user_accountnameTextBox.Name = "user_accountnameTextBox";
            this.user_accountnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.user_accountnameTextBox.TabIndex = 5;
            // 
            // user_accountpasswordTextBox
            // 
            this.user_accountpasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_useraccountsBindingSource, "user_accountpassword", true));
            this.user_accountpasswordTextBox.Location = new System.Drawing.Point(177, 143);
            this.user_accountpasswordTextBox.Name = "user_accountpasswordTextBox";
            this.user_accountpasswordTextBox.PasswordChar = '*';
            this.user_accountpasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.user_accountpasswordTextBox.TabIndex = 7;
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(543, 5);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(158, 20);
            this.tbx_search.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search by ID";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(707, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cbx_showpass
            // 
            this.cbx_showpass.AutoSize = true;
            this.cbx_showpass.Location = new System.Drawing.Point(296, 146);
            this.cbx_showpass.Name = "cbx_showpass";
            this.cbx_showpass.Size = new System.Drawing.Size(99, 17);
            this.cbx_showpass.TabIndex = 11;
            this.cbx_showpass.Text = "show password";
            this.cbx_showpass.UseVisualStyleBackColor = true;
            this.cbx_showpass.CheckedChanged += new System.EventHandler(this.cbx_showpass_CheckedChanged);
            // 
            // table_useraccountsDataGridView
            // 
            this.table_useraccountsDataGridView.AutoGenerateColumns = false;
            this.table_useraccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_useraccountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.table_useraccountsDataGridView.DataSource = this.table_useraccountsBindingSource;
            this.table_useraccountsDataGridView.Location = new System.Drawing.Point(55, 228);
            this.table_useraccountsDataGridView.Name = "table_useraccountsDataGridView";
            this.table_useraccountsDataGridView.Size = new System.Drawing.Size(657, 246);
            this.table_useraccountsDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user_accountid";
            this.dataGridViewTextBoxColumn1.HeaderText = "user_accountid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "user_accountname";
            this.dataGridViewTextBoxColumn2.HeaderText = "user_accountname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "user_accountpassword";
            this.dataGridViewTextBoxColumn3.HeaderText = "user_accountpassword";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // table_useraccountsBindingSource
            // 
            this.table_useraccountsBindingSource.DataMember = "table_useraccounts";
            this.table_useraccountsBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_useraccountsTableAdapter
            // 
            this.table_useraccountsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.table_useraccountsTableAdapter = this.table_useraccountsTableAdapter;
            this.tableAdapterManager.UpdateOrder = login_crud_dashboard.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(55, 489);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(177, 23);
            this.btn_excel.TabIndex = 12;
            this.btn_excel.Text = "Generate Excel File";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.table_useraccountsDataGridView);
            this.Controls.Add(this.cbx_showpass);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(user_accountpasswordLabel);
            this.Controls.Add(this.user_accountpasswordTextBox);
            this.Controls.Add(user_accountnameLabel);
            this.Controls.Add(this.user_accountnameTextBox);
            this.Controls.Add(user_accountidLabel);
            this.Controls.Add(this.user_accountidTextBox);
            this.Controls.Add(this.table_useraccountsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_useraccountsBindingNavigator)).EndInit();
            this.table_useraccountsBindingNavigator.ResumeLayout(false);
            this.table_useraccountsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_useraccountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_useraccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource table_useraccountsBindingSource;
        private Database1DataSetTableAdapters.table_useraccountsTableAdapter table_useraccountsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator table_useraccountsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton table_useraccountsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox user_accountidTextBox;
        private System.Windows.Forms.TextBox user_accountnameTextBox;
        private System.Windows.Forms.TextBox user_accountpasswordTextBox;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox cbx_showpass;
        private System.Windows.Forms.DataGridView table_useraccountsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btn_excel;
    }
}

