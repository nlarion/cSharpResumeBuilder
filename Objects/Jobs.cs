using System.Collections.Generic;
using Resume.Addresses;

namespace Resume.Objects
{
  public class Job
  {
    // variables
    private string _jobTitle;
    private int _id;
    private string _description;
    private Address _address;//local instance of the object Address i.e. putting empty varibles to put something in
    private static List<Job> _pastJobs = new List<Job>{};
    // constructor
    public Job(string jobTitle, string description, Address image)
    {
      _jobTitle =jobTitle;
      _description = description;
      _pastJobs.Add(this);
      _id = _pastJobs.Count;
      _address = image;
    }
    // getters and setters
    public string GetCity()
    {
      return _jobTitle;
    }
    public void SetCity(string jobTitle)
    {
      _jobTitle = jobTitle;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string description)
    {
      _description = description;
    }

    public Address GetAddress()
    {
      return _address;
    }
    public void SetAddress(Address image)
    {
      _address = image;
    }
    public static List<Job> GetAll()
    {
      return _pastJobs;
    }
    public int GetId()
    {
      return _id;
    }
    public static Job Find(int id)
    {
      return _pastJobs[id-1];
    }

  }
}
