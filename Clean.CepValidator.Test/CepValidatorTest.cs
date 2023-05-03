using NUnit.Framework;

namespace Clean.CepValidator.Test
{
    [TestFixture]
    public class CepValidatorTest
    {
        [Test, Description("ensure CepValidator returns false if an invalid cep is provided.")]
        public void CepValidator_InvalidCep_ReturnsFalse()
        {
            Assert.That(CepValidator.Validate("12345"), Is.EqualTo(false));
        }

        [Test, Description("ensure CepValidator returns false if an empty cep is provided.")]
        public void CepValidator_EmptyCep_ReturnsFalse()
        {
            Assert.That(CepValidator.Validate(""), Is.EqualTo(false));
        }
    }
}
