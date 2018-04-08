namespace TCC
{
    partial class frmEditPaci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCanc = new MetroFramework.Controls.MetroButton();
            this.btnGravar = new MetroFramework.Controls.MetroButton();
            this.dtNasc = new MetroFramework.Controls.MetroDateTime();
            this.cbxUf = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtCep = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtBairro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtEnd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtNac = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.rdbMasc = new MetroFramework.Controls.MetroRadioButton();
            this.rdbFem = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtFone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtRg = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCpf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCod = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(279, 516);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(88, 45);
            this.btnCanc.TabIndex = 77;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseSelectable = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(107, 516);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(88, 45);
            this.btnGravar.TabIndex = 76;
            this.btnGravar.Text = "Confirmar";
            this.btnGravar.UseSelectable = true;
            // 
            // dtNasc
            // 
            this.dtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNasc.Location = new System.Drawing.Point(294, 188);
            this.dtNasc.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtNasc.Name = "dtNasc";
            this.dtNasc.Size = new System.Drawing.Size(144, 29);
            this.dtNasc.TabIndex = 75;
            // 
            // cbxUf
            // 
            this.cbxUf.FormattingEnabled = true;
            this.cbxUf.ItemHeight = 23;
            this.cbxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbxUf.Location = new System.Drawing.Point(294, 458);
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.Size = new System.Drawing.Size(73, 29);
            this.cbxUf.TabIndex = 74;
            this.cbxUf.UseSelectable = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(294, 436);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(25, 19);
            this.metroLabel12.TabIndex = 73;
            this.metroLabel12.Text = "UF";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(23, 436);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(33, 19);
            this.metroLabel11.TabIndex = 72;
            this.metroLabel11.Text = "CEP";
            // 
            // txtCep
            // 
            // 
            // 
            // 
            this.txtCep.CustomButton.Image = null;
            this.txtCep.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtCep.CustomButton.Name = "";
            this.txtCep.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCep.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCep.CustomButton.TabIndex = 1;
            this.txtCep.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCep.CustomButton.UseSelectable = true;
            this.txtCep.CustomButton.Visible = false;
            this.txtCep.Lines = new string[0];
            this.txtCep.Location = new System.Drawing.Point(23, 458);
            this.txtCep.MaxLength = 32767;
            this.txtCep.Name = "txtCep";
            this.txtCep.PasswordChar = '\0';
            this.txtCep.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCep.SelectedText = "";
            this.txtCep.SelectionLength = 0;
            this.txtCep.SelectionStart = 0;
            this.txtCep.ShortcutsEnabled = true;
            this.txtCep.Size = new System.Drawing.Size(172, 25);
            this.txtCep.TabIndex = 71;
            this.txtCep.UseSelectable = true;
            this.txtCep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(294, 386);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 70;
            this.metroLabel10.Text = "Cidade";
            // 
            // txtCidade
            // 
            // 
            // 
            // 
            this.txtCidade.CustomButton.Image = null;
            this.txtCidade.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtCidade.CustomButton.Name = "";
            this.txtCidade.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCidade.CustomButton.TabIndex = 1;
            this.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCidade.CustomButton.UseSelectable = true;
            this.txtCidade.CustomButton.Visible = false;
            this.txtCidade.Lines = new string[0];
            this.txtCidade.Location = new System.Drawing.Point(294, 408);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(172, 25);
            this.txtCidade.TabIndex = 69;
            this.txtCidade.UseSelectable = true;
            this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(23, 386);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(45, 19);
            this.metroLabel9.TabIndex = 68;
            this.metroLabel9.Text = "Bairro";
            // 
            // txtBairro
            // 
            // 
            // 
            // 
            this.txtBairro.CustomButton.Image = null;
            this.txtBairro.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtBairro.CustomButton.Name = "";
            this.txtBairro.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBairro.CustomButton.TabIndex = 1;
            this.txtBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBairro.CustomButton.UseSelectable = true;
            this.txtBairro.CustomButton.Visible = false;
            this.txtBairro.Lines = new string[0];
            this.txtBairro.Location = new System.Drawing.Point(23, 408);
            this.txtBairro.MaxLength = 32767;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.Size = new System.Drawing.Size(172, 25);
            this.txtBairro.TabIndex = 67;
            this.txtBairro.UseSelectable = true;
            this.txtBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 336);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(64, 19);
            this.metroLabel8.TabIndex = 66;
            this.metroLabel8.Text = "Endereço";
            // 
            // txtEnd
            // 
            // 
            // 
            // 
            this.txtEnd.CustomButton.Image = null;
            this.txtEnd.CustomButton.Location = new System.Drawing.Point(419, 1);
            this.txtEnd.CustomButton.Name = "";
            this.txtEnd.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEnd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnd.CustomButton.TabIndex = 1;
            this.txtEnd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnd.CustomButton.UseSelectable = true;
            this.txtEnd.CustomButton.Visible = false;
            this.txtEnd.Lines = new string[0];
            this.txtEnd.Location = new System.Drawing.Point(23, 358);
            this.txtEnd.MaxLength = 32767;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.PasswordChar = '\0';
            this.txtEnd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnd.SelectedText = "";
            this.txtEnd.SelectionLength = 0;
            this.txtEnd.SelectionStart = 0;
            this.txtEnd.ShortcutsEnabled = true;
            this.txtEnd.Size = new System.Drawing.Size(443, 25);
            this.txtEnd.TabIndex = 65;
            this.txtEnd.UseSelectable = true;
            this.txtEnd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(294, 277);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 19);
            this.metroLabel7.TabIndex = 64;
            this.metroLabel7.Text = "Nacionalidade";
            // 
            // txtNac
            // 
            // 
            // 
            // 
            this.txtNac.CustomButton.Image = null;
            this.txtNac.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtNac.CustomButton.Name = "";
            this.txtNac.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNac.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNac.CustomButton.TabIndex = 1;
            this.txtNac.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNac.CustomButton.UseSelectable = true;
            this.txtNac.CustomButton.Visible = false;
            this.txtNac.Lines = new string[0];
            this.txtNac.Location = new System.Drawing.Point(294, 299);
            this.txtNac.MaxLength = 32767;
            this.txtNac.Name = "txtNac";
            this.txtNac.PasswordChar = '\0';
            this.txtNac.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNac.SelectedText = "";
            this.txtNac.SelectionLength = 0;
            this.txtNac.SelectionStart = 0;
            this.txtNac.ShortcutsEnabled = true;
            this.txtNac.Size = new System.Drawing.Size(172, 25);
            this.txtNac.TabIndex = 63;
            this.txtNac.UseSelectable = true;
            this.txtNac.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNac.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(294, 223);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(37, 19);
            this.metroLabel6.TabIndex = 62;
            this.metroLabel6.Text = "Sexo";
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdbMasc.Location = new System.Drawing.Point(386, 245);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(87, 19);
            this.rdbMasc.TabIndex = 61;
            this.rdbMasc.Text = "Masculino";
            this.rdbMasc.UseSelectable = true;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdbFem.Location = new System.Drawing.Point(294, 245);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(81, 19);
            this.rdbFem.TabIndex = 60;
            this.rdbFem.Text = "Feminino";
            this.rdbFem.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 277);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 19);
            this.metroLabel5.TabIndex = 59;
            this.metroLabel5.Text = "Telefone";
            // 
            // txtFone
            // 
            // 
            // 
            // 
            this.txtFone.CustomButton.Image = null;
            this.txtFone.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtFone.CustomButton.Name = "";
            this.txtFone.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtFone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFone.CustomButton.TabIndex = 1;
            this.txtFone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFone.CustomButton.UseSelectable = true;
            this.txtFone.CustomButton.Visible = false;
            this.txtFone.Lines = new string[0];
            this.txtFone.Location = new System.Drawing.Point(23, 299);
            this.txtFone.MaxLength = 32767;
            this.txtFone.Name = "txtFone";
            this.txtFone.PasswordChar = '\0';
            this.txtFone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFone.SelectedText = "";
            this.txtFone.SelectionLength = 0;
            this.txtFone.SelectionStart = 0;
            this.txtFone.ShortcutsEnabled = true;
            this.txtFone.Size = new System.Drawing.Size(172, 25);
            this.txtFone.TabIndex = 58;
            this.txtFone.UseSelectable = true;
            this.txtFone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(294, 166);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(125, 19);
            this.metroLabel4.TabIndex = 57;
            this.metroLabel4.Text = "Data de nascimento";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 223);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(26, 19);
            this.metroLabel3.TabIndex = 56;
            this.metroLabel3.Text = "RG";
            // 
            // txtRg
            // 
            // 
            // 
            // 
            this.txtRg.CustomButton.Image = null;
            this.txtRg.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtRg.CustomButton.Name = "";
            this.txtRg.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRg.CustomButton.TabIndex = 1;
            this.txtRg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRg.CustomButton.UseSelectable = true;
            this.txtRg.CustomButton.Visible = false;
            this.txtRg.Lines = new string[0];
            this.txtRg.Location = new System.Drawing.Point(23, 245);
            this.txtRg.MaxLength = 32767;
            this.txtRg.Name = "txtRg";
            this.txtRg.PasswordChar = '\0';
            this.txtRg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRg.SelectedText = "";
            this.txtRg.SelectionLength = 0;
            this.txtRg.SelectionStart = 0;
            this.txtRg.ShortcutsEnabled = true;
            this.txtRg.Size = new System.Drawing.Size(172, 25);
            this.txtRg.TabIndex = 55;
            this.txtRg.UseSelectable = true;
            this.txtRg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 166);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(33, 19);
            this.metroLabel2.TabIndex = 54;
            this.metroLabel2.Text = "CPF";
            // 
            // txtCpf
            // 
            // 
            // 
            // 
            this.txtCpf.CustomButton.Image = null;
            this.txtCpf.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtCpf.CustomButton.Name = "";
            this.txtCpf.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCpf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpf.CustomButton.TabIndex = 1;
            this.txtCpf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpf.CustomButton.UseSelectable = true;
            this.txtCpf.CustomButton.Visible = false;
            this.txtCpf.Lines = new string[0];
            this.txtCpf.Location = new System.Drawing.Point(23, 188);
            this.txtCpf.MaxLength = 32767;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.ShortcutsEnabled = true;
            this.txtCpf.Size = new System.Drawing.Size(172, 25);
            this.txtCpf.TabIndex = 53;
            this.txtCpf.UseSelectable = true;
            this.txtCpf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, -38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 52;
            this.metroLabel1.Text = "ID";
            // 
            // txtCod
            // 
            // 
            // 
            // 
            this.txtCod.CustomButton.Image = null;
            this.txtCod.CustomButton.Location = new System.Drawing.Point(42, 1);
            this.txtCod.CustomButton.Name = "";
            this.txtCod.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCod.CustomButton.TabIndex = 1;
            this.txtCod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCod.CustomButton.UseSelectable = true;
            this.txtCod.CustomButton.Visible = false;
            this.txtCod.Lines = new string[0];
            this.txtCod.Location = new System.Drawing.Point(23, 80);
            this.txtCod.MaxLength = 32767;
            this.txtCod.Name = "txtCod";
            this.txtCod.PasswordChar = '\0';
            this.txtCod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCod.SelectedText = "";
            this.txtCod.SelectionLength = 0;
            this.txtCod.SelectionStart = 0;
            this.txtCod.ShortcutsEnabled = true;
            this.txtCod.Size = new System.Drawing.Size(66, 25);
            this.txtCod.TabIndex = 51;
            this.txtCod.UseSelectable = true;
            this.txtCod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(426, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(23, 134);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(450, 25);
            this.txtNome.TabIndex = 49;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmEditPaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 586);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.dtNasc);
            this.Controls.Add(this.cbxUf);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtNac);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.rdbMasc);
            this.Controls.Add(this.rdbFem);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmEditPaci";
            this.Text = "Edição de paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCanc;
        private MetroFramework.Controls.MetroButton btnGravar;
        private MetroFramework.Controls.MetroDateTime dtNasc;
        private MetroFramework.Controls.MetroComboBox cbxUf;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtCep;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtBairro;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtEnd;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtNac;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroRadioButton rdbMasc;
        private MetroFramework.Controls.MetroRadioButton rdbFem;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtFone;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtRg;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCpf;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCod;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox txtNome;
    }
}