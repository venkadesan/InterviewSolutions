using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewSolutions.DP.Problems
{
    public class StackofBoxes
    {
        public decimal maxHeight(List<Box> boxes)
        {
            boxes.Sort();
            decimal[] stackMap = new decimal[boxes.Count];
            return maxHeight(boxes, null, 0, stackMap);
        }

        private decimal maxHeight(List<Box> boxes, Box bottom, int offSet, decimal[] stackMap)
        {
            if (offSet >= boxes.Count) return 0;
            Box newBottom = boxes[offSet];
            decimal heightWithBottom = 0;
            if (bottom == null || newBottom.canBeAbove(bottom))
            {
                if (stackMap[offSet] == 0)
                {
                    stackMap[offSet] = maxHeight(boxes, newBottom, offSet + 1, stackMap);
                    stackMap[offSet] += newBottom.height;
                }
                heightWithBottom = stackMap[offSet];
            }
            decimal heightWithoutBottom = maxHeight(boxes, bottom, offSet + 1, stackMap);
            return Math.Max(heightWithBottom, heightWithoutBottom);
        }
    }

    public class Box : IComparable
    {

        public Box(decimal _height, decimal _width, decimal _length)
        {
            height = _height;
            width = _width;
            length = _length;
        }
        public decimal height { get; set; }
        public decimal width { get; set; }
        public decimal length { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) { return 1; }
            var b = obj as Box;
            if (b != null)
            {
                int compareResult = this.width.CompareTo(b.width);
                compareResult = compareResult * -1;
                return compareResult;
            }
            else { throw new ArgumentException("object is not valid Box type"); }

        }

        public bool canBeAbove(Box box)
        {
            if (box.width > width && box.height > height)
            {
                return true;
            }
            return false;
        }
    }
}
