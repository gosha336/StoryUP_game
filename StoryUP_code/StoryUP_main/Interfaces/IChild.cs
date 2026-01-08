using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.Interfaces
{
    public interface IChild<Parent, Child> where Parent : IParent<Parent, Child> where Child : IChild<Parent, Child>
    {
        public bool HasParent { get; }

        public bool AddParent(Parent newParent);

        public bool RemoveParent(Parent oldParent);
    }
}
