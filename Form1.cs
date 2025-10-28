using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        label7.Visible = false;
                        textBox4.Visible = false;
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    break;
                case 1:
                    {
                        label7.Visible = true;
                        textBox4.Visible = true;
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    break;
            }
        }
        double f(double x, ref int k1)
        {
            switch (k1)
            {
                case 0: return x * x - 4;
                case 1: return 3 * x - 4 * Math.Log(x) - 5;
                case 2: return 3*Math.Pow(Math.E, x)-8;
            }
            return 0;
        }
        double fp(double x, double d, ref int k1) // перша похідна
        {
            return (f(x + d, ref k1) - f(x, ref k1)) / d;
        }
        double f2p(double x, double d, ref int k1) // друга похідна
        {
            return (f(x + d, ref k1) + f(x - d, ref k1) - 2 * f(x, ref k1)) / (d * d);
        }
        double MDP(double a, double b, double Eps, ref int k1, ref int L)
        {
            double c = 0, Fc; while (b - a > Eps)
            {
                c = 0.5 * (b - a) + a;
                L++;
                Fc = f(c, ref k1);
                if (Math.Abs(Fc) < Eps)
                    return c;
                if (f(a, ref k1) * Fc > 0) a = c;
                else b = c;
            }
            return c;
        }
        double MN(double a, double b, double Eps, ref int k1, int Kmax, ref int L)
        {
            double x, Dx, D; int i; Dx = 0.0; D = Eps / 100.0; x = b; if (f(x, ref k1) * f2p(x, D, ref k1) < 0) x = a;
            if (f(x, ref k1) * f2p(x, D, ref k1) < 0)
                MessageBox.Show("Для цього рівняння збіжність ітерацій не гарантована");
            for (i = 1; i <= Kmax; i++)
            {
                Dx = f(x, ref k1) / fp(x, D, ref k1); x = x - Dx; if (Math.Abs(Dx) < Eps)
                {
                    L = i;
                    return x;
                }
            }
            MessageBox.Show("За задану кількість ітерацій кореня не знайдено");
            return -1000.0; // -1000.0 Це наша ознака цієї нестандартної ситуації
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int L = 0, k = -1, Kmax, m = -1;
            double D, Eps = 0, a, b;

            // Вибір чисельного методу
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    m = 0; // метод ділення навпіл
                    break;
                case 1:
                    m = 1; // метод Ньютона
                    label7.Visible = true; // робимо видимим вікно для введення Kmax
                    textBox4.Visible = true;
                    textBox4.Enabled = true;
                    break;
            }

            if (m == -1)
            {
                MessageBox.Show("Оберіть метод!");
                comboBox1.Focus();
                return;
            }

            // Вибір нелінійного рівняння
            switch (comboBox2.SelectedIndex)
            {
                case 0: k = 0; break;
                case 1: k = 1; break;
                case 2: k = 2; break;
            }

            if (k == -1)
            {
                MessageBox.Show("Оберіть рівняння!");
                comboBox2.Focus();
                return;
            }

            // Перевірка введення a
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Введіть число в textBox1");
                textBox1.Focus();
                return;
            }
            a = Convert.ToDouble(textBox1.Text);

            // Перевірка введення b
            textBox2.Enabled = true;
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Введіть число в textBox2");
                textBox2.Focus();
                return;
            }
            b = Convert.ToDouble(textBox2.Text);

            // Якщо a > b, міняємо місцями
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
                textBox1.Text = a.ToString();
                textBox2.Text = b.ToString();
            }

            // Перевірка введення Eps
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Введіть число в textBox3");
                textBox3.Focus();
                return;
            }
            Eps = Convert.ToDouble(textBox3.Text);

            // Корекція похибки, якщо вона поза допустимим діапазоном
            if (Eps > 1e-1 || Eps <= 0)
            {
                Eps = 1e-4;
                textBox3.Text = Eps.ToString();
            }

            // Перевірка кореня на межах інтервалу для методу ділення навпіл
            if (m == 0)
            {
                if (f(a, ref k) * f(b, ref k) > 0)
                {
                    MessageBox.Show("Введіть правильний інтервал [a, b]!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                    return;
                }

                if (Math.Abs(f(a, ref k)) < Eps)
                {
                    textBox5.Text = a.ToString();
                    textBox6.Text = L.ToString();
                    return;
                }

                if (Math.Abs(f(b, ref k)) < Eps)
                {
                    textBox5.Text = b.ToString();
                    textBox6.Text = L.ToString();
                    return;
                }
            }

            // Виклик обраного методу
            switch (m)
            {
                case 0: // метод ділення навпіл
                    textBox5.Text = MDP(a, b, Eps, ref k, ref L).ToString();
                    textBox6.Text = L.ToString();
                    label10.Text = "К-ть поділів =";
                    break;

                case 1: // метод Ньютона
                    if (string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        MessageBox.Show("Введіть число в textBox4");
                        textBox4.Focus();
                        return;
                    }
                    Kmax = Convert.ToInt32(textBox4.Text);
                    textBox5.Text = MN(a, b, Eps, ref k, Kmax, ref L).ToString();
                    textBox6.Text = L.ToString();
                    label10.Text = "К-ть ітерац. =";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Очищення всіх текстових полів
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            // Налаштування видимості елементів залежно від обраного методу
            switch (comboBox1.SelectedIndex)
            {
                case 0: // метод ділення навпіл
                    label7.Visible = false;   // ховаємо мітку для Kmax
                    textBox4.Visible = false; // ховаємо поле для Kmax
                    break;

                case 1: // метод Ньютона
                    label7.Visible = true;    // показуємо мітку для Kmax
                    textBox4.Visible = true;  // показуємо поле для Kmax
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
