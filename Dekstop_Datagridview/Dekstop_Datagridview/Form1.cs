namespace Dekstop_Datagridview
{
    public partial class Form1 : Form
    {
        List<Agrikultur> listAgrikultur = new List<Agrikultur>();
        public Form1()
        {
            InitializeComponent();

            Agrikultur agrikultur1 = new Agrikultur();
            agrikultur1.nama_tanaman = "Pohon maangga";
            agrikultur1.luas_lahan = 20;

            listAgrikultur.Add(agrikultur1);

            dataGridView1.DataSource = listAgrikultur;
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
                    Agrikultur agrikultur1 = frmDataBaru.GetAgrikultur();
                    listAgrikultur.Add(agrikultur1 );
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listAgrikultur;

                    frmDataBaru.Close();
                }
            }
            
        }
    }
    public class Agrikultur
    {
        public string nama_tanaman { get; set; }
        public int luas_lahan { get; set; }
        //public Agrikultur(string _nama_tanaman, int _luas_lahan)
        //{
        //    this.nama_tanaman = _nama_tanaman;
        //    this.luas_lahan = _luas_lahan;
        //}
    }
}