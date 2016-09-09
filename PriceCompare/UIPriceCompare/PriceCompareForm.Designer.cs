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
            this.ChainStoresColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StoreColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewStores
            // 
            this.listViewStores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StoreColumn,
            this.ChainStoresColumn});
            this.listViewStores.FullRowSelect = true;
            this.listViewStores.GridLines = true;
            this.listViewStores.Location = new System.Drawing.Point(22, 27);
            this.listViewStores.Name = "listViewStores";
            this.listViewStores.Size = new System.Drawing.Size(525, 239);
            this.listViewStores.TabIndex = 0;
            this.listViewStores.UseCompatibleStateImageBehavior = false;
            this.listViewStores.View = System.Windows.Forms.View.Details;
            this.listViewStores.SelectedIndexChanged += new System.EventHandler(this.listViewStores_SelectedIndexChanged);
            // 
            // ChainStoresColumn
            // 
            this.ChainStoresColumn.DisplayIndex = 0;
            this.ChainStoresColumn.Text = "Chain stores ";
            this.ChainStoresColumn.Width = 245;
            // 
            // StoreColumn
            // 
            this.StoreColumn.DisplayIndex = 1;
            this.StoreColumn.Text = "Store";
            this.StoreColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.StoreColumn.Width = 284;
            // 
            // PriceCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 472);
            this.Controls.Add(this.listViewStores);
            this.Name = "PriceCompareForm";
            this.Text = "PriceCompareForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewStores;
        private System.Windows.Forms.ColumnHeader ChainStoresColumn;
        private System.Windows.Forms.ColumnHeader StoreColumn;
    }
}