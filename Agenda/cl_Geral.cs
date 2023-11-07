using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Agenda
{
    public static class cl_Geral
    {
        public static List<cl_Contactos> ListaContactos;
        public static void ConstroiListaContactos() 
        {
            string Pasta_Doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string Nome_Ficheiro = Pasta_Doc + @"/Lista_Contactos.txt";
            ListaContactos = new List<cl_Contactos>();
            if (File.Exists(Nome_Ficheiro))
            {
                StreamReader ficheiro = new StreamReader(Nome_Ficheiro, Encoding.Default);
                while (!ficheiro.EndOfStream)
                {
                    string nome = ficheiro.ReadLine();
                    string numero = ficheiro.ReadLine();
                    cl_Contactos novo_Contacto = new cl_Contactos();
                    novo_Contacto.nome = nome;
                    novo_Contacto.numero = numero;
                    ListaContactos.Add(novo_Contacto);
                }
                ficheiro.Dispose();
            }
        }
        public static void GravarNovoContacto(string nome, string numero)
        {
            ListaContactos.Add(new cl_Contactos() { nome = nome, numero = numero });
            GravarFicheiro();
        }
        public static void GravarFicheiro()
        {
            string Pasta_Doc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string Nome_Ficheiro = Pasta_Doc + @"/Lista_Contactos.txt";
            StreamWriter ficheiro = new StreamWriter(Nome_Ficheiro, false, Encoding.Default);
            foreach (cl_Contactos contacto in ListaContactos)
            {
                ficheiro.WriteLine(contacto.nome);
                ficheiro.WriteLine(contacto.numero);
            }
            ficheiro.Dispose();
        }
    }
}
