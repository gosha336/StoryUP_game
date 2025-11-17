using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryUP_main.Interfaces;

namespace StoryUP_main.TextElements
{
    internal partial class TextRun : IChild<TextLine, TextRun>
    {
        private TextLine? _parent;

        public bool HasParent
        {
            get { return _parent is not null; }
        }

        public bool AddParent(TextLine newParent)
        {
            if (HasParent) return false;
            _parent = newParent;
            return true;
        }

        public bool RemoveParent(TextLine oldParent)
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
