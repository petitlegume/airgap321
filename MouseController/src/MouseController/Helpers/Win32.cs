using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MouseController.Helpers
{
    public class Win32
    {
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);
    }
}
