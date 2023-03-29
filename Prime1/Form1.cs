namespace Prime1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                listBox1.Items.Clear();
                FontStyle fontStyle = FontStyle.Regular;
                if (checkBox1.Checked)
                {
                    fontStyle = fontStyle | FontStyle.Bold;
                }
                if (checkBox2.Checked)
                {
                    fontStyle = fontStyle | FontStyle.Italic;
                }
                if (checkBox3.Checked)
                {
                    fontStyle = fontStyle | FontStyle.Underline;
                }
                if (checkBox4.Checked)
                {
                    fontStyle = fontStyle | FontStyle.Strikeout;
                }

                Font font = new Font("Times New Roman", 14, fontStyle);
                listBox1.Font = font;
                listBox1.ForeColor = Color.Black;

                if (radioButton1.Checked)
                {
                    listBox1.ForeColor = Color.Red;
                }
                if (radioButton2.Checked)
                {
                    listBox1.ForeColor = Color.Blue;
                }
                if (radioButton3.Checked)
                {
                    listBox1.ForeColor = Color.Green;
                }
                if (radioButton4.Checked)
                {
                    listBox1.ForeColor = Color.Yellow;
                }
                if (radioButton5.Checked)
                {
                    listBox1.ForeColor = Color.Black;
                }

                listBox1.Items.Add(textBox1.Text);
            }
            else
                MessageBox.Show("Заповніть, будь ласка, дані.", "Помилка вводу даних.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}