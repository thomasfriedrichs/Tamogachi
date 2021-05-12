using System;
using System.Collections.Generic;

namespace Tamogachi.Models
{
  class Tamogachi
  {
    public int Hunger { get; set; }
    public int Play { get; set; }
    public int Sleep { get; set; }
    public int Id { get; }
    public string Name { get; set; }
    private static List<Tamogachi> tamogachis = new List<Tamogachi> { };

    public static void Tamogachi (string name)
    {
      Hunger = 20;
      Play = 20;
      Sleep = 20;
      Name = name;
      tamogachis.Add(this);
      Id = tamogachis.Count;
    }
    // Find method
    public static Tamogachi Find(int searchId)
    {
      return tamogachis[searchId - 1];
    }

    // GetAll method
    public static void GetAll()
    {
      return tamogachis;
    }

    // ClearAll method
    public static void ClearAll()
    {
      tamogachis.Clear();
    }

    // Clear Tamogachi instance?
    public static void Death(int tamogachiId)
    {
      tamogachis.RemoveAt(tamogachiId);
    }

    // Feed method?
    public static void Feed()
    {
      Tamogachi.Hunger += 10;
    }

    // PLay method
    public static void AddPlay()
    {
      Tamogachi.Play += 10;
    }

    // sleep method 
    public static void Rest()
    {
      Tamogachi.Sleep += 10;
    }
  } 
}