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
    public partial class frm_Inserir_Editar : Form
    {
        int indice;
        public frm_Inserir_Editar()
        {
            InitializeComponent();
            ConstroiLista();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text == "" || txt_Numero.Text == "")
            {
                MessageBox.Show("Preencha os Campos vazios");
                return;
            }
            foreach (cl_Contactos contacto in cl_Geral.ListaContactos)
            {
                if (contacto.nome == txt_Nome.Text && contacto.numero == txt_Numero.Text)
                {
                    MessageBox.Show("O Contacto Já Foi Gravado", "AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
            }
            cl_Geral.GravarNovoContacto(txt_Nome.Text, txt_Numero.Text);
            ConstroiLista();
            txt_Nome.Text = "";
            txt_Numero.Text = "";
            txt_Nome.Focus();
        }
        private void ConstroiLista()
        {
            lst_Contactos.Items.Clear();
            foreach (cl_Contactos contacto in cl_Geral.ListaContactos)
            {
                lst_Contactos.Items.Add(contacto.nome + " ( " + contacto.numero + " )");
                lbl_Numero_Registo.Text = " Registos: " + lst_Contactos.Items.Count;
            }
            btn_Apagar.Enabled = false;
            btn_Editar.Enabled = false;
        }

        private void lst_Contactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Contactos.SelectedIndex == -1)
                return;
            indice = lst_Contactos.SelectedIndex;
            btn_Apagar.Enabled = true;
            btn_Editar.Enabled = true;
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Apagar O Contacto ?", "Apagar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            cl_Geral.ListaContactos.RemoveAt(indice);
            cl_Geral.GravarFicheiro();
            ConstroiLista();

        }
    }
}
