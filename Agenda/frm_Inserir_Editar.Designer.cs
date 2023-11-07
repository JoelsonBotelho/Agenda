namespace Agenda
{
    partial class frm_Inserir_Editar
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_Nome = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Numero = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btn_Gravar = new DevComponents.DotNetBar.ButtonX();
            this.lst_Contactos = new DevComponents.DotNetBar.ListBoxAdv();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Numero_Registo = new DevComponents.DotNetBar.LabelX();
            this.btn_Apagar = new DevComponents.DotNetBar.ButtonX();
            this.btn_Editar = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Voltar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Voltar.Location = new System.Drawing.Point(656, 593);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(120, 41);
            this.btn_Voltar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Voltar.Symbol = "";
            this.btn_Voltar.SymbolSize = 15F;
            this.btn_Voltar.TabIndex = 3;
            this.btn_Voltar.Text = " Voltar";
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(13, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(131, 34);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolSize = 15F;
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = " Nome :";
            // 
            // txt_Nome
            // 
            // 
            // 
            // 
            this.txt_Nome.Border.Class = "TextBoxBorder";
            this.txt_Nome.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Nome.Location = new System.Drawing.Point(150, 13);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.PreventEnterBeep = true;
            this.txt_Nome.Size = new System.Drawing.Size(582, 34);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Numero
            // 
            // 
            // 
            // 
            this.txt_Numero.Border.Class = "TextBoxBorder";
            this.txt_Numero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Numero.Location = new System.Drawing.Point(150, 53);
            this.txt_Numero.MaxLength = 20;
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.PreventEnterBeep = true;
            this.txt_Numero.Size = new System.Drawing.Size(317, 34);
            this.txt_Numero.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX2.Location = new System.Drawing.Point(13, 53);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(131, 34);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolSize = 15F;
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = " Número :";
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Gravar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Gravar.Location = new System.Drawing.Point(13, 93);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(131, 41);
            this.btn_Gravar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Gravar.Symbol = "";
            this.btn_Gravar.SymbolSize = 15F;
            this.btn_Gravar.TabIndex = 2;
            this.btn_Gravar.Text = " Gravar";
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // lst_Contactos
            // 
            this.lst_Contactos.AutoScroll = true;
            // 
            // 
            // 
            this.lst_Contactos.BackgroundStyle.Class = "ListBoxAdv";
            this.lst_Contactos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lst_Contactos.ContainerControlProcessDialogKey = true;
            this.lst_Contactos.DragDropSupport = true;
            this.lst_Contactos.Location = new System.Drawing.Point(13, 180);
            this.lst_Contactos.Name = "lst_Contactos";
            this.lst_Contactos.Size = new System.Drawing.Size(763, 407);
            this.lst_Contactos.TabIndex = 9;
            this.lst_Contactos.Text = "listBoxAdv1";
            this.lst_Contactos.SelectedIndexChanged += new System.EventHandler(this.lst_Contactos_SelectedIndexChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Location = new System.Drawing.Point(13, 140);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(407, 34);
            this.labelX3.Symbol = "";
            this.labelX3.SymbolSize = 15F;
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = " Lista De Contactos Registados";
            // 
            // lbl_Numero_Registo
            // 
            // 
            // 
            // 
            this.lbl_Numero_Registo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Numero_Registo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Numero_Registo.Location = new System.Drawing.Point(12, 593);
            this.lbl_Numero_Registo.Name = "lbl_Numero_Registo";
            this.lbl_Numero_Registo.Size = new System.Drawing.Size(275, 34);
            this.lbl_Numero_Registo.Symbol = "";
            this.lbl_Numero_Registo.SymbolSize = 15F;
            this.lbl_Numero_Registo.TabIndex = 10;
            this.lbl_Numero_Registo.Text = " Número De Registos : 0";
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Apagar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Apagar.Location = new System.Drawing.Point(518, 593);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(120, 41);
            this.btn_Apagar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Apagar.Symbol = "";
            this.btn_Apagar.SymbolSize = 15F;
            this.btn_Apagar.TabIndex = 4;
            this.btn_Apagar.Text = " Apagar";
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Editar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Editar.Location = new System.Drawing.Point(381, 593);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(120, 41);
            this.btn_Editar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Editar.Symbol = "";
            this.btn_Editar.SymbolSize = 15F;
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = " Editar";
            // 
            // frm_Inserir_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 646);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.lbl_Numero_Registo);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.lst_Contactos);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_Voltar);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Inserir_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Inserir_Editar";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_Voltar;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Nome;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Numero;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btn_Gravar;
        private DevComponents.DotNetBar.ListBoxAdv lst_Contactos;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbl_Numero_Registo;
        private DevComponents.DotNetBar.ButtonX btn_Apagar;
        private DevComponents.DotNetBar.ButtonX btn_Editar;
    }
}