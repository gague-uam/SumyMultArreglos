namespace TiroDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lbSumCount = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Location = new System.Drawing.Point(44, 53);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(68, 13);
            this.lblDice1.TabIndex = 0;
            this.lblDice1.Text = "Primer Dado:";
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Location = new System.Drawing.Point(241, 53);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(82, 13);
            this.lblDice2.TabIndex = 1;
            this.lblDice2.Text = "Segundo Dado:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(152, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultados";
            // 
            // btnRoll
            // 
            this.btnRoll.Image = ((System.Drawing.Image)(resources.GetObject("btnRoll.Image")));
            this.btnRoll.Location = new System.Drawing.Point(123, 140);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(121, 46);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lbSumCount
            // 
            this.lbSumCount.FormattingEnabled = true;
            this.lbSumCount.Location = new System.Drawing.Point(46, 202);
            this.lbSumCount.Name = "lbSumCount";
            this.lbSumCount.Size = new System.Drawing.Size(306, 147);
            this.lbSumCount.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 362);
            this.Controls.Add(this.lbSumCount);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.ListBox lbSumCount;
    }
}

