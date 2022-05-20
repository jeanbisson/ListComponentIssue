using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ListComponentIssue.Shared.MyComponent;

namespace ListComponentIssue.Pages
{
    public partial class Index
    {
        private List<FakeStuff> damn = new List<FakeStuff>();

        protected override void OnInitialized()
        {
            base.OnInitialized();
            damn.Add(
                new FakeStuff()
                {
                    Id = "1",
                    Title = "What"
                }
            );
            damn.Add(
                new FakeStuff()
                {
                    Id = "2",
                    Title = "What"
                }
            );
            damn.Add(
             new FakeStuff()
             {
                 Id = "3",
                 Title = "in"
             }
         );
            damn.Add(
             new FakeStuff()
             {
                 Id = "4",
                 Title = "the"
             }
         );
            damn.Add(
             new FakeStuff()
             {
                 Id = "5",
                 Title = "button"
             }
         );
        }

        public void close(FakeStuff what)
        {
            damn.Remove(what);
        }

    }
}
