using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; 
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public GameObject collectible;
    public Text countText;
    public Text WinText;
    public GameObject ball; 
    

    private int count; //score

    //The Start method runs before frames load
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0; 
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //input from horizontal axis from keyboard
        float moveVertical = Input.GetAxis("Vertical");  //input from vertical axis from keyboard

        //these will add forces to the rigidbody. 

        Vector3 userMovement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(userMovement * speed);

        countText.text = "Score: " + count;

        
        if(count >= 12) //hardcoded. 
        {
            WinText.text = "YOU WIN!";  
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up") == true){
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            count++; //score goes up
        }

        else if (other.gameObject.CompareTag("ricochet")== true)
        {
            Vector3 collisionpos = other.gameObject.transform.position;
            other.gameObject.SetActive(false); 
            Vector3 ricochetvec = new Vector3((transform.position.x - collisionpos.x)*8, 0.0f,
                (transform.position.z - collisionpos.z)*9); //calculates a rebound velocity

            //TODO: better way to calculate force factor. 

            
            rb.velocity = ricochetvec; //rigid body velocity is now this velocity
        }
    }
    


}
