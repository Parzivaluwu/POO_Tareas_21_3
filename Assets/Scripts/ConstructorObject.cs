using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorObject 
{
    public int objectId;
    private Transform posicion;
    public int Puntos;
    private float velocidad;
    private bool visibilidad;


//Metodo Constructor
public ConstructorObject(int id, int puntos){
    this.objectId=id;
    this.Puntos=puntos;
}
}