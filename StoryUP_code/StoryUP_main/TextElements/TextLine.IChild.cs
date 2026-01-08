using StoryUP_main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.TextElements
{
    public partial class TextLine : IChild<TextBlock, TextLine>
    {
        private TextBlock? _parent;

        public bool HasParent
        {
            get { return _parent is not null; }
        }

        public bool AddParent(TextBlock newParent)
        {
            if (HasParent) return false;
            _parent = newParent;
            return true;
        }

        public bool RemoveParent(TextBlock oldParent)
        {
            if (HasParent && _parent == oldParent)
            {
                _parent = null;
                return true;
            }
            return false;
        }
    }
}
