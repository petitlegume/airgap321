using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MouseController.Helpers
{
    public class KeyboardControls
    {
        public void press(String key) {
            Win32.SendKey(key);
        }
    }
}
