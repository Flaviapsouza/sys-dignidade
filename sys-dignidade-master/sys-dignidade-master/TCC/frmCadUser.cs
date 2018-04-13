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
    public partial class frmCadUser : MetroFramework.Forms.MetroForm
    {
        public frmCadUser()
        {
            InitializeComponent();
        }

        private void frmCadUser_Load(object sender, EventArgs e)
        {
            cbxTipoUser.SelectedIndex = 0;
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            bool ok = false;
            string ret = string.Empty;
            if (validaSenha(txtUser.Text))
            {
                ok = true;
                ret = "Usuário Inválido!";
            }
            if (validaSenha(txtNome.Text))
            {
                ok = true;
                ret += "Nome Inválido!";
            }

            if (ok)
            { MessageBox.Show(ret); }
            else
            {
                daoPaciente dp = new daoPaciente();
                dp.chkUser(tratarStr(txtUser.Text), tratarStr(txtNome.Text), cbxTipoUser.Text);
                MessageBox.Show("Usuário Cadastrado com Sucesso!");
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

    }
}
