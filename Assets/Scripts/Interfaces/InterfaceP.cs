using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InterfaceP : MonoBehaviour
{

    public Text vidaTXT;
    public Text puntuacionTXT;
    Player playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData=GetComponentInParent<Player>();
        
        StartCoroutine(AsignarDatos(0.35f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator AsignarDatos(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
        vidaTXT.text=playerData.vida.ToString();
        puntuacionTXT.text=playerData.puntuacion.ToString();
        
    }
}
