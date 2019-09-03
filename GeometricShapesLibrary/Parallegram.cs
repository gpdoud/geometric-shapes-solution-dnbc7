using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapesLibrary {

    public class Parallegram : Quadrilateral {

        public int Area() {
            return Side1 * Side2;
        }

        public Parallegram(int side1, int side2) : base(side1, side2, side1, side2) {

        }
    }
}
