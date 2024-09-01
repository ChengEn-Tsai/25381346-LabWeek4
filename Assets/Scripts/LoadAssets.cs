using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
    // Start is called before the first frame update 
    void Start()
    {
        Vector3 redPosition = new Vector3(2,0,0);
        Quaternion redRotation = Quaternion.identity;
        Vector3 bluePosition = new Vector3(-2, 0, 0);
        Quaternion blueRotation = Quaternion.identity;
        Instantiate(redObj, redPosition, redRotation);
        Instantiate(blueObj, bluePosition, blueRotation);

        Application.targetFrameRate = 60;

        //redObj.transform.position = new Vector3(2, 0, 0);
        //redObj.transform.rotation = Quaternion.identity;
        //blueObj.transform.position = new Vector3(-2, 0, 0);
        //blueObj.transform.rotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
