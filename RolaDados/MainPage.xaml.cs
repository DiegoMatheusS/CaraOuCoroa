using RolaDados.Models;

namespace RolaDados
{
    public partial class MainPage : ContentPage
    {
        string escolha = "";
        int escolhaResultado = 0;

        public MainPage()
        {
            InitializeComponent();
            SidesPicker.SelectedIndex = 0;
        }

        private void dadoBtn_Clicked(object sender, EventArgs e)
        {
            //Pegar a opção escolhida e armazenar
            escolha = SidesPicker.SelectedItem.ToString();

            //Sortear um número
            int rnd = new Coin().Girar();

            //Comparar o que o usuário escolheu com o número sorteado
            EscolhaResultado("Cara");


            //Exibe a mensagem de resultado do sorteio
            ExibirMensagem(rnd);


            //Troca a imagem de acordo com o número sorteado
            TrocarImagem(rnd);

        }
        private void EscolhaResultado(string escolhaDoUsuario)
        {
            if (escolha == escolhaDoUsuario)
            {
                escolhaResultado = (int)CoinType.CARA;
            }
            else
            {
                escolhaResultado = (int)CoinType.COROA;
            }
        }
        private void ExibirMensagem(int rnd)
        {
            if (escolhaResultado == rnd)
            {
                Result.Text = $"Eba, deu {escolha}, você ganhou!";
            }
            else
            {
                Result.Text = $"Que pena, não deu {escolha}, você perdeu!";
            }
        }

        private void TrocarImagem(int rnd)
        {
            switch (rnd)
            {
                case (int)CoinType.CARA:
                default:
                    CoinImage.Source = "cara.jpg";
                    break;
                case (int)CoinType.COROA:
                    CoinImage.Source = "coroa.jpg";
                    break;
            }
        }
    }
}
