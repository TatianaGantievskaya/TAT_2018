using System;
using System.Collections.Generic;

namespace CarsSale
{
  class Check
  {
    public void CheckTheMatches(List<Car> checkingList)
    {
      if (checkingList.Count.Equals(0))
      {
        throw new Exception("\nThere is no matches for your request.");
      }
    }
  }
}