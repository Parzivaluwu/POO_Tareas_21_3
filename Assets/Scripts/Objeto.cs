using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    public int objectId;
    public int Puntos;
  BaseObjetos bdObjeto;

 private void Start() {

     bdObjeto=GameObject.FindObjectOfType<BaseObjetos>();

   

      
  }
}
