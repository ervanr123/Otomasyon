
namespace BilgisayarOtomasyonu
{
    partial class UrunEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txturunfotolink = new System.Windows.Forms.TextBox();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.ana = new System.Windows.Forms.Button();
            this.UrunNumara = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UrunEkleBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txturunozellik = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txturunfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txturunmarka = new System.Windows.Forms.ComboBox();
            this.txturunkategori = new System.Windows.Forms.ComboBox();
            this.txturunstok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txturunad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bilgisayarOtomasyonuDataSet1 = new BilgisayarOtomasyonu.BilgisayarOtomasyonuDataSet();
            this.bilgisayarOtomasyonuDataSet2 = new BilgisayarOtomasyonu.BilgisayarOtomasyonuDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarOtomasyonuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txturunfotolink);
            this.groupBox1.Controls.Add(this.picturebox1);
            this.groupBox1.Controls.Add(this.ana);
            this.groupBox1.Controls.Add(this.UrunNumara);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.UrunEkleBtn);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txturunozellik);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txturunfiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txturunmarka);
            this.groupBox1.Controls.Add(this.txturunkategori);
            this.groupBox1.Controls.Add(this.txturunstok);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txturunad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN BİLGİLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(864, 217);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(67, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ekle";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txturunfotolink
            // 
            this.txturunfotolink.Location = new System.Drawing.Point(674, 219);
            this.txturunfotolink.Name = "txturunfotolink";
            this.txturunfotolink.Size = new System.Drawing.Size(174, 28);
            this.txturunfotolink.TabIndex = 23;
            // 
            // picturebox1
            // 
            this.picturebox1.Location = new System.Drawing.Point(674, 265);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(257, 122);
            this.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox1.TabIndex = 22;
            this.picturebox1.TabStop = false;
            this.picturebox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ana
            // 
            this.ana.BackColor = System.Drawing.Color.Thistle;
            this.ana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ana.BackgroundImage")));
            this.ana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ana.Location = new System.Drawing.Point(6, 401);
            this.ana.Name = "ana";
            this.ana.Size = new System.Drawing.Size(62, 51);
            this.ana.TabIndex = 21;
            this.ana.UseVisualStyleBackColor = false;
            this.ana.Click += new System.EventHandler(this.ana_Click);
            // 
            // UrunNumara
            // 
            this.UrunNumara.Location = new System.Drawing.Point(197, 49);
            this.UrunNumara.Name = "UrunNumara";
            this.UrunNumara.Size = new System.Drawing.Size(257, 28);
            this.UrunNumara.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(65, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ürün Kodu:";
            // 
            // UrunEkleBtn
            // 
            this.UrunEkleBtn.BackColor = System.Drawing.Color.Thistle;
            this.UrunEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunEkleBtn.Location = new System.Drawing.Point(803, 394);
            this.UrunEkleBtn.Name = "UrunEkleBtn";
            this.UrunEkleBtn.Size = new System.Drawing.Size(128, 58);
            this.UrunEkleBtn.TabIndex = 2;
            this.UrunEkleBtn.Text = "Ürün Ekle";
            this.UrunEkleBtn.UseVisualStyleBackColor = false;
            this.UrunEkleBtn.Click += new System.EventHandler(this.UrunEkleBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(509, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ürün Fotoğrafı:";
            // 
            // txturunozellik
            // 
            this.txturunozellik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunozellik.Location = new System.Drawing.Point(674, 89);
            this.txturunozellik.Name = "txturunozellik";
            this.txturunozellik.Size = new System.Drawing.Size(257, 106);
            this.txturunozellik.TabIndex = 16;
            this.txturunozellik.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(499, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Özellikleri:";
            // 
            // txturunfiyat
            // 
            this.txturunfiyat.Location = new System.Drawing.Point(674, 48);
            this.txturunfiyat.Name = "txturunfiyat";
            this.txturunfiyat.Size = new System.Drawing.Size(257, 28);
            this.txturunfiyat.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(542, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ürün Fiyatı:";
            // 
            // txturunmarka
            // 
            this.txturunmarka.FormattingEnabled = true;
            this.txturunmarka.Items.AddRange(new object[] {
            "Asus",
            "Casper",
            "HP",
            "Lenovo",
            "Dell"});
            this.txturunmarka.Location = new System.Drawing.Point(197, 165);
            this.txturunmarka.Name = "txturunmarka";
            this.txturunmarka.Size = new System.Drawing.Size(257, 30);
            this.txturunmarka.TabIndex = 12;
            // 
            // txturunkategori
            // 
            this.txturunkategori.FormattingEnabled = true;
            this.txturunkategori.Items.AddRange(new object[] {
            "Laptop",
            "Masaüstü"});
            this.txturunkategori.Location = new System.Drawing.Point(197, 125);
            this.txturunkategori.Name = "txturunkategori";
            this.txturunkategori.Size = new System.Drawing.Size(257, 30);
            this.txturunkategori.TabIndex = 11;
            // 
            // txturunstok
            // 
            this.txturunstok.Location = new System.Drawing.Point(197, 205);
            this.txturunstok.Name = "txturunstok";
            this.txturunstok.Size = new System.Drawing.Size(257, 28);
            this.txturunstok.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Stok Sayısı:";
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(197, 87);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(257, 28);
            this.txturunad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Markası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Kategorisi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "25694.png");
            // 
            // bilgisayarOtomasyonuDataSet1
            // 
            this.bilgisayarOtomasyonuDataSet1.DataSetName = "BilgisayarOtomasyonuDataSet";
            this.bilgisayarOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilgisayarOtomasyonuDataSet2
            // 
            this.bilgisayarOtomasyonuDataSet2.DataSetName = "BilgisayarOtomasyonuDataSet";
            this.bilgisayarOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(970, 482);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgisayarOtomasyonuDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txturunad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txturunmarka;
        private System.Windows.Forms.ComboBox txturunkategori;
        private System.Windows.Forms.TextBox txturunstok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txturunfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txturunozellik;
        private System.Windows.Forms.Button UrunEkleBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UrunNumara;
        private System.Windows.Forms.Label label8;
        private BilgisayarOtomasyonuDataSet bilgisayarOtomasyonuDataSet1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button ana;
        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txturunfotolink;
        private BilgisayarOtomasyonuDataSet bilgisayarOtomasyonuDataSet2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}