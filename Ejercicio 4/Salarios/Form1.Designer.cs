namespace Salarios
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
            this.lblSellings = new System.Windows.Forms.Label();
            this.tbSellings = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.lbSummary = new System.Windows.Forms.ListBox();
            this.btnShowSummary = new System.Windows.Forms.Button();
            this.btnAddSell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSellings
            // 
            this.lblSellings.AutoSize = true;
            this.lblSellings.Location = new System.Drawing.Point(35, 34);
            this.lblSellings.Name = "lblSellings";
            this.lblSellings.Size = new System.Drawing.Size(85, 13);
            this.lblSellings.TabIndex = 0;
            this.lblSellings.Text = "Ventas en bruto:";
            // 
            // tbSellings
            // 
            this.tbSellings.Location = new System.Drawing.Point(131, 31);
            this.tbSellings.Name = "tbSellings";
            this.tbSellings.Size = new System.Drawing.Size(134, 20);
            this.tbSellings.TabIndex = 1;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(63, 167);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(98, 13);
            this.lblAdd.TabIndex = 4;
            this.lblAdd.Text = "Agregue una venta";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(194, 167);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(89, 13);
            this.lblShow.TabIndex = 5;
            this.lblShow.Text = "Mostrar el reporte";
            // 
            // lbSummary
            // 
            this.lbSummary.FormattingEnabled = true;
            this.lbSummary.Location = new System.Drawing.Point(60, 201);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.Size = new System.Drawing.Size(222, 186);
            this.lbSummary.TabIndex = 6;
            // 
            // btnShowSummary
            // 
            this.btnShowSummary.Image = global::Salarios.Properties.Resources.document_summary_report_report_analysis_icon_263005;
            this.btnShowSummary.Location = new System.Drawing.Point(197, 81);
            this.btnShowSummary.Name = "btnShowSummary";
            this.btnShowSummary.Size = new System.Drawing.Size(80, 75);
            this.btnShowSummary.TabIndex = 3;
            this.btnShowSummary.Text = " ";
            this.btnShowSummary.UseVisualStyleBackColor = true;
            this.btnShowSummary.Click += new System.EventHandler(this.btnShowSummary_Click);
            // 
            // btnAddSell
            // 
            this.btnAddSell.Image = global::Salarios.Properties.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335;
            this.btnAddSell.Location = new System.Drawing.Point(72, 81);
            this.btnAddSell.Name = "btnAddSell";
            this.btnAddSell.Size = new System.Drawing.Size(79, 75);
            this.btnAddSell.TabIndex = 2;
            this.btnAddSell.Text = " ";
            this.btnAddSell.UseVisualStyleBackColor = true;
            this.btnAddSell.Click += new System.EventHandler(this.btnAddSell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 440);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnShowSummary);
            this.Controls.Add(this.btnAddSell);
            this.Controls.Add(this.tbSellings);
            this.Controls.Add(this.lblSellings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSellings;
        private System.Windows.Forms.TextBox tbSellings;
        private System.Windows.Forms.Button btnAddSell;
        private System.Windows.Forms.Button btnShowSummary;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.ListBox lbSummary;
    }
}

