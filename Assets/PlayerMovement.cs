using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.5f; 
    private Camera cam;
    Vector3 movementVectorX;
    Vector3 movementVectorY;
    Vector3 movementVectorZ;

    void Awake () {
      print(cam);
    }
 
    void Update()
    {
        float speedDelta = speed * Time.deltaTime;

        movementVectorX = new Vector3(speedDelta, 0, 0);
        movementVectorY = new Vector3(0, speedDelta, 0);
        movementVectorZ = new Vector3(0, 0, speedDelta);

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
