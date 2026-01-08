using StoryUP_main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main
{
    public class ColorStyle: IUpdatable
    {
        private Color? _foregroundColor;
        public Color? ForegroundColor
        {
            get { return _foregroundColor; }
            set
            {
                if (Nullable.Equals(_foregroundColor, value)) return;
                _foregroundColor = value;
                OnUpdate();
            }
        }

        private Color? _backgroundColor;
        public Color? BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                if (Nullable.Equals(_backgroundColor, value)) return;
                _backgroundColor = value;
                OnUpdate();
            }
        }

        public ColorStyle(Color? foreground, Color? background)
        {
            _foregroundColor = foreground;
            _backgroundColor = background;
        }

        public void SetColorStyle(ColorStyle colorStyle)
        {
            _foregroundColor = colorStyle.ForegroundColor;
            _backgroundColor = colorStyle.BackgroundColor;
            OnUpdate();
        }

        public void SetColorStyle(Color? foregroundColor, Color? backgroundColor)
        {
            _foregroundColor = foregroundColor;
            _backgroundColor = backgroundColor;
            OnUpdate();
        }

        public void OnUpdate()
        {
            Updated?.Invoke();
        }

        public event Action? Updated;
    }
}
