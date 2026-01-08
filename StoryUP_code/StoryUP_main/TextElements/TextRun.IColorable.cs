using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoryUP_main.Interfaces;

namespace StoryUP_main.TextElements
{
    public partial class TextRun : IColorable
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
                return _colorStyle.ForegroundColor ?? _parent?.ForegroundColor;
            }
        }

        public Color? BackgroundColor
        {
            get
            {
                return _colorStyle.BackgroundColor ?? _parent?.BackgroundColor;
            }
        }
    }
}
