﻿namespace TCC
{
    partial class frmEditUser
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
            this.cbxTipoUser = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.btnCanc = new MetroFramework.Controls.MetroButton();
            this.btnConfirma = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cbxTipoUser
            // 
            this.cbxTipoUser.FormattingEnabled = true;
            this.cbxTipoUser.ItemHeight = 23;
            this.cbxTipoUser.Items.AddRange(new object[] {
            "Interno",
            "Externo"});
            this.cbxTipoUser.Location = new System.Drawing.Point(24, 221);
            this.cbxTipoUser.Name = "cbxTipoUser";
            this.cbxTipoUser.Size = new System.Drawing.Size(170, 29);
            this.cbxTipoUser.TabIndex = 27;
            this.cbxTipoUser.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 199);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "Tipo de usuário";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 25;
            this.metroLabel1.Text = "Usuário";
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(23, 152);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(172, 25);
            this.txtUser.TabIndex = 24;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(297, 276);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(87, 54);
            this.btnCanc.TabIndex = 23;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseSelectable = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(108, 276);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(87, 54);
            this.btnConfirma.TabIndex = 22;
            this.btnConfirma.Text = "Confirmar";
            this.btnConfirma.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 68);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Nome";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(337, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(23, 90);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(361, 25);
            this.txtNome.TabIndex = 20;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 362);
            this.Controls.Add(this.cbxTipoUser);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtNome);
            this.Name = "frmEditUser";
            this.Text = "Edição de usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbxTipoUser;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroButton btnCanc;
        private MetroFramework.Controls.MetroButton btnConfirma;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtNome;
    }
}