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
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void linkRecuperarSenha_Click(object sender, EventArgs e)
        {
            frmRecSenha frmrs = new frmRecSenha();
            frmrs.ShowDialog();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            daoPaciente dp = new daoPaciente();
            int usuarioLog = dp.validaUsuario(tratarStr(txtUsuario.Text), tratarStr(txtSenha.Text));
            if (usuarioLog > 0)
            {
                frmPrincipal fp = new frmPrincipal();
                fp.gravaUser(usuarioLog);
                fp.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos!");
            }
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
        #endregion

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkPrAcesso_LinkClicked(object sender, EventArgs e)
        {
            frmPrimeiroAcesso pa = new frmPrimeiroAcesso();
            pa.ShowDialog();

        }
    }
}
