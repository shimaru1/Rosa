using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace Rosa
{

    public partial class Form1 : Form
    {

        Ciclo cicloo;
        Cadastrar cadastro;
        public Form1()
        {

            cicloo = new Ciclo();
            InitializeComponent();

            cadastro = new Cadastrar();

        }//fim do contrutor

        private void cadastrar_Click(object sender, EventArgs e)
        {
            cadastro.ShowDialog();
        }//Fim do botão Cadastrar

        private void ciclo_Click(object sender, EventArgs e)
        {

        }// Fim do Botão Ciclo

        private void consultar_Click(object sender, EventArgs e)
        {

        }// Fim do Botão Consultar
    }//Fim da Class
}//Fim do Programa
       

