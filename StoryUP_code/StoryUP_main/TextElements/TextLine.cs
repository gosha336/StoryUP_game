using StoryUP_main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.TextElements
{
    internal partial class TextLine : IUpdatable
    {
        private bool _updateSuppressed;
        public IReadOnlyList<TextRun> Text
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

        public TextLine(IReadOnlyList<TextRun> text, ColorStyle colorStyle)
        {
            _children = new List<TextRun>();

            _updateSuppressed = true;

            AddChildren(text);

            _updateSuppressed = false;

            _colorStyle = colorStyle;
        }

        private void OnUpdate()
        {
            if (_updateSuppressed) return;
            Updated?.Invoke();
        }

        public event Action? Updated;
    }
}
