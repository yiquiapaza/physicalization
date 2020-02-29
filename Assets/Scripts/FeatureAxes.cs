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

    [Tooltip("Parent for elements")]
    [SerializeField]
    private Transform elementsParent = null;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = colorAxes;
        //CreateElements();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateElements()
    {
        float position = 0.2f;
        GameObject temp;
        for (int i = 0; i < elements; i++ )
        {
            temp = Instantiate(element);
            temp.transform.parent = elementsParent;
            temp.transform.localPosition = new Vector3(position, 0.1f, 0);
            position++;
        }
    }
}
