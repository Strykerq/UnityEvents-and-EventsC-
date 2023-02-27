using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class Event : MonoBehaviour
{
   
   private int clickcount;
   public event EventHandler ClickEvent;

   void Start()
   {
      ClickEvent += Event1;
   }

   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         
         ClickEvent.Invoke(this, EventArgs.Empty);
      }
   }

   private void Event1(object o,EventArgs e)
   {
      clickcount++;
      GetComponent<Text>().text = "Click: " + clickcount;
   }
   
   
}
