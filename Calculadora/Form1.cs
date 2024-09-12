namespace Calculadora
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public bool NaoInseriuNumero()
        {
            return string.IsNullOrEmpty(TxtResult.Text) | TxtResult.Text == "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void BtnCos_Click(object sender, EventArgs e)
        {

        }

        private void BtnResult_Click(object sender, EventArgs e)
        {

        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {

        }

        private void BtnConvBin_Click(object sender, EventArgs e)
        {

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "0";
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "1";
            }
            else { TxtResult.Text = "1"; }
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "2";
            }
            else { TxtResult.Text = "2"; }

        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "3";
            }
            else { TxtResult.Text = "3"; }

        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "4";
            }
            else { TxtResult.Text = "4"; }

        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "5";
            }
            else { TxtResult.Text = "5"; }

        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "6";
            }
            else { TxtResult.Text = "6"; }

        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "7";
            }
            else { TxtResult.Text = "7"; }
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "8";
            }
            else { TxtResult.Text = "8"; }

        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "9";
            }
            else { TxtResult.Text = "9"; }

        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            if (TxtResult.Text != "0")
            {
                TxtResult.Text += "0";
            }

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TxtResult.Text.Remove(TxtResult.Text.Length - 1);
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {

        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {

            if (NaoInseriuNumero()) { return; }
            TempValue.Text = TxtResult.Text;
            TxtResult.Text = "0";
        }

        private void TempValue_Click(object sender, EventArgs e)
        {

        }
    }
}
