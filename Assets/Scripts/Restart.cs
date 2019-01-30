using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //no code needed for it to run before
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R) == true)
        {
            //User has pressed R

            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Load Scene only works by name
        }
    }
}
