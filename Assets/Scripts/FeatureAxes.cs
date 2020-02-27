using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatureAxes : MonoBehaviour
{
    [Tooltip("Color for axes")]
    [SerializeField]
    private Color colorAxes = Color.black;

    [Tooltip("Number of elements on real object")]
    [SerializeField]
    private int elements = 0;
        
    [Tooltip("Object 3D with the user interactive with it")]
    [SerializeField]
    private GameObject element = null;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = colorAxes;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateElements()
    {
        for (int i = 0; i < elements; i++ )
        {
            Instantiate(element);
        }
    }
}
