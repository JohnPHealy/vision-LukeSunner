using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GplatMove : MonoBehaviour
{
   public GameObject[] GreenAppear;
   public GameObject[] BlueAppear;
   public GameObject[] PinkAppear;

   public void Start()
   {
      GreenAppear = GameObject.FindGameObjectsWithTag("Gplat");
      BlueAppear = GameObject.FindGameObjectsWithTag("Bplat");
      PinkAppear = GameObject.FindGameObjectsWithTag("Pplat");
   }
}
