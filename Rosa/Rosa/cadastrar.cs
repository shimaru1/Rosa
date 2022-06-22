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
    public partial class Cadastrar : Form
    {
        DAOCadastro cadastro;
        public Cadastrar()
        {
            InitializeComponent();
            cadastro = new DAOCadastro();// Abrindo a conexão com o Banco de dados 
            
        }// Fim do metodo de construtor

        private void NomeBox_TextChanged(object sender, EventArgs e)
        {

        }// caixa de infomação do nome

        private void DataBox_TextChanged(object sender, EventArgs e)
        {

        }// Caixa de informação do Data de nacimento

        private void PesoBox_TextChanged(object sender, EventArgs e)
        {

        }// Caixa de informação Peso 

        private void MenarcaBox_TextChanged(object sender, EventArgs e)
        {

        }//Caixa de infomação menarca 

        private void MenoPausaBox_TextChanged(object sender, EventArgs e)
        {

        }//Caixa de informação da menopausa

        private void CodigoBox_TextChanged(object sender, EventArgs e)
        {

        }//Caixa de informação do codigo 

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                
                string nome = (NomeBox.Text);
                string menopausa = (MenoPausaBox.Text);
                string menarca = (MenarcaBox.Text);
                DateTime dataN = Convert.ToDateTime(DataBox.Text);
                decimal peso = Convert.ToDecimal(PesoBox.Text);
                //Chamar o método inserir que foi Criado na classe cadastrar
                cadastro.InserirCA(nome, menopausa, menarca, dataN, peso);
            }
            catch (Exception er)
            {
                MessageBox.Show("" + er);
            }


        }//Fim do Cadastrar

     
     

    }
}
