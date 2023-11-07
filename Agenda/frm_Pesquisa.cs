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
    public partial class frm_Pesquisa : Form
    {
        public bool cancelado { get; set;}
        public string texto { get; set; }
        public frm_Pesquisa()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
           this.Close();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_pesquisa.Text=="")
            {
                return;
            }
            texto = txt_pesquisa.Text;
            cancelado = false;
            this.Close();
        }
    }
}
