using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6kpp
{
    public partial class Form1 : Form
    {


        int N = 1;
        int i = 0;
        int j = 0;
        int Change; 
        double[,] A = new double[6, 6];
        double[] B = new double[6];
        double[] X = new double[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void Decomp(int N, ref int Change)
        {
            int i, j, k, imax;
            double max, temp, sum;

            Change = 1;

            imax = 1;
            max = Math.Abs(A[1, 1]);
            for (i = 2; i <= N; i++)
            {
                if (Math.Abs(A[i, 1]) > max)
                {
                    max = Math.Abs(A[i, 1]);
                    imax = i;
                }
            }

            if (imax != 1)
            {
                Change = imax;
                for (j = 1; j <= N; j++)
                {
                    temp = A[1, j];
                    A[1, j] = A[imax, j];
                    A[imax, j] = temp;
                }
            }

            for (j = 2; j <= N; j++)
            {
                A[1, j] = A[1, j] / A[1, 1];
            }

            for (i = 2; i <= N; i++)
            {
                for (j = i; j <= N; j++)
                {
                    sum = 0;
                    for (k = 1; k <= i - 1; k++)
                        sum += A[j, k] * A[k, i];
                    A[j, i] = A[j, i] - sum;
                }

                for (j = i + 1; j <= N; j++)
                {
                    sum = 0;
                    for (k = 1; k <= i - 1; k++)
                        sum += A[i, k] * A[k, j];
                    A[i, j] = (A[i, j] - sum) / A[i, i];
                }
            }

            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                    C_matrix_dgv.Rows[i].Cells[j].Value = A[i + 1, j + 1].ToString("0.###");
        }
        private void Solve(int Change, int N)
        {
            int i, j;
            double sum, temp;
            double[] Y = new double[N + 1];

            if (Change != 1)
            {
                temp = B[1];
                B[1] = B[Change];
                B[Change] = temp;
            }

            Y[1] = B[1] / A[1, 1];

            for (i = 2; i <= N; i++)
            {
                sum = 0;
                for (j = 1; j <= i - 1; j++)
                    sum += A[i, j] * Y[j];
                Y[i] = (B[i] - sum) / A[i, i];
            }

            X[N] = Y[N];

            for (i = N - 1; i >= 1; i--)
            {
                sum = 0;
                for (j = i + 1; j <= N; j++)
                    sum += A[i, j] * X[j];
                X[i] = Y[i] - sum;
            }

            for (i = 0; i < N; i++)
                X_vector_dgv[0, i].Value = X[i + 1].ToString("0.###");
        }

        void Gauss(double[,] A, double[] B, int N, double[] X)
        {
            // Прямий хід
            for (int k = 0; k < N; k++)
            {
                double max = Math.Abs(A[k, k]);
                int maxRow = k;
                for (int i = k + 1; i < N; i++)
                {
                    if (Math.Abs(A[i, k]) > max)
                    {
                        max = Math.Abs(A[i, k]);
                        maxRow = i;
                    }
                }

                for (int j = 0; j < N; j++)
                {
                    double temp = A[k, j];
                    A[k, j] = A[maxRow, j];
                    A[maxRow, j] = temp;
                }
                double tempB = B[k];
                B[k] = B[maxRow];
                B[maxRow] = tempB;

                if (Math.Abs(A[k, k]) < 1e-12)
                {
                    MessageBox.Show("Неможливо розв’язати систему: ділення на нуль");
                    return;
                }

                for (int i = k + 1; i < N; i++)
                {
                    double factor = A[i, k] / A[k, k];
                    for (int j = k; j < N; j++)
                        A[i, j] -= factor * A[k, j];
                    B[i] -= factor * B[k];
                }
            }

            for (int i = N - 1; i >= 0; i--)
            {
                double sum = B[i];
                for (int j = i + 1; j < N; j++)
                    sum -= A[i, j] * X[j];
                X[i] = sum / A[i, i];
            }
        }

        private void SolveGauss()
        {
            double[,] A_copy = new double[N, N];
            double[] B_copy = new double[N];
            double[] X_copy = new double[N];

            for (int i = 0; i < N; i++)
            {
                B_copy[i] = B[i + 1];
                for (int j = 0; j < N; j++)
                {
                    A_copy[i, j] = A[i + 1, j + 1];
                }
            }

            Gauss(A_copy, B_copy, N, X_copy);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    C_matrix_dgv.Rows[i].Cells[j].Value = A_copy[i, j].ToString("0.###");
                }
            }

            for (int i = 0; i < N; i++)
            {
                X_vector_dgv[0, i].Value = X_copy[i].ToString("0.###");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            X_vector_dgv.ReadOnly = true;
            A_matrix_dgv.AllowUserToAddRows = false;
            B_vector_dgv.AllowUserToAddRows = false;
            X_vector_dgv.AllowUserToAddRows = false;
            A_matrix_dgv.ColumnCount = 1;
            A_matrix_dgv.RowCount = 1;
            X_vector_dgv.ColumnCount = 1;
            X_vector_dgv.RowCount = 1;
            B_vector_dgv.ColumnCount = 1;
            B_vector_dgv.RowCount = 1;
        }

        private void NUD_rozmir_ValueChanged(object sender, EventArgs e)
        {
            N = Convert.ToInt16(NUD_rozmir.Value);
            A_matrix_dgv.RowCount = N;
            A_matrix_dgv.ColumnCount = N;
            X_vector_dgv.RowCount = N;
            B_vector_dgv.RowCount = N;
            C_matrix_dgv.RowCount = N;
            C_matrix_dgv.ColumnCount = N;

        }

        private void BСreateGrid_Click(object sender, EventArgs e)
        {
            bool exc_A = false;
            bool exc_B = false;

            for (i = 1; i <= N; i++)
            {
                for (j = 1; j <= N; j++)
                {
                    try
                    {
                        A[i, j] = Convert.ToDouble(A_matrix_dgv[j - 1, i - 1].Value);
                    }
                    catch
                    {
                        A_matrix_dgv[j - 1, i - 1].Style.ForeColor = Color.Red;
                        exc_A = true;
                    }
                }
            }

            for (j = 0; j < N; j++)
            {
                try
                {
                    B[j + 1] = Convert.ToDouble(B_vector_dgv[0, j].Value);
                }
                catch
                {
                    B_vector_dgv[0, j].Style.ForeColor = Color.Red;
                    exc_B = true;
                }
            }

            if (exc_A || exc_B)
            {
                MessageBox.Show("Помилка введення!");
                return;
            }

            if (comboBox1.SelectedIndex == 0)
            {
                Decomp(N, ref Change);
                Solve(Change, N);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SolveGauss();
            }
            else
            {
                MessageBox.Show("Виберіть метод розв'язку (LU або Гаус)!");
                return;
            }

            MessageBox.Show("Розв'язок знайдено!");
        }


        private void BClear_Click(object sender, EventArgs e)
        {
            for (i = 0; i < N; i++)
                for (j = 0; j < N; j++)
                {
                    A_matrix_dgv[j, i].Value = "";
                    C_matrix_dgv[j, i].Value = "";
                }
            for (j = 0; j < N; j++)
            {
                B_vector_dgv[0, j].Value = "";
                X_vector_dgv[0, j].Value = "";
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void A_matrix_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            A_matrix_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }

        private void B_vector_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            B_vector_dgv.CurrentCell.Style.ForeColor = Color.Black;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Text = "Матриця C LU-розкладу";
            } else if (comboBox1.SelectedIndex == 1)
            {
                label5.Text = "Матриця C методу Гауса";
            }
        }
    }
}
