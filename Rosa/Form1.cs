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


namespace Rosa
{

    public partial class Form1 : Form
    {

        Ciclo cicloo;       
        public Form1()
        {

            cicloo = new Ciclo();
            InitializeComponent();
            
        }//fim do contrutor

        private void cadastrar_Click(object sender, EventArgs e)
        {

        }//Fim do botão Cadastrar

        private void ciclo_Click(object sender, EventArgs e)
        {

        }// Fim do Botão Ciclo

        private void consultar_Click(object sender, EventArgs e)
        {

        }// Fim do Botão Consultar
    }//Fim da Class
}//Fim do Programa
       

