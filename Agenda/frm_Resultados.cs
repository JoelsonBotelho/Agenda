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
    public partial class frm_Resultados : Form
    {
        string texto;
        public frm_Resultados(string texto)
        {
            InitializeComponent();
            this.texto = texto.ToUpper();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Resultados_Load(object sender, EventArgs e)
        {
            ExecutaPesquisa();
        }

        private void ExecutaPesquisa()
        {
            List<cl_Contactos> Lista_Resultado = new List<cl_Contactos>();
            foreach (cl_Contactos contacto in cl_Geral.ListaContactos)
            {
                if (contacto.nome.ToUpper().Contains(texto) || contacto.numero.ToUpper().Contains(texto))
                {
                    Lista_Resultado.Add(contacto);
                }
            }
            lst_Resultado.Items.Clear();
            foreach (cl_Contactos contacto in Lista_Resultado)
            {
                lst_Resultado.Items.Add(contacto.nome + " ( " + contacto.numero + " )");
            }
            lbl_Numero_Registo.Text = " Registos: " + lst_Resultado.Items.Count;
        }

        private void btn_NovaPesquisa_Click(object sender, EventArgs e)
        {
            frm_Pesquisa frmPes = new frm_Pesquisa();
            frmPes.ShowDialog();
            if (frmPes.cancelado)
                return;
            texto = frmPes.texto.ToUpper();
            ExecutaPesquisa();
        }
    }
}
