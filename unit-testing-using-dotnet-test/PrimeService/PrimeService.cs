using System;

namespace Prime.Services
{
  public class PrimeService
  {
    public bool IsPrime(int candidate)
    {
      if (candidate < 3)
      {
        return false;
      }
      throw new NotImplementedException("Not implemented");
    }
  }
}