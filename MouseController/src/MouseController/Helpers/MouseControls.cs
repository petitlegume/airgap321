using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static MouseController.Helpers.Win32;

namespace MouseController.Helpers
{
    public class MouseControls
    {
        public void MoveCursorTo(int x, int y)
        {
            Win32.SetCursorPos(x, y);
        }

        public void MoveCursorFrom(int deltaX, int deltaY)
        {
            POINT p = Win32.GetCursorPosition();
            Win32.SetCursorPos(p.X + deltaX, p.Y + deltaY);
        }
    }
}
