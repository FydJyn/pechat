using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace pechat
{
    public partial class Form1 : Form
    {
        private string targetText = "мама мыла раму";
        private Stopwatch stopwatch = new Stopwatch();
        private bool started = false;

        public Form1()
        {
            InitializeComponent();
            lblTargetText.Text = targetText;
            lblTime.Text = "Время: 0 сек";
            lblErrors.Text = "Ошибки: 0";
            lblResult.Text = "Статус: ожидание";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();

            stopwatch.Reset();
            stopwatch.Start();

            started = true;

            lblTime.Text = "Время: 0 сек";
            lblErrors.Text = "Ошибки: 0";
            lblResult.Text = "Статус: тренировка началась";

            timer1.Start();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (!started)
                return;

            string userText = txtInput.Text;
            int errors = CountErrors(userText, targetText);

            lblErrors.Text = $"Ошибки: {errors}";

            if (userText == targetText)
            {
                stopwatch.Stop();
                timer1.Stop();
                started = false;

                lblResult.Text = $"Готово! Время: {stopwatch.Elapsed.Seconds} сек, ошибок: {errors}";
                MessageBox.Show(
                    $"Текст введён верно!\nВремя: {stopwatch.Elapsed.Seconds} сек\nОшибок: {errors}",
                    "Результат",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private int CountErrors(string userText, string correctText)
        {
            int errors = 0;
            int minLength = Math.Min(userText.Length, correctText.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (userText[i] != correctText[i])
                    errors++;
            }

            if (userText.Length > correctText.Length)
                errors += userText.Length - correctText.Length;

            return errors;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (started)
            {
                lblTime.Text = $"Время: {stopwatch.Elapsed.Seconds} сек";
            }
        }
    }
}