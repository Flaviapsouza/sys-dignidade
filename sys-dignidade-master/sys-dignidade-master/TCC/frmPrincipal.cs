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

    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public static int usuarioLog { get; set; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUser.Text = "";
            daoPaciente dp = new daoPaciente();
            lblUser.Text = dp.userLog(usuarioLog);
        }

        public void gravaUser(int id)
        {
            usuarioLog = id;
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaciente fp = new frmPaciente();
            fp.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fcad = new frmUsuario();
            fcad.ShowDialog();
        }
    }
}
