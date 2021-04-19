using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlatformHor3 : MonoBehaviour
{
    private float MoveSpeed = 2f;
    [SerializeField]private bool MoveUp = true;

 
   
    private void FixedUpdate()
    {
        if (transform.position.x > 70f)
        {
            MoveUp = false;
        }
        if (transform.position.x < 55f)
        {
            MoveUp = true;
        }
      
        if (MoveUp)
        {
            transform.position = new Vector2(transform.position.x + MoveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - MoveSpeed * Time.deltaTime, transform.position.y);
        }
      
    }
}
