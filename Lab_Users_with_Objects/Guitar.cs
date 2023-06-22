using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Users_with_Objects
{
    internal class Guitar
    {
        public enum GuitarType { acousticGuitar, electricGuitar }
        GuitarType _guitarType;

        public GuitarType GuitarType1 { get => _guitarType; set => _guitarType = value; }
    }
}
