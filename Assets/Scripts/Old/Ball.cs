using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  public int amplify = 1000;
  private bool groundHit = false;
  private Vector3 impactValue = Vector3.zero;
  void OnCollisionEnter(Collision collision)
  {
    Debug.Log($"I hit the {collision.collider.name}");
    
  }

  void FixedUpdate()
  {
    //if (groundHit) HitGround();
    //impactValue = GetComponent<Rigidbody>().velocity;
  }


}
