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

    public object Update(Cat update, string id)
    {
      Cat foundCat = FAKEDB.Cats.Find(c => c.Id == id);
      if (foundCat != null)
      {
        FAKEDB.Cats.Remove(foundCat);
        foundCat.Name = update.Name == null ? foundCat.Name : update.Name;
        foundCat.Description = update.Description == null ? foundCat.Description : update.Description;
        FAKEDB.Cats.Add(foundCat);
        return foundCat;
      }
      throw new System.Exception("No such cat ere hoss, best you mosey along.");
    }

    public object Remove(string id)
    {
      Cat foundCat = FAKEDB.Cats.Find(c => c.Id == id);
      if (foundCat != null)
      {
        FAKEDB.Cats.Remove(foundCat);
        return "Cat Removed";
      }
      throw new System.Exception("No such cat ere hoss, best you mosey along.");
    }
  }
}