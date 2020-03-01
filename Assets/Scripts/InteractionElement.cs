using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.Input;

public class InteractionElement : MonoBehaviour,
    IMixedRealityInputActionHandler
{
    GameObject cubeTest;
    public void OnActionEnded(BaseInputEventData eventData)
    {        
        Debug.Log("Action Ended");
    }

    public void OnActionStarted(BaseInputEventData eventData)
    {
        Debug.Log(eventData);
        cubeTest = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cubeTest.GetComponent<Renderer>().material.color = Color.yellow;
        cubeTest.transform.SetParent( gameObject.transform, true);
        cubeTest.transform.localScale = new Vector3(0.5f, 1f, 1f);
        cubeTest.transform.localPosition = new Vector3(0f, 1f, 0f);
        Debug.Log("This is a GLOBAL Position " + cubeTest.transform.position);
        Debug.Log("This is a LOCAL Position" +cubeTest.transform.localPosition);
        eventData.Use();
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
