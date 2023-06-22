using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Users_with_Objects
{
    internal class GuitarPick : Guitar
    {
        public enum Material
        {
            celluloid, tortex, ultex, delrin, nylon, stone
        , metal, wood, felt
        }
        Material _material;

        public enum Shape
        {
            standard, sharpTip, pointy, triangle, sharkFin, jazz
        , teardrop
        }
        Shape _shape;

        public Material PickMaterial { get => _material; set => _material = value; }
        public Shape PickShape { get => _shape; set => _shape = value; }
    }
}
