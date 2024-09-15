using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
  public class PrimeService_IsPrimeShould
  {
    private readonly PrimeService _primeService;

    public PrimeService_IsPrimeShould()
    {
      _primeService = new PrimeService();
    }

    [Theory]
    [InlineData(-2)]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public void IsPrime_ValuesLessThan3_ReturnFalse(int value)
    {
      var result = _primeService.IsPrime(value);

      Assert.False(result, $"{value} should not be prime");
    }
  }
}