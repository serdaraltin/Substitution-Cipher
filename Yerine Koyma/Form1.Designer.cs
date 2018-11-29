namespace Yerine_Koyma
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
            this.label1 = new System.Windows.Forms.Label();
            this.tx_anahtar = new System.Windows.Forms.TextBox();
            this.btn_anahtarolustur = new System.Windows.Forms.Button();
            this.tx_acikmesaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_sirelimesaj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anahtar (key) :";
            // 
            // tx_anahtar
            // 
            this.tx_anahtar.Location = new System.Drawing.Point(94, 11);
            this.tx_anahtar.Name = "tx_anahtar";
            this.tx_anahtar.Size = new System.Drawing.Size(175, 20);
            this.tx_anahtar.TabIndex = 1;
            // 
            // btn_anahtarolustur
            // 
            this.btn_anahtarolustur.Location = new System.Drawing.Point(275, 9);
            this.btn_anahtarolustur.Name = "btn_anahtarolustur";
            this.btn_anahtarolustur.Size = new System.Drawing.Size(106, 23);
            this.btn_anahtarolustur.TabIndex = 2;
            this.btn_anahtarolustur.Text = "Anahtar Oluştur";
            this.btn_anahtarolustur.UseVisualStyleBackColor = true;
            this.btn_anahtarolustur.Click += new System.EventHandler(this.btn_anahtarolustur_Click);
            // 
            // tx_acikmesaj
            // 
            this.tx_acikmesaj.Location = new System.Drawing.Point(145, 37);
            this.tx_acikmesaj.Name = "tx_acikmesaj";
            this.tx_acikmesaj.Size = new System.Drawing.Size(124, 20);
            this.tx_acikmesaj.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Açık Mesaj (plain text) :";
            // 
            // tx_sirelimesaj
            // 
            this.tx_sirelimesaj.Location = new System.Drawing.Point(145, 63);
            this.tx_sirelimesaj.Multiline = true;
            this.tx_sirelimesaj.Name = "tx_sirelimesaj";
            this.tx_sirelimesaj.Size = new System.Drawing.Size(236, 50);
            this.tx_sirelimesaj.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifreli Mesaj (cipher text) :";
            // 
            // btn_sifrele
            // 
            this.btn_sifrele.Location = new System.Drawing.Point(275, 35);
            this.btn_sifrele.Name = "btn_sifrele";
            this.btn_sifrele.Size = new System.Drawing.Size(106, 23);
            this.btn_sifrele.TabIndex = 7;
            this.btn_sifrele.Text = "Şifrele";
            this.btn_sifrele.UseVisualStyleBackColor = true;
            this.btn_sifrele.Click += new System.EventHandler(this.btn_sifrele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 124);
            this.Controls.Add(this.btn_sifrele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_sirelimesaj);
            this.Controls.Add(this.tx_acikmesaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_anahtarolustur);
            this.Controls.Add(this.tx_anahtar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_anahtar;
        private System.Windows.Forms.Button btn_anahtarolustur;
        private System.Windows.Forms.TextBox tx_acikmesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_sirelimesaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sifrele;
    }
}

