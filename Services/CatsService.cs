using CSharpApi.db;
using CSharpApi.Models;
using System;
using System.Collections.Generic;

namespace CSharpApi.Services
{
  public class CatsService
  {
    public IEnumerable<Cat> GetCats()
    {
      return FAKEDB.Cats;
    }
    public Cat Create(Cat newCat)
    {
      FAKEDB.Cats.Add(newCat);
      return newCat;
    }
    public Cat GetCatById(string id)
    {
      Cat foundCat = FAKEDB.Cats.Find(c => c.Id == id);
      if (foundCat != null)
      {
        return foundCat;
      }
      throw new System.Exception("No such cat ere hoss, best you mosey along.");
    }
  }
}