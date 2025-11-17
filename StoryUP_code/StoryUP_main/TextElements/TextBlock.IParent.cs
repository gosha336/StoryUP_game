using StoryUP_main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.TextElements
{
    internal partial class TextBlock : IParent<TextBlock, TextLine>
    {
        private List<TextLine> _children;

        public bool AddChild(TextLine newChild)
        {
            if (newChild.AddParent(this))
            {
                newChild.Updated += OnUpdate;
                _children.Add(newChild);
                OnUpdate();
                return true;
            }
            return false;
        }

        private void AddChildren(IReadOnlyList<TextLine> newChildren)
        {
            foreach (var child in newChildren)
            {
                if (!AddChild(child))
                {
                    throw new InvalidOperationException(); // TextRun уже имеет родителя
                }
            }
        }

        public bool RemoveChild(TextLine oldChild)
        {
            if (oldChild.RemoveParent(this))
            {
                oldChild.Updated -= OnUpdate;
                _children.Remove(oldChild);
                OnUpdate();
                return true;
            }
            return false;
        }

        private void RemoveChildren(IReadOnlyList<TextLine> oldChildren)
        {
            foreach (var child in _children)
            {
                RemoveChild(child);
            }
        }
    }
}
