using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Transform body;
    public void TurnRight() {
        body.localScale = new Vector3(1, 1, 1);
    }
    public void TurnLeft()
    {
        body.localScale = new Vector3(-1, 1, 1);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Hammer") {
            print("effffffff");
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Hammer")
        {
            audio.Play();
        }
    }


}
