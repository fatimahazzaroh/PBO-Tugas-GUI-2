namespace Dekstop_Datagridview
{
    public partial class Form1 : Form
    {
        List<PNS> listPNS = new List<PNS>();
        public Form1()
        {
            InitializeComponent();

            PNS pns1 = new PNS();
            pns1.nama = "Jetro";
            pns1.nip = 222410101064;
            pns1.gaji = 2000000;
            pns1.tanggalLahir = new DateOnly(2004,05,17);
            pns1.tempatLahir = "Metro";
            pns1.bidang = "Agrikultur";
            pns1.noTelp = "081221389123";

            listPNS.Add(pns1);
            dataGridView1.DataSource = listPNS;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (FormDataBaru frmDataBaru = new FormDataBaru())
            {
                if (frmDataBaru.ShowDialog() == DialogResult.OK)
                {
                    PNS pns_baru = frmDataBaru.GetPNS();
                    dataGridView1.DataSource = null;
                    listPNS.Add(pns_baru);
                    dataGridView1.DataSource = listPNS;

                    frmDataBaru.Close();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class PNS
    {
        public string nama { get; set; }
        public long nip { get; set; }
        public long gaji { get; set; }
        public DateOnly tanggalLahir { get; set; }
        public string tempatLahir { get; set; }
        public string bidang { get; set; }
        public string noTelp { get; set; }
    }
}