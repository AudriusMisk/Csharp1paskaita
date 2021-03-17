using System;
using System.Collections.Generic;
using System.Text;

namespace Uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ReadIntNumber();
            // SentenceAnalysis();
             MatricosSprendimai();
            // SkaiciuStatusTrikampis();
            // SkaiciuEile();
            // IntegerToBinary();
            // FormulesSprendimas("1 + x + x / 2 + x / 3 + x / 2 + 1 * 2", 3); 
        }


        static void ReadIntNumber()
        {
            Console.WriteLine("Iveskite sveikaji skaiciu");
            string skaiciusStr = string.Empty;
            bool arSkaiciusTeisingas = false;
            while (!arSkaiciusTeisingas)
            {
                skaiciusStr = Console.ReadLine();
                arSkaiciusTeisingas = int.TryParse(skaiciusStr, out _);
                if (!arSkaiciusTeisingas) Console.WriteLine("Ivestas skaicius neteisingas, bandykite dar");
            }

            Console.WriteLine($"Ivestas skaicius: {skaiciusStr}");
        }

        /*static void SentenceAnalysis()
        {
            string tekstas = "Kazkas parasyta".Replace(" ", ""); ;
            char[] tekstoRaides = tekstas.ToCharArray();         
            Console.WriteLine(tekstoRaides);

            Dictionary<char, int> SimbolisPasikartojimai = new Dictionary<char, int>
            for (int i = 0; i < tekstoRaides.Length; i++)

            {
                            for (int i = 0; i < tekstoRaides.Length; i++)
                { tekstoRaides[i], 1 }
            };
            for (int i = 0; i < tekstoRaides.Length; i++)
            {
            }


        }*/

        static void MatricosSprendimai()
        {
            int[,] matrica = new int[4, 4] { { 9, 22, 3, 19 }, { 6 ,16 ,11 ,8 }, { 7, 5, 18, 10 }, { 8, 6, 2, 11 } };
            int didziausiasSkaicius = 0;
            int suma = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int matricosSkaicius = matrica[i, j];
                    if (didziausiasSkaicius < matricosSkaicius)
                    {
                        didziausiasSkaicius = matricosSkaicius;
                    }
                    suma = suma + matricosSkaicius;
                  
                    Console.WriteLine($"matrica: {matricosSkaicius}");
                    Console.WriteLine($"suma: {suma}");
                }
            }


            double vidutinisSkaicius = (double)suma/ matrica.Length;
            Console.WriteLine($"vid sk: {vidutinisSkaicius}");
            double? maziausiasAtstumas = null;
            int? arciausiasSkaicius = null;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int matricosSkaicius = matrica[i, j];
                    double atstumas = Math.Abs(vidutinisSkaicius - matricosSkaicius);
                    
                    if (maziausiasAtstumas == null)
                    {
                        maziausiasAtstumas = atstumas;
                        arciausiasSkaicius = matricosSkaicius;
                    }
                    else if (maziausiasAtstumas > atstumas)
                    {
                        maziausiasAtstumas = atstumas;
                        arciausiasSkaicius = matricosSkaicius;

                    }
                }
            }
            Console.WriteLine($"maziausio sk atstumas {maziausiasAtstumas}");
            Console.WriteLine($"maziausio sk atstumas {arciausiasSkaicius}");
        }

        static void SkaiciuStatusTrikampis()
        {
            Console.WriteLine("Iveskite skaicius nuo 1 iki 9");
            int skaicius = int.Parse(Console.ReadLine());
            if (skaicius < 1 || skaicius > 9)
            {
                Console.WriteLine("Ivestas klaidingas skaicius");
                SkaiciuStatusTrikampis();
                return;
            }
            for (int row = 0; row < skaicius; row++)
            {
                for (int column = 0; column < row + 1; column++)
                {
                    Console.Write($"{skaicius}");
                }
                Console.WriteLine();
            }
        }

        static void SkaiciuEile()
        {
            Console.WriteLine("Irasykite skaiciu");
            int skaicius = int.Parse(Console.ReadLine());
            Console.WriteLine("Irasykite grupiu kieki");
            int grupiuKiekis = int.Parse(Console.ReadLine());
            Console.WriteLine($"{skaicius}{grupiuKiekis}");
            string stringas = "->";
            var sb = new StringBuilder();

            for (int i = 1; i <= grupiuKiekis  ; i++)
            {
                sb.Append(" -> ");
                for (int j = 1  ; j <= i ; j++)
                {
                    sb.Append("1");
                    stringas = stringas + $"{skaicius}";
                }
                stringas += "->";
            }

            Console.WriteLine($"stringas: {stringas}");
            Console.WriteLine($"stringas: {sb}");
        }

        static void IntegerToBinary()
        {
            int n, i;
            int[] a = new int[10];
            Console.Write("Enter the number to convert: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }

        public static bool TryParseReloaded(string tekstas, out int skaicius)
        {
            skaicius = 0;
            foreach (var raide in tekstas)
            {
                if (!char.IsDigit(raide)) ; // tikrina ar char yra skaicius
                return false;
            }

            skaicius = int.Parse(tekstas);
            return true;
        }

        static void SentenceAnalysis(string eilute, out Dictionary<char, int> simboliuZodynas, out string maziausiaiPasikartojo, out string daugiausiaiPasikartojo)
        {
            simboliuZodynas = SukurtiSkirtinguSimboliuZodyna(eilute.ToUpper().ToCharArray());
            MaziausiaiIrDaugiausiaiPasikartojimu(simboliuZodynas, out maziausiaiPasikartojo, out daugiausiaiPasikartojo);
        }

        static Dictionary<char, int> SukurtiSkirtinguSimboliuZodyna(char[] charArray)
        {
            var simboliai = new Dictionary<char, int>();
            foreach (var raide in charArray)
            {
                if (!string.IsNullOrWhiteSpace(raide.ToString()))
                {
                    if (simboliai.ContainsKey(raide))
                    {
                        simboliai[raide]++;
                    }
                    else
                    {
                        simboliai.Add(raide, 1);

                    }
                }
            }
            return simboliai;
        }
        static void MaziausiaiIrDaugiausiaiPasikartojimu(Dictionary<char, int> simboliuZodynas, out string maziausiaiPasikartojo, out string daugiausiaiPasikartojo)
        {
            int min = int.MaxValue;
            int max = 0;

            foreach (var simbolis in simboliuZodynas)
            {
                if (simbolis.Value < min) min = simbolis.Value;
                if (simbolis.Value > max) max = simbolis.Value;
            }

            List<char> minSimboliuMasyvas = new List<char>();
            List<char> maxSimboliuMasyvas = new List<char>();

            foreach (var simbolis in simboliuZodynas)
            {
                if (simbolis.Value == min) minSimboliuMasyvas.Add(simbolis.Key);
                if (simbolis.Value == max) maxSimboliuMasyvas.Add(simbolis.Key);
                
            }

            daugiausiaiPasikartojo = $"{string.Join(", ", maxSimboliuMasyvas)}pasikartojo {max}";
            maziausiaiPasikartojo = $"{string.Join(", ", minSimboliuMasyvas)}pasikartojo {min}";
        }

        public static double FormulesSprendimas(string formule, int kintamasisX)
        {
            var naujaFormule = formule.Replace("x", kintamasisX.ToString().Replace(" ", ""));
            var charArr = naujaFormule.ToCharArray();
            double rezultatas = double.Parse(charArr[0].ToString());

            for (int i = 1; i < charArr.Length; i++)
            {
                if (charArr[i] == '+')
                {
                    var sk = int.Parse(charArr[i + 1].ToString());
                    rezultatas += sk;
                }
                else if (charArr[i] == '/')
                {
                    var sk = int.Parse(charArr[i + 1].ToString());
                    rezultatas /= sk;
                }
                else if (charArr[i] == '*')
                {
                    var sk = int.Parse(charArr[i + 1].ToString());
                    rezultatas *= sk;
                }
                else if (charArr[i] == '-')
                {
                    var sk = int.Parse(charArr[i + 1].ToString());
                    rezultatas -= sk;
                }
            }
            return rezultatas;
            Console.WriteLine(rezultatas);
        }

        public static double FormulesSprendimas2(string formule, double kintamasisX)
        {
            var naujaFormule = formule.Replace("x", kintamasisX.ToString().Replace(" ", ""));
            var charArr = naujaFormule.ToCharArray();
            var tokens = new List<string>();
            foreach (var simbolis in charArr)
            {
                tokens.Add(simbolis.ToString());
            }
            while (tokens.Contains("/") || tokens.Contains("*"))
            {
                for (int i = 0; i < tokens.Count; i++)
                {
                    var token = tokens[i];
                    if (token == "/")
                    {
                        tokens[i] = (double.Parse(tokens[i - 1]) / double.Parse(tokens[i + 1])).ToString(); // vieotj matematinio veiksmo irasome suma
                        tokens.RemoveAt(i - 1); // pasalinamas kairys elementas
                        tokens.RemoveAt(i); // pasalinamas desinys elementas
                        break;
                    }
                    else if (token == "*")
                    {
                        tokens[i] = (double.Parse(tokens[i - 1]) * double.Parse(tokens[i + 1])).ToString(); // vieotj matematinio veiksmo irasome suma
                        tokens.RemoveAt(i - 1); // pasalinamas kairys elementas
                        tokens.RemoveAt(i); // pasalinamas desinys elementas
                        break;
                    }
                }
            }

            while (tokens.Contains("+") || tokens.Contains("-"))
            {
                for (int i = 0; i < tokens.Count; i++)
                {
                    var token = tokens[i];
                    if (token == "+")
                    {
                        tokens[i] = (double.Parse(tokens[i - 1]) + double.Parse(tokens[i + 1])).ToString(); // vieotj matematinio veiksmo irasome suma
                        tokens.RemoveAt(i - 1); // pasalinamas kairys elementas
                        tokens.RemoveAt(i); // pasalinamas desinys elementas
                        break;
                    }
                    else if (token == "-")
                    {
                        tokens[i] = (double.Parse(tokens[i - 1]) - double.Parse(tokens[i + 1])).ToString(); // vieotj matematinio veiksmo irasome suma
                        tokens.RemoveAt(i - 1); // pasalinamas kairys elementas
                        tokens.RemoveAt(i); // pasalinamas desinys elementas
                        break;
                    }
                }
            }
            return double.Parse(tokens[0]);           
        }

    }

}