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
    public partial class frmPesqPac : MetroFramework.Forms.MetroForm
    {
        public frmPesqPac()
        {
            InitializeComponent();
            gvPesqClie.AutoGenerateColumns = false;
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

        private void btnPesq_Click(object sender, EventArgs e)
        {
            string id = tratarStr(txtId.Text);
            string nome = tratarStr(txtNome.Text);
            string cpf = tratarStr(txtCpf.Text);

            gvPesqClie.DataSource = null;

            daoPaciente dp = new daoPaciente();
            if (dp.pesqPaciente(id, nome, cpf).Rows.Count > 0)
            {
                gvPesqClie.DataSource = dp.pesqPaciente(id, nome, cpf);
            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(gvPesqClie.CurrentRow.Cells["ID"].Value) > 0)
            {
                frmPaciente frm = new frmPaciente();
                frm.setaVar(true, Convert.ToInt16(gvPesqClie.CurrentRow.Cells["ID"].Value));
                this.Close();

            }
        }

        private void frmPesqPac_Load(object sender, EventArgs e)
        {

        }
    }
}