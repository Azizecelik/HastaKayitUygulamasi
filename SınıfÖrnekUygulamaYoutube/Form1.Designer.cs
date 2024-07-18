namespace SınıfÖrnekUygulamaYoutube
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxId = new TextBox();
            textBoxYas = new TextBox();
            textBoxAd = new TextBox();
            checkBoxSigorta = new CheckBox();
            buttonEkle = new Button();
            buttonGuncelle = new Button();
            buttonSil = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            dateTimePickerRandevu = new DateTimePicker();
            comboBoxBirim = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 68);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 0;
            label1.Text = "Id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 113);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 151);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "Randevu Tarihi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 197);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Birim :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 236);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Yaş :";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(181, 64);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(224, 22);
            textBoxId.TabIndex = 5;
            // 
            // textBoxYas
            // 
            textBoxYas.Location = new Point(181, 232);
            textBoxYas.Name = "textBoxYas";
            textBoxYas.Size = new Size(224, 22);
            textBoxYas.TabIndex = 7;
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(181, 105);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(224, 22);
            textBoxAd.TabIndex = 10;
            // 
            // checkBoxSigorta
            // 
            checkBoxSigorta.AutoSize = true;
            checkBoxSigorta.Location = new Point(26, 277);
            checkBoxSigorta.Name = "checkBoxSigorta";
            checkBoxSigorta.Size = new Size(70, 19);
            checkBoxSigorta.TabIndex = 11;
            checkBoxSigorta.Text = "Sigortalı";
            checkBoxSigorta.UseVisualStyleBackColor = true;
            // 
            // buttonEkle
            // 
            buttonEkle.BackColor = Color.White;
            buttonEkle.Location = new Point(555, 64);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(168, 64);
            buttonEkle.TabIndex = 12;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = false;
            buttonEkle.Click += buttonEkle_Click;
            // 
            // buttonGuncelle
            // 
            buttonGuncelle.BackColor = Color.White;
            buttonGuncelle.Location = new Point(555, 148);
            buttonGuncelle.Name = "buttonGuncelle";
            buttonGuncelle.Size = new Size(168, 64);
            buttonGuncelle.TabIndex = 13;
            buttonGuncelle.Text = "Güncelle";
            buttonGuncelle.UseVisualStyleBackColor = false;
            buttonGuncelle.Click += buttonGuncelle_Click;
            // 
            // buttonSil
            // 
            buttonSil.BackColor = Color.White;
            buttonSil.Location = new Point(555, 232);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(168, 64);
            buttonSil.TabIndex = 14;
            buttonSil.Text = "Sil";
            buttonSil.UseVisualStyleBackColor = false;
            buttonSil.Click += buttonSil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.refresh;
            pictureBox1.Location = new Point(674, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.plus;
            pictureBox2.Location = new Point(674, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.remove;
            pictureBox3.Location = new Point(674, 251);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // dateTimePickerRandevu
            // 
            dateTimePickerRandevu.Location = new Point(181, 147);
            dateTimePickerRandevu.Name = "dateTimePickerRandevu";
            dateTimePickerRandevu.Size = new Size(219, 22);
            dateTimePickerRandevu.TabIndex = 18;
            // 
            // comboBoxBirim
            // 
            comboBoxBirim.FormattingEnabled = true;
            comboBoxBirim.Items.AddRange(new object[] { "Dahiliye", "KBB", "Nöroloji", "Göz", "Genel Cerrahi" });
            comboBoxBirim.Location = new Point(181, 193);
            comboBoxBirim.Name = "comboBoxBirim";
            comboBoxBirim.Size = new Size(219, 23);
            comboBoxBirim.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 334);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(697, 163);
            dataGridView1.TabIndex = 20;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(751, 515);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxBirim);
            Controls.Add(dateTimePickerRandevu);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSil);
            Controls.Add(buttonGuncelle);
            Controls.Add(buttonEkle);
            Controls.Add(checkBoxSigorta);
            Controls.Add(textBoxAd);
            Controls.Add(textBoxYas);
            Controls.Add(textBoxId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Hasta Kayıt Randevu Uygulaması";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxId;
        private TextBox textBoxYas;
        private TextBox textBoxAd;
        private CheckBox checkBoxSigorta;
        private Button buttonEkle;
        private Button buttonGuncelle;
        private Button buttonSil;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DateTimePicker dateTimePickerRandevu;
        private ComboBox comboBoxBirim;
        private DataGridView dataGridView1;
    }
}
