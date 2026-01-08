using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.Interfaces
{
    public interface IRenderElementChild : IRenderElement, IChild<IRenderElementParent, IRenderElementChild>
    {
    }
}
