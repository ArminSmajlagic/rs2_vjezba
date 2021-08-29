using DesktopClient.Services;
using Models.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
    public partial class MainClientDisplay : Form
    {
        CRUDService service = new CRUDService();
        ModalForm mf;
        public MainClientDisplay()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text))
            {
                dgvData.DataSource = await service.Get<Korisnik>(tbSearch.Text);
            }
            else
            {
                mf = new ModalForm("Unsite validan sadrzaj za pretragu");
                mf.Show();

            }
        }

        private async void btnLoadData_Click(object sender, EventArgs e)
        {
            dgvData.AutoGenerateColumns = false;
            dgvData.DataSource = await service.Get<List<Korisnik>>();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
