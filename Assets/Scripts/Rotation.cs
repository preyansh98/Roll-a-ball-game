using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        /*
         * Since the objects are a prefab and all run the same code, 
         * we need a way to differentiate specific objects. 
         * All have different position: i.e. based on position they are different objects. 
         * */
        
        Vector3 rotationcords = new Vector3(15*transform.position.x,30*transform.position.y,45*transform.position.y);

        transform.Rotate(rotationcords * Time.deltaTime);
    }
}
