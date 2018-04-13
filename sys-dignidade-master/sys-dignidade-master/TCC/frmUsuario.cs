using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC
{
    public partial class frmUsuario : MetroFramework.Forms.MetroForm
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadUser fcad = new frmCadUser();
            fcad.ShowDialog();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            gvDados.AutoGenerateColumns = false;
            daoPaciente dp = new daoPaciente();
            gvDados.DataSource = dp.carregaUsuario();
        }
    }
}
