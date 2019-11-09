using System;
using System.Collections.Generic;
using System.Linq;
using ItemsApi.Models;

namespace ItemsApi.Services
{
    public class ItemService : ServiceBase<Item>
    {
        private static List<Item> ListItems = Item.Spawn();
        
        public override Item Add(Item item)
        {
            if(item.ParentId.HasValue) 
            {
                Console.WriteLine(item.ParentId);
                var itemParent = Find(item.ParentId.Value);
                if(itemParent == null) 
                {
                    return null;
                }

                itemParent.Children ??= new List<Item>();
                item.ParentId = itemParent.Id;
                itemParent.Children.Add(item);                
            } 
            else
            {
                ListItems.Add(item);
            }            
            return item;
        }

        public override IEnumerable<Item> FindAll()
        {
            return ListItems;
        }

        public override Item Remove(Item item)
        {
            return DeepRemove(ListItems, item.Id);
        }

        protected Item DeepRemove(IList<Item> Items, Guid id)
        {
            foreach (var item in Items)
            {
                if (item.Id.Equals(id))
                {
                    Items.Remove(item);
                    return item;
                }
                else if (item.Children != null && item.Children.Count > 0)
                {
                    var subItem = DeepRemove(item.Children, id);
                    if(subItem != null)
                    {
                        return subItem;
                    }
                }
            }
            return null;
        }

        public override Item Find(object id)
        {
            return DeepFind(ListItems, (Guid)id);
        }

        protected Item DeepFind(IList<Item> Items, Guid id) 
        {
            foreach(var item in Items) 
            {
                if(item.Id.Equals(id)) 
                {
                    return item;
                }
                else if(item.Children != null && item.Children.Count > 0) 
                {
                    var subItem = DeepFind(item.Children, id);
                    if(subItem != null)
                    {
                        return subItem;
                    }
                }
            }        
            return null;    
        }

        public override Item Update(Item itemParameter)
        {
            var item = Find(itemParameter.Id);
            if(item == null)
            {
                return null;
            }
            item.Name = itemParameter.Name;
            return item;
        }

    }
} 