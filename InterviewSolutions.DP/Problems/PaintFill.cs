using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{

    public enum Color
    {
        Black,
        Whilte,
        Red,
        Yellow,
        Green
    };

    public class PaintFill
    {

        #region PaintFill
        /// <summary>
        ///  Can Paint Fill
        /// </summary>
        /// <param name="screen"></param>
        /// <param name="r"></param>
        /// <param name="c"></param>
        /// <param name="nColor"></param>
        /// <returns></returns>
        public bool CanPaintFill(Color[][] screen, int r, int c, Color nColor)
        {
            if (screen[r][c] == nColor) return false;
            return CanPaintFill(screen, r, c, screen[r][c], nColor);
        }
        #endregion


        private bool CanPaintFill(Color[][] screen, int r, int c, Color oColor, Color nColor)
        {
            if (r < 0 || r >= screen.Length || c < 0 || c >= screen[0].Length)
            {
                return false;
            }
            if (screen[r][c] == oColor)
            {
                screen[r][c] = nColor;
                CanPaintFill(screen, r - 1, c, oColor, nColor); // Up 
                CanPaintFill(screen, r + 1, c, oColor, nColor); // Dwn
                CanPaintFill(screen, r, c + 1, oColor, nColor); // right
                CanPaintFill(screen, r, c - 1, oColor, nColor); // left
            }
            return true;
        }
    }
}
