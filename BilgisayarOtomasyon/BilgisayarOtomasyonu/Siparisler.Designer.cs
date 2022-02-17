
namespace BilgisayarOtomasyonu
{
    partial class Siparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparisler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sprsler = new System.Windows.Forms.ListView();
            this.no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mştri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kodu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ktgri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sprsekle = new System.Windows.Forms.Button();
            this.ana = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.ana);
            this.groupBox1.Controls.Add(this.sprsler);
            this.groupBox1.Controls.Add(this.sprsekle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİPARİŞLER";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // sprsler
            // 
            this.sprsler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.mştri,
            this.kodu,
            this.uad,
            this.ktgri,
            this.marka,
            this.fiyat,
            this.adt,
            this.adres,
            this.trh});
            this.sprsler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sprsler.HideSelection = false;
            this.sprsler.Location = new System.Drawing.Point(34, 48);
            this.sprsler.Name = "sprsler";
            this.sprsler.Size = new System.Drawing.Size(896, 335);
            this.sprsler.TabIndex = 25;
            this.sprsler.UseCompatibleStateImageBehavior = false;
            this.sprsler.View = System.Windows.Forms.View.Details;
            this.sprsler.SelectedIndexChanged += new System.EventHandler(this.sprsler_SelectedIndexChanged_1);
            // 
            // no
            // 
            this.no.Text = "No";
            this.no.Width = 37;
            // 
            // mştri
            // 
            this.mştri.Text = "Müşteri";
            this.mştri.Width = 118;
            // 
            // kodu
            // 
            this.kodu.Text = "Ürün Kodu";
            this.kodu.Width = 98;
            // 
            // uad
            // 
            this.uad.Text = "Ürün Adı";
            this.uad.Width = 138;
            // 
            // ktgri
            // 
            this.ktgri.Text = "Kategori";
            this.ktgri.Width = 93;
            // 
            // marka
            // 
            this.marka.Text = "Marka";
            this.marka.Width = 91;
            // 
            // fiyat
            // 
            this.fiyat.Text = "Fiyat";
            this.fiyat.Width = 86;
            // 
            // adt
            // 
            this.adt.Text = "Adet";
            // 
            // adres
            // 
            this.adres.Text = "Teslimat Adresi";
            this.adres.Width = 137;
            // 
            // trh
            // 
            this.trh.Text = "Sipariş Tarihi";
            this.trh.Width = 135;
            // 
            // sprsekle
            // 
            this.sprsekle.BackColor = System.Drawing.Color.Thistle;
            this.sprsekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sprsekle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sprsekle.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.sprsekle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumOrchid;
            this.sprsekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.sprsekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sprsekle.Location = new System.Drawing.Point(770, 419);
            this.sprsekle.Name = "sprsekle";
            this.sprsekle.Size = new System.Drawing.Size(160, 59);
            this.sprsekle.TabIndex = 22;
            this.sprsekle.Text = "Sipariş Ekle";
            this.sprsekle.UseVisualStyleBackColor = false;
            this.sprsekle.Click += new System.EventHandler(this.sprsekle_Click);
            // 
            // ana
            // 
            this.ana.BackColor = System.Drawing.Color.Thistle;
            this.ana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ana.BackgroundImage")));
            this.ana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ana.Location = new System.Drawing.Point(34, 427);
            this.ana.Name = "ana";
            this.ana.Size = new System.Drawing.Size(62, 51);
            this.ana.TabIndex = 46;
            this.ana.UseVisualStyleBackColor = false;
            this.ana.Click += new System.EventHandler(this.ana_Click);
            // 
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(985, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "Siparisler";
            this.Text = "Siparisler";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sprsekle;
        private System.Windows.Forms.ListView sprsler;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader mştri;
        private System.Windows.Forms.ColumnHeader kodu;
        private System.Windows.Forms.ColumnHeader uad;
        private System.Windows.Forms.ColumnHeader ktgri;
        private System.Windows.Forms.ColumnHeader marka;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.ColumnHeader adres;
        private System.Windows.Forms.ColumnHeader trh;
        private System.Windows.Forms.ColumnHeader adt;
        private System.Windows.Forms.Button ana;
    }
}