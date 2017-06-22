using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UltimaHex
{
    public static class HexExtensions
    {
        public const float sqrt_3 = 1.73205080757f;

        public static Vector3 ToWorldSpace(this CubeCoord cubeCoord)
        {
            return new Vector3(sqrt_3 * (cubeCoord.Q + cubeCoord.R / 2), 0, 1.5f * cubeCoord.R);
        }

        public static CubeCoord ToCubeCoord(this Vector3 position)
        {
            return new CubeCoord(((position.x * sqrt_3 / 3) - (position.z / 3)), (position.z * (2 / 3)));
        }
    }
}