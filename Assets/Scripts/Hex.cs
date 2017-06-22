using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimaHex
{
    public class Hex
    {
        public CubeCoord position { get; protected set; }

        public float height = 0;
        public float humidity = 0;
        public float temperature = 0;
        
        public Hex()
        {
            this.position = new CubeCoord(0, 0);
        }

        public Hex(int q, int r)
        {
            this.position = new CubeCoord(q, r);
        }
    }
}
