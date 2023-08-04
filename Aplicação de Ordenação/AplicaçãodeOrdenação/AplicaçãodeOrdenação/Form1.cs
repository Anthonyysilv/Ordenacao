namespace AplicaçãodeOrdenação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Classe organizadora
        class Ordena
        {
            //Atributos/variaveis
            public string? name1;
            public string? name2;
            public string? name3;
        }
        //Botão
        private void button1_Click(object sender, EventArgs e)
        {
            //Chamando a classe Ordena
            Ordena ord = new();
            //O valor digitado nas textsBox são jogados na variavel correta
            ord.name1 = textBox1.Text;
            ord.name2 = textBox2.Text;
            ord.name3 = textBox3.Text;
            //Criação da variavel auxiliar
            string aux;
            //Criação da variavel res para jogar o resultado da comparação entre o name1 e name2
            int res = String.Compare(ord.name1, ord.name2);
            if (res > 0)
            {
                aux = ord.name1;
                ord.name1 = ord.name2;
                ord.name2 = aux;
            }
            int res1 = String.Compare(ord.name1, ord.name3);
            if (res1 > 0)
            {
                aux = ord.name1;
                ord.name1 = ord.name3;
                ord.name3 = aux;
            }
            int res2 = String.Compare(ord.name2, ord.name3);
            if (res2 > 0)
            {
                aux = ord.name2;
                ord.name2 = ord.name3;
                ord.name3 = aux;
            }
        }
        //Caixa de texto 1 - Nome1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Caixa de texto 2 - Nome2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //Caixa de texto 3 - Nome3
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //Caixa onde os nomes, já organizados devem aparecer
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}