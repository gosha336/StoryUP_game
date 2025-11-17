using StoryUP_main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.TextElements
{
    internal partial class TextLine : IParent<TextLine, TextRun>
    {
        private List<TextRun> _children;

        public bool AddChild(TextRun newChild)
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

        private void AddChildren(IReadOnlyList<TextRun> newChildren)
        {
            foreach (var child in newChildren)
            {
                if (!AddChild(child))
                {
                    throw new InvalidOperationException(); // TextRun уже имеет родителя
                }
            }
        }

        public bool RemoveChild(TextRun oldChild)
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

        private void RemoveChildren(IReadOnlyList<TextRun> oldChildren)
        {
            foreach (var child in _children)
            {
                RemoveChild(child);
            }
        }
    }
}
