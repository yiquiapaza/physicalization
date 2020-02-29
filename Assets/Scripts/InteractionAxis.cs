using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

public class InteractionAxis : MonoBehaviour,
    IMixedRealitySourceStateHandler
{
    GameObject cube;

    public void OnSourceDetected(SourceStateEventData eventData)
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0.5f, 0.5f, 0.5f);
        cube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    public void OnSourceLost(SourceStateEventData eventData)
    {
        //Destroy(cube);
        Debug.Log("dont detect Source");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
