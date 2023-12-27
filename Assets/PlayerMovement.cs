using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.005f;
    Vector3 movementVectorX;
    Vector3 movementVectorY;
    Vector3 movementVectorZ;

    void Update()
    {
        movementVectorX = new Vector3(speed, 0, 0);
        movementVectorY = new Vector3(0, speed, 0);
        movementVectorZ = new Vector3(0, 0, speed);

        if (Input.GetKey(KeyCode.W)){
          transform.Translate(movementVectorZ);
        }
        if (Input.GetKey(KeyCode.S)){
          transform.Translate(-movementVectorZ);
        }
        if (Input.GetKey(KeyCode.A)){
          transform.Translate(-movementVectorX);
        }
        if (Input.GetKey(KeyCode.D)){
          transform.Translate(movementVectorX);
        }
    }
}
