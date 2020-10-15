using System.Collections.Generic;
using CSharpApi.Models;

namespace CSharpApi.db
{
  public class FAKEDB
  {
    public static List<Cat> Cats { get; set; } = new List<Cat>(){
      new Cat("Chonkers", "He's Chunky")
    };
  }
}