using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed = 1.0f;
    public float RotationSpeed = 1.0f;
    public float JumpForce = 100.0f;

    private Rigidbody Physics;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento Jugador
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(Horizontal, 0.0f, Vertical) * Time.deltaTime * Speed);

        //Rotación Jugador Horizontal
        float rotationY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * RotationSpeed, 0));

        //Rotación Jugador Vertical
        //float rotationX = Input.GetAxis("Mouse Y");

        //transform.Rotate(new Vector3(-rotationX * Time.deltaTime * RotationSpeed, 0, 0));


        //Salto Jugador
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
        }
    }
}
