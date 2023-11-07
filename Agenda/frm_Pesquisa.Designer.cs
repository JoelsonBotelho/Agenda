namespace Agenda
{
    partial class frm_Pesquisa
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_pesquisa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Pesquisar = new DevComponents.DotNetBar.ButtonX();
            this.btn_Cancelar = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
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
            this.labelX1.Size = new System.Drawing.Size(337, 33);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolSize = 15F;
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = " Digite o Nome ou o Número";
            // 
            // txt_pesquisa
            // 
            // 
            // 
            // 
            this.txt_pesquisa.Border.Class = "TextBoxBorder";
            this.txt_pesquisa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_pesquisa.Location = new System.Drawing.Point(13, 52);
            this.txt_pesquisa.MaxLength = 30;
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.PreventEnterBeep = true;
            this.txt_pesquisa.Size = new System.Drawing.Size(337, 34);
            this.txt_pesquisa.TabIndex = 0;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Pesquisar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Pesquisar.Location = new System.Drawing.Point(13, 92);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(162, 41);
            this.btn_Pesquisar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btn_Pesquisar.Symbol = "";
            this.btn_Pesquisar.SymbolSize = 15F;
            this.btn_Pesquisar.TabIndex = 1;
            this.btn_Pesquisar.Text = " Pesquisar";
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Cancelar.Location = new System.Drawing.Point(188, 92);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(162, 41);
            this.btn_Cancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btn_Cancelar.Symbol = "";
            this.btn_Cancelar.SymbolSize = 15F;
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 143);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Pesquisa";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_pesquisa;
        private DevComponents.DotNetBar.ButtonX btn_Pesquisar;
        private DevComponents.DotNetBar.ButtonX btn_Cancelar;
    }
}