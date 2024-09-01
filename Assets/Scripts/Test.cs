using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test???"+gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(n);
        n++;
    }
}
