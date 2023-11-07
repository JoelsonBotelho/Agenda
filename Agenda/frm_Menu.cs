using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
            cl_Geral.ConstroiListaContactos();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) 
                return;
            Application.Exit();
        }

        private void btn_Inserir_Editar_Click(object sender, EventArgs e)
        {
            frm_Inserir_Editar frmIE = new frm_Inserir_Editar();
            frmIE.ShowDialog();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            frm_Pesquisa frmPes = new frm_Pesquisa();
            frmPes.ShowDialog();
            if (frmPes.cancelado) 
                return;
            frm_Resultados frmRe = new frm_Resultados(frmPes.texto);
            frmRe.ShowDialog();
        }
    }
}
