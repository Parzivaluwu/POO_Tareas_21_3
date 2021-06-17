using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int EnemyId;
    public string nombre;
    public int daño;
    public float velocidad;
    BaseEnemigo bdEnemigo;

      private void Start() {
       bdEnemigo=GameObject.FindObjectOfType<BaseEnemigo>();
        
    }

}
