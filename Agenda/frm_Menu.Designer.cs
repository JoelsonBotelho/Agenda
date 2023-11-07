namespace Agenda
{
    partial class frm_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_Inserir_Editar = new DevComponents.DotNetBar.ButtonX();
            this.btn_Pesquisar = new DevComponents.DotNetBar.ButtonX();
            this.btn_Sair = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Location = new System.Drawing.Point(151, 56);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(154, 23);
            this.labelX1.Symbol = "57551";
            this.labelX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "AGENDA";
            // 
            // btn_Inserir_Editar
            // 
            this.btn_Inserir_Editar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Inserir_Editar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Inserir_Editar.Location = new System.Drawing.Point(133, 142);
            this.btn_Inserir_Editar.Name = "btn_Inserir_Editar";
            this.btn_Inserir_Editar.Size = new System.Drawing.Size(190, 52);
            this.btn_Inserir_Editar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Inserir_Editar.Symbol = "";
            this.btn_Inserir_Editar.SymbolColor = System.Drawing.Color.Black;
            this.btn_Inserir_Editar.SymbolSize = 15F;
            this.btn_Inserir_Editar.TabIndex = 0;
            this.btn_Inserir_Editar.Text = " Inserir / Editar";
            this.btn_Inserir_Editar.Click += new System.EventHandler(this.btn_Inserir_Editar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Pesquisar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Pesquisar.Location = new System.Drawing.Point(133, 212);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(190, 52);
            this.btn_Pesquisar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Pesquisar.Symbol = "";
            this.btn_Pesquisar.SymbolColor = System.Drawing.Color.Black;
            this.btn_Pesquisar.SymbolSize = 15F;
            this.btn_Pesquisar.TabIndex = 1;
            this.btn_Pesquisar.Text = " Pesquisar";
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sair.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btn_Sair.Location = new System.Drawing.Point(133, 282);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(190, 52);
            this.btn_Sair.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sair.Symbol = "";
            this.btn_Sair.SymbolColor = System.Drawing.Color.Black;
            this.btn_Sair.SymbolSize = 15F;
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = " Sair";
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 395);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Inserir_Editar);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_Inserir_Editar;
        private DevComponents.DotNetBar.ButtonX btn_Pesquisar;
        private DevComponents.DotNetBar.ButtonX btn_Sair;
    }
}

