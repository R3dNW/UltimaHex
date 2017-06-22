using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UltimaHex
{
    public class HexMap : MonoBehaviour
    {
        public GameObject HexVisualsPrefab;

        int width = 40;
        int height = 20;

        public Hex[,] hexes;
        public GameObject[,] hexVisuals;

        public void Start()
        {
            hexes = new Hex[width, height];
            hexVisuals = new GameObject[width, height];

            for (int q = 0; q < width; q++)
            {
                for (int r = 0; r < height; r++)
                {
                    hexes[q, r] = new Hex(q, r);
                    hexVisuals[q, r] = GameObject.Instantiate(HexVisualsPrefab, hexes[q, r].position.ToWorldSpace(), Quaternion.identity, this.transform);
                }
            }
        }
    }
}
