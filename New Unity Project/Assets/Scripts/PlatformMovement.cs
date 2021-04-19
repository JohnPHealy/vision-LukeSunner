using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlatformMovement : MonoBehaviour
{
   private float MoveSpeed = 2f;
   [SerializeField]private bool MoveUp = true;

 
   
   private void FixedUpdate()
   {
      if (transform.position.y > 4f)
      {
         MoveUp = false;
      }
      if (transform.position.y < -8f)
      {
         MoveUp = true;
      }
      
      if (MoveUp)
      {
         transform.position = new Vector2(transform.position.x, transform.position.y + MoveSpeed * Time.deltaTime);
      }
      else
      {
         transform.position = new Vector2(transform.position.x, transform.position.y - MoveSpeed * Time.deltaTime);
      }
      
   }
}
   