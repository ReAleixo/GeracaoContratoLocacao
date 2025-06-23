using GeracaoContratoLocacao.Domain.Utils;

namespace GeracaoContratoLocacao.Presentation.Utils
{
    public class TextBoxKeyPress
    {
        public static void OnlyDigits(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public static void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        public static void OnlyLettersAndDigits(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar);
        }
    }

    public class TextBoxMasks
    {
        public static void ApplyCPFMask(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress.OnlyDigits(sender, e);
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            var textBox = sender as TextBox;
            if (textBox == null || textBox.Text.Length >= Lengths.CPF)
            {
                return;
            }
            if (textBox.Text.Length == 3 || textBox.Text.Length == 7)
            {
                textBox.AppendText(".");
            }
            else if (textBox.Text.Length == 11)
            {
                textBox.AppendText("-");
            }
        }

        public static void ApplyDateMask(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress.OnlyDigits(sender, e);
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }

            var textBox = sender as TextBox;
            if (textBox == null || textBox.Text.Length >= 10)
            {
                return;
            }
            if (textBox.Text.Length == 2 || textBox.Text.Length == 5)
            {
                textBox.AppendText("/");
            }
        }

        public static void ApplyMoneyMask(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress.OnlyDigits(sender, e);
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            var textBox = sender as TextBox;
            if (textBox == null)
            {
                return;
            }

            if (textBox.Text.Length >= textBox.MaxLength)
            {
                return;
            }

            string digits = new string(textBox.Text.Where(char.IsDigit).ToArray());
            digits = digits.TrimStart('0');

            if (!e.Handled && char.IsDigit(e.KeyChar))
            {
                digits += e.KeyChar;
            }

            if (digits.Length == 0)
            {
                textBox.Text = string.Empty;
            }
            else if (digits.Length == 1)
            {
                textBox.Text = "0,0" + digits;
            }
            else if (digits.Length == 2)
            {
                textBox.Text = "0," + digits;
            }
            else
            {
                textBox.Text = digits.Insert(digits.Length - 2, ",");
            }

            textBox.SelectionStart = textBox.Text.Length;
            e.Handled = true;
        }
    }
}
