namespace görüntüleyici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnklasorac_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.Description = "Resim ve metin dosyalarının olduğu klasörü seçiniz.";
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                string klasoryolu = folderBrowserDialog1.SelectedPath;
                DirectoryInfo klasor = new DirectoryInfo(klasoryolu);
                FileInfo[] dosyalar = klasor.GetFiles();
                listBox1.Items.Clear();
                foreach (FileInfo dosya in dosyalar)
                {

                    if (dosya.Extension == ".jpeg" ||
                        dosya.Extension == ".jpg" ||
                        dosya.Extension == ".bmp" ||
                        dosya.Extension == ".png" ||
                        dosya.Extension == ".gif" ||
                        dosya.Extension == ".txt" ||
                        dosya.Extension == ".cs" ||
                        dosya.Extension == ".log")
                        listBox1.Items.Add(dosya);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;

            FileInfo dosya = listBox1.SelectedItem as FileInfo;
            if (dosya.Extension == ".jpeg" ||
                        dosya.Extension == ".jpg" ||
                        dosya.Extension == ".bmp" ||
                        dosya.Extension == ".png" ||
                        dosya.Extension == ".gif")
            {
                pictureBox1.Load(dosya.FullName);
                tabControl1.SelectedTab = tabresim;
                lblresimboyut.Text = pictureBox1.Image.Size.ToString();
            }
            else
            {

                tabControl1.SelectedTab = tabmetin;
                StreamReader oku = new StreamReader(dosya.FullName);
                textBox1.Text = oku.ReadToEnd();
                oku.Close();
                lblresimboyut.Text = "";
            }

            lbldosyaadi.Text = dosya.FullName;
            lbldosyabyt.Text = dosya.Length + " Byte ";

        }

        private void btndosyaac_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            if (tabControl1.SelectedTab == tabresim)
            {
                openFileDialog1.Filter = "Resim dosyaları | *.jpeg;*.jpg;*.png;*.bmp;*.gif";
                sonuc = openFileDialog1.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    string dosyayolu = openFileDialog1.FileName;
                    FileInfo dosya = new FileInfo(dosyayolu);
                    int index = listBox1.Items.Add(dosya);

                }

            }
            else
            {
                openFileDialog1.Filter = "Metin dosyası | *.txt;*.cs;*.log";
                sonuc = openFileDialog1.ShowDialog();
                string dosyayolu= openFileDialog1.FileName;
                FileInfo dosya= new FileInfo(dosyayolu);
                int index =listBox1.Items.Add(dosya);
                listBox1.SelectedIndex = index;
                    

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
