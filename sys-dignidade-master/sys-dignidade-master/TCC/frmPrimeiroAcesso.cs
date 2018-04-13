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
    public partial class frmPrimeiroAcesso : MetroFramework.Forms.MetroForm
    {
        public frmPrimeiroAcesso()
        {
            InitializeComponent();
        }

        private void frmPrimeiroAcesso_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (!validaCampos())
            {
                if (!validaSenha(txtSenha.Text))
                {
                    string[] ret = new string[1];
                    if (txtSenha.Text == txtSenha2.Text)
                    {
                        daoPaciente dp = new daoPaciente();
                        ret = dp.primeiroAcesso(tratarStr(txtUsuario.Text), tratarStr(txtSenha.Text), tratarStr(txtPsec.Text), tratarStr(txtRsec.Text));

                        if (ret[0] == "0")
                        {
                            MessageBox.Show(ret[1]);
                        }
                        else
                        {
                            if (ret[0] == "1")
                            {
                                MessageBox.Show(ret[1]);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senhas não são conferem!");
                    }
                }
                else
                {
                    MessageBox.Show("Senha não pode conter carácteres especiais!");
                }
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region TratarStr
        public string tratarStr(string @_str)
        {
            foreach (var chr in new string[] { "'", "(", ")", "-", "+", "!", "@", "#", "$", "%", "&", "*", "[", "]", "{", "}", ".", "/", ";" })
            {
                @_str = @_str.Replace(chr, "");
            }

            StringBuilder stb = new StringBuilder(@_str);

            return stb.ToString();
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

        public bool validaCampos()
        {
            bool msg = false;
            string strMsg = string.Empty;

            if (string.IsNullOrEmpty(txtUsuario.Text) || validaSenha(txtUsuario.Text))
            {
                msg = true;
                strMsg += "\nUsuário Incorreta!";
            }
            if (string.IsNullOrEmpty(txtSenha.Text) || validaSenha(txtSenha.Text))
            {
                msg = true;
                strMsg += "\nSenhas Incorreta!";
            }
            if (string.IsNullOrEmpty(txtSenha2.Text) || validaSenha(txtSenha2.Text))
            {
                msg = true;
                strMsg += "\nSenhas Incorreta!";
            }
            if (string.IsNullOrEmpty(txtPsec.Text) || validaSenha(txtPsec.Text))
            {
                msg = true;
                strMsg += "\nPergunta secreta Incorreta!";
            }
            if (string.IsNullOrEmpty(txtRsec.Text) || validaSenha(txtRsec.Text))
            {
                msg = true;
                strMsg += "\nResposta secreta Incorreta!";
            }

            if (msg) MessageBox.Show(strMsg);

            return msg;

        }

        #endregion 
    }
}
