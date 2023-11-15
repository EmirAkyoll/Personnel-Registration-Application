
namespace Personel_Kayıt_Uygulaması_veritabanlı_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedMAAS = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.secenekBekar = new System.Windows.Forms.RadioButton();
            this.secenekEvli = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxSehir = new System.Windows.Forms.ComboBox();
            this.txtMESLEK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSEHIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMAASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMESLEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabloPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabanıDataSet = new Personel_Kayıt_Uygulaması_veritabanlı_.PersonelVeriTabanıDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablo_PersonelTableAdapter = new Personel_Kayıt_Uygulaması_veritabanlı_.PersonelVeriTabanıDataSetTableAdapters.tablo_PersonelTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.maskedMAAS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.secenekBekar);
            this.groupBox1.Controls.Add(this.secenekEvli);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbxSehir);
            this.groupBox1.Controls.Add(this.txtMESLEK);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSOYAD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // maskedMAAS
            // 
            this.maskedMAAS.Location = new System.Drawing.Point(129, 209);
            this.maskedMAAS.Mask = "0000";
            this.maskedMAAS.Name = "maskedMAAS";
            this.maskedMAAS.Size = new System.Drawing.Size(125, 31);
            this.maskedMAAS.TabIndex = 5;
            this.maskedMAAS.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maaş:";
            // 
            // secenekBekar
            // 
            this.secenekBekar.AutoSize = true;
            this.secenekBekar.Location = new System.Drawing.Point(186, 239);
            this.secenekBekar.Name = "secenekBekar";
            this.secenekBekar.Size = new System.Drawing.Size(86, 29);
            this.secenekBekar.TabIndex = 13;
            this.secenekBekar.TabStop = true;
            this.secenekBekar.Text = "Bekar";
            this.secenekBekar.UseVisualStyleBackColor = true;
            this.secenekBekar.CheckedChanged += new System.EventHandler(this.secenekBekar_CheckedChanged);
            // 
            // secenekEvli
            // 
            this.secenekEvli.AutoSize = true;
            this.secenekEvli.Location = new System.Drawing.Point(125, 239);
            this.secenekEvli.Name = "secenekEvli";
            this.secenekEvli.Size = new System.Drawing.Size(65, 29);
            this.secenekEvli.TabIndex = 6;
            this.secenekEvli.TabStop = true;
            this.secenekEvli.Text = "Evli";
            this.secenekEvli.UseVisualStyleBackColor = true;
            this.secenekEvli.CheckedChanged += new System.EventHandler(this.secenekEvli_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Meslek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Durum:";
            // 
            // cmbxSehir
            // 
            this.cmbxSehir.FormattingEnabled = true;
            this.cmbxSehir.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "Edirne",
            "Samsun",
            "Trabzon",
            "Van",
            "Bursa",
            "İzmir",
            "Nevşehir"});
            this.cmbxSehir.Location = new System.Drawing.Point(129, 168);
            this.cmbxSehir.Name = "cmbxSehir";
            this.cmbxSehir.Size = new System.Drawing.Size(125, 33);
            this.cmbxSehir.TabIndex = 4;
            // 
            // txtMESLEK
            // 
            this.txtMESLEK.Location = new System.Drawing.Point(129, 275);
            this.txtMESLEK.Name = "txtMESLEK";
            this.txtMESLEK.Size = new System.Drawing.Size(125, 31);
            this.txtMESLEK.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şehir:";
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(129, 123);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(125, 31);
            this.txtSOYAD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "PrsnlSOYAD:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(129, 81);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(125, 31);
            this.txtAD.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "PersonelAD:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(129, 40);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 31);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PersoneID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnGrafikler);
            this.groupBox2.Controls.Add(this.btnIstatistik);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(593, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafikler.Location = new System.Drawing.Point(16, 248);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(117, 35);
            this.btnGrafikler.TabIndex = 8;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIstatistik.Location = new System.Drawing.Point(16, 212);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(117, 35);
            this.btnIstatistik.TabIndex = 7;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.Location = new System.Drawing.Point(16, 176);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(117, 35);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(16, 140);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 35);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(16, 104);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 35);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(16, 68);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 35);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListele.Location = new System.Drawing.Point(16, 32);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(117, 35);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perADDataGridViewTextBoxColumn,
            this.perSOYADDataGridViewTextBoxColumn,
            this.perSEHIRDataGridViewTextBoxColumn,
            this.perMAASDataGridViewTextBoxColumn,
            this.perDURUMDataGridViewCheckBoxColumn,
            this.perMESLEKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabloPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(762, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // perADDataGridViewTextBoxColumn
            // 
            this.perADDataGridViewTextBoxColumn.DataPropertyName = "PerAD";
            this.perADDataGridViewTextBoxColumn.HeaderText = "PerAD";
            this.perADDataGridViewTextBoxColumn.Name = "perADDataGridViewTextBoxColumn";
            this.perADDataGridViewTextBoxColumn.Width = 110;
            // 
            // perSOYADDataGridViewTextBoxColumn
            // 
            this.perSOYADDataGridViewTextBoxColumn.DataPropertyName = "PerSOYAD";
            this.perSOYADDataGridViewTextBoxColumn.HeaderText = "PerSOYAD";
            this.perSOYADDataGridViewTextBoxColumn.Name = "perSOYADDataGridViewTextBoxColumn";
            this.perSOYADDataGridViewTextBoxColumn.Width = 110;
            // 
            // perSEHIRDataGridViewTextBoxColumn
            // 
            this.perSEHIRDataGridViewTextBoxColumn.DataPropertyName = "PerSEHIR";
            this.perSEHIRDataGridViewTextBoxColumn.HeaderText = "PerSEHIR";
            this.perSEHIRDataGridViewTextBoxColumn.Name = "perSEHIRDataGridViewTextBoxColumn";
            this.perSEHIRDataGridViewTextBoxColumn.Width = 110;
            // 
            // perMAASDataGridViewTextBoxColumn
            // 
            this.perMAASDataGridViewTextBoxColumn.DataPropertyName = "PerMAAS";
            this.perMAASDataGridViewTextBoxColumn.HeaderText = "PerMAAS";
            this.perMAASDataGridViewTextBoxColumn.Name = "perMAASDataGridViewTextBoxColumn";
            // 
            // perDURUMDataGridViewCheckBoxColumn
            // 
            this.perDURUMDataGridViewCheckBoxColumn.DataPropertyName = "PerDURUM";
            this.perDURUMDataGridViewCheckBoxColumn.HeaderText = "PerDURUM";
            this.perDURUMDataGridViewCheckBoxColumn.Name = "perDURUMDataGridViewCheckBoxColumn";
            this.perDURUMDataGridViewCheckBoxColumn.Width = 110;
            // 
            // perMESLEKDataGridViewTextBoxColumn
            // 
            this.perMESLEKDataGridViewTextBoxColumn.DataPropertyName = "PerMESLEK";
            this.perMESLEKDataGridViewTextBoxColumn.HeaderText = "PerMESLEK";
            this.perMESLEKDataGridViewTextBoxColumn.Name = "perMESLEKDataGridViewTextBoxColumn";
            this.perMESLEKDataGridViewTextBoxColumn.Width = 120;
            // 
            // tabloPersonelBindingSource
            // 
            this.tabloPersonelBindingSource.DataMember = "tablo_Personel";
            this.tabloPersonelBindingSource.DataSource = this.personelVeriTabanıDataSet;
            // 
            // personelVeriTabanıDataSet
            // 
            this.personelVeriTabanıDataSet.DataSetName = "PersonelVeriTabanıDataSet";
            this.personelVeriTabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(390, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "görünmez yazı";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tablo_PersonelTableAdapter
            // 
            this.tablo_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(804, 528);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabloPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton secenekBekar;
        private System.Windows.Forms.RadioButton secenekEvli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxSehir;
        private System.Windows.Forms.TextBox txtMESLEK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.MaskedTextBox maskedMAAS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKaydet;
        private PersonelVeriTabanıDataSet personelVeriTabanıDataSet;
        private System.Windows.Forms.BindingSource tabloPersonelBindingSource;
        private PersonelVeriTabanıDataSetTableAdapters.tablo_PersonelTableAdapter tablo_PersonelTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSEHIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMAASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDURUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMESLEKDataGridViewTextBoxColumn;
    }
}

