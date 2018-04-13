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
    public partial class frmEditPaci : MetroFramework.Forms.MetroForm
    {
        public int idPaciente { get; set; }
        public bool modConsulta { get; set; }
        string nome, cpf, rg, dt, fone, sexo, nac, end, num, cep, uf;

        public frmEditPaci()
        {
            InitializeComponent();
        }

        private void editPaci_Load(object sender, EventArgs e)
        {
            #region PREENCHE UF
            cbxUf.Items.Add("AC");
            cbxUf.Items.Add("AL");
            cbxUf.Items.Add("AM");
            cbxUf.Items.Add("AP");
            cbxUf.Items.Add("BA");
            cbxUf.Items.Add("CE");
            cbxUf.Items.Add("DF");
            cbxUf.Items.Add("ES");
            cbxUf.Items.Add("GO");
            cbxUf.Items.Add("MA");
            cbxUf.Items.Add("MG");
            cbxUf.Items.Add("MS");
            cbxUf.Items.Add("MT");
            cbxUf.Items.Add("PA");
            cbxUf.Items.Add("PB");
            cbxUf.Items.Add("PE");
            cbxUf.Items.Add("PI");
            cbxUf.Items.Add("PR");
            cbxUf.Items.Add("RJ");
            cbxUf.Items.Add("RN");
            cbxUf.Items.Add("RO");
            cbxUf.Items.Add("RR");
            cbxUf.Items.Add("RS");
            cbxUf.Items.Add("SC");
            cbxUf.Items.Add("SE");
            cbxUf.Items.Add("SP");
            cbxUf.Items.Add("TO");
            #endregion

            if (modConsulta)
            {
                txtId.ReadOnly = true;
                txtNome.ReadOnly = true;
                txtCpf.ReadOnly = true;
                txtRg.ReadOnly = true;
                dtNasc.Enabled = false;
                txtFone.ReadOnly = true;
                txtNac.ReadOnly = true;
                txtEnd.ReadOnly = true;
                txtNum.ReadOnly = true;
                txtCep.ReadOnly = true;
                rdbFem.Enabled = false;
                rdbMasc.Enabled = false;
                cbxUf.Enabled = false;
                btnGravar.Visible = false;
            }

            DataTable dt = new DataTable();

            daoPaciente dp = new daoPaciente();
            dt = dp.consultaPaciente(idPaciente);

            txtId.Text = dt.Rows[0]["ID"].ToString();
            txtNome.Text = dt.Rows[0]["NOME"].ToString();
            txtCpf.Text = dt.Rows[0]["CPF"].ToString();
            txtRg.Text = dt.Rows[0]["RG"].ToString();
            dtNasc.Value = Convert.ToDateTime(dt.Rows[0]["DTNASC"]);
            txtFone.Text = dt.Rows[0]["FONE"].ToString();
            txtNac.Text = dt.Rows[0]["NACIONALIDADE"].ToString();
            txtEnd.Text = dt.Rows[0]["ENDERECEO"].ToString();
            txtNum.Text = dt.Rows[0]["NUMERO"].ToString();
            txtCep.Text = dt.Rows[0]["CEP"].ToString();
            cbxUf.Text = dt.Rows[0]["UF"].ToString();

            if (dt.Rows[0]["SEXO"].ToString() == "M")
            {
                rdbMasc.Checked = true;
                rdbFem.Checked = false;
            }
            else
            {
                rdbFem.Checked = true;
                rdbMasc.Checked = false;
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            frmPaciente frm = new frmPaciente();
            frm.setaVar(true, Convert.ToInt32(txtId.Text));
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (validaDados())
            {
                int id = Convert.ToInt32(txtId.Text);

                nome = tratarStr(txtNome.Text);
                cpf = tratarStr(txtCpf.Text);
                rg = tratarStr(txtRg.Text);
                dt = dtNasc.Text;
                fone = tratarStr(txtFone.Text);
                sexo = (rdbMasc.Checked ? "M" : "F");
                nac = tratarStr(txtNac.Text);
                end = tratarStr(txtEnd.Text);
                num = tratarStr(txtNum.Text);
                cep = tratarStr(txtCep.Text);
                uf = tratarStr(cbxUf.Text);

                daoPaciente dp = new daoPaciente();
                if (dp.editPac(id, nome, cpf, rg, dt, fone, sexo, nac, end, num, cep, uf))
                {
                    frmPaciente fr = new frmPaciente();
                    fr.atualizaGrid();
                    this.Close();
                }
            }

        }

        public string tratarStr(string @_str)
        {
            foreach (var chr in new string[] { "'", "(", ")", "-", "+", "!", "@", "#", "$", "%", "&", "*", "[", "]", "{", "}", ".", "/", ";" })
            {
                @_str = @_str.Replace(chr, "");
            }

            StringBuilder stb = new StringBuilder(@_str);

            return stb.ToString();
        }

        public bool validaDados()
        {
            bool ok = true;

            if (string.IsNullOrEmpty(tratarStr(txtNome.Text)))
            {
                ok = false;
                MessageBox.Show("Campo Inválido");
                txtNome.Focus();
                return ok;
            }

            if (string.IsNullOrEmpty(tratarStr(txtCpf.Text)) && txtCpf.Text.Length < 11)
            {
                ok = false;
                MessageBox.Show("Campo Inválido");
                txtNome.Focus();
                return ok;
            }
            if (string.IsNullOrEmpty(tratarStr(txtRg.Text)) && txtRg.Text.Length < 9)
            {
                ok = false;
                MessageBox.Show("Campo Inválido");
                txtNome.Focus();
                return ok;
            }
            //if (string.IsNullOrEmpty(tratarStr(dtNasc.Text)) ok = false;
            if (string.IsNullOrEmpty(tratarStr(txtFone.Text)))
            {
                ok = false;
                MessageBox.Show("Campo Inválido");
                txtNome.Focus();
                return ok;
            }
            if (string.IsNullOrEmpty(tratarStr(txtNac.Text)))
            {
                ok = false;
                MessageBox.Show("Campo Inválido");
                txtNome.Focus();
                return ok;
            }
            if (string.IsNullOrEmpty(tratarStr(txtNum.Text)))
            {
                ok = false;
                MessageBox.Show("Campo Inválido");
                txtNome.Focus();
                return ok;
            }
            if (string.IsNullOrEmpty(tratarStr(txtCep.Text)) && txtCep.Text.Length < 8)
            {
                ok = false;
                MessageBox.Show("Campo Inválido");
                txtNome.Focus();
                return ok;
            }

            return ok;
        }
    }
}
