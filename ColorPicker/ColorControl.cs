using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPicker
{
    class ColorControl
    {
        public Color color { get; set; }

        public struct CMYK
        {
            public double C;
            public double M;
            public double Y;
            public double K;
        };

        public struct HSI
        {
            public double Hue;
            public double Saturation;
            public double Intensity;
        }

        public Color[] history = new Color[5] { Color.White , Color.White , Color.White , Color.White , Color.White };

        public string ToHex()
        {
            return ColorTranslator.ToHtml(color);
        }
  

        public CMYK ToCMYK()
        {

            CMYK cmyk = new CMYK();

            cmyk.C = (255 - color.R) / 255.0;
            cmyk.M = (0xFF - color.G) / 255.0;
            cmyk.Y = (0xFF - color.B) / 255.0;
            cmyk.K = Math.Min(cmyk.C, Math.Min(cmyk.M, cmyk.Y));

            if (cmyk.K == 1.0)
            {
                cmyk.C = cmyk.M = cmyk.Y = 0;
            }
            else
            {
                cmyk.C = (cmyk.C - cmyk.K) / (1 - cmyk.K);
                cmyk.M = (cmyk.M - cmyk.K) / (1 - cmyk.K);
                cmyk.Y = (cmyk.Y - cmyk.K) / (1 - cmyk.K);
            }

            return cmyk;
        }

        public HSI ToHSI()
        {
            HSI hsi = new HSI();

            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            double theta = Math.Acos(0.5 * ((r - g) + (r - b)) / Math.Sqrt((r - g) * (r - g) + (r - b) * (g - b))) / (2 * Math.PI);

            hsi.Hue = (b <= g) ? theta : (1 - theta);
            hsi.Saturation = 1 - 3 * Math.Min(Math.Min(r, g), b) / (r + g + b);
            hsi.Intensity = (r + g + b) / 3;

            return hsi;
        }

        public void SaveHistory()
        {
            for (int i=4; i>0; i--)
            {
                history[i] = history[i - 1];
            }

            history[0] = this.color;
        }
    }
}
