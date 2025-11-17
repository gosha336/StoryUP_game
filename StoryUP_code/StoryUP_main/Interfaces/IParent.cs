using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.Interfaces
{
    internal interface IParent<Parent, Child> where Child : IChild<Parent, Child> where Parent : IParent<Parent, Child>
    {
        public bool AddChild(Child newChild);

        public bool RemoveChild(Child oldChild);
    }
}
