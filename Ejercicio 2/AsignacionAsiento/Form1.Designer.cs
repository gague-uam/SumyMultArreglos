namespace AsignacionAsiento
{
    partial class AsignarAsientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarAsientos));
            this.lblSelect = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbSmoke = new System.Windows.Forms.RadioButton();
            this.rdbNoSmoke = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblBoard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(43, 19);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(203, 13);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Seleccione el asiento en el que abordará:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rdbSmoke
            // 
            this.rdbSmoke.AutoSize = true;
            this.rdbSmoke.Location = new System.Drawing.Point(113, 75);
            this.rdbSmoke.Name = "rdbSmoke";
            this.rdbSmoke.Size = new System.Drawing.Size(103, 17);
            this.rdbSmoke.TabIndex = 2;
            this.rdbSmoke.TabStop = true;
            this.rdbSmoke.Text = "Area para Fumar";
            this.rdbSmoke.UseVisualStyleBackColor = true;
            // 
            // rdbNoSmoke
            // 
            this.rdbNoSmoke.AutoSize = true;
            this.rdbNoSmoke.Location = new System.Drawing.Point(113, 146);
            this.rdbNoSmoke.Name = "rdbNoSmoke";
            this.rdbNoSmoke.Size = new System.Drawing.Size(113, 17);
            this.rdbNoSmoke.TabIndex = 4;
            this.rdbNoSmoke.TabStop = true;
            this.rdbNoSmoke.Text = "Area libre de humo";
            this.rdbNoSmoke.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 65);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(82, 219);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(116, 40);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Asignar Asiento";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblBoard
            // 
            this.lblBoard.AutoSize = true;
            this.lblBoard.Location = new System.Drawing.Point(31, 270);
            this.lblBoard.Name = "lblBoard";
            this.lblBoard.Size = new System.Drawing.Size(0, 13);
            this.lblBoard.TabIndex = 6;
            // 
            // AsignarAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 310);
            this.Controls.Add(this.lblBoard);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.rdbNoSmoke);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rdbSmoke);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSelect);
            this.Name = "AsignarAsientos";
            this.Text = "Asignacion de Asientos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbSmoke;
        private System.Windows.Forms.RadioButton rdbNoSmoke;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblBoard;
    }
}

