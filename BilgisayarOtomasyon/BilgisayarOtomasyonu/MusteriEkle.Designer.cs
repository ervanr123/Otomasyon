
namespace BilgisayarOtomasyonu
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ana = new System.Windows.Forms.Button();
            this.meklebtn = new System.Windows.Forms.Button();
            this.MTC = new System.Windows.Forms.TextBox();
            this.Msoyad = new System.Windows.Forms.TextBox();
            this.Mad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Mtelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(this.Mtelefon);
            this.groupBox1.Controls.Add(this.ana);
            this.groupBox1.Controls.Add(this.meklebtn);
            this.groupBox1.Controls.Add(this.MTC);
            this.groupBox1.Controls.Add(this.Msoyad);
            this.groupBox1.Controls.Add(this.Mad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(69, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 292);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MÜŞTERİ BİLGİLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ana
            // 
            this.ana.BackColor = System.Drawing.Color.Thistle;
            this.ana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ana.BackgroundImage")));
            this.ana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ana.Location = new System.Drawing.Point(6, 235);
            this.ana.Name = "ana";
            this.ana.Size = new System.Drawing.Size(62, 51);
            this.ana.TabIndex = 22;
            this.ana.UseVisualStyleBackColor = false;
            this.ana.Click += new System.EventHandler(this.ana_Click);
            // 
            // meklebtn
            // 
            this.meklebtn.BackColor = System.Drawing.Color.Thistle;
            this.meklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.meklebtn.Location = new System.Drawing.Point(360, 235);
            this.meklebtn.Name = "meklebtn";
            this.meklebtn.Size = new System.Drawing.Size(119, 46);
            this.meklebtn.TabIndex = 8;
            this.meklebtn.Text = "Ekle";
            this.meklebtn.UseVisualStyleBackColor = false;
            this.meklebtn.Click += new System.EventHandler(this.meklebtn_Click);
            // 
            // MTC
            // 
            this.MTC.Location = new System.Drawing.Point(136, 124);
            this.MTC.MaxLength = 11;
            this.MTC.Name = "MTC";
            this.MTC.Size = new System.Drawing.Size(254, 28);
            this.MTC.TabIndex = 6;
            // 
            // Msoyad
            // 
            this.Msoyad.Location = new System.Drawing.Point(136, 92);
            this.Msoyad.Name = "Msoyad";
            this.Msoyad.Size = new System.Drawing.Size(254, 28);
            this.Msoyad.TabIndex = 5;
            // 
            // Mad
            // 
            this.Mad.Location = new System.Drawing.Point(136, 60);
            this.Mad.Name = "Mad";
            this.Mad.Size = new System.Drawing.Size(254, 28);
            this.Mad.TabIndex = 4;
            this.Mad.TextChanged += new System.EventHandler(this.Mad_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(87, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(56, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(88, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "25694.png");
            // 
            // Mtelefon
            // 
            this.Mtelefon.Location = new System.Drawing.Point(136, 156);
            this.Mtelefon.Mask = "(999) 000-0000";
            this.Mtelefon.Name = "Mtelefon";
            this.Mtelefon.Size = new System.Drawing.Size(254, 28);
            this.Mtelefon.TabIndex = 23;
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(620, 388);
            this.Controls.Add(this.groupBox1);
            this.Name = "MusteriEkle";
            this.Text = "MusteriEkle";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button meklebtn;
        private System.Windows.Forms.TextBox MTC;
        private System.Windows.Forms.TextBox Msoyad;
        private System.Windows.Forms.TextBox Mad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button ana;
        private System.Windows.Forms.MaskedTextBox Mtelefon;
    }
}