using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dekstop_Datagridview
{
    public partial class FormDataBaru : Form
    {
        public FormDataBaru()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public Agrikultur GetAgrikultur()
        {
            Agrikultur agrikultur1 = new Agrikultur();
            agrikultur1.nama_tanaman = tbNama.Text;
            agrikultur1.luas_lahan = int.Parse(tbLuas.Text);

            return agrikultur1;

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
