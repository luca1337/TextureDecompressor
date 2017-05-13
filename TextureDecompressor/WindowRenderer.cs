using Aiv.Fast2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextureDecompressor
{
    public static class WindowRenderer
    {
        private static Window window;

        public static void Init()
        {
            window = new Window(1024, 300, "Decompressor");
        }

        public static void Update()
        {
            while(window.opened)
            {
                window.Update();
            }
        }
    }
}
