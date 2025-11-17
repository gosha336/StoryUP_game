using StoryUP_main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.TextElements
{
    internal partial class TextBlock : IUpdatable
    {
        private bool _updateSuppressed;
        public IReadOnlyList<TextLine> Text
        {
            get
            {
                return _children;
            }
            set
            {
                _updateSuppressed = true;

                RemoveChildren(_children);

                AddChildren(value);

                _updateSuppressed = false;

                OnUpdate();
            }
        }

        public TextBlock(IReadOnlyList<TextLine> text, ColorStyle colorStyle)
        {
            _children = new List<TextLine>();

            _updateSuppressed = true;

            AddChildren(text);

            _updateSuppressed = false;

            _colorStyle = colorStyle;
        }

        private void OnUpdate()
        {
            Updated?.Invoke();
        }

        public event Action? Updated;
    }
}
