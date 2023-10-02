namespace Kar_Hesaplama
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
            this.lblAlısfiyatı = new System.Windows.Forms.Label();
            this.lblSatisfiyat = new System.Windows.Forms.Label();
            this.lblToplamkar = new System.Windows.Forms.Label();
            this.txtAlisfiyat = new System.Windows.Forms.TextBox();
            this.txtSatisfiyati = new System.Windows.Forms.TextBox();
            this.btnKarhesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlısfiyatı
            // 
            this.lblAlısfiyatı.AutoSize = true;
            this.lblAlısfiyatı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlısfiyatı.Location = new System.Drawing.Point(35, 69);
            this.lblAlısfiyatı.Name = "lblAlısfiyatı";
            this.lblAlısfiyatı.Size = new System.Drawing.Size(68, 15);
            this.lblAlısfiyatı.TabIndex = 0;
            this.lblAlısfiyatı.Text = "Alış Fiyat:";
            // 
            // lblSatisfiyat
            // 
            this.lblSatisfiyat.AutoSize = true;
            this.lblSatisfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisfiyat.Location = new System.Drawing.Point(34, 102);
            this.lblSatisfiyat.Name = "lblSatisfiyat";
            this.lblSatisfiyat.Size = new System.Drawing.Size(77, 15);
            this.lblSatisfiyat.TabIndex = 1;
            this.lblSatisfiyat.Text = "Satış Fiyat:";
            // 
            // lblToplamkar
            // 
            this.lblToplamkar.AutoSize = true;
            this.lblToplamkar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamkar.Location = new System.Drawing.Point(35, 237);
            this.lblToplamkar.Name = "lblToplamkar";
            this.lblToplamkar.Size = new System.Drawing.Size(85, 15);
            this.lblToplamkar.TabIndex = 2;
            this.lblToplamkar.Text = "Toplam Kar:";
            // 
            // txtAlisfiyat
            // 
            this.txtAlisfiyat.Location = new System.Drawing.Point(107, 69);
            this.txtAlisfiyat.Name = "txtAlisfiyat";
            this.txtAlisfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtAlisfiyat.TabIndex = 3;
            // 
            // txtSatisfiyati
            // 
            this.txtSatisfiyati.Location = new System.Drawing.Point(107, 101);
            this.txtSatisfiyati.Name = "txtSatisfiyati";
            this.txtSatisfiyati.Size = new System.Drawing.Size(100, 20);
            this.txtSatisfiyati.TabIndex = 4;
            // 
            // btnKarhesapla
            // 
            this.btnKarhesapla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKarhesapla.Location = new System.Drawing.Point(107, 160);
            this.btnKarhesapla.Name = "btnKarhesapla";
            this.btnKarhesapla.Size = new System.Drawing.Size(100, 45);
            this.btnKarhesapla.TabIndex = 5;
            this.btnKarhesapla.Text = "Kar Hesapla";
            this.btnKarhesapla.UseVisualStyleBackColor = false;
            this.btnKarhesapla.Click += new System.EventHandler(this.btnKarhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(259, 293);
            this.Controls.Add(this.btnKarhesapla);
            this.Controls.Add(this.txtSatisfiyati);
            this.Controls.Add(this.txtAlisfiyat);
            this.Controls.Add(this.lblToplamkar);
            this.Controls.Add(this.lblSatisfiyat);
            this.Controls.Add(this.lblAlısfiyatı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlısfiyatı;
        private System.Windows.Forms.Label lblSatisfiyat;
        private System.Windows.Forms.Label lblToplamkar;
        private System.Windows.Forms.TextBox txtAlisfiyat;
        private System.Windows.Forms.TextBox txtSatisfiyati;
        private System.Windows.Forms.Button btnKarhesapla;
    }
}

