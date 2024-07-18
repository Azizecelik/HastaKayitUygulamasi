using System.ComponentModel;

namespace SınıfÖrnekUygulamaYoutube
{
    public partial class Form1 : Form
    {


        BindingList<Hasta> hastalar = new BindingList<Hasta>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hasta hasta1 = new Hasta { Id = 1, AdSoyad = "Ayla Bak", birim = "Göz", Tarih = DateTime.Now, yas = 25, sigorta = true };
            Hasta hasta2 = new Hasta { Id = 2, AdSoyad = "Necla Yurdakul", birim = "KBB", Tarih = DateTime.Now, yas = 40, sigorta = false };
            Hasta hasta3 = new Hasta { Id = 3, AdSoyad = "Neriman Çelik", birim = "Dahiliye", Tarih = DateTime.Now, yas = 55, sigorta = true };

            hastalar.Add(hasta1);
            hastalar.Add(hasta2);
            hastalar.Add(hasta3);

            dataGridView1.DataSource = hastalar;

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxId.Text);
            string adSoyad = textBoxAd.Text;
            string birim = comboBoxBirim.Text;
            int yas = Convert.ToInt32(textBoxYas.Text);
            bool sigorta = checkBoxSigorta.Checked;
            DateTime dateTime = dateTimePickerRandevu.Value;

            Hasta hasta = new Hasta { Id = Id, AdSoyad = adSoyad, birim = birim, Tarih = DateTime.Now, yas = yas, sigorta = sigorta };
            hastalar.Add(hasta);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Hasta hasta = (Hasta)dataGridView1.SelectedRows[0].DataBoundItem;
                textBoxId.Text = hasta.Id.ToString();
                textBoxAd.Text = hasta.AdSoyad;
                textBoxYas.Text = hasta.yas.ToString();
                comboBoxBirim.Text = hasta.birim.ToString();
                dateTimePickerRandevu.Value = hasta.Tarih;
                checkBoxSigorta.Checked = hasta.sigorta;
            }

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Hasta hasta = (Hasta)dataGridView1.SelectedRows[0].DataBoundItem;
                hasta.AdSoyad = textBoxAd.Text;
                hasta.yas = Convert.ToInt32(textBoxYas.Text);
                hasta.birim = comboBoxBirim.Text;
                hasta.Tarih = dateTimePickerRandevu.Value;
                hasta.sigorta = checkBoxSigorta.Checked;
                dataGridView1.Refresh();
            }

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Hasta hasta = (Hasta)dataGridView1.SelectedRows[0].DataBoundItem;
                DialogResult result = MessageBox.Show(hasta.AdSoyad + "Silinsin mi?", "Randevu sil", MessageBoxButtons.YesNo, MessageBoxIcon.Error );
                if (result == DialogResult.Yes)
                {
                    hastalar.Remove(hasta);
                    dataGridView1.Refresh();

                }
            }

        }
    }
}
