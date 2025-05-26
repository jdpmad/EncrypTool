using System;
using System.IO;

namespace EncrypTool
{
    public class FileProcessor
    {
        private readonly string inputFilePath;
        private readonly string outputFilePath;
        private readonly ICipher cipher;
        private readonly bool encrypt;

        public bool Success { get; private set; }

        public FileProcessor(string inputFilePath, string outputFilePath, ICipher cipher, bool encrypt)
        {
            this.inputFilePath = inputFilePath;
            this.outputFilePath = outputFilePath;
            this.encrypt = encrypt;
            this.cipher = cipher;
        }

        public void Process()
        {
            try
            {
                var inputText = FileRW.ReadInputFile();
                var processedText = ProcessText(inputText);
                FileRW.SaveOutputFile(Path.Combine(Variables.outputFileLoc, $"{Variables.outputFileName}.txt"), processedText);

                Success = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar ficheiro: {ex.Message}");
                Success = false;
            }
        }

        public string ProcessText(string input)
        {
            return encrypt ? cipher.Encrypt(input) : cipher.Decrypt(input);
        }
    }
}