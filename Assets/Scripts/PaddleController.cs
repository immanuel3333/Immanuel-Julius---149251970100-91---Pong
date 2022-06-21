using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //private Vector2 speed;
    public int speed;
    public int oldSpeed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private Vector3 newSize;
    private Vector3 oldSize;

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

    public void ActivatePUExtendPaddle(int extension)
    {
        newSize = transform.localScale;
        oldSize = newSize;

        newSize.y *= extension;

        transform.localScale = newSize;

        Invoke("ReturnPaddleSize", 5f);
    }

    public void ReturnPaddleSize()
    {
        transform.localScale = oldSize;
    }

    public void ActivatePUAcceleratePaddle(int acceleration)
    {
        oldSpeed = speed;
        speed *= acceleration;

        Invoke("ReturnPaddleSpeed", 5f);
    }

    public void ReturnPaddleSpeed()
    {
        speed = oldSpeed;
    }
}

