using Calculadora.Util;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Variaveis Globais
        Calculo calc = new Calculo();
        public Form1()
        {
            InitializeComponent();
        }



        #region Funções Gerais

        public bool NaoInseriuCampoPrimario()
        {
            //Verifica se o campo primario de numero nao teve algum numero inserido.
            return string.IsNullOrEmpty(TxtResult.Text) | TxtResult.Text == "0" | TxtResult.Text == "-0";
        }

        public void ProximoNumero()
        {
            //Transfere o valor inserido ao campo secundario para inserir o segundo numero da operacao.
            TempValue.Text = TxtResult.Text;
            TxtResult.Text = "0";
        }

        public string ExecutarOperacao()
        {
            switch (TxtOperation.Text)
            {
                case "+":
                    return calc.Soma(TempValue.Text, TxtResult.Text);
                case "-":
                    return calc.Subtrair(TempValue.Text, TxtResult.Text);
                case "*":
                    return calc.Mult(TempValue.Text, TxtResult.Text);
                case "÷":
                    return calc.Div(TempValue.Text, TxtResult.Text);
            }
            return "Erro de Operador";
        }
        #endregion



        #region Botões Essenciais

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text.Length == 1)
            {
                TxtResult.Text = "0";
                return;
            }

            TxtResult.Text = TxtResult.Text.Remove(TxtResult.Text.Length - 1);
        }

        private void TempValue_Click(object sender, EventArgs e)
        {
            //O usuario pode apertar no campo secundario pra trocar de posicao com o primario.

            //Se o campo secundario estiver vazio, nao tem o que trocar.
            if (string.IsNullOrEmpty(TempValue.Text)) { return; }
            string temp = TempValue.Text;
            TempValue.Text = TxtResult.Text;
            TxtResult.Text = temp;
        }

        private void BtnCanc_Click(object sender, EventArgs e)
        {
            //O botao C cancela o calculo inteiro.
            TxtResult.Text = "0";
            TempValue.Text = "";
            TxtOperation.Text = "";
        }

        private void BtnCancEntr_Click(object sender, EventArgs e)
        {
            //O botao CE so cancela o campo primario.
            TxtResult.Text = "0";
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (NaoInseriuCampoPrimario()) { return; }
            if (string.IsNullOrEmpty(TxtOperation.Text)) { return; }
            TxtResult.Text = ExecutarOperacao();
            TxtOperation.Text = "";
            TempValue.Text = "";
        }

        #endregion



        #region Operações Básicas

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            if (NaoInseriuCampoPrimario()) { return; }

            if (!string.IsNullOrEmpty(TxtOperation.Text)) { BtnResult.PerformClick(); }

            ProximoNumero();
            TxtOperation.Text = "+";

        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            // Se nao tiver numero pra fazer operacao, comecar um numero negativo
            if (NaoInseriuCampoPrimario())
            {
                TxtResult.Text = "-0";
                return;
            }

            if (!string.IsNullOrEmpty(TxtOperation.Text)) { BtnResult.PerformClick(); }

            ProximoNumero();
            TxtOperation.Text = "-";
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (NaoInseriuCampoPrimario()) { return; }

            if (!string.IsNullOrEmpty(TxtOperation.Text)) { BtnResult.PerformClick(); }

            ProximoNumero();
            TxtOperation.Text = "*";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (NaoInseriuCampoPrimario()) { return; }

            if (!string.IsNullOrEmpty(TxtOperation.Text)) { BtnResult.PerformClick(); }

            ProximoNumero();
            TxtOperation.Text = "÷";
        }

        #endregion



        #region Operações Solicitadas

        private void BtnConvBin_Click(object sender, EventArgs e)
        {
            if (NaoInseriuCampoPrimario()) { return; }

            if (!string.IsNullOrEmpty(TxtOperation.Text)) { BtnResult.PerformClick(); }

            TxtResult.Text = calc.Binario(TxtResult.Text);
        }

        private void BtnSeno_Click(object sender, EventArgs e)
        {
            if (NaoInseriuCampoPrimario()) { return; }

            if (!string.IsNullOrEmpty(TxtOperation.Text)) { BtnResult.PerformClick(); }

            TxtResult.Text = calc.Seno(TxtResult.Text);
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            if (NaoInseriuCampoPrimario()) { return; }

            if (!string.IsNullOrEmpty(TxtOperation.Text)) { BtnResult.PerformClick(); }

            TxtResult.Text = calc.Cosseno(TxtResult.Text);
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            if (NaoInseriuCampoPrimario()) { return; }

            if (!string.IsNullOrEmpty(TxtOperation.Text)) { BtnResult.PerformClick(); }

            TxtResult.Text = calc.Tangente(TxtResult.Text);
        }

        private void BtnFat_Click(object sender, EventArgs e)
        {
            if (NaoInseriuCampoPrimario()) { return; }

            if (!string.IsNullOrEmpty(TxtOperation.Text)) { BtnResult.PerformClick(); }

            TxtResult.Text = calc.Fatorial(TxtResult.Text);
        }

        #endregion



        #region Botões de Número

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "1"; }
            if (TxtResult.Text == "0") { TxtResult.Text = "1"; }
            if (TxtResult.Text == "-0") { TxtResult.Text = "-1"; }
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "2"; }
            if (TxtResult.Text == "0") { TxtResult.Text = "2"; }
            if (TxtResult.Text == "-0") { TxtResult.Text = "-2"; }
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "3"; }
            if (TxtResult.Text == "0") { TxtResult.Text = "3"; }
            if (TxtResult.Text == "-0") { TxtResult.Text = "-3"; }
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "4"; }
            if (TxtResult.Text == "0") { TxtResult.Text = "4"; }
            if (TxtResult.Text == "-0") { TxtResult.Text = "-4"; }
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "5"; }
            if (TxtResult.Text == "0") { TxtResult.Text = "5"; }
            if (TxtResult.Text == "-0") { TxtResult.Text = "-5"; }
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "6"; }
            if (TxtResult.Text == "0") { TxtResult.Text = "6"; }
            if (TxtResult.Text == "-0") { TxtResult.Text = "-6"; }
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "7"; }
            if (TxtResult.Text == "0") { TxtResult.Text = "7"; }
            if (TxtResult.Text == "-0") { TxtResult.Text = "-7"; }
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "8"; }
            if (TxtResult.Text == "0") { TxtResult.Text = "8"; }
            if (TxtResult.Text == "-0") { TxtResult.Text = "-8"; }
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "9"; }
            if (TxtResult.Text == "0") { TxtResult.Text = "9"; }
            if (TxtResult.Text == "-0") { TxtResult.Text = "-9"; }
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            if (!NaoInseriuCampoPrimario()) { TxtResult.Text += "0"; }
        }

#endregion
    }
}
