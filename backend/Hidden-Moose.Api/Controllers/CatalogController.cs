using Microsoft.AspNetCore.Mvc;
using HiddenMoose.Domain.Catalog;
using System;
using System.Collections.Generic;

namespace Hidden.Moose.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
    [HttpGet]
    public IActionResult GetItems()
    {
        var items = new List<Item>()
        {
            new Item("shirt", "Ohio State shirt.", "Nike", 29.99m),
            new Item("shorts", "Ohio State shorts.", "Nike", 44.99m)
        };
        return Ok(items);
    }
    
}
}
