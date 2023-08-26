using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OP_Net6._0
{
    public class ScreenWatcher
    {
        public int r;
        public int g;
        public int b;
        public void Watch()
        {
            [DllImport("user32.dll")]
            static extern IntPtr GetDC(IntPtr hWnd);

            [DllImport("gdi32.dll")]
            static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

            [DllImport("user32.dll")]
            static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);


            int left = 0, top = 0, right = 0, bottom = 0;
            IntPtr hdc = GetDC(IntPtr.Zero);
            for (int x = left; x <= right; x++)
            {
                for (int y = top; y <= bottom; y++)
                {

                    uint pixel = GetPixel(hdc, x, y);
                    Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                                                         (int)(pixel & 0x0000FF00) >> 8,
                                                         (int)(pixel & 0x00FF0000) >> 16);
                    Console.WriteLine($"The color at ({x}, {y}) is {color}");
                    r = color.R; g = color.G; b = color.B;
                }
            }
        }
        public bool IsWhite()
        {
            return (r == 255 && g == 255 && b == 255) ? true : false;
        }
    }
}
