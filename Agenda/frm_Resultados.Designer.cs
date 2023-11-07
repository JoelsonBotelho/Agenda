namespace Agenda
{
    partial class frm_Resultados
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
            this.btn_Voltar = new DevComponents.DotNetBar.ButtonX();
            this.btn_NovaPesquisa = new DevComponents.DotNetBar.ButtonX();
            this.lst_Resultado = new DevComponents.DotNetBar.ListBoxAdv();
            this.lbl_Numero_Registo = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Voltar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Voltar.Location = new System.Drawing.Point(421, 238);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(107, 49);
            this.btn_Voltar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Voltar.Symbol = "";
            this.btn_Voltar.SymbolSize = 15F;
            this.btn_Voltar.TabIndex = 0;
            this.btn_Voltar.Text = " Voltar";
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_NovaPesquisa
            // 
            this.btn_NovaPesquisa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_NovaPesquisa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_NovaPesquisa.Location = new System.Drawing.Point(217, 238);
            this.btn_NovaPesquisa.Name = "btn_NovaPesquisa";
            this.btn_NovaPesquisa.Size = new System.Drawing.Size(191, 49);
            this.btn_NovaPesquisa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_NovaPesquisa.Symbol = "";
            this.btn_NovaPesquisa.SymbolSize = 15F;
            this.btn_NovaPesquisa.TabIndex = 1;
            this.btn_NovaPesquisa.Text = " Nova Pesquisa";
            this.btn_NovaPesquisa.Click += new System.EventHandler(this.btn_NovaPesquisa_Click);
            // 
            // lst_Resultado
            // 
            this.lst_Resultado.AutoScroll = true;
            // 
            // 
            // 
            this.lst_Resultado.BackgroundStyle.Class = "ListBoxAdv";
            this.lst_Resultado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lst_Resultado.CheckStateMember = null;
            this.lst_Resultado.ContainerControlProcessDialogKey = true;
            this.lst_Resultado.DragDropSupport = true;
            this.lst_Resultado.Location = new System.Drawing.Point(13, 13);
            this.lst_Resultado.Name = "lst_Resultado";
            this.lst_Resultado.Size = new System.Drawing.Size(515, 216);
            this.lst_Resultado.TabIndex = 2;
            this.lst_Resultado.Text = "listBoxAdv1";
            // 
            // lbl_Numero_Registo
            // 
            // 
            // 
            // 
            this.lbl_Numero_Registo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Numero_Registo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Numero_Registo.Location = new System.Drawing.Point(13, 238);
            this.lbl_Numero_Registo.Name = "lbl_Numero_Registo";
            this.lbl_Numero_Registo.Size = new System.Drawing.Size(189, 44);
            this.lbl_Numero_Registo.Symbol = "";
            this.lbl_Numero_Registo.SymbolSize = 15F;
            this.lbl_Numero_Registo.TabIndex = 11;
            this.lbl_Numero_Registo.Text = " Registos : 0";
            // 
            // frm_Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 294);
            this.Controls.Add(this.lbl_Numero_Registo);
            this.Controls.Add(this.lst_Resultado);
            this.Controls.Add(this.btn_NovaPesquisa);
            this.Controls.Add(this.btn_Voltar);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Resultados";
            this.Load += new System.EventHandler(this.frm_Resultados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_Voltar;
        private DevComponents.DotNetBar.ButtonX btn_NovaPesquisa;
        private DevComponents.DotNetBar.ListBoxAdv lst_Resultado;
        private DevComponents.DotNetBar.LabelX lbl_Numero_Registo;
    }
}