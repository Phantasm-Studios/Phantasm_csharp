using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace Lumix
{ 
    public struct Quat
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public static readonly Quat Identity = new Quat(1, 0, 0, 0);
        public Quat(float _x, float _y, float _z, float _w)
        {
            x = _x;
            y = _y;
            z = _z;
            w = _w;
        }
    }
}
