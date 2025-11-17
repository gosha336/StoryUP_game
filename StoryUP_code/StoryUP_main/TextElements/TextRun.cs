using StoryUP_main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.TextElements
{
    internal partial class TextRun : IUpdatable
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                if (_text.Equals(value)) return;
                _text = value;
                OnUpdate();
            }
        }

        public TextRun(string text, ColorStyle colorStyle)
        {
            _text = text;
            _colorStyle = colorStyle;
        }

        private void OnUpdate()
        {
            Updated?.Invoke();
        }

        public event Action? Updated;
    }
}
