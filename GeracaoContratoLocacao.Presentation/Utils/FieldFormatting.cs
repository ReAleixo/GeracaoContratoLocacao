using GeracaoContratoLocacao.Domain.Utils;

namespace GeracaoContratoLocacao.Presentation.Utils
{
    public class TextBoxKeyPress
    {
        public static void OnlyDigits(KeyPressEventArgs @event)
        {
            @event.Handled = !char.IsControl(@event.KeyChar) && !char.IsDigit(@event.KeyChar);
        }

        public static void OnlyLetters(KeyPressEventArgs @event)
        {
            @event.Handled = !char.IsControl(@event.KeyChar) && !char.IsLetter(@event.KeyChar) && !char.IsWhiteSpace(@event.KeyChar);
        }

        public static void OnlyLettersAndDigits(KeyPressEventArgs @event)
        {
            @event.Handled = !char.IsControl(@event.KeyChar) && !char.IsLetterOrDigit(@event.KeyChar);
        }
    }

    public class TextBoxMasks
    {
        public static void ApplyCPFMask(object sender, KeyPressEventArgs @event)
        {
            TextBoxKeyPress.OnlyDigits(@event);
            if (@event.KeyChar == (char)Keys.Back)
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

        public static void ApplyDateMask(object sender, KeyPressEventArgs @event)
        {
            TextBoxKeyPress.OnlyDigits(@event);
            if (@event.KeyChar == (char)Keys.Back)
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

        public static void ApplyMoneyMask(object sender, KeyPressEventArgs @event)
        {
            TextBoxKeyPress.OnlyDigits(@event);
            if (@event.KeyChar == (char)Keys.Back)
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

            if (!@event.Handled && char.IsDigit(@event.KeyChar))
            {
                digits += @event.KeyChar;
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
            @event.Handled = true;
        }
    }
}
