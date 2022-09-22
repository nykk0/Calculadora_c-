using System.Globalization;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valor1 = 0 , valor2=0;
        string operacao = "";

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtnumero.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtnumero.Text += "9";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtnumero.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtnumero.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtnumero.Text += "6";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtnumero.Text += "3";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtnumero.Text += "2";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtnumero.Text += "1";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtnumero.Text += "0";
        }

        private void btn_ponto_Click(object sender, EventArgs e)
        {
            txtnumero.Text += ".";
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtnumero.Text, CultureInfo.InvariantCulture);

            lbl_operacao.Text = "="; 
            if (operacao == "SOMA") 
            {
                txtnumero.Text=Convert.ToString( valor1 + valor2);
            }
            else if (operacao == "SUBTRACAO") 
            {
                txtnumero.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "DIVISAO")
            {
                txtnumero.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                txtnumero.Text = Convert.ToString(valor1 * valor2);
            }
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(txtnumero.Text, CultureInfo.InvariantCulture);

                txtnumero.Text = "";
                operacao = "SOMA";
                lbl_operacao.Text = "+";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi informado nenhum valor");
            }
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(txtnumero.Text, CultureInfo.InvariantCulture);

                txtnumero.Text = "";
                operacao = "SUBTRACAO";
                lbl_operacao.Text = "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi informado nenhum valor");
            }
        }

        private void btn_vezes_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(txtnumero.Text, CultureInfo.InvariantCulture);

                txtnumero.Text = "";
                operacao = "MULTIPLICACAO";
                lbl_operacao.Text = "x";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi informado nenhum valor");
            }
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = double.Parse(txtnumero.Text, CultureInfo.InvariantCulture);

                txtnumero.Text = "";
                operacao = "DIVISAO";
                lbl_operacao.Text = "/";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi informado nenhum valor");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
            valor1 = 0;
            valor2 = 0;
            lbl_operacao.Text = "";
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtnumero.Text +=  "7";
        }

    }
}