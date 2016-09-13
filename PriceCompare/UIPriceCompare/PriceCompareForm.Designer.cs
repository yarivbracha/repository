namespace UIPriceCompare
{
    partial class PriceCompareForm
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
            this.listViewStores = new System.Windows.Forms.ListView();
            this.IdStoreColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StoreColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChainStoresColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBoxShopingCart = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveShopingCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelShopingCartPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxStoreCheapItems = new System.Windows.Forms.ListBox();
            this.listBoxStoreExpensiveItems = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNameItem = new System.Windows.Forms.Label();
            this.labelPriceItem = new System.Windows.Forms.Label();
            this.labelQuantityItem = new System.Windows.Forms.Label();
            this.labelUnitOfMeasureItem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.CheckedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOMColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonShowLast = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewStores
            // 
            this.listViewStores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdStoreColumn,
            this.StoreColumn,
            this.ChainStoresColumn});
            this.listViewStores.FullRowSelect = true;
            this.listViewStores.GridLines = true;
            this.listViewStores.Location = new System.Drawing.Point(12, 12);
            this.listViewStores.Name = "listViewStores";
            this.listViewStores.Size = new System.Drawing.Size(327, 239);
            this.listViewStores.TabIndex = 0;
            this.listViewStores.UseCompatibleStateImageBehavior = false;
            this.listViewStores.View = System.Windows.Forms.View.Details;
            this.listViewStores.SelectedIndexChanged += new System.EventHandler(this.listViewStores_SelectedIndexChanged);
            // 
            // IdStoreColumn
            // 
            this.IdStoreColumn.Text = "Id";
            // 
            // StoreColumn
            // 
            this.StoreColumn.Text = "Store";
            this.StoreColumn.Width = 108;
            // 
            // ChainStoresColumn
            // 
            this.ChainStoresColumn.Text = "Chain stores ";
            this.ChainStoresColumn.Width = 134;
            // 
            // listBoxShopingCart
            // 
            this.listBoxShopingCart.FormattingEnabled = true;
            this.listBoxShopingCart.Location = new System.Drawing.Point(703, 296);
            this.listBoxShopingCart.Name = "listBoxShopingCart";
            this.listBoxShopingCart.Size = new System.Drawing.Size(181, 199);
            this.listBoxShopingCart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shopping cart:";
            // 
            // buttonSaveShopingCart
            // 
            this.buttonSaveShopingCart.Location = new System.Drawing.Point(907, 397);
            this.buttonSaveShopingCart.Name = "buttonSaveShopingCart";
            this.buttonSaveShopingCart.Size = new System.Drawing.Size(94, 44);
            this.buttonSaveShopingCart.TabIndex = 4;
            this.buttonSaveShopingCart.Text = "Save";
            this.buttonSaveShopingCart.UseVisualStyleBackColor = true;
            this.buttonSaveShopingCart.Click += new System.EventHandler(this.buttonSaveShopingCart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            // 
            // labelShopingCartPrice
            // 
            this.labelShopingCartPrice.AutoSize = true;
            this.labelShopingCartPrice.Location = new System.Drawing.Point(756, 499);
            this.labelShopingCartPrice.Name = "labelShopingCartPrice";
            this.labelShopingCartPrice.Size = new System.Drawing.Size(28, 13);
            this.labelShopingCartPrice.TabIndex = 6;
            this.labelShopingCartPrice.Text = "0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.listBoxStoreCheapItems);
            this.groupBox1.Controls.Add(this.listBoxStoreExpensiveItems);
            this.groupBox1.Location = new System.Drawing.Point(36, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Store details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Most expensive:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cheapest:";
            // 
            // listBoxStoreCheapItems
            // 
            this.listBoxStoreCheapItems.FormattingEnabled = true;
            this.listBoxStoreCheapItems.Location = new System.Drawing.Point(151, 60);
            this.listBoxStoreCheapItems.Name = "listBoxStoreCheapItems";
            this.listBoxStoreCheapItems.Size = new System.Drawing.Size(120, 95);
            this.listBoxStoreCheapItems.TabIndex = 1;
            this.listBoxStoreCheapItems.SelectedIndexChanged += new System.EventHandler(this.listBoxStoreCheapItems_SelectedIndexChanged);
            // 
            // listBoxStoreExpensiveItems
            // 
            this.listBoxStoreExpensiveItems.FormattingEnabled = true;
            this.listBoxStoreExpensiveItems.Location = new System.Drawing.Point(6, 60);
            this.listBoxStoreExpensiveItems.Name = "listBoxStoreExpensiveItems";
            this.listBoxStoreExpensiveItems.Size = new System.Drawing.Size(120, 95);
            this.listBoxStoreExpensiveItems.TabIndex = 0;
            this.listBoxStoreExpensiveItems.SelectedIndexChanged += new System.EventHandler(this.listBoxStoreExpensiveItems_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelNameItem);
            this.groupBox2.Controls.Add(this.labelPriceItem);
            this.groupBox2.Controls.Add(this.labelQuantityItem);
            this.groupBox2.Controls.Add(this.labelUnitOfMeasureItem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(355, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 134);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item details:";
            // 
            // labelNameItem
            // 
            this.labelNameItem.AutoSize = true;
            this.labelNameItem.Location = new System.Drawing.Point(96, 25);
            this.labelNameItem.Name = "labelNameItem";
            this.labelNameItem.Size = new System.Drawing.Size(33, 13);
            this.labelNameItem.TabIndex = 11;
            this.labelNameItem.Text = "None";
            // 
            // labelPriceItem
            // 
            this.labelPriceItem.AutoSize = true;
            this.labelPriceItem.Location = new System.Drawing.Point(96, 44);
            this.labelPriceItem.Name = "labelPriceItem";
            this.labelPriceItem.Size = new System.Drawing.Size(33, 13);
            this.labelPriceItem.TabIndex = 10;
            this.labelPriceItem.Text = "None";
            // 
            // labelQuantityItem
            // 
            this.labelQuantityItem.AutoSize = true;
            this.labelQuantityItem.Location = new System.Drawing.Point(97, 63);
            this.labelQuantityItem.Name = "labelQuantityItem";
            this.labelQuantityItem.Size = new System.Drawing.Size(33, 13);
            this.labelQuantityItem.TabIndex = 9;
            this.labelQuantityItem.Text = "None";
            // 
            // labelUnitOfMeasureItem
            // 
            this.labelUnitOfMeasureItem.AutoSize = true;
            this.labelUnitOfMeasureItem.Location = new System.Drawing.Point(97, 82);
            this.labelUnitOfMeasureItem.Name = "labelUnitOfMeasureItem";
            this.labelUnitOfMeasureItem.Size = new System.Drawing.Size(33, 13);
            this.labelUnitOfMeasureItem.TabIndex = 8;
            this.labelUnitOfMeasureItem.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unit of Measure:";
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(907, 341);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(94, 44);
            this.buttonCompare.TabIndex = 9;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(907, 280);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 49);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add to shopping cart";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToOrderColumns = true;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckedColumn,
            this.AmountColumn,
            this.IdColumn,
            this.NameColumn,
            this.PriceColumn,
            this.QuantityColumn,
            this.UOMColumn,
            this.CodeColumn,
            this.TypeColumn});
            this.dataGridViewItems.Location = new System.Drawing.Point(355, 12);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(682, 239);
            this.dataGridViewItems.TabIndex = 11;
            // 
            // CheckedColumn
            // 
            this.CheckedColumn.HeaderText = "select";
            this.CheckedColumn.Name = "CheckedColumn";
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.HeaderText = "Quantity";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // UOMColumn
            // 
            this.UOMColumn.HeaderText = "UnitOfMeasure";
            this.UOMColumn.Name = "UOMColumn";
            this.UOMColumn.ReadOnly = true;
            // 
            // CodeColumn
            // 
            this.CodeColumn.HeaderText = "Code";
            this.CodeColumn.Name = "CodeColumn";
            this.CodeColumn.ReadOnly = true;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // buttonShowLast
            // 
            this.buttonShowLast.Location = new System.Drawing.Point(907, 451);
            this.buttonShowLast.Name = "buttonShowLast";
            this.buttonShowLast.Size = new System.Drawing.Size(94, 44);
            this.buttonShowLast.TabIndex = 12;
            this.buttonShowLast.Text = "Show last shopping cart";
            this.buttonShowLast.UseVisualStyleBackColor = true;
            this.buttonShowLast.Click += new System.EventHandler(this.buttonShowLast_Click);
            // 
            // PriceCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 523);
            this.Controls.Add(this.buttonShowLast);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelShopingCartPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveShopingCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxShopingCart);
            this.Controls.Add(this.listViewStores);
            this.Name = "PriceCompareForm";
            this.Text = "PriceCompareForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewStores;
        private System.Windows.Forms.ColumnHeader ChainStoresColumn;
        private System.Windows.Forms.ColumnHeader StoreColumn;
        private System.Windows.Forms.ColumnHeader IdStoreColumn;
        private System.Windows.Forms.ListBox listBoxShopingCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveShopingCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelShopingCartPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxStoreCheapItems;
        private System.Windows.Forms.ListBox listBoxStoreExpensiveItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNameItem;
        private System.Windows.Forms.Label labelPriceItem;
        private System.Windows.Forms.Label labelQuantityItem;
        private System.Windows.Forms.Label labelUnitOfMeasureItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOMColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.Button buttonShowLast;
    }
}