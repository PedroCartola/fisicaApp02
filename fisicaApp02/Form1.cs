namespace fisicaApp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVelocidadeMedia_Click(object sender, EventArgs e)
        {
            double velocidademedia = (double)nudDistancia.Value / (double)nudTempo.Value;
            txtResultado.Text = velocidademedia.ToString() + " m/s";
        }

        private void btAceleracao_Click(object sender, EventArgs e)
        {
            double aceleracao = (double)nudVelocidade.Value / (double)nudTempo.Value;
            txtResultado.Text = aceleracao.ToString() + " m/s²";
        }

        private void btMovimentoUniforme_Click(object sender, EventArgs e)
        {
            double movimento = (double)nudVelocidade.Value * (double)nudTempo.Value;
            txtResultado.Text = movimento.ToString() + " m";
        }

        private void btTorricelli_Click(object sender, EventArgs e)
        {
            double torricelli = ((double)nudVelocidade.Value*(double)nudVelocidade.Value)+(2*(double)nudAceleracao.Value*(double)nudDistancia.Value);
            if (torricelli <= 0)
            {
                MessageBox.Show("Delta 0 ou negativo");
            }
            else
            {
                torricelli = Math.Sqrt(torricelli);
                txtResultado.Text = torricelli.ToString() + " m/s";
            }
        }
    }
}
