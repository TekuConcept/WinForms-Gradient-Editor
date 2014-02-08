using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GradientEditor
{
    public class GPanel : Panel
    {
        public GPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
        }
    }
}
