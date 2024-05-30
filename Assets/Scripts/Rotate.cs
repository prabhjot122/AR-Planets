using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject plantobject;
    public Vector3 vectorrotate;


    // Update is called once per frame
    void Update()
    {
        plantobject.transform.Rotate(vectorrotate*Time.deltaTime);
    }
}
