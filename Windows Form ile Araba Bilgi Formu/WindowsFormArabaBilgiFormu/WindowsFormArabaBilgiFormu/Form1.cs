namespace WindowsFormArabaBilgiFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

            // Kullanıcıdan alınan bilgileri değişkenlerde saklamaya yarar
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            string kapiSayisi = txtKapiSayisi.Text;
            string pencereSayisi = txtPencereSayisi.Text;
            string yakit = txtYakit.Text;

            // Bilgileri birleştir ve mesaj kutusunda göstermeye yarar
            string bilgi = $"🚗 Araba Bilgileri:\n\n" +
                           $"Marka: {marka}\n" +
                           $"Model: {model}\n" +
                           $"Renk: {renk}\n" +
                           $"Kapı Sayısı: {kapiSayisi}\n" +
                           $"Pencere Sayısı: {pencereSayisi}\n" +
                           $"100 km’de Yakıt Tüketimi: {yakit} L";

            MessageBox.Show(bilgi, "Araba Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information); //kullanıcıya bir bilgi penceresi (MessageBox) açar.

        }
    }
}
