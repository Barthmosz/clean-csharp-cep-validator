using System.Text.RegularExpressions;

namespace Clean.CepValidator
{
    public static class CepValidator
    {
        /// <summary>
        /// Validates an cep.
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static bool Validate(string cep)
        {
            string cepRegex = "^[0-9]{5}-[0-9]{3}$";
            return Regex.IsMatch(cep, cepRegex);
        }
    }
}
