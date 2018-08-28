using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {

    public float Speed;
    private Vector2 MoveVelocity;

    // Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MoveVelocity = moveInput.normalized * Speed;
        //Accesses Rigidbody2D
        Rigidbody2D rb2D = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        //Applies the movement to the player
        rb2D.velocity = (MoveVelocity * Time.deltaTime);
    }

}
