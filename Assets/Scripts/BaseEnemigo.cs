using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemigo : MonoBehaviour
{

    public ConstructorEnemy[] nuevoEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        nuevoEnemigo= new ConstructorEnemy[7];

        nuevoEnemigo[0]= new ConstructorEnemy(1, "Demon1", 10, 5);
        nuevoEnemigo[1]= new ConstructorEnemy(2, "Demon2", 15, 5);
        nuevoEnemigo[2]= new ConstructorEnemy(3, "Demon3", 8, 5);
        nuevoEnemigo[3]= new ConstructorEnemy(4, "Demon4", 5, 5);
        nuevoEnemigo[4]= new ConstructorEnemy(5, "Demon5", 17, 5);
        nuevoEnemigo[5]= new ConstructorEnemy(6, "Demon6", 9, 5);
        nuevoEnemigo[6]= new ConstructorEnemy(7, "Demon7", 11, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
