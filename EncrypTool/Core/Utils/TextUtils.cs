using System.Globalization;
using System.Text;

namespace EncrypTool
{
    class TextUtils
    {
            public static string RemoveDiacritics(string text, bool recompose)
            {
                string normalized = text.Normalize(NormalizationForm.FormD);
                var sb = new StringBuilder();

                foreach (char c in normalized)
                {
                    if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                        sb.Append(c);
                }

                if (recompose)
                {
                    return sb.ToString().Normalize(NormalizationForm.FormC);
                }

                return sb.ToString();
            }
    }
}
