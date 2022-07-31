using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapGenerator : MonoBehaviour
{
    public int mapLength;
    public int mapWidth;
    public float noiseScale;
    public bool autoUpdate;
    public void GenerateMap()
    {
        float[,] noiseMap = noiseAPI.PerlinNoiseGenerateMap(mapLength, mapWidth, noiseScale);

        mapDisplay display = FindObjectOfType<mapDisplay>();
        display.DrawNoiseMap(noiseMap);
    }
}
