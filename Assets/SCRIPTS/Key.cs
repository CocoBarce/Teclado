using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
   void OnMouseDown(){
    Debug.Log("hola");
    transform.Translate(0,0.5f,0);
   }
   void OnMouseUp(){
      transform.Translate(0,-0.5f,0);
   }
}
