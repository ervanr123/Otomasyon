
namespace YazilimMimari
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.KrtTipBox = new System.Windows.Forms.ComboBox();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kartdurumgrup = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.harcamagrup = new System.Windows.Forms.GroupBox();
            this.harcamabtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.odemegrup = new System.Windows.Forms.GroupBox();
            this.odebtn = new System.Windows.Forms.Button();
            this.puanodebtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.kartdurumgrup.SuspendLayout();
            this.harcamagrup.SuspendLayout();
            this.odemegrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList2;
            this.button1.Location = new System.Drawing.Point(59, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kart Olustur";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "kart.png");
            this.imageList2.Images.SetKeyName(1, "HARCAMA.png");
            this.imageList2.Images.SetKeyName(2, "odeme.png");
            this.imageList2.Images.SetKeyName(3, "puanode.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // KrtTipBox
            // 
            this.KrtTipBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KrtTipBox.FormattingEnabled = true;
            this.KrtTipBox.Items.AddRange(new object[] {
            "MASTER",
            "VISA",
            "AMEX"});
            this.KrtTipBox.Location = new System.Drawing.Point(94, 99);
            this.KrtTipBox.Name = "KrtTipBox";
            this.KrtTipBox.Size = new System.Drawing.Size(124, 28);
            this.KrtTipBox.TabIndex = 2;
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(94, 62);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(138, 27);
            this.soyadtxt.TabIndex = 4;
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(94, 25);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(138, 27);
            this.adtxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(379, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(429, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(429, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(577, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(632, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "master.png");
            this.imageList1.Images.SetKeyName(1, "visa.png");
            this.imageList1.Images.SetKeyName(2, "amex.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.adtxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.KrtTipBox);
            this.groupBox1.Controls.Add(this.soyadtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(41, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 226);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Olustur";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(43, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Tipi:";
            // 
            // kartdurumgrup
            // 
            this.kartdurumgrup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.kartdurumgrup.Controls.Add(this.label13);
            this.kartdurumgrup.Controls.Add(this.label15);
            this.kartdurumgrup.Controls.Add(this.label12);
            this.kartdurumgrup.Controls.Add(this.label11);
            this.kartdurumgrup.Controls.Add(this.label9);
            this.kartdurumgrup.Controls.Add(this.label8);
            this.kartdurumgrup.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.kartdurumgrup.Location = new System.Drawing.Point(41, 302);
            this.kartdurumgrup.Name = "kartdurumgrup";
            this.kartdurumgrup.Size = new System.Drawing.Size(290, 145);
            this.kartdurumgrup.TabIndex = 15;
            this.kartdurumgrup.TabStop = false;
            this.kartdurumgrup.Text = "Kart Durum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(112, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(40, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "Limit:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(112, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(112, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(37, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Puan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(40, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Borç:";
            // 
            // harcamagrup
            // 
            this.harcamagrup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.harcamagrup.Controls.Add(this.harcamabtn);
            this.harcamagrup.Controls.Add(this.label7);
            this.harcamagrup.Controls.Add(this.textBox1);
            this.harcamagrup.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.harcamagrup.Location = new System.Drawing.Point(41, 478);
            this.harcamagrup.Name = "harcamagrup";
            this.harcamagrup.Size = new System.Drawing.Size(290, 175);
            this.harcamagrup.TabIndex = 16;
            this.harcamagrup.TabStop = false;
            this.harcamagrup.Text = "Harcama";
            // 
            // harcamabtn
            // 
            this.harcamabtn.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harcamabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.harcamabtn.ImageIndex = 1;
            this.harcamabtn.ImageList = this.imageList2;
            this.harcamabtn.Location = new System.Drawing.Point(59, 85);
            this.harcamabtn.Name = "harcamabtn";
            this.harcamabtn.Size = new System.Drawing.Size(143, 65);
            this.harcamabtn.TabIndex = 3;
            this.harcamabtn.Text = "Harca";
            this.harcamabtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.harcamabtn.UseVisualStyleBackColor = true;
            this.harcamabtn.Click += new System.EventHandler(this.harcamabtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(36, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tutar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 27);
            this.textBox1.TabIndex = 0;
            // 
            // odemegrup
            // 
            this.odemegrup.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.odemegrup.Controls.Add(this.odebtn);
            this.odemegrup.Controls.Add(this.puanodebtn);
            this.odemegrup.Controls.Add(this.label10);
            this.odemegrup.Controls.Add(this.textBox2);
            this.odemegrup.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.odemegrup.Location = new System.Drawing.Point(379, 478);
            this.odemegrup.Name = "odemegrup";
            this.odemegrup.Size = new System.Drawing.Size(395, 175);
            this.odemegrup.TabIndex = 17;
            this.odemegrup.TabStop = false;
            this.odemegrup.Text = "Odeme";
            // 
            // odebtn
            // 
            this.odebtn.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.odebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odebtn.ImageIndex = 2;
            this.odebtn.ImageList = this.imageList2;
            this.odebtn.Location = new System.Drawing.Point(38, 85);
            this.odebtn.Name = "odebtn";
            this.odebtn.Size = new System.Drawing.Size(143, 65);
            this.odebtn.TabIndex = 9;
            this.odebtn.Text = "Öde";
            this.odebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.odebtn.UseVisualStyleBackColor = true;
            this.odebtn.Click += new System.EventHandler(this.odebtn_Click);
            // 
            // puanodebtn
            // 
            this.puanodebtn.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanodebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.puanodebtn.ImageIndex = 3;
            this.puanodebtn.ImageList = this.imageList2;
            this.puanodebtn.Location = new System.Drawing.Point(218, 85);
            this.puanodebtn.Name = "puanodebtn";
            this.puanodebtn.Size = new System.Drawing.Size(143, 65);
            this.puanodebtn.TabIndex = 7;
            this.puanodebtn.Text = "Puanla Öde";
            this.puanodebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.puanodebtn.UseVisualStyleBackColor = true;
            this.puanodebtn.Click += new System.EventHandler(this.puanodebtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(89, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tutar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 27);
            this.textBox2.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(571, 319);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 24);
            this.label17.TabIndex = 19;
            this.label17.Text = "CVV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(815, 686);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.odemegrup);
            this.Controls.Add(this.harcamagrup);
            this.Controls.Add(this.kartdurumgrup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.kartdurumgrup.ResumeLayout(false);
            this.kartdurumgrup.PerformLayout();
            this.harcamagrup.ResumeLayout(false);
            this.harcamagrup.PerformLayout();
            this.odemegrup.ResumeLayout(false);
            this.odemegrup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox KrtTipBox;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox kartdurumgrup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox harcamagrup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox odemegrup;
        private System.Windows.Forms.Button harcamabtn;
        private System.Windows.Forms.Button puanodebtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button odebtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
    }
}

