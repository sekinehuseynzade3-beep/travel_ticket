using System;
using System.Windows.Forms;

namespace avtobus_tapsirigi
{
    public partial class Form1 : Form
    {

        int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxarılsınmı?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == comboBox2.Text && !string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Eyni şəhərlərə gedir", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                n++;
                listBox1.Items.Add(n.ToString() + ") " + comboBox1.Text + " " + comboBox2.Text + " (" + maskedTextBox1.Text + ") " + textBox1.Text);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Xahiş olunur, silmək istədiyiniz bileti siyahıdan seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}