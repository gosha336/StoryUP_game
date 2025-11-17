using StoryUP_main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.TextElements
{
    internal partial class TextBlock : IColorable
    {
        private ColorStyle _colorStyle;
        public ColorStyle ColorStyle
        {
            get { return _colorStyle; }
            set
            {
                if (_colorStyle == value) return;
                _colorStyle = value;
                OnUpdate();
            }
        }

        public Color? ForegroundColor
        {
            get
            {
                return _colorStyle.ForegroundColor;
            }
        }

        public Color? BackgroundColor
        {
            get
            {
                return _colorStyle?.BackgroundColor;
            }
        }
    }
}
