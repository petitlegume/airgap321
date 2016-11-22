using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MouseController.Helpers
{
    public class MouseControls
    {
        public void MoveCursor(int x, int y)
        {
            Win32.SetCursorPos(x, y);
        }
    }
}
