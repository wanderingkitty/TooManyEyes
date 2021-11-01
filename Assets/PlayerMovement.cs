using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer spriteRend;
    public float speed = 15;
    public bool grounded;
    public bool crouch;
    Rigidbody rbPlayer;
    Vector3 movement = new Vector3();


    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.Translate(direction.normalized * Time.deltaTime * speed);

        //float x = Input.GetAxisRaw("Horizontal");
        //float z = Input.GetAxisRaw("Vertical");

        //movement.x = x * speed;
        //movement.z = z * speed;
        
        //movement = rbPlayer.velocity;
        //rbPlayer.velocity = movement;

    }



    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        grounded = true;
    }

    private void OnTriggerExit(Collider other)
    {
        grounded = false;
    }
}