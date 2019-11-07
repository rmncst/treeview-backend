using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ItemsApi.Models;
using ItemsApi.Services;
using System.Linq;

namespace ItemsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly ItemService BaseItemService = new ItemService();

        /// <summary>
        /// Lists all items.
        /// </summary>       
        /// <returns></returns>   
        /// <response code="200">Returns all items</response>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return BaseItemService.FindAll();
        }

        /// <summary>
        /// Lists all items.
        /// </summary>       
        /// <returns></returns>   
        /// <response code="200">Returns all items</response>
        [HttpGet("{id}")]
        public Item Get(string id)
        {
            return BaseItemService.Find(Guid.Parse(id));
        }

        /// <summary>
        /// Creates an Item.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// POST /Item
        /// {
        ///    name: "MyItem",
        ///    parentId: "4c06d4c6-22ea-46ed-88ac-a0c2831a0a43"
        /// }
        ///
        /// </remarks>
        /// <param name="item"></param>        
        /// <returns></returns>
        /// <response code="204">Returns no content</response>
        [HttpPost()]
        public Item Post(Item item)
        {
            return BaseItemService.Add(item);
        }

        /// <summary>
        /// Updates an Item.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// PATCH /Item
        /// {
        ///    id: "afb934f4-5551-4457-81ff-74073502d124",
        ///    name: "My item updated"
        /// }
        ///
        /// </remarks>
        /// <param name="id"></param>        
        /// <param name="itemParameter"></param>
        /// <returns></returns>
        /// <response code="204">Returns no content</response>
        [HttpPut("{id}")]
        public Item Put(string id, Item itemParameter)
        {
            if(itemParameter == null)
            {
                return null;
            }

            itemParameter.Id = Guid.Parse(id);
            return BaseItemService.Update(itemParameter);
        }

        /// <summary>
        /// Deletes an Item.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// DELETE /Item/afb934f4-5551-4457-81ff-74073502d124
        /// </remarks>        
        /// <returns></returns>
        /// <response code="204">Returns no content</response>
        [HttpDelete("{id}")]
        public Item Delete(string id)
        {
            var item = BaseItemService.Find(Guid.Parse(id));
            return BaseItemService.Remove(item);
        }
    }
}
