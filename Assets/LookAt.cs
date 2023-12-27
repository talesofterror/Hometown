using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LookAt : MonoBehaviour
{
  public GameObject target;

    void Update()
    {
        transform.LookAt(target.transform.position);
    }
}
