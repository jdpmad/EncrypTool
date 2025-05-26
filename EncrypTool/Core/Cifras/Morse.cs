using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncrypTool
{
    public class Morse : ICipher
    {
        private static readonly Dictionary<char, string> TextToMorse = new Dictionary<char, string>
        {
            ['a'] = ".-",
            ['b'] = "-...",
            ['c'] = "-.-.",
            ['d'] = "-..",
            ['e'] = ".",
            ['f'] = "..-.",
            ['g'] = "--.",
            ['h'] = "....",
            ['i'] = "..",
            ['j'] = ".---",
            ['k'] = "-.-",
            ['l'] = ".-..",
            ['m'] = "--",
            ['n'] = "-.",
            ['o'] = "---",
            ['p'] = ".--.",
            ['q'] = "--.-",
            ['r'] = ".-.",
            ['s'] = "...",
            ['t'] = "-",
            ['u'] = "..-",
            ['v'] = "...-",
            ['w'] = ".--",
            ['x'] = "-..-",
            ['y'] = "-.--",
            ['z'] = "--..",
            ['0'] = "-----",
            ['1'] = ".----",
            ['2'] = "..---",
            ['3'] = "...--",
            ['4'] = "....-",
            ['5'] = ".....",
            ['6'] = "-....",
            ['7'] = "--...",
            ['8'] = "---..",
            ['9'] = "----.",
            ['.'] = ".-.-.-",
            [','] = "--..--",
            ['?'] = "..--..",
            ['\''] = "·----·",
            ['!'] = "-.-.--",
            ['/'] = "-··-·",
            ['('] = "-·--·",
            [')'] = "-·--·-",
            ['&'] = "·-···",
            [':'] = "---···",
            [';'] = "-·-·-·",
            ['='] = "-···-",
            ['-'] = "-....-",
            ['_'] = "··--·-",
            ['"'] = "·-··-·",
            ['$'] = "···-··-",
            ['@'] = "·--·-·"
        };

        private static readonly Dictionary<string, char> MorseToText =
            TextToMorse.ToDictionary(pair => pair.Value, pair => pair.Key);

        public string Encrypt(string input)
        {
            input = TextUtils.RemoveDiacritics(input, false);
            // Normalize os newlines para só \n para facilitar o split
            var normalizedInput = input.Replace("\r\n", "\n").Replace("\r", "\n").ToLower();

            var lines = normalizedInput.Split('\n');
            var morseLines = new List<string>();

            foreach (var line in lines)
            {
                var trimmedLine = line.TrimEnd(); // remove espaços finais que causam problema

                if (string.IsNullOrWhiteSpace(trimmedLine))
                {
                    // Linha vazia, pode ser representada só pelo separador de linhas em Morse
                    morseLines.Add("");
                    continue;
                }

                var words = trimmedLine.Split(' ');
                var morseWords = new List<string>();

                foreach (var word in words)
                {
                    var morseLetters = new List<string>();

                    foreach (var c in word)
                    {
                        if (TextToMorse.TryGetValue(c, out var morse))
                            morseLetters.Add(morse);
                        else
                            morseLetters.Add(c.ToString());
                    }

                    morseWords.Add(string.Join(" ", morseLetters)); // 1 espaço entre letras
                }

                morseLines.Add(string.Join("   ", morseWords)); // 3 espaços entre palavras
            }

            // Juntamos as linhas com " // "
            return string.Join(" // ", morseLines);
        }


        public string Decrypt(string input)
        {
            var lines = input.Split(new string[] { " // " }, StringSplitOptions.None);
            var result = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim(); // tira espaços em branco antes/depois da linha
                var words = line.Split(new string[] { "   " }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < words.Length; j++)
                {
                    var letters = words[j].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var letter in letters)
                    {
                        if (MorseToText.TryGetValue(letter, out var character))
                            result.Append(character);
                        else
                            result.Append('?'); // símbolo desconhecido
                    }

                    if (j < words.Length - 1)
                        result.Append(' ');
                }

                if (i < lines.Length - 1)
                    result.Append(Environment.NewLine);
            }

            return result.ToString();
        }

    }
}
