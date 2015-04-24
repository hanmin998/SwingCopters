using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject player;
	// Use this for initialization
	void Start () {
        
	}

    void OnMouseDown()
    {
        audio.Play();
        Vector3 palyerScreenPosition = Camera.main.WorldToScreenPoint(player.transform.position);
        float dx = Input.mousePosition.x - palyerScreenPosition.x;
        float x = dx > 0 ? 5 : -5;
        player.GetComponent<Rigidbody2D>().AddForce(new Vector2(x, 120));
        if (dx > 0) player.GetComponent<Player>().TurnRight();
        else player.GetComponent<Player>().TurnLeft();
    }
	
	
}
