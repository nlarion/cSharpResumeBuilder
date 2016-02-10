using System.Collections.Generic;

namespace Resume.Addresses
{
  public class Address
  {
    private string _location;

    public Address(string location)
    {
      _location =  location;
    }

    public string GetAddressLocation()
    {
      return _location;
    }
    public void SetAddressLocation(string location)
    {
      _location = location;
    }
  }
}
