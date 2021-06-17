using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ConstructorEnemy 
{
  public int EnemyId;
  private Transform posicion;
   public float velocidad;
   public int daño;
   public string nombre;

   //Metodo Constructor
   public ConstructorEnemy(int id, string n, float velo, int daño){
       this.EnemyId=id;
       this.nombre=n;
       this.velocidad=velo;
       this.daño=daño;
       

   }
   
}
