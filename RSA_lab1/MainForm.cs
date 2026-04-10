
using System.Numerics;

namespace RSA_lab1
{
    public partial class MainForm : Form
    {
        RSA_cipher rsa = new RSA_cipher();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rsa.GenerateKeys();
            textBoxN.Text = rsa.keys.N.ToString() ;
            textBoxE.Text = rsa.keys.e.ToString() ;
            textBoxS.Text = rsa.keys.s.ToString();   
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxN.Text) || string.IsNullOrEmpty(textBoxS.Text))
            {
                MessageBox.Show("—генерируйте или вставьте ключи 'N' и 's'!",
                        "ќшибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                return;
            }

            BigInteger s = BigInteger.Parse(textBoxS.Text);
            BigInteger N = BigInteger.Parse(textBoxN.Text);

            cipherBox.Text = rsa.Encrypt(textBox.Text, s, N);
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxN.Text) || string.IsNullOrEmpty(textBoxE.Text))
            {
                MessageBox.Show("—генерируйте или вставьте ключи 'N' и 'e'!",
                        "ќшибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                return;
            }

            BigInteger E = BigInteger.Parse(textBoxE.Text);
            BigInteger N = BigInteger.Parse(textBoxN.Text);

            textBox.Text = rsa.Decrypt(cipherBox.Text, E, N);
        }
    }
}
