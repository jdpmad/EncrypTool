using EncrypTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncrypTool
{
    public partial class Variables
    {               
        public static string cifra; //a cifra (césar/tap/morse) 
        public static string currentForm; //o form a ser mostrado atualmente 
        public static int caesarShift; // Número de shifts na cifra de César
        public static string outputFileLoc; // Localização do ficheiro gerado pelo programa
        public static string inputFileLoc; // Localização do ficheiro lido pelo programa
        public static string outputFileName; // Nome do ficheiro gerado pelo programa
    }
}
