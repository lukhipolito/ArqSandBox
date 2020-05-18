using System;
using System.Threading;

namespace SampleConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wich number do you want to convert to roman numbers?");
            string input = Console.ReadLine();
            int auxNumber;

            if (!int.TryParse(input, out auxNumber))
                throw new ArgumentException("Invalid number!");

            if (auxNumber < 1 || auxNumber > 999)
                throw new ArgumentException("Please provide number from 1 to 999!");


            ArabicNumber num = new ArabicNumber(auxNumber);
            string result = num.ConvertToRoman(num.Value);

            Console.WriteLine("");
            Console.WriteLine($"You entered: {input}");
            Console.WriteLine($"The conversion to roman algarism: {result}");
        }
    }

    public abstract class Number
    {
        public Type Type { get; set; }

        public abstract Number ConvertNumber(int number);

        public abstract Number ConvertNumber(string number);
    }

    public class RomanNumber : Number
    {
        private RomanNumber()
        {
            this.Type = Type.Roman;
        }
        public RomanNumber(string number)
        {
            this.Value = number;
            this.Type = Type.Roman;
        }

        public string Value { get; set; }

        public override Number ConvertNumber(int number)
        {
            return new RomanNumber
            {
                Value = number.ToString(),
                Type = Type.Roman
            };
        }

        public override Number ConvertNumber(string number)
        {
            return new RomanNumber
            {
                Value = number,
                Type = Type.Roman
            };
        }

        public ArabicNumber ConvertToArabic(string number)
        {
            return new ArabicNumber(Convert.ToInt32(number));
        }
    }

    public class ArabicNumber : Number
    {
        private ArabicNumber()
        {
            this.Type = Type.Arabic;
        }

        public ArabicNumber(int number)
        {
            this.Value = number;
            this.Type = Type.Arabic;
        }

        public int Value { get; set; }

        public override Number ConvertNumber(int number)
        {
            return new ArabicNumber
            {
                Value = number,
                Type = Type.Arabic
            };
        }

        public override Number ConvertNumber(string number)
        {
            return new ArabicNumber
            {
                Value = int.Parse(number),
                Type = Type.Arabic
            };
        }

        public string ConvertToRoman(int number)
        {
            string numberStr = number.ToString();
            if (numberStr.Length == 1)
                return GetAlgarism(numberStr[0].ToString());

            if (numberStr.Length == 2)
                return GetAlgarism($"{numberStr[0]}0") 
                    + GetAlgarism(numberStr[1].ToString());

            if (numberStr.Length == 3)
                return GetAlgarism($"{numberStr[0]}00")
                    + GetAlgarism($"{numberStr[1]}0")
                    + GetAlgarism(numberStr[2].ToString());

            return numberStr;

        }

        public string GetAlgarism(string character)
        {
            switch (character.Trim())
            {
                case "1":
                    return "I";
                case "2":
                    return "II";
                case "3":
                    return "III";
                case "4":
                    return "IV";
                case "5":
                    return "V";
                case "6":
                    return "VI";
                case "7":
                    return "VII";
                case "8":
                    return "VIII";
                case "9":
                    return "IX";
                case "10":
                    return "X";
                case "20":
                    return "XX";
                case "30":
                    return "XXX";
                case "40":
                    return "XL";
                case "50":
                    return "L";
                case "60":
                    return "LX";
                case "70":
                    return "LXX";
                case "80":
                    return "LXXX";
                case "90":
                    return "XC";
                case "100":
                    return "C";
                case "200":
                    return "CC";
                case "300":
                    return "CCC";
                case "400":
                    return "CD";
                case "500":
                    return "D";
                case "600":
                    return "DC";
                case "700":
                    return "DCC";
                case "800":
                    return "DCCC";
                case "900":
                    return "CM";
                default:
                    return string.Empty;
            }
        }
    }

    public enum Type
    {
        Roman,
        Arabic
    }
}
