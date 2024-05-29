namespace Nesneye_Dayali_Programlama_Proje
{
    partial class Form1menu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1menu));
            this.btn1randevu = new System.Windows.Forms.Button();
            this.btn2islem = new System.Windows.Forms.Button();
            this.btn3calisan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1randevu
            // 
            this.btn1randevu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1randevu.BackgroundImage")));
            this.btn1randevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1randevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1randevu.ForeColor = System.Drawing.Color.Red;
            this.btn1randevu.Location = new System.Drawing.Point(101, 343);
            this.btn1randevu.Name = "btn1randevu";
            this.btn1randevu.Size = new System.Drawing.Size(257, 93);
            this.btn1randevu.TabIndex = 0;
            this.btn1randevu.Text = "Randevular";
            this.btn1randevu.UseVisualStyleBackColor = true;
            this.btn1randevu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn2islem
            // 
            this.btn2islem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn2islem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2islem.BackgroundImage")));
            this.btn2islem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2islem.ForeColor = System.Drawing.Color.Red;
            this.btn2islem.Location = new System.Drawing.Point(445, 343);
            this.btn2islem.Name = "btn2islem";
            this.btn2islem.Size = new System.Drawing.Size(257, 93);
            this.btn2islem.TabIndex = 1;
            this.btn2islem.Text = "İşlemler";
            this.btn2islem.UseVisualStyleBackColor = true;
            this.btn2islem.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3calisan
            // 
            this.btn3calisan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3calisan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3calisan.BackgroundImage")));
            this.btn3calisan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3calisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3calisan.ForeColor = System.Drawing.Color.Red;
            this.btn3calisan.Location = new System.Drawing.Point(773, 343);
            this.btn3calisan.Name = "btn3calisan";
            this.btn3calisan.Size = new System.Drawing.Size(258, 93);
            this.btn3calisan.TabIndex = 1;
            this.btn3calisan.Text = "Çalışanlar";
            this.btn3calisan.UseVisualStyleBackColor = true;
            this.btn3calisan.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1005, 79);
            this.label1.TabIndex = 2;
            this.label1.Text = "KUAFÖR VEDAT GÜZELLİK SALONU";
            // 
            // Form1menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3calisan);
            this.Controls.Add(this.btn2islem);
            this.Controls.Add(this.btn1randevu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KUAFÖR VEDAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1randevu;
        private System.Windows.Forms.Button btn2islem;
        private System.Windows.Forms.Button btn3calisan;
        private System.Windows.Forms.Label label1;
    }
}

