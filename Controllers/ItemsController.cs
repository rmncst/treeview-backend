using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ItemsApi.Models;

namespace ItemsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<Item> Items = Item.Spawn();

        /// <summary>
        /// Lists all items.
        /// </summary>       
        /// <returns></returns>   
        /// <response code="200">Returns all items</response>
        [HttpGet]
        public IEnumerable<Item> Get()
        {            
            return Items;
        }

        /// <summary>
        /// Creates an Item.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        /// POST /Item
        /// {
        ///    id: "afb934f4-5551-4457-81ff-74073502d124",
        ///    name: "MyItem",
        ///    parentId: "4c06d4c6-22ea-46ed-88ac-a0c2831a0a43"
        /// }
        ///
        /// </remarks>
        /// <param name="item"></param>        
        /// <returns></returns>
        /// <response code="204">Returns no content</response>
        [HttpPost()]
        public IActionResult Post(Item item)
        {
            // TODO
            return NoContent();
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
        /// <param name="item"></param>        
        /// <returns></returns>
        /// <response code="204">Returns no content</response>
        [HttpPatch("{id}")]
        public IActionResult Put(Item item)
        {
            // TODO
            return NoContent();
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
        public IActionResult Delete(Guid id)
        {
            // TODO
            return NoContent();
        }
    }
}
