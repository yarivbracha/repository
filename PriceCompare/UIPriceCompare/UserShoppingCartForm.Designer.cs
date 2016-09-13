namespace UIPriceCompare
{
    partial class UserShoppingCartForm
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
            this.listViewShoppingCart = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSumShoppingCart = new System.Windows.Forms.Label();
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUnitOfMeasure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStoreId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewShoppingCart
            // 
            this.listViewShoppingCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAmount,
            this.columnId,
            this.columnName,
            this.columnPrice,
            this.columnQuantity,
            this.columnUnitOfMeasure,
            this.columnCode,
            this.columnType,
            this.columnStoreId});
            this.listViewShoppingCart.GridLines = true;
            this.listViewShoppingCart.Location = new System.Drawing.Point(1, -1);
            this.listViewShoppingCart.Name = "listViewShoppingCart";
            this.listViewShoppingCart.Size = new System.Drawing.Size(633, 352);
            this.listViewShoppingCart.TabIndex = 0;
            this.listViewShoppingCart.UseCompatibleStateImageBehavior = false;
            this.listViewShoppingCart.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price:";
            // 
            // labelSumShoppingCart
            // 
            this.labelSumShoppingCart.AutoSize = true;
            this.labelSumShoppingCart.Location = new System.Drawing.Point(669, 119);
            this.labelSumShoppingCart.Name = "labelSumShoppingCart";
            this.labelSumShoppingCart.Size = new System.Drawing.Size(28, 13);
            this.labelSumShoppingCart.TabIndex = 2;
            this.labelSumShoppingCart.Text = "0.00";
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 94;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 71;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.Width = 70;
            // 
            // columnUnitOfMeasure
            // 
            this.columnUnitOfMeasure.Text = "Unit of measure";
            this.columnUnitOfMeasure.Width = 80;
            // 
            // columnCode
            // 
            this.columnCode.Text = "Code";
            this.columnCode.Width = 52;
            // 
            // columnType
            // 
            this.columnType.Text = "Type";
            this.columnType.Width = 87;
            // 
            // columnStoreId
            // 
            this.columnStoreId.Text = "StoreId";
            // 
            // UserShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 350);
            this.Controls.Add(this.labelSumShoppingCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewShoppingCart);
            this.Name = "UserShoppingCartForm";
            this.Text = "UserShoppingCartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewShoppingCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSumShoppingCart;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnUnitOfMeasure;
        private System.Windows.Forms.ColumnHeader columnCode;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnStoreId;
    }
}