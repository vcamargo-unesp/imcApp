namespace imcApp5
{
    public partial class ImcApp : Form
    {
        public ImcApp()
        {
            InitializeComponent();
        }

        decimal Imc(decimal p, decimal h)
        {
            return p / (h * h);
        }
        
        string Classificacao(decimal imc)
        {
            double i = (double)imc;
            if (i < 18.6)
                return "Abaixo do peso";
            if (i < 25)
                return "Peso ideal";
            if (i < 30)
                return "Levemente acima do peso";
            if (i < 35)
                return "Obesidade grau I";
            if (i < 40)
                return "Obesidade grau II";
            return "Obesidade grau III";
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            decimal peso, altura;

            peso = numPeso.Value;
            altura = numAltura.Value;

            if (altura == 0)
            {
                MessageBox.Show("Bota uma altura válida!");
            }
            else
            {
                decimal imc = Imc(peso, altura);

                lblCalculo.Text = imc.ToString("0.0");
                lblClass.Text = Classificacao(imc);
            }
        }
    }
}
