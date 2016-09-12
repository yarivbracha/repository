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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnChainStore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewNewShopingCart = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnStore,
            this.columnChainStore});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(238, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 287);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.columnPrice});
            this.listViewNewShopingCart.GridLines = true;
            this.listViewNewShopingCart.Location = new System.Drawing.Point(544, 62);
            this.listViewNewShopingCart.Name = "listViewNewShopingCart";
            this.listViewNewShopingCart.Size = new System.Drawing.Size(254, 277);
            this.listViewNewShopingCart.TabIndex = 2;
            this.listViewNewShopingCart.UseCompatibleStateImageBehavior = false;
            this.listViewNewShopingCart.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 179;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0.00";
            // 
            // ComparerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewNewShopingCart);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBoxOldShopingCart);
            this.Name = "ComparerForm";
            this.Text = "ComparerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOldShopingCart;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnStore;
        private System.Windows.Forms.ColumnHeader columnChainStore;
        private System.Windows.Forms.ListView listViewNewShopingCart;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}