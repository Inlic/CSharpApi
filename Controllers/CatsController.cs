using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpApi.Models;
using CSharpApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharpApi.Controllers
{

  [ApiController]
  [Route("[controller]")]
  public class CatsController : ControllerBase
  {
    private readonly CatsService _catService;

    public CatsController(CatsService catsService)
    {
      _catService = catsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Cat>> Get()
    {
      try
      {
        return Ok(_catService.GetCats());
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpGet("{catId}")]
    public ActionResult<Cat> GetById(string catId)
    {
      try
      {
        return Ok(_catService.GetCatById(catId));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Cat> Create([FromBody] Cat newCat)
    {
      try
      {
        return Ok(_catService.Create(newCat));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpPut("{catId}")]
    public ActionResult<Cat> Update([FromBody] Cat update, string catId)
    {
      try
      {
        return Ok(_catService.Update(update, catId));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    [HttpDelete("{catId}")]
    public ActionResult<Cat> Remove(string catId)
    {
      try
      {
        return Ok(_catService.Remove(catId));
      }
      catch (System.Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}