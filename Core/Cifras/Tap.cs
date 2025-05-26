using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncrypTool
{
    public class Tap : ICipher
    {
        private static readonly Dictionary<char, string> TextToTap = new Dictionary<char, string>
        {
            ['a'] = "1,1",
            ['b'] = "1,2",
            ['c'] = "1,3",
            ['d'] = "1,4",
            ['e'] = "1,5",
            ['f'] = "2,1",
            ['g'] = "2,2",
            ['h'] = "2,3",
            ['i'] = "2,4",
            ['j'] = "2,4", // j → i
            ['k'] = "2,5",
            ['l'] = "3,1",
            ['m'] = "3,2",
            ['n'] = "3,3",
            ['o'] = "3,4",
            ['p'] = "3,5",
            ['q'] = "4,1",
            ['r'] = "4,2",
            ['s'] = "4,3",
            ['t'] = "4,4",
            ['u'] = "4,5",
            ['v'] = "5,1",
            ['w'] = "5,2",
            ['x'] = "5,3",
            ['y'] = "5,4",
            ['z'] = "5,5",
            [' '] = "/"
        };

        private static readonly Dictionary<string, char> TapToText = TextToTap
            .GroupBy(p => p.Value)
            .ToDictionary(g => g.Key, g => g.First().Key); // se 'j' e 'i' partilham código, escolhe 'i'

        public string Encrypt(string input)
        {
            // Quebra linhas de forma cross-platform
            var lines = TextUtils.RemoveDiacritics(input.ToLower(), false)
                                 .Split(new[] { "\r\n", "\n" }, System.StringSplitOptions.None);
            var encryptedLines = new List<string>();

            foreach (var line in lines)
            {
                var result = new List<string>();
                foreach (char c in line)
                {
                    char letter = c == 'j' ? 'i' : c;
                    if (TextToTap.TryGetValue(letter, out var tap))
                        result.Add(tap);
                    else
                        result.Add(letter.ToString()); // caractere desconhecido
                }
                encryptedLines.Add(string.Join(" ", result)); // espaço entre letras
            }

            // Usa " // " para separar linhas (com espaços)
            return string.Join(" // ", encryptedLines);
        }

        public string Decrypt(string input)
        {
            var lines = input.Split(new[] { " // " }, System.StringSplitOptions.None);
            var sb = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();

                // palavras separadas por '/'
                var words = line.Split(new char[] { '/' }, System.StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < words.Length; w++)
                {
                    var letters = words[w].Split(new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

                    foreach (var letter in letters)
                    {
                        if (TapToText.TryGetValue(letter, out var c))
                            sb.Append(c);
                        else
                            sb.Append('?');
                    }

                    if (w < words.Length - 1)
                        sb.Append(' '); // espaço entre palavras
                }

                if (i < lines.Length - 1)
                    sb.AppendLine(); // newline entre linhas
            }

            return sb.ToString();
        }

    }
}
