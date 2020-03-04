using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TableScript : MonoBehaviour
{
    private GameObject table = null;
    private GameObject anchor1 = null;
    private GameObject anchor2 = null;

    private Vector3 possition1 = new Vector3();
    private Vector3 possition2 = new Vector3();

    private ReactiveProperty<bool> _state = new ReactiveProperty<bool>();
    // Start is called before the first frame update
    void Start()
    {
        Observable.WhenAll(
            Observable.FromCoroutine(DetectionAnchor1),
            Observable.FromCoroutine(DetectionAnchor2))
            .Subscribe(_ => {
                Debug.Log("Success");
                table.transform.parent = GameObject.Find("Axes").transform;
                table.transform.localScale = new Vector3(2f, 2f, 2f);
                Debug.Log(GameObject.Find("Anchor1").transform);
            }).AddTo(this);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(possition1);
    }

    private IEnumerator DetectionAnchor1()
    {
        Debug.Log("Start Detection Anchor 1");
        if(GameObject.Find("Anchor1").transform.localScale.x > 0)
        {
            Debug.Log("This is the Anchor 1");
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("End Detection Anchor 1");
    }

    private IEnumerator DetectionAnchor2()
    {
        Debug.Log("Start Detection Anchor 2");
        if(!GameObject.Find("Anchor2"))
        {
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("End Detection Anchor 2");
    }

    void CreateTable()
    {
        
    }
}
