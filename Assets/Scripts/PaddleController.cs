using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //private Vector2 speed;
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {

        if (Input.GetKey(upKey))
        {
            // Gerakkan ke atas
            //  speed = new Vector2(0, 1, 0);
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            // Gerakkan ke bawah
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        //Gerakkan object pake input
        // transform.Translate(movement * Time.deltaTime);
       // Debug.Log("Kecepatan: " + speed);
        rig.velocity = movement;


    }
}

