namespace MedicalStoreSoftware.Pages
{
    partial class UpdateStoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStoc));
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.NUD_Quantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(50, 61);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(97, 20);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Medicine ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(214, 58);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(313, 26);
            this.txtID.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(194, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(189, 22);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "UPDATE MEDICINE";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(50, 106);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(122, 20);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Medicine Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 103);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(313, 26);
            this.txtName.TabIndex = 0;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(50, 151);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(115, 20);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "Medicine Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(214, 148);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(313, 26);
            this.txtPrice.TabIndex = 1;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(50, 196);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(139, 20);
            this.lbQuantity.TabIndex = 0;
            this.lbQuantity.Text = "Medicine Quantity:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Location = new System.Drawing.Point(387, 381);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 43);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(214, 283);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(313, 26);
            this.txtType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(214, 328);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(313, 26);
            this.txtCompany.TabIndex = 1;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(51, 241);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(111, 20);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Medicine Size:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(214, 238);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(313, 26);
            this.txtSize.TabIndex = 1;
            // 
            // NUD_Quantity
            // 
            this.NUD_Quantity.Location = new System.Drawing.Point(214, 194);
            this.NUD_Quantity.Name = "NUD_Quantity";
            this.NUD_Quantity.Size = new System.Drawing.Size(313, 26);
            this.NUD_Quantity.TabIndex = 3;
            // 
            // UpdateStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 436);
            this.Controls.Add(this.NUD_Quantity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "UpdateStoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateStock";
            this.Load += new System.EventHandler(this.UpdateStoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.NumericUpDown NUD_Quantity;
    }
}