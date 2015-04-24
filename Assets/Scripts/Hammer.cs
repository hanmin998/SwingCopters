using UnityEngine;
using System.Collections;

public class Hammer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        rigidbody2D.AddForce(new Vector2(200, 0));
	}
	
}
