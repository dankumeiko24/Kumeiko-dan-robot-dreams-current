using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
   [SerializeField] private Transform _first;
   [SerializeField] private Transform _second;
   [SerializeField] private float _range;

   [ContextMenu("Is in range")]
   private void InRange()
   {
      Vector3 difference = _first.position - _second.position;
      float distance = difference.magnitude;
      /*  Debug.Log(distance <= _range ? "is in range!" : "is out of range!");*/
      
         if (distance <= _range) 
         {
            Debug.Log("Is in range");

         }
         else 
         {Debug.Log("Is not in range");}

      }
   }


