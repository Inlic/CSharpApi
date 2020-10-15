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
  }
}