using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  public float lookSpeed;

    void Start()
    {
        
    }

    void Update()
  {
    MouseControl();
  }

  private void MouseControl()
  {
    float MouseX = Input.mousePosition.x / -lookSpeed / 3;
    float MouseY = Input.mousePosition.y / lookSpeed;

    transform.eulerAngles = new Vector3(transform.rotation.y - MouseY, transform.rotation.x + MouseX, transform.rotation.z);

    print("mouse X = " + MouseX);
    print("mouse Y = " + MouseY);
  }
}
