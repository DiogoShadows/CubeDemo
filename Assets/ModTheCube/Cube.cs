using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 initialPosition;
    public float xAngle, yAngle, zAngle;
    private float r = 0.5f, g = 1.0f, b = 0.3f, a = 0.4f;
    private bool bIncreasing = false, rIncreasing = false, gIncreasing = false, aIncreasing = false;
    public float scale;

    void Start()
    {
        transform.position = initialPosition;
        transform.localScale = Vector3.one * scale;
        
        Material material = Renderer.material;
        
        material.color = new Color(r, g, b, a);
    }
    
    void Update()
    {
        transform.Rotate(xAngle * Time.deltaTime, yAngle * Time.deltaTime, zAngle * Time.deltaTime);

        if(rIncreasing)
            r += 0.1f * Time.deltaTime;

        else
            r -= 0.1f * Time.deltaTime;

        if(gIncreasing)
            g += 0.1f * Time.deltaTime;

        else
            g -= 0.1f * Time.deltaTime;

        if(bIncreasing)
            b += 0.1f * Time.deltaTime;
        else
            b -= 0.1f * Time.deltaTime;

        if(aIncreasing)
            a += 0.1f * Time.deltaTime;
        else
            a -= 0.1f * Time.deltaTime;

        if (r >= 1 || r <= 0)rIncreasing = !rIncreasing;
        if (g >= 1 || g <= 0)gIncreasing = !gIncreasing;
        if (b >= 1 || b <= 0)bIncreasing = !bIncreasing;
        if (a >= 1 || a <= 0)aIncreasing = !aIncreasing;

        Renderer.material.color = new Color(r, g, b, a);
    }
}
