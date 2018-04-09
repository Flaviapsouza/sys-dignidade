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
    public partial class frmPaciente : MetroFramework.Forms.MetroForm
    {

        public frmPaciente()
        {
            InitializeComponent();
        }


        #region Var Globais
        public static bool selLinha { get; set; }
        public static int idLinha { get; set; }
        #endregion

        DataTable dt;

        private void frmCadPaciente_Activated(object sender, EventArgs e)
        {
            atualizaGrid();

            frmCadPaciente cd = new frmCadPaciente();
            if (selLinha)
            {
                if (idLinha > 0)
                {
                    for (int i = 0; i < gvDados.Rows.Count; i++)
                    {
                        int teste = Convert.ToInt16(gvDados.Rows[i].Cells["ID"].Value);
                        if (Convert.ToInt16(gvDados.Rows[i].Cells["ID"].Value) == idLinha)
                        {
                            gvDados.Rows[i].Selected = true;
                        }
                    }

                }
            }
        }

        public void setaVar(bool ok, int num)
        {
            selLinha = ok;
            idLinha = num;
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadPaciente cl = new frmCadPaciente();
            cl.ShowDialog();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(gvDados.CurrentRow.Cells["ID"].Value) > 0)
            {
                frmEditPaci ep = new frmEditPaci();
                ep.modConsulta = false;
                ep.idPaciente = Convert.ToInt32(gvDados.CurrentRow.Cells["ID"].Value);
                ep.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um registro!");
            }
        }

        public void atualizaGrid()
        {
            daoPaciente dp = new daoPaciente();
            gvDados.DataSource = dp.carregaPaciente();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmEditPaci ep = new frmEditPaci();
            ep.modConsulta = true;
            ep.idPaciente = Convert.ToInt32(gvDados.CurrentRow.Cells["ID"].Value);
            ep.ShowDialog();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvDados.CurrentRow.Cells["ID"].Value);
            if (id > 0)
            {
                string nome = gvDados.CurrentRow.Cells["NOME"].Value.ToString();
                var exc = MessageBox.Show("Deseja realmente excluir o paciente " + nome + " ?", "Excluir", MessageBoxButtons.YesNo);

                if (exc == DialogResult.Yes)
                {
                    daoPaciente dp = new daoPaciente();
                    if (dp.delPac(id))
                    {
                        MessageBox.Show("Paciente Excluido Com Sucesso!");
                        atualizaGrid();
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gvDados.AutoGenerateColumns = false;
            atualizaGrid();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            frmPesqPac pesqPac = new frmPesqPac();
            pesqPac.ShowDialog();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            gvDados.AutoGenerateColumns = false;
            daoPaciente dp = new daoPaciente();
            gvDados.DataSource = dp.carregaPaciente();
        }
    }
}
