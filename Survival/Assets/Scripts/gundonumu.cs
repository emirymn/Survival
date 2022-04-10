using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gundonumu : MonoBehaviour
{
    public float hiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(250f, 0, 250f), Vector3.right, hiz * Time.deltaTime);
    }
}
