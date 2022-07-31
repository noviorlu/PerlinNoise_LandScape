using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapDisplay : MonoBehaviour
{
    /* 
     * drag Terrain Mesh Renderer here
     */
    public Renderer textureRender;

    /*
     * Draw the perlinNoise Generated texture onto the Terrain Mesh Renderer
     */
    public void DrawNoiseMap(float[,] noiseMap)
    {
        int width = noiseMap.GetLength(0);
        int height = noiseMap.GetLength(1);

        Texture2D noiseTexture = new Texture2D(width, height);

        Color[] colorMap = new Color[width*height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                // Visualize perlin noise in black/white
                colorMap[y* width + x] = Color.Lerp(Color.black, Color.white, noiseMap[x, y]);
            }
        }
        
        // color vect => texture
        noiseTexture.SetPixels(colorMap);
        noiseTexture.Apply();

        // texture => Renderer
        textureRender.sharedMaterial.mainTexture = noiseTexture;
        textureRender.transform.localScale = new Vector3(width, 1, height);
    } 
}
