using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///the simple application of perlin noise
///based on the original point to generate the terrain
public class TerrianCreator : MonoBehaviour
{
    /// <summary>
    /// the max value of the x-axis 
    /// </summary>
    public float maxX = 100;

    /// <summary>
    /// the max value of the z-axis 
    /// </summary>
    public float maxZ = 100;

    /// <summary>
    /// the max Height of the terrain
    /// </summary>
    public float maxHeight = 30;

    /// <summary>
    /// the seed of the perlin noise
    /// </summary>
    private float seedX, seedZ;

    /// <summary>
    /// 
    /// </summary>
    public float relief = 16.0f;
    private void Awake()
    {
        seedX = Random.value * 100f;
        seedZ = Random.value * 100f;
        for (int i = 0; i < maxX; i++)
            for (int j = 0; j < maxZ; j++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.GetComponent<Transform>().position = new Vector3(i, 0, j);
                setY(cube);
                setColor(cube);
            }

    }
    private void setY(GameObject obj)
    {
        float x = obj.GetComponent<Transform>().position.x;
        float z = obj.GetComponent<Transform>().position.z;
        float xSample = (x + seedX) / relief;
        float zSample = (z + seedZ) / relief;
        float y = Mathf.Round(Mathf.PerlinNoise(xSample, zSample) * maxHeight);
        obj.transform.position = new Vector3(x, y, z);
    }
    private void setColor(GameObject obj)
    {
        float y = obj.GetComponent<Transform>().position.y;
        if (y >= maxHeight * 0.3)
        {
            obj.GetComponent<MeshRenderer>().material.color = new Color(0, 0.7f, 0);
        }
        else if (y >= maxHeight * 0.2)
        {
            obj.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else
        {
            obj.GetComponent<MeshRenderer>().material.color = Color.gray;
        }

    }
}
