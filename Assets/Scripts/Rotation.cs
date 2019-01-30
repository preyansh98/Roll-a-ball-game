using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //TODO: need to make rotations random. 
        
        /**
         * Get number of active collectible objects first
         * assign each one to a different rotationcord
         **/ 

        
        Vector3 rotationcords = new Vector3(15,30,45);

        transform.Rotate(rotationcords * Time.deltaTime);
    }
}
