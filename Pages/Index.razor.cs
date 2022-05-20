using System.Collections.Generic;
using static ListComponentIssue.Shared.MyComponent;

namespace ListComponentIssue.Pages
{
    public partial class Index
    {
        private List<Item> listOfItems = new List<Item>();

        protected override void OnInitialized()
        {
            base.OnInitialized();
            listOfItems.Add(
                new Item()
                {
                    Id = "1",
                    Title = "First"
                }
            );
            listOfItems.Add(
                new Item()
                {
                    Id = "2",
                    Title = "Second"
                }
            );
            listOfItems.Add(
             new Item()
             {
                 Id = "3",
                 Title = "Third"
             }
         );
            listOfItems.Add(
             new Item()
             {
                 Id = "4",
                 Title = "Fourth"
             }
         );
            listOfItems.Add(
             new Item()
             {
                 Id = "5",
                 Title = "Fifth"
             }
         );
        }

        public void close(Item itemToRemove)
        {
            listOfItems.Remove(itemToRemove);
        }

    }
}
