using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv/

public class Bounce : MonoBehaviour
{
    [SerializeField] float jumpForce = 1000f;

    void OnTriggerEnter(Collider pannenkoek)
    {

        JumpyJumpy(pannenkoek);
    }

    void JumpyJumpy(Collider collisionObject)
    {
        if (collisionObject.tag == "Player")
        {
            //IF Player collides with pad
            //Player gets lauched

            collisionObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
            Debug.Log("PLayer collides with pad");
        }
        else if (collisionObject.tag == "Enemy")
        {
            Debug.Log("Detected an Enemy");
        }
        else
        {
            Debug.Log("Anything else");
        }
    }
}