using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UltimaHex
{
    public struct CubeCoord
    {
        private float _q;
        private float _r;
        public float _s;

        public CubeCoord(float q, float r)
        {
            this._q = 0;
            this._r = 0;
            this._s = 0;

            this.Q = q;
            this.R = r;
        }

        // Column
        public float Q
        {
            get
            {
                return this._q;
            }

            set
            {
                this._q = value;
                this._s = -this.Q - this.R;
            }
        }

        // Row
        public float R
        {
            get
            {
                return this._r;
            }

            set
            {
                this._r = value;
                this._s = -this.Q - this.R;
            }
        }

        // S = -Q - R
        public float S
        {
            get
            {
                return this._s;
            }
        }
    }
}