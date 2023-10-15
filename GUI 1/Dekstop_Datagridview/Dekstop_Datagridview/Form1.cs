using System.Windows.Forms;

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
            pns1.tanggalLahir = new DateOnly(2004, 05, 17);
            pns1.tempatLahir = "Metro";
            pns1.bidang = "Agrikultur";
            pns1.noTelp = "081221389123";
            dataGridView1.Rows.Add(pns1.nama, pns1.nip, pns1.gaji, pns1.tanggalLahir, pns1.tempatLahir, pns1.bidang, pns1.noTelp);


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
                    PNS pns1 = frmDataBaru.GetPNS();
                    dataGridView1.Rows.Add(pns1.nama, pns1.nip, pns1.gaji, pns1.tanggalLahir, pns1.tempatLahir, pns1.bidang, pns1.noTelp);
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