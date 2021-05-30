using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float randomSpeed;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one * 1f;
        
        Material material = Renderer.material;
        
        material.color = new Color(255.0f, 255.0f, 0.0f, 0.0f);

        randomSpeed = Random.Range(1.0f, 100.0f);
    }
    
    void Update()
    {
        
        transform.position = new Vector3(Random.Range(0.0f, 100.0f), 0, Random.Range(0.0f, 100.0f));

        Debug.Log(randomSpeed);
        transform.Rotate(0.0f, 0.0f, 10.0f * Time.deltaTime * randomSpeed);
    }
}
