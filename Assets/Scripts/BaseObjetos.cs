using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObjetos : MonoBehaviour
{
  
     public ConstructorObject[] nuevoObjeto;



    // Start is called before the first frame update
    void Start()
    {
        nuevoObjeto= new ConstructorObject[4];

        nuevoObjeto[0]= new ConstructorObject(1,1);
        nuevoObjeto[1]= new ConstructorObject(2,1);
        nuevoObjeto[2]= new ConstructorObject(3,1);
        nuevoObjeto[3]= new ConstructorObject(4,1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
