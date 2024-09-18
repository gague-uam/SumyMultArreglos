namespace Vendedores
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
            this.lblShow = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lbSummary = new System.Windows.Forms.ListBox();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.tbSell = new System.Windows.Forms.TextBox();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.tbSeller = new System.Windows.Forms.TextBox();
            this.btnShowSummary = new System.Windows.Forms.Button();
            this.btnAddSell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(178, 192);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(83, 13);
            this.lblShow.TabIndex = 22;
            this.lblShow.Text = "Mostrar Reporte";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(66, 192);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(75, 13);
            this.lblAdd.TabIndex = 21;
            this.lblAdd.Text = "Agregar Venta";
            // 
            // lbSummary
            // 
            this.lbSummary.FormattingEnabled = true;
            this.lbSummary.Location = new System.Drawing.Point(40, 221);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(300, 199);
            this.lbSummary.TabIndex = 20;
            // 
            // lblSell
            // 
            this.lblSell.AutoSize = true;
            this.lblSell.Location = new System.Drawing.Point(40, 111);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(82, 13);
            this.lblSell.TabIndex = 17;
            this.lblSell.Text = "Monto de venta";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(40, 71);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(71, 13);
            this.lblProduct.TabIndex = 16;
            this.lblProduct.Text = "Producto(1-5)";
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Location = new System.Drawing.Point(40, 31);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(74, 13);
            this.lblSeller.TabIndex = 15;
            this.lblSeller.Text = "Vendedor(1-4)";
            // 
            // tbSell
            // 
            this.tbSell.Location = new System.Drawing.Point(130, 111);
            this.tbSell.Name = "tbSell";
            this.tbSell.Size = new System.Drawing.Size(100, 20);
            this.tbSell.TabIndex = 14;
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(130, 71);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(100, 20);
            this.tbProduct.TabIndex = 13;
            // 
            // tbSeller
            // 
            this.tbSeller.Location = new System.Drawing.Point(130, 31);
            this.tbSeller.Name = "tbSeller";
            this.tbSeller.Size = new System.Drawing.Size(100, 20);
            this.tbSeller.TabIndex = 12;
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.Image = global::Vendedores.Properties.Resources.document_summary_report_report_analysis_icon_263005;
            this.btnShowSummary.Location = new System.Drawing.Point(191, 151);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(56, 38);
            this.btnShowSummary.TabIndex = 19;
            this.btnShowSummary.UseVisualStyleBackColor = true;
            this.btnShowSummary.Click += new System.EventHandler(this.btnShowSummary_Click);
            // 
            // btnAddSell
            // 
            this.btnAddSell.Image = global::Vendedores.Properties.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335;
            this.btnAddSell.Location = new System.Drawing.Point(78, 151);
            this.btnAddSell.Name = "btnAddSell";
            this.btnAddSell.Size = new System.Drawing.Size(53, 38);
            this.btnAddSell.TabIndex = 18;
            this.btnAddSell.UseVisualStyleBackColor = true;
            this.btnAddSell.Click += new System.EventHandler(this.btnAddSell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.btnShowSummary);
            this.Controls.Add(this.btnAddSell);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.tbSell);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.tbSeller);
            this.Name = "Form1";
            this.Text = "Producto y Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.ListBox lbSummary;
        private System.Windows.Forms.Button btnShowSummary;
        private System.Windows.Forms.Button btnAddSell;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.TextBox tbSell;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.TextBox tbSeller;
    }
}

