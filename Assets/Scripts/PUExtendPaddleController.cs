using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUExtendPaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public int extension;
    public PaddleController leftPaddleScript;
    public PaddleController rightPaddleScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            // Extend paddle
            if (ball.GetComponent<BallController>().LastHitPaddle == 0)
            {
                leftPaddleScript.GetComponent<PaddleController>().ActivatePUExtendPaddle(extension);
                manager.RemovePowerUp(gameObject);
            }

            if (ball.GetComponent<BallController>().LastHitPaddle == 1)
            {
                rightPaddleScript.GetComponent<PaddleController>().ActivatePUExtendPaddle(extension);
                manager.RemovePowerUp(gameObject);
            }
        }
    }
}
