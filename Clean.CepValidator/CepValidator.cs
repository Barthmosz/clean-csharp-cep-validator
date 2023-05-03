using System.Text.RegularExpressions;

namespace Clean.CepValidator
{
    public static class CepValidator
    {
        public static bool Validate(string cep)
        {
            string cepRegex = "^[0-9]{5}-[0-9]{3}$";
            return Regex.IsMatch(cep, cepRegex);
        }
    }
}
