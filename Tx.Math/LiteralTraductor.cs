using System.Text.RegularExpressions;

namespace Tx.Math
{
    public enum CurrencyGenere
    {
        Male = 1,
        Female = 2
    }

    public enum CurrencyLanguage
    {
        Spanish = 1,
        English = 2
    }

    public static class LiteralTraductor
    {
        public static string ConvertToLiteral(int number, CurrencyGenere genere = CurrencyGenere.Male, CurrencyLanguage spanish = CurrencyLanguage.Spanish)
        {
            switch (LengthNumber(number))
            {
                case 1:
                    return Units(number, genere);
                case 2:
                    return Tens(number, genere);
                case 3:
                    return Hundreds(number, genere);
                case 4:
                    return MillerUnits(number, genere);
                case 5:
                    return MillerTens(number, genere);
                case 6:
                    return MillerHundreds(number, genere);
                case 7:
                    return MillionUnits(number, genere);
                case 8:
                    return MillonTens(number, genere);
                case 9:
                    return MillonHundreds(number, genere);
                default:
                    return "Numero demasiado grande.";
                    break;
            }
        }

        private static string MillonHundreds(int number, CurrencyGenere genere)
        {
            var hundreds = Hundreds(number / 1000000, genere);
            hundreds = Regex.Replace(hundreds, "(?<xxx>as)", "os");
            if (hundreds.EndsWith("na")) hundreds = hundreds.Remove(hundreds.Length - 1, 1);
            return hundreds + " millones " + MillerHundreds(number % 1000000, genere);
        }

        private static string MillonTens(int number, CurrencyGenere genere)
        {
            var tens = Tens(number / 1000000, genere);
            if (tens.EndsWith("na")) tens = tens.Remove(tens.Length - 1, 1);
            return tens + " millones " + MillerHundreds(number % 1000000, genere);
        }

        private static string MillionUnits(int number, CurrencyGenere genere)
        {
            if (number > 1999999)
                return Units(number / 1000000, genere) + " millones " + MillerHundreds(number % 1000000, genere);
            return "un millon " + MillerHundreds(number % 1000000, genere);
        }

        private static string MillerHundreds(int number, CurrencyGenere genere)
        {
            if (number > 99999)
                return Hundreds(number / 1000, genere) + " mil " + Hundreds(number % 1000, genere);
            return MillerTens(number, genere);
        }

        private static string MillerTens(int number, CurrencyGenere genere)
        {
            if (number > 9999)
                return Tens(number / 1000, genere) + " mil " + Hundreds(number % 1000, genere);
            return MillerUnits(number, genere);
        }

        private static string MillerUnits(int number, CurrencyGenere genere)
        {
            if (number > 999)
            {
                if (number > 1999)
                    return Units(number / 1000) + " mil " + Hundreds(number % 1000, genere);
                return "un mil " + Hundreds(number % 1000, genere);
            }
            return Hundreds(number, genere);
        }

        private static string Hundreds(int number, CurrencyGenere genere)
        {
            if (number == 0) return "";
            if (number >= 1 && number <= 99) return Tens(number, genere);
            if (number == 100) return "cien";
            if (number >= 101 && number <= 199) return "ciento " + Tens(number % 100, genere);
            if (number == 200) return (genere == CurrencyGenere.Male) ? "doscientos" : "doscientas";
            if (number == 500) return (genere == CurrencyGenere.Male) ? "quinientos" : "quinientas";
            if (number >= 501 && number <= 599)
                return (genere == CurrencyGenere.Male)
                           ? "quinientos " + Tens(number % 100, genere)
                           : "quinientas " + Tens(number % 100, genere);
            if (number == 700) return (genere == CurrencyGenere.Male) ? "setecientos" : "setecientas";
            if (number >= 701 && number <= 799)
                return (genere == CurrencyGenere.Male)
                           ? "setecientos " + Tens(number % 100, genere)
                           : "setecientas " + Tens(number % 100, genere);
            if (number >= 900 && number <= 999)
                return (genere == CurrencyGenere.Male)
                           ? "novecientos " + Tens(number % 100, genere)
                           : "novecientas " + Tens(number % 100, genere);
            return (genere == CurrencyGenere.Male)
                       ? Units(number / 100, genere) + "cientos " + Tens(number % 100, genere)
                       : Units(number / 100, genere) + "cientas " + Tens(number % 100, genere);
        }

        private static string Tens(int number, CurrencyGenere genere)
        {
            switch (number)
            {
                case 0:
                    return "";
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    return Units(number);
                case 10:
                    return "diez";
                case 11:
                    return "once";
                case 12:
                    return "doce";
                case 13:
                    return "trece";
                case 14:
                    return "catorce";
                case 15:
                    return "quince";
                case 16:
                    return "dieciséis";
                case 17:
                    return "diecisiete";
                case 18:
                    return "dieciocho";
                case 19:
                    return "diecinueve";
                case 20:
                    return "veinte";
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                    return "veinti" + Units(number % 10, genere);
                case 30:
                    return "treinta";
                case 40:
                    return "cuarenta";
                case 50:
                    return "cincuenta";
                case 60:
                    return "sesenta";
                case 70:
                    return "setenta";
                case 80:
                    return "ochenta";
                case 90:
                    return "noventa";
                default: return Tens(number - number % 10, genere) + " y " + Units(number % 10, genere);

            }
        }

        private static string Units(int number, CurrencyGenere genere = CurrencyGenere.Male, CurrencyLanguage spanish = CurrencyLanguage.Spanish)
        {
            switch (number)
            {
                case 0:
                    return "";
                case 1:
                    return (genere == CurrencyGenere.Male) ? "uno" : "una";
                case 2:
                    return "dos";
                case 3:
                    return "tres";
                case 4:
                    return "cuatro";
                case 5:
                    return "cinco";
                case 6:
                    return "seis";
                case 7:
                    return "siete";
                case 8:
                    return "ocho";
                case 9:
                    return "nueve";
            }
            return "Error";
        }

        private static int LengthNumber(int number)
        {
            return System.Math.Truncate((decimal)number / 10) == 0
                       ? 1
                       : 1 + LengthNumber((int)System.Math.Truncate((decimal)number / 10));
        }
    }
}