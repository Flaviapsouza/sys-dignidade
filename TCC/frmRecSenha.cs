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
    public partial class frmRecSenha : MetroFramework.Forms.MetroForm
    {
        public frmRecSenha()
        {
            InitializeComponent();
        }

        private void frmRecSenha_Load(object sender, EventArgs e)
        {

        }

        public bool validaSenha(string @_str)
        {
            bool valida = false;
            foreach (var chr in new string[] { "'", "(", ")", "-", "+", "!", "@", "#", "$", "%", "&", "*", "[", "]", "{", "}", ".", "/", ";" })
            {
                if (@_str.Contains(chr.ToString()))
                    valida = true;
            }

            return valida;
        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOkSenha_Click(object sender, EventArgs e)
        {
            if (txtNewSenha.Text == txtNewSenha2.Text)
            {
                if (!validaSenha(txtRsec.Text))
                {
                    daoPaciente dp = new daoPaciente();
                    if (dp.alteraSenha(Convert.ToInt32(txtCod.Text), txtNewSenha.Text))
                    {
                        MessageBox.Show("Senha Alterada!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar!");
                        this.Close();
                    }
                }
                else MessageBox.Show("Senha Não pode conter especiais!");
            }
            else MessageBox.Show("Senhas não conferam!");

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (!validaSenha(txtRsec.Text))
            {
                daoPaciente dp = new daoPaciente();
                if (dp.obtResp(Convert.ToInt32(txtCod.Text)).Equals(txtRsec.Text))
                { gbxAltSenha.Enabled = true; }
                else
                {
                    MessageBox.Show("Digite a Resposta Corretamente!");
                    txtRsec.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite a Resposta Corretamente!");
                txtRsec.Focus();
            }
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtPsec.Text = "";
            txtRsec.Text = "";
            gbxAltSenha.Enabled = false;
            string[] psec = new string[2];
            if (!validaSenha(txtUser.Text))
            {
                daoPaciente dp = new daoPaciente();
                psec = dp.recSenha(txtUser.Text);

                if (!psec[0].Contains("Incorreto"))
                {
                    txtPsec.Text = psec[0];
                    txtCod.Text = psec[1];
                    btnOkSenha.Enabled = true;
                }
                else
                {
                    MessageBox.Show(psec[0]);
                }
            }
            else
            {
                MessageBox.Show("Nome Incorreto!");
            }

        }

    }
}

