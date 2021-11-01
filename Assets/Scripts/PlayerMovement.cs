using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer spriteRend;
    public float speed = 3000;
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
        rbPlayer.AddForce(direction.normalized * Time.deltaTime * speed);


        

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