using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class noiseAPI
{
    /* 
     * Generate Noise map in Width X Height float matrix
     */
    public static float[,] PerlinNoiseGenerateMap(int mapWidth, int mapHeight, float scale, float persistance, float lacunarity)
    {
        if(scale <= 0) scale = 0.0001f;

        float[,] perlinNoiseMap = new float[mapWidth, mapHeight];
        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapHeight; y++)
            {
                perlinNoiseMap[x, y] = Mathf.PerlinNoise(x/scale, y/scale);
            }
        }
        return perlinNoiseMap;
    }
}
