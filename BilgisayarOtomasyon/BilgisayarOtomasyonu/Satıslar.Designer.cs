
namespace BilgisayarOtomasyonu
{
    partial class Satıslar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satıslar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ana = new System.Windows.Forms.Button();
            this.stok = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urun = new System.Windows.Forms.TextBox();
            this.urnadet = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.kategori = new System.Windows.Forms.TextBox();
            this.kod = new System.Windows.Forms.TextBox();
            this.müsteri = new System.Windows.Forms.ComboBox();
            this.stsonay = new System.Windows.Forms.Button();
            this.kodlabel = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.urunfoto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ana);
            this.groupBox2.Controls.Add(this.stok);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.urun);
            this.groupBox2.Controls.Add(this.urnadet);
            this.groupBox2.Controls.Add(this.marka);
            this.groupBox2.Controls.Add(this.kategori);
            this.groupBox2.Controls.Add(this.kod);
            this.groupBox2.Controls.Add(this.müsteri);
            this.groupBox2.Controls.Add(this.stsonay);
            this.groupBox2.Controls.Add(this.kodlabel);
            this.groupBox2.Controls.Add(this.adres);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fiyat);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.urunfoto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 421);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SATIŞ SEKMESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(734, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Adet";
            // 
            // ana
            // 
            this.ana.BackColor = System.Drawing.Color.Thistle;
            this.ana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ana.BackgroundImage")));
            this.ana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ana.Location = new System.Drawing.Point(6, 364);
            this.ana.Name = "ana";
            this.ana.Size = new System.Drawing.Size(62, 51);
            this.ana.TabIndex = 45;
            this.ana.UseVisualStyleBackColor = false;
            this.ana.Click += new System.EventHandler(this.ana_Click);
            // 
            // stok
            // 
            this.stok.AutoSize = true;
            this.stok.Location = new System.Drawing.Point(648, 242);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(24, 25);
            this.stok.TabIndex = 32;
            this.stok.Text = "0";
            this.stok.Click += new System.EventHandler(this.stok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Stok Sayısı:";
            // 
            // urun
            // 
            this.urun.Enabled = false;
            this.urun.Location = new System.Drawing.Point(195, 158);
            this.urun.Name = "urun";
            this.urun.Size = new System.Drawing.Size(188, 30);
            this.urun.TabIndex = 30;
            // 
            // urnadet
            // 
            this.urnadet.Location = new System.Drawing.Point(195, 237);
            this.urnadet.Name = "urnadet";
            this.urnadet.Size = new System.Drawing.Size(188, 30);
            this.urnadet.TabIndex = 29;
            // 
            // marka
            // 
            this.marka.Enabled = false;
            this.marka.Location = new System.Drawing.Point(195, 120);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(188, 30);
            this.marka.TabIndex = 28;
            this.marka.TextChanged += new System.EventHandler(this.marka_TextChanged);
            // 
            // kategori
            // 
            this.kategori.Enabled = false;
            this.kategori.Location = new System.Drawing.Point(195, 82);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(188, 30);
            this.kategori.TabIndex = 27;
            this.kategori.TextChanged += new System.EventHandler(this.kategori_TextChanged);
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(195, 44);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(188, 30);
            this.kod.TabIndex = 24;
            this.kod.TextChanged += new System.EventHandler(this.kod_TextChanged);
            // 
            // müsteri
            // 
            this.müsteri.FormattingEnabled = true;
            this.müsteri.Location = new System.Drawing.Point(195, 196);
            this.müsteri.Name = "müsteri";
            this.müsteri.Size = new System.Drawing.Size(188, 33);
            this.müsteri.TabIndex = 23;
            this.müsteri.SelectedIndexChanged += new System.EventHandler(this.müsteri_SelectedIndexChanged);
            // 
            // stsonay
            // 
            this.stsonay.BackColor = System.Drawing.Color.Thistle;
            this.stsonay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stsonay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.stsonay.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.stsonay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.stsonay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.stsonay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsonay.Location = new System.Drawing.Point(607, 356);
            this.stsonay.Name = "stsonay";
            this.stsonay.Size = new System.Drawing.Size(160, 59);
            this.stsonay.TabIndex = 21;
            this.stsonay.Text = "Satışı Onayla";
            this.stsonay.UseVisualStyleBackColor = false;
            this.stsonay.Click += new System.EventHandler(this.stsonay_Click);
            // 
            // kodlabel
            // 
            this.kodlabel.AutoSize = true;
            this.kodlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodlabel.Location = new System.Drawing.Point(63, 44);
            this.kodlabel.Name = "kodlabel";
            this.kodlabel.Size = new System.Drawing.Size(116, 24);
            this.kodlabel.TabIndex = 19;
            this.kodlabel.Text = "Ürün Kodu:";
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(195, 273);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(188, 81);
            this.adres.TabIndex = 15;
            this.adres.Text = "";
            this.adres.TextChanged += new System.EventHandler(this.adres_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adres Bilgisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(57, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürün Adedi:";
            // 
            // fiyat
            // 
            this.fiyat.AutoSize = true;
            this.fiyat.Location = new System.Drawing.Point(648, 217);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(30, 25);
            this.fiyat.TabIndex = 11;
            this.fiyat.Text = "0 ";
            this.fiyat.Click += new System.EventHandler(this.fiyat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ürün Fiyatı: ";
            // 
            // urunfoto
            // 
            this.urunfoto.ErrorImage = null;
            this.urunfoto.Location = new System.Drawing.Point(504, 39);
            this.urunfoto.Name = "urunfoto";
            this.urunfoto.Size = new System.Drawing.Size(263, 167);
            this.urunfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.urunfoto.TabIndex = 8;
            this.urunfoto.TabStop = false;
            this.urunfoto.Click += new System.EventHandler(this.urunfoto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(44, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ürün Seçiniz:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(21, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Müşteri Seçiniz:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(33, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Marka Seçiniz:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kategori Seçiniz:";
            // 
            // Satıslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(798, 445);
            this.Controls.Add(this.groupBox2);
            this.Name = "Satıslar";
            this.Text = "Satıslar";
            this.Load += new System.EventHandler(this.Satıslar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button stsonay;
        private System.Windows.Forms.Label kodlabel;
        private System.Windows.Forms.RichTextBox adres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox urunfoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox müsteri;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.TextBox kategori;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox urnadet;
        private System.Windows.Forms.TextBox urun;
        private System.Windows.Forms.Label stok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ana;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}