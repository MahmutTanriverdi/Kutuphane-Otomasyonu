namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKitapId = new System.Windows.Forms.TextBox();
            this.TxtKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKitapSayfa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKitapYazar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.CmbKitapTur = new System.Windows.Forms.ComboBox();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtKitapBul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 482);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1397, 366);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitap İd:";
            // 
            // TxtKitapId
            // 
            this.TxtKitapId.Enabled = false;
            this.TxtKitapId.Location = new System.Drawing.Point(249, 34);
            this.TxtKitapId.Name = "TxtKitapId";
            this.TxtKitapId.Size = new System.Drawing.Size(324, 44);
            this.TxtKitapId.TabIndex = 4;
            // 
            // TxtKitapAd
            // 
            this.TxtKitapAd.Location = new System.Drawing.Point(249, 101);
            this.TxtKitapAd.Name = "TxtKitapAd";
            this.TxtKitapAd.Size = new System.Drawing.Size(324, 44);
            this.TxtKitapAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitap Ad:";
            // 
            // TxtKitapSayfa
            // 
            this.TxtKitapSayfa.Location = new System.Drawing.Point(249, 232);
            this.TxtKitapSayfa.Name = "TxtKitapSayfa";
            this.TxtKitapSayfa.Size = new System.Drawing.Size(324, 44);
            this.TxtKitapSayfa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sayfa:";
            // 
            // TxtKitapYazar
            // 
            this.TxtKitapYazar.Location = new System.Drawing.Point(249, 165);
            this.TxtKitapYazar.Name = "TxtKitapYazar";
            this.TxtKitapYazar.Size = new System.Drawing.Size(324, 44);
            this.TxtKitapYazar.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yazar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tür:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Durum:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(249, 368);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(167, 42);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İkinci El";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(422, 366);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(153, 42);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pakette";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CmbKitapTur
            // 
            this.CmbKitapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKitapTur.FormattingEnabled = true;
            this.CmbKitapTur.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir",
            "Tiyatro"});
            this.CmbKitapTur.Location = new System.Drawing.Point(249, 302);
            this.CmbKitapTur.Name = "CmbKitapTur";
            this.CmbKitapTur.Size = new System.Drawing.Size(324, 46);
            this.CmbKitapTur.TabIndex = 4;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(662, 40);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(223, 66);
            this.BtnListele.TabIndex = 17;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(662, 122);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(223, 66);
            this.BtnKaydet.TabIndex = 18;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(662, 292);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(223, 66);
            this.BtnGuncelle.TabIndex = 20;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(662, 210);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(223, 66);
            this.BtnSil.TabIndex = 19;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1028, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // TxtKitapBul
            // 
            this.TxtKitapBul.Location = new System.Drawing.Point(1107, 321);
            this.TxtKitapBul.Name = "TxtKitapBul";
            this.TxtKitapBul.Size = new System.Drawing.Size(267, 44);
            this.TxtKitapBul.TabIndex = 22;
            this.TxtKitapBul.TextChanged += new System.EventHandler(this.TxtKitapBul_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(949, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 38);
            this.label7.TabIndex = 23;
            this.label7.Text = "Kitap Adı:";
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(1141, 385);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(193, 66);
            this.BtnBul.TabIndex = 24;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1405, 847);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.TxtKitapBul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.CmbKitapTur);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtKitapSayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKitapYazar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtKitapAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKitapId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKitapId;
        private System.Windows.Forms.TextBox TxtKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKitapSayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKitapYazar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox CmbKitapTur;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtKitapBul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBul;
    }
}

