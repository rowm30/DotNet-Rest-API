using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Controllers
{
    //GET /items
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsController()
        {
            repository = new InMemItemsRepository();
        }

        //GET /Item
        [HttpGet]
        public IEnumerable<Item> GetItem()
        {
            var items = repository.GetItems();
            return items;
        }
    }
}