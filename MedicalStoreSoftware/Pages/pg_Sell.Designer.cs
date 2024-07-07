namespace MedicalStoreSoftware.Pages
{
    partial class pg_Sell
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
            this.components = new System.ComponentModel.Container();
            this.lbSellTitle = new System.Windows.Forms.Label();
            this.lbSellPrdID = new System.Windows.Forms.Label();
            this.txtSell_prdID = new System.Windows.Forms.TextBox();
            this.lbSellPrdName = new System.Windows.Forms.Label();
            this.txtSell_prdName = new System.Windows.Forms.TextBox();
            this.lbSellprdPrice = new System.Windows.Forms.Label();
            this.txtSell_prdPrice = new System.Windows.Forms.TextBox();
            this.lbSellprdQuntity = new System.Windows.Forms.Label();
            this.dgvFilterPrd = new System.Windows.Forms.DataGridView();
            this.txtSell_totalPrd = new System.Windows.Forms.TextBox();
            this.lbSellTotalPrd = new System.Windows.Forms.Label();
            this.lbSelltotalbill = new System.Windows.Forms.Label();
            this.txtSell_totalBill = new System.Windows.Forms.TextBox();
            this.lbSelldiscunt = new System.Windows.Forms.Label();
            this.lbSellGivenAmount = new System.Windows.Forms.Label();
            this.lbSellreturnAmount = new System.Windows.Forms.Label();
            this.txtSell_returnAmount = new System.Windows.Forms.TextBox();
            this.nUP_prdQuantitr = new System.Windows.Forms.NumericUpDown();
            this.btnSell_prdAdd = new System.Windows.Forms.Button();
            this.btnSell_PrintBill = new System.Windows.Forms.Button();
            this.btnSellClear = new System.Windows.Forms.Button();
            this.lbprdSize = new System.Windows.Forms.Label();
            this.txtprdSize = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelSellprd = new System.Windows.Forms.Panel();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtGivenAmount = new System.Windows.Forms.TextBox();
            this.vsbProducts = new System.Windows.Forms.VScrollBar();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterPrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_prdQuantitr)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSellTitle
            // 
            this.lbSellTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSellTitle.AutoSize = true;
            this.lbSellTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSellTitle.Location = new System.Drawing.Point(639, 0);
            this.lbSellTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbSellTitle.Name = "lbSellTitle";
            this.lbSellTitle.Size = new System.Drawing.Size(260, 29);
            this.lbSellTitle.TabIndex = 0;
            this.lbSellTitle.Text = "BILLING PRODUCTS";
            this.lbSellTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSellPrdID
            // 
            this.lbSellPrdID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSellPrdID.AutoSize = true;
            this.lbSellPrdID.Location = new System.Drawing.Point(5, 70);
            this.lbSellPrdID.Name = "lbSellPrdID";
            this.lbSellPrdID.Size = new System.Drawing.Size(93, 20);
            this.lbSellPrdID.TabIndex = 2;
            this.lbSellPrdID.Text = "Product ID: ";
            // 
            // txtSell_prdID
            // 
            this.txtSell_prdID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSell_prdID.Location = new System.Drawing.Point(109, 67);
            this.txtSell_prdID.Name = "txtSell_prdID";
            this.txtSell_prdID.ReadOnly = true;
            this.txtSell_prdID.Size = new System.Drawing.Size(148, 26);
            this.txtSell_prdID.TabIndex = 3;
            // 
            // lbSellPrdName
            // 
            this.lbSellPrdName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSellPrdName.AutoSize = true;
            this.lbSellPrdName.Location = new System.Drawing.Point(297, 70);
            this.lbSellPrdName.Name = "lbSellPrdName";
            this.lbSellPrdName.Size = new System.Drawing.Size(118, 20);
            this.lbSellPrdName.TabIndex = 2;
            this.lbSellPrdName.Text = "Product Name: ";
            // 
            // txtSell_prdName
            // 
            this.txtSell_prdName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSell_prdName.Location = new System.Drawing.Point(423, 67);
            this.txtSell_prdName.Name = "txtSell_prdName";
            this.txtSell_prdName.Size = new System.Drawing.Size(251, 26);
            this.txtSell_prdName.TabIndex = 3;
            this.txtSell_prdName.TextChanged += new System.EventHandler(this.txtSell_prdName_TextChanged);
            // 
            // lbSellprdPrice
            // 
            this.lbSellprdPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSellprdPrice.AutoSize = true;
            this.lbSellprdPrice.Location = new System.Drawing.Point(1047, 70);
            this.lbSellprdPrice.Name = "lbSellprdPrice";
            this.lbSellprdPrice.Size = new System.Drawing.Size(113, 20);
            this.lbSellprdPrice.TabIndex = 2;
            this.lbSellprdPrice.Text = "Product Rrice: ";
            // 
            // txtSell_prdPrice
            // 
            this.txtSell_prdPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSell_prdPrice.Location = new System.Drawing.Point(1166, 67);
            this.txtSell_prdPrice.Name = "txtSell_prdPrice";
            this.txtSell_prdPrice.ReadOnly = true;
            this.txtSell_prdPrice.Size = new System.Drawing.Size(139, 26);
            this.txtSell_prdPrice.TabIndex = 3;
            // 
            // lbSellprdQuntity
            // 
            this.lbSellprdQuntity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSellprdQuntity.AutoSize = true;
            this.lbSellprdQuntity.Location = new System.Drawing.Point(778, 70);
            this.lbSellprdQuntity.Name = "lbSellprdQuntity";
            this.lbSellprdQuntity.Size = new System.Drawing.Size(135, 20);
            this.lbSellprdQuntity.TabIndex = 2;
            this.lbSellprdQuntity.Text = "Product Quantity: ";
            // 
            // dgvFilterPrd
            // 
            this.dgvFilterPrd.AllowUserToAddRows = false;
            this.dgvFilterPrd.AllowUserToDeleteRows = false;
            this.dgvFilterPrd.AllowUserToResizeColumns = false;
            this.dgvFilterPrd.AllowUserToResizeRows = false;
            this.dgvFilterPrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvFilterPrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilterPrd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFilterPrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilterPrd.Location = new System.Drawing.Point(9, 172);
            this.dgvFilterPrd.Name = "dgvFilterPrd";
            this.dgvFilterPrd.ReadOnly = true;
            this.dgvFilterPrd.RowHeadersVisible = false;
            this.dgvFilterPrd.RowTemplate.Height = 28;
            this.dgvFilterPrd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFilterPrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilterPrd.Size = new System.Drawing.Size(1508, 192);
            this.dgvFilterPrd.TabIndex = 4;
            this.dgvFilterPrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilterPrd_CellContentClick);
            // 
            // txtSell_totalPrd
            // 
            this.txtSell_totalPrd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSell_totalPrd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSell_totalPrd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSell_totalPrd.Location = new System.Drawing.Point(130, 689);
            this.txtSell_totalPrd.Name = "txtSell_totalPrd";
            this.txtSell_totalPrd.ReadOnly = true;
            this.txtSell_totalPrd.Size = new System.Drawing.Size(125, 26);
            this.txtSell_totalPrd.TabIndex = 6;
            // 
            // lbSellTotalPrd
            // 
            this.lbSellTotalPrd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSellTotalPrd.AutoSize = true;
            this.lbSellTotalPrd.Location = new System.Drawing.Point(5, 692);
            this.lbSellTotalPrd.Name = "lbSellTotalPrd";
            this.lbSellTotalPrd.Size = new System.Drawing.Size(119, 20);
            this.lbSellTotalPrd.TabIndex = 5;
            this.lbSellTotalPrd.Text = "Total Products: ";
            // 
            // lbSelltotalbill
            // 
            this.lbSelltotalbill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSelltotalbill.AutoSize = true;
            this.lbSelltotalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelltotalbill.Location = new System.Drawing.Point(1228, 688);
            this.lbSelltotalbill.Name = "lbSelltotalbill";
            this.lbSelltotalbill.Size = new System.Drawing.Size(124, 25);
            this.lbSelltotalbill.TabIndex = 2;
            this.lbSelltotalbill.Text = "TOTAL BILL";
            // 
            // txtSell_totalBill
            // 
            this.txtSell_totalBill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSell_totalBill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSell_totalBill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSell_totalBill.Enabled = false;
            this.txtSell_totalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSell_totalBill.Location = new System.Drawing.Point(1355, 676);
            this.txtSell_totalBill.Name = "txtSell_totalBill";
            this.txtSell_totalBill.ReadOnly = true;
            this.txtSell_totalBill.Size = new System.Drawing.Size(163, 44);
            this.txtSell_totalBill.TabIndex = 3;
            this.txtSell_totalBill.Text = "0";
            this.txtSell_totalBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSelldiscunt
            // 
            this.lbSelldiscunt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSelldiscunt.AutoSize = true;
            this.lbSelldiscunt.Location = new System.Drawing.Point(297, 692);
            this.lbSelldiscunt.Name = "lbSelldiscunt";
            this.lbSelldiscunt.Size = new System.Drawing.Size(76, 20);
            this.lbSelldiscunt.TabIndex = 7;
            this.lbSelldiscunt.Text = "Discount:";
            // 
            // lbSellGivenAmount
            // 
            this.lbSellGivenAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSellGivenAmount.AutoSize = true;
            this.lbSellGivenAmount.Location = new System.Drawing.Point(571, 692);
            this.lbSellGivenAmount.Name = "lbSellGivenAmount";
            this.lbSellGivenAmount.Size = new System.Drawing.Size(118, 20);
            this.lbSellGivenAmount.TabIndex = 7;
            this.lbSellGivenAmount.Text = "Given Amount: ";
            // 
            // lbSellreturnAmount
            // 
            this.lbSellreturnAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSellreturnAmount.AutoSize = true;
            this.lbSellreturnAmount.Location = new System.Drawing.Point(907, 692);
            this.lbSellreturnAmount.Name = "lbSellreturnAmount";
            this.lbSellreturnAmount.Size = new System.Drawing.Size(126, 20);
            this.lbSellreturnAmount.TabIndex = 7;
            this.lbSellreturnAmount.Text = "Return Amount: ";
            // 
            // txtSell_returnAmount
            // 
            this.txtSell_returnAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSell_returnAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSell_returnAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSell_returnAmount.Enabled = false;
            this.txtSell_returnAmount.Location = new System.Drawing.Point(1039, 689);
            this.txtSell_returnAmount.Name = "txtSell_returnAmount";
            this.txtSell_returnAmount.ReadOnly = true;
            this.txtSell_returnAmount.Size = new System.Drawing.Size(174, 26);
            this.txtSell_returnAmount.TabIndex = 8;
            // 
            // nUP_prdQuantitr
            // 
            this.nUP_prdQuantitr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nUP_prdQuantitr.Location = new System.Drawing.Point(929, 67);
            this.nUP_prdQuantitr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUP_prdQuantitr.Name = "nUP_prdQuantitr";
            this.nUP_prdQuantitr.Size = new System.Drawing.Size(63, 26);
            this.nUP_prdQuantitr.TabIndex = 9;
            this.nUP_prdQuantitr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSell_prdAdd
            // 
            this.btnSell_prdAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSell_prdAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSell_prdAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell_prdAdd.Location = new System.Drawing.Point(9, 129);
            this.btnSell_prdAdd.Name = "btnSell_prdAdd";
            this.btnSell_prdAdd.Size = new System.Drawing.Size(136, 39);
            this.btnSell_prdAdd.TabIndex = 10;
            this.btnSell_prdAdd.Text = "ADD";
            this.btnSell_prdAdd.UseVisualStyleBackColor = false;
            this.btnSell_prdAdd.Click += new System.EventHandler(this.btnSell_prdAdd_Click);
            // 
            // btnSell_PrintBill
            // 
            this.btnSell_PrintBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSell_PrintBill.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSell_PrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell_PrintBill.Enabled = false;
            this.btnSell_PrintBill.Location = new System.Drawing.Point(1239, 127);
            this.btnSell_PrintBill.Name = "btnSell_PrintBill";
            this.btnSell_PrintBill.Size = new System.Drawing.Size(136, 39);
            this.btnSell_PrintBill.TabIndex = 10;
            this.btnSell_PrintBill.Text = "PRINT BILL";
            this.btnSell_PrintBill.UseVisualStyleBackColor = false;
            this.btnSell_PrintBill.Click += new System.EventHandler(this.btnSell_PrintBill_Click);
            // 
            // btnSellClear
            // 
            this.btnSellClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSellClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSellClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSellClear.Enabled = false;
            this.btnSellClear.Location = new System.Drawing.Point(1381, 130);
            this.btnSellClear.Name = "btnSellClear";
            this.btnSellClear.Size = new System.Drawing.Size(136, 36);
            this.btnSellClear.TabIndex = 10;
            this.btnSellClear.Text = "CLEAR BILL";
            this.btnSellClear.UseVisualStyleBackColor = false;
            this.btnSellClear.Click += new System.EventHandler(this.btnSell_new_Click);
            // 
            // lbprdSize
            // 
            this.lbprdSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbprdSize.AutoSize = true;
            this.lbprdSize.Location = new System.Drawing.Point(1352, 70);
            this.lbprdSize.Name = "lbprdSize";
            this.lbprdSize.Size = new System.Drawing.Size(44, 20);
            this.lbprdSize.TabIndex = 2;
            this.lbprdSize.Text = "Size:";
            // 
            // txtprdSize
            // 
            this.txtprdSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtprdSize.Location = new System.Drawing.Point(1402, 67);
            this.txtprdSize.Name = "txtprdSize";
            this.txtprdSize.ReadOnly = true;
            this.txtprdSize.Size = new System.Drawing.Size(115, 26);
            this.txtprdSize.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lbTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1538, 50);
            this.panelHeader.TabIndex = 11;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(682, 5);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(175, 40);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "SELLING";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSellprd
            // 
            this.panelSellprd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelSellprd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelSellprd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSellprd.Location = new System.Drawing.Point(9, 361);
            this.panelSellprd.Name = "panelSellprd";
            this.panelSellprd.Padding = new System.Windows.Forms.Padding(5);
            this.panelSellprd.Size = new System.Drawing.Size(1508, 308);
            this.panelSellprd.TabIndex = 12;
            // 
            // txtDiscount
            // 
            this.txtDiscount.AcceptsReturn = true;
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDiscount.Location = new System.Drawing.Point(379, 689);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(125, 26);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // txtGivenAmount
            // 
            this.txtGivenAmount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtGivenAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGivenAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGivenAmount.Location = new System.Drawing.Point(695, 689);
            this.txtGivenAmount.Name = "txtGivenAmount";
            this.txtGivenAmount.Size = new System.Drawing.Size(174, 26);
            this.txtGivenAmount.TabIndex = 8;
            this.txtGivenAmount.TextChanged += new System.EventHandler(this.txtGivenAmount_TextChanged);
            // 
            // vsbProducts
            // 
            this.vsbProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vsbProducts.Location = new System.Drawing.Point(1511, 361);
            this.vsbProducts.Name = "vsbProducts";
            this.vsbProducts.Size = new System.Drawing.Size(15, 308);
            this.vsbProducts.TabIndex = 0;
            this.vsbProducts.Visible = false;
            this.vsbProducts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbProducts_Scroll);
            // 
            // pg_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.vsbProducts);
            this.Controls.Add(this.panelSellprd);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnSell_PrintBill);
            this.Controls.Add(this.btnSellClear);
            this.Controls.Add(this.btnSell_prdAdd);
            this.Controls.Add(this.nUP_prdQuantitr);
            this.Controls.Add(this.txtGivenAmount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtSell_returnAmount);
            this.Controls.Add(this.lbSellreturnAmount);
            this.Controls.Add(this.lbSellGivenAmount);
            this.Controls.Add(this.lbSelldiscunt);
            this.Controls.Add(this.txtSell_totalPrd);
            this.Controls.Add(this.lbSellTotalPrd);
            this.Controls.Add(this.dgvFilterPrd);
            this.Controls.Add(this.txtSell_totalBill);
            this.Controls.Add(this.txtprdSize);
            this.Controls.Add(this.txtSell_prdPrice);
            this.Controls.Add(this.txtSell_prdName);
            this.Controls.Add(this.lbSelltotalbill);
            this.Controls.Add(this.lbSellprdQuntity);
            this.Controls.Add(this.lbprdSize);
            this.Controls.Add(this.lbSellprdPrice);
            this.Controls.Add(this.lbSellPrdName);
            this.Controls.Add(this.txtSell_prdID);
            this.Controls.Add(this.lbSellPrdID);
            this.Controls.Add(this.lbSellTitle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "pg_Sell";
            this.Size = new System.Drawing.Size(1538, 731);
            this.Load += new System.EventHandler(this.pg_Sell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilterPrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_prdQuantitr)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSellTitle;
        private System.Windows.Forms.Label lbSellPrdID;
        private System.Windows.Forms.TextBox txtSell_prdID;
        private System.Windows.Forms.Label lbSellPrdName;
        private System.Windows.Forms.TextBox txtSell_prdName;
        private System.Windows.Forms.Label lbSellprdPrice;
        private System.Windows.Forms.TextBox txtSell_prdPrice;
        private System.Windows.Forms.Label lbSellprdQuntity;
        private System.Windows.Forms.DataGridView dgvFilterPrd;
        private System.Windows.Forms.TextBox txtSell_totalPrd;
        private System.Windows.Forms.Label lbSellTotalPrd;
        private System.Windows.Forms.Label lbSelltotalbill;
        private System.Windows.Forms.TextBox txtSell_totalBill;
        private System.Windows.Forms.Label lbSelldiscunt;
        private System.Windows.Forms.Label lbSellGivenAmount;
        private System.Windows.Forms.Label lbSellreturnAmount;
        private System.Windows.Forms.TextBox txtSell_returnAmount;
        private System.Windows.Forms.NumericUpDown nUP_prdQuantitr;
        private System.Windows.Forms.Button btnSell_prdAdd;
        private System.Windows.Forms.Button btnSell_PrintBill;
        private System.Windows.Forms.Button btnSellClear;
        private System.Windows.Forms.Label lbprdSize;
        private System.Windows.Forms.TextBox txtprdSize;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelSellprd;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtGivenAmount;
        private System.Windows.Forms.VScrollBar vsbProducts;
        private System.Windows.Forms.BindingSource productsBindingSource;

    }
}
