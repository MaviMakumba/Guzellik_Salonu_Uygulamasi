namespace Nesneye_Dayali_Programlama_Proje
{
    partial class Form2randevu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2randevu));
            this.radioButton1erkek = new System.Windows.Forms.RadioButton();
            this.radioButton2kadin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2soyad = new System.Windows.Forms.TextBox();
            this.textBox3yas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1islem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1tarih = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1randevuayarla = new System.Windows.Forms.Button();
            this.listBox1randevular = new System.Windows.Forms.ListBox();
            this.button2randevusil = new System.Windows.Forms.Button();
            this.button3randevuduzenle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1erkek
            // 
            this.radioButton1erkek.AutoSize = true;
            this.radioButton1erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1erkek.ForeColor = System.Drawing.Color.Blue;
            this.radioButton1erkek.Location = new System.Drawing.Point(133, 79);
            this.radioButton1erkek.Name = "radioButton1erkek";
            this.radioButton1erkek.Size = new System.Drawing.Size(77, 26);
            this.radioButton1erkek.TabIndex = 0;
            this.radioButton1erkek.TabStop = true;
            this.radioButton1erkek.Text = "Erkek";
            this.radioButton1erkek.UseVisualStyleBackColor = true;
            // 
            // radioButton2kadin
            // 
            this.radioButton2kadin.AutoSize = true;
            this.radioButton2kadin.BackColor = System.Drawing.Color.IndianRed;
            this.radioButton2kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2kadin.ForeColor = System.Drawing.Color.Fuchsia;
            this.radioButton2kadin.Location = new System.Drawing.Point(234, 79);
            this.radioButton2kadin.Name = "radioButton2kadin";
            this.radioButton2kadin.Size = new System.Drawing.Size(77, 26);
            this.radioButton2kadin.TabIndex = 1;
            this.radioButton2kadin.TabStop = true;
            this.radioButton2kadin.Text = "Kadın";
            this.radioButton2kadin.UseVisualStyleBackColor = false;
            this.radioButton2kadin.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Randevu Oluştur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cinsiyet";
            // 
            // textBox1ad
            // 
            this.textBox1ad.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1ad.Location = new System.Drawing.Point(121, 124);
            this.textBox1ad.Name = "textBox1ad";
            this.textBox1ad.Size = new System.Drawing.Size(200, 22);
            this.textBox1ad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad";
            // 
            // textBox2soyad
            // 
            this.textBox2soyad.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2soyad.Location = new System.Drawing.Point(121, 166);
            this.textBox2soyad.Name = "textBox2soyad";
            this.textBox2soyad.Size = new System.Drawing.Size(200, 22);
            this.textBox2soyad.TabIndex = 4;
            // 
            // textBox3yas
            // 
            this.textBox3yas.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3yas.Location = new System.Drawing.Point(121, 209);
            this.textBox3yas.Name = "textBox3yas";
            this.textBox3yas.Size = new System.Drawing.Size(200, 22);
            this.textBox3yas.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Yaş";
            // 
            // textBox4tel
            // 
            this.textBox4tel.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4tel.Location = new System.Drawing.Point(121, 259);
            this.textBox4tel.Name = "textBox4tel";
            this.textBox4tel.Size = new System.Drawing.Size(200, 22);
            this.textBox4tel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefon No";
            // 
            // comboBox1islem
            // 
            this.comboBox1islem.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1islem.FormattingEnabled = true;
            this.comboBox1islem.Location = new System.Drawing.Point(121, 312);
            this.comboBox1islem.Name = "comboBox1islem";
            this.comboBox1islem.Size = new System.Drawing.Size(200, 24);
            this.comboBox1islem.TabIndex = 5;
            this.comboBox1islem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "İşlem";
            // 
            // dateTimePicker1tarih
            // 
            this.dateTimePicker1tarih.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1tarih.Location = new System.Drawing.Point(121, 364);
            this.dateTimePicker1tarih.Name = "dateTimePicker1tarih";
            this.dateTimePicker1tarih.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1tarih.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tarih";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(592, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 40);
            this.label9.TabIndex = 2;
            this.label9.Text = "Randevu Görüntüle";
            // 
            // button1randevuayarla
            // 
            this.button1randevuayarla.BackColor = System.Drawing.Color.Coral;
            this.button1randevuayarla.Location = new System.Drawing.Point(23, 425);
            this.button1randevuayarla.Name = "button1randevuayarla";
            this.button1randevuayarla.Size = new System.Drawing.Size(125, 90);
            this.button1randevuayarla.TabIndex = 8;
            this.button1randevuayarla.Text = "Randevu Ayarla";
            this.button1randevuayarla.UseVisualStyleBackColor = false;
            this.button1randevuayarla.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1randevular
            // 
            this.listBox1randevular.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1randevular.FormattingEnabled = true;
            this.listBox1randevular.ItemHeight = 16;
            this.listBox1randevular.Location = new System.Drawing.Point(470, 79);
            this.listBox1randevular.Name = "listBox1randevular";
            this.listBox1randevular.Size = new System.Drawing.Size(610, 436);
            this.listBox1randevular.TabIndex = 9;
            // 
            // button2randevusil
            // 
            this.button2randevusil.BackColor = System.Drawing.Color.Gold;
            this.button2randevusil.Location = new System.Drawing.Point(170, 425);
            this.button2randevusil.Name = "button2randevusil";
            this.button2randevusil.Size = new System.Drawing.Size(125, 90);
            this.button2randevusil.TabIndex = 10;
            this.button2randevusil.Text = "Randevu Sil";
            this.button2randevusil.UseVisualStyleBackColor = false;
            this.button2randevusil.Click += new System.EventHandler(this.button2randevusil_Click_1);
            // 
            // button3randevuduzenle
            // 
            this.button3randevuduzenle.BackColor = System.Drawing.Color.Olive;
            this.button3randevuduzenle.Location = new System.Drawing.Point(317, 425);
            this.button3randevuduzenle.Name = "button3randevuduzenle";
            this.button3randevuduzenle.Size = new System.Drawing.Size(125, 90);
            this.button3randevuduzenle.TabIndex = 11;
            this.button3randevuduzenle.Text = "Randevu Düzenle";
            this.button3randevuduzenle.UseVisualStyleBackColor = false;
            this.button3randevuduzenle.Click += new System.EventHandler(this.button3randevuduzenle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Location = new System.Drawing.Point(341, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2randevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3randevuduzenle);
            this.Controls.Add(this.button2randevusil);
            this.Controls.Add(this.listBox1randevular);
            this.Controls.Add(this.button1randevuayarla);
            this.Controls.Add(this.dateTimePicker1tarih);
            this.Controls.Add(this.comboBox1islem);
            this.Controls.Add(this.textBox4tel);
            this.Controls.Add(this.textBox3yas);
            this.Controls.Add(this.textBox2soyad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1ad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2kadin);
            this.Controls.Add(this.radioButton1erkek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2randevu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2randevu";
            this.Load += new System.EventHandler(this.Form2randevu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1erkek;
        private System.Windows.Forms.RadioButton radioButton2kadin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2soyad;
        private System.Windows.Forms.TextBox textBox3yas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1islem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1tarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1randevuayarla;
        private System.Windows.Forms.ListBox listBox1randevular;
        private System.Windows.Forms.Button button2randevusil;
        private System.Windows.Forms.Button button3randevuduzenle;
        private System.Windows.Forms.Button button1;
    }
}