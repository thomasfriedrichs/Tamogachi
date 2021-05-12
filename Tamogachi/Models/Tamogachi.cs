using System;
using System.Collections.Generic;

namespace Tamogachi.Model 
{
  class Tamogachi
  {
    public int Hunger { get; set; }
    public int Play { get; set; }
    public int Sleep { get; set; }
    public int Id { get; }
    private static List<Tamogachi> tamogachis = new List<Tamogachi> { };

    public static void Tamogachi (int hunger, int play, int sleep)
    {
      Hunger = hunger;
      Play = play;
      Sleep = sleep;
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