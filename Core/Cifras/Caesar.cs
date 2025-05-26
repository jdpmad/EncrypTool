using System.Globalization;
using System.Text;

namespace EncrypTool
{
    public class Caesar : ICipher
    {
        private int shift;

        public Caesar(int shift)
        {
            this.shift = shift % 26;
        }

        public string Encrypt(string input)
        {
            return Transform(input, shift);
        }

        public string Decrypt(string input)
        {
            return Transform(input, 26 - shift);
        }

        private string Transform(string input, int effectiveShift)
        {
            var sb = new StringBuilder();

            foreach (char c in TextUtils.RemoveDiacritics(input, true))
            {
                if (char.IsLetter(c))
                {
                    bool isUpper = char.IsUpper(c);
                    char offset = isUpper ? 'A' : 'a';
                    char shifted = (char)((((c - offset) + effectiveShift) % 26) + offset);
                    sb.Append(shifted);
                }
                else
                {
                    sb.Append(c); // Mantém espaços, pontuação, etc.
                }
            }

            return sb.ToString();
        }
    }
}