namespace MedicalStoreSoftware.Pages
{
    partial class pg_Purchase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_BuyProuducts = new System.Windows.Forms.DataGridView();
            this.btnSell_prdDelete = new System.Windows.Forms.Button();
            this.btnSell_prdUpdate = new System.Windows.Forms.Button();
            this.btnSell_prdAdd = new System.Windows.Forms.Button();
            this.NUD_prdQuantitr = new System.Windows.Forms.NumericUpDown();
            this.txtprdSize = new System.Windows.Forms.TextBox();
            this.txtSell_prdtype = new System.Windows.Forms.TextBox();
            this.txtSell_prdName = new System.Windows.Forms.TextBox();
            this.lbSellprdQuntity = new System.Windows.Forms.Label();
            this.lbprdSize = new System.Windows.Forms.Label();
            this.lbSellprdtype = new System.Windows.Forms.Label();
            this.lbSellPrdName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprdSellPrice = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbprdCompany = new System.Windows.Forms.Label();
            this.txtprdCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprdID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuyProuducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_prdQuantitr)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BuyProuducts
            // 
            this.dgv_BuyProuducts.AllowUserToAddRows = false;
            this.dgv_BuyProuducts.AllowUserToDeleteRows = false;
            this.dgv_BuyProuducts.AllowUserToResizeColumns = false;
            this.dgv_BuyProuducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BuyProuducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_BuyProuducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgv_BuyProuducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BuyProuducts.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_BuyProuducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BuyProuducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_BuyProuducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BuyProuducts.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_BuyProuducts.Location = new System.Drawing.Point(8, 151);
            this.dgv_BuyProuducts.Name = "dgv_BuyProuducts";
            this.dgv_BuyProuducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_BuyProuducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_BuyProuducts.RowHeadersVisible = false;
            this.dgv_BuyProuducts.RowTemplate.Height = 28;
            this.dgv_BuyProuducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_BuyProuducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BuyProuducts.Size = new System.Drawing.Size(1524, 534);
            this.dgv_BuyProuducts.TabIndex = 0;
            this.dgv_BuyProuducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BuyProuducts_CellContentClick);
            // 
            // btnSell_prdDelete
            // 
            this.btnSell_prdDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSell_prdDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSell_prdDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell_prdDelete.Location = new System.Drawing.Point(1396, 691);
            this.btnSell_prdDelete.Name = "btnSell_prdDelete";
            this.btnSell_prdDelete.Size = new System.Drawing.Size(136, 39);
            this.btnSell_prdDelete.TabIndex = 21;
            this.btnSell_prdDelete.Text = "DELETE";
            this.btnSell_prdDelete.UseVisualStyleBackColor = false;
            this.btnSell_prdDelete.Click += new System.EventHandler(this.btnSell_prdDelete_Click);
            // 
            // btnSell_prdUpdate
            // 
            this.btnSell_prdUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSell_prdUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSell_prdUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell_prdUpdate.Location = new System.Drawing.Point(1254, 691);
            this.btnSell_prdUpdate.Name = "btnSell_prdUpdate";
            this.btnSell_prdUpdate.Size = new System.Drawing.Size(136, 39);
            this.btnSell_prdUpdate.TabIndex = 22;
            this.btnSell_prdUpdate.Text = "UPDATE";
            this.btnSell_prdUpdate.UseVisualStyleBackColor = false;
            this.btnSell_prdUpdate.Click += new System.EventHandler(this.btnSell_prdUpdate_Click);
            // 
            // btnSell_prdAdd
            // 
            this.btnSell_prdAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSell_prdAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSell_prdAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell_prdAdd.Location = new System.Drawing.Point(1112, 691);
            this.btnSell_prdAdd.Name = "btnSell_prdAdd";
            this.btnSell_prdAdd.Size = new System.Drawing.Size(136, 39);
            this.btnSell_prdAdd.TabIndex = 23;
            this.btnSell_prdAdd.Text = "ADD";
            this.btnSell_prdAdd.UseVisualStyleBackColor = false;
            this.btnSell_prdAdd.Click += new System.EventHandler(this.btnSell_prdAdd_Click);
            // 
            // NUD_prdQuantitr
            // 
            this.NUD_prdQuantitr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NUD_prdQuantitr.Location = new System.Drawing.Point(1267, 65);
            this.NUD_prdQuantitr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_prdQuantitr.Name = "NUD_prdQuantitr";
            this.NUD_prdQuantitr.Size = new System.Drawing.Size(100, 26);
            this.NUD_prdQuantitr.TabIndex = 20;
            this.NUD_prdQuantitr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtprdSize
            // 
            this.txtprdSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprdSize.Location = new System.Drawing.Point(113, 103);
            this.txtprdSize.Name = "txtprdSize";
            this.txtprdSize.Size = new System.Drawing.Size(141, 26);
            this.txtprdSize.TabIndex = 16;
            // 
            // txtSell_prdtype
            // 
            this.txtSell_prdtype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSell_prdtype.Location = new System.Drawing.Point(403, 103);
            this.txtSell_prdtype.Name = "txtSell_prdtype";
            this.txtSell_prdtype.Size = new System.Drawing.Size(192, 26);
            this.txtSell_prdtype.TabIndex = 17;
            // 
            // txtSell_prdName
            // 
            this.txtSell_prdName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSell_prdName.Location = new System.Drawing.Point(403, 65);
            this.txtSell_prdName.Name = "txtSell_prdName";
            this.txtSell_prdName.Size = new System.Drawing.Size(325, 26);
            this.txtSell_prdName.TabIndex = 18;
            // 
            // lbSellprdQuntity
            // 
            this.lbSellprdQuntity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSellprdQuntity.AutoSize = true;
            this.lbSellprdQuntity.Location = new System.Drawing.Point(1126, 68);
            this.lbSellprdQuntity.Name = "lbSellprdQuntity";
            this.lbSellprdQuntity.Size = new System.Drawing.Size(135, 20);
            this.lbSellprdQuntity.TabIndex = 11;
            this.lbSellprdQuntity.Text = "Product Quantity: ";
            // 
            // lbprdSize
            // 
            this.lbprdSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbprdSize.AutoSize = true;
            this.lbprdSize.Location = new System.Drawing.Point(4, 106);
            this.lbprdSize.Name = "lbprdSize";
            this.lbprdSize.Size = new System.Drawing.Size(103, 20);
            this.lbprdSize.TabIndex = 12;
            this.lbprdSize.Text = "Product Size:";
            // 
            // lbSellprdtype
            // 
            this.lbSellprdtype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSellprdtype.AutoSize = true;
            this.lbSellprdtype.Location = new System.Drawing.Point(279, 106);
            this.lbSellprdtype.Name = "lbSellprdtype";
            this.lbSellprdtype.Size = new System.Drawing.Size(118, 20);
            this.lbSellprdtype.TabIndex = 13;
            this.lbSellprdtype.Text = "Product Types: ";
            // 
            // lbSellPrdName
            // 
            this.lbSellPrdName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSellPrdName.AutoSize = true;
            this.lbSellPrdName.Location = new System.Drawing.Point(279, 68);
            this.lbSellPrdName.Name = "lbSellPrdName";
            this.lbSellPrdName.Size = new System.Drawing.Size(118, 20);
            this.lbSellPrdName.TabIndex = 14;
            this.lbSellPrdName.Text = "Product Name: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Product Sell Rrice: ";
            // 
            // txtprdSellPrice
            // 
            this.txtprdSellPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprdSellPrice.Location = new System.Drawing.Point(909, 65);
            this.txtprdSellPrice.Name = "txtprdSellPrice";
            this.txtprdSellPrice.Size = new System.Drawing.Size(165, 26);
            this.txtprdSellPrice.TabIndex = 17;
            this.txtprdSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprdSellPrice_KeyPress);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lbTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1540, 50);
            this.panelHeader.TabIndex = 24;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(637, 5);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(266, 40);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "PURCHASING";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbprdCompany
            // 
            this.lbprdCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbprdCompany.AutoSize = true;
            this.lbprdCompany.Location = new System.Drawing.Point(653, 106);
            this.lbprdCompany.Name = "lbprdCompany";
            this.lbprdCompany.Size = new System.Drawing.Size(143, 20);
            this.lbprdCompany.TabIndex = 13;
            this.lbprdCompany.Text = "Product Company: ";
            // 
            // txtprdCompany
            // 
            this.txtprdCompany.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprdCompany.Location = new System.Drawing.Point(801, 103);
            this.txtprdCompany.Name = "txtprdCompany";
            this.txtprdCompany.Size = new System.Drawing.Size(192, 26);
            this.txtprdCompany.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product ID:";
            // 
            // txtprdID
            // 
            this.txtprdID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprdID.Location = new System.Drawing.Point(99, 65);
            this.txtprdID.Name = "txtprdID";
            this.txtprdID.ReadOnly = true;
            this.txtprdID.Size = new System.Drawing.Size(155, 26);
            this.txtprdID.TabIndex = 18;
            // 
            // pg_Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnSell_prdDelete);
            this.Controls.Add(this.btnSell_prdUpdate);
            this.Controls.Add(this.btnSell_prdAdd);
            this.Controls.Add(this.NUD_prdQuantitr);
            this.Controls.Add(this.txtprdSize);
            this.Controls.Add(this.txtprdSellPrice);
            this.Controls.Add(this.txtprdCompany);
            this.Controls.Add(this.txtSell_prdtype);
            this.Controls.Add(this.txtprdID);
            this.Controls.Add(this.txtSell_prdName);
            this.Controls.Add(this.lbSellprdQuntity);
            this.Controls.Add(this.lbprdSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbprdCompany);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSellprdtype);
            this.Controls.Add(this.lbSellPrdName);
            this.Controls.Add(this.dgv_BuyProuducts);
            this.Name = "pg_Purchase";
            this.Size = new System.Drawing.Size(1540, 733);
            this.Load += new System.EventHandler(this.pg_Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BuyProuducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_prdQuantitr)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BuyProuducts;
        private System.Windows.Forms.Button btnSell_prdDelete;
        private System.Windows.Forms.Button btnSell_prdUpdate;
        private System.Windows.Forms.Button btnSell_prdAdd;
        private System.Windows.Forms.NumericUpDown NUD_prdQuantitr;
        private System.Windows.Forms.TextBox txtprdSize;
        private System.Windows.Forms.TextBox txtSell_prdtype;
        private System.Windows.Forms.TextBox txtSell_prdName;
        private System.Windows.Forms.Label lbSellprdQuntity;
        private System.Windows.Forms.Label lbprdSize;
        private System.Windows.Forms.Label lbSellprdtype;
        private System.Windows.Forms.Label lbSellPrdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprdSellPrice;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbprdCompany;
        private System.Windows.Forms.TextBox txtprdCompany;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprdID;

    }
}
