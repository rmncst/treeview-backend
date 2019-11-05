using System;
using System.Collections.Generic;

namespace ItemsApi.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<Item> Children { get; set; }
        public Guid? ParentId { get; set; }

        public Item(string Name, IList<Item> Children = null)
        {
            this.Id = Guid.NewGuid();
            this.Name = Name;           
            this.Children = Children; 
        }

        public static List<Item> Spawn()
        {
            return new List<Item>()
            {
                new Item("Frutas", new List<Item>()
                {
                    new Item("Morango"),
                    new Item("Banana"),
                    new Item("Maracujá"),
                    new Item("Mamão"),
                    new Item("Limão"),
                }),
                
                new Item("Carnes", new List<Item>()
                {
                    new Item("Costela de porco"),
                    new Item("Picanha bovina"),
                    new Item("Filé de frango"),
                    new Item("Frango frito"),
                    new Item("Fígado de boi"),
                }),
                
                new Item("Massas", new List<Item>()
                {
                    new Item("Macarrão ao molho"),
                    new Item("Talharim de Glútem"),
                }),
                
                new Item("Bebidas", new List<Item>()
                {
                    new Item("Alcoólicas", new List<Item>()
                    {
                        new Item("Ceveja"),
                        new Item("Vinho"),
                        new Item("Champanhe"),
                        new Item("Whiskey"),
                        new Item("Conhaque"),
                        new Item("Cidra"),
                        new Item("Martini"),
                    }),

                    new Item("Refrigerantes", new List<Item>()
                    {
                        new Item("Coca-Cola"),
                        new Item("Guaraná Antartica"),
                        new Item("Sprite"),
                        new Item("Fanta"),
                        new Item("Pepsi"),
                    }),

                    new Item("Energéticos", new List<Item>()
                    {
                        new Item("Red Bull"),
                        new Item("Monster"),
                        new Item("Flying Horse"),
                    }),
                }),
            };
        }
    }
}