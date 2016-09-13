namespace UIPriceCompare
{
    partial class ComparerForm
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
            this.listBoxOldShopingCart = new System.Windows.Forms.ListBox();
            this.listViewStores = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnChainStore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewNewShopingCart = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.labelNewShopingCart = new System.Windows.Forms.Label();
            this.labelOldShoppingCart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listBoxOldShopingCart
            // 
            this.listBoxOldShopingCart.FormattingEnabled = true;
            this.listBoxOldShopingCart.Location = new System.Drawing.Point(12, 36);
            this.listBoxOldShopingCart.Name = "listBoxOldShopingCart";
            this.listBoxOldShopingCart.Size = new System.Drawing.Size(190, 303);
            this.listBoxOldShopingCart.TabIndex = 0;
            // 
            // listViewStores
            // 
            this.listViewStores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnStore,
            this.columnChainStore});
            this.listViewStores.FullRowSelect = true;
            this.listViewStores.GridLines = true;
            this.listViewStores.Location = new System.Drawing.Point(238, 52);
            this.listViewStores.Name = "listViewStores";
            this.listViewStores.Size = new System.Drawing.Size(300, 287);
            this.listViewStores.TabIndex = 1;
            this.listViewStores.UseCompatibleStateImageBehavior = false;
            this.listViewStores.View = System.Windows.Forms.View.Details;
            this.listViewStores.SelectedIndexChanged += new System.EventHandler(this.listViewStores_SelectedIndexChanged);
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 61;
            // 
            // columnStore
            // 
            this.columnStore.Text = "Stores";
            this.columnStore.Width = 104;
            // 
            // columnChainStore
            // 
            this.columnChainStore.Text = "ChainStore";
            this.columnChainStore.Width = 133;
            // 
            // listViewNewShopingCart
            // 
            this.listViewNewShopingCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPrice,
            this.columnAmount});
            this.listViewNewShopingCart.GridLines = true;
            this.listViewNewShopingCart.Location = new System.Drawing.Point(544, 52);
            this.listViewNewShopingCart.Name = "listViewNewShopingCart";
            this.listViewNewShopingCart.Size = new System.Drawing.Size(254, 287);
            this.listViewNewShopingCart.TabIndex = 2;
            this.listViewNewShopingCart.UseCompatibleStateImageBehavior = false;
            this.listViewNewShopingCart.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 103;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price:";
            // 
            // labelNewShopingCart
            // 
            this.labelNewShopingCart.AutoSize = true;
            this.labelNewShopingCart.Location = new System.Drawing.Point(671, 356);
            this.labelNewShopingCart.Name = "labelNewShopingCart";
            this.labelNewShopingCart.Size = new System.Drawing.Size(28, 13);
            this.labelNewShopingCart.TabIndex = 4;
            this.labelNewShopingCart.Text = "0.00";
            // 
            // labelOldShoppingCart
            // 
            this.labelOldShoppingCart.AutoSize = true;
            this.labelOldShoppingCart.Location = new System.Drawing.Point(111, 356);
            this.labelOldShoppingCart.Name = "labelOldShoppingCart";
            this.labelOldShoppingCart.Size = new System.Drawing.Size(28, 13);
            this.labelOldShoppingCart.TabIndex = 6;
            this.labelOldShoppingCart.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price:";
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            this.columnAmount.Width = 82;
            // 
            // ComparerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 478);
            this.Controls.Add(this.labelOldShoppingCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNewShopingCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewNewShopingCart);
            this.Controls.Add(this.listViewStores);
            this.Controls.Add(this.listBoxOldShopingCart);
            this.Name = "ComparerForm";
            this.Text = "ComparerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOldShopingCart;
        private System.Windows.Forms.ListView listViewStores;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnStore;
        private System.Windows.Forms.ColumnHeader columnChainStore;
        private System.Windows.Forms.ListView listViewNewShopingCart;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNewShopingCart;
        private System.Windows.Forms.Label labelOldShoppingCart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnAmount;
    }
}