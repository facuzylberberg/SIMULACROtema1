using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valores : MonoBehaviour
{
    public int monto;
    public string moneda;
    
    // Start is called before the first frame update
    void Start()
    {
        int D = monto / 110;
        int E = monto / 120;
        int R = monto / 24;

        if (moneda != "D" & moneda != "E" & moneda != "R")
        {
            Debug.Log("Opcion de moneda extranjera no vàlida");
        }
        else if (monto < 1000)
        {
            Debug.Log("El monto minimo es 1000");
        }
        else if (moneda == "D")
        {
            Debug.Log(monto + " pesos argentinos equivalen a " + D + " dolares");
        }
        else if (moneda == "E")
        {
            Debug.Log(monto + " pesos argentinos equivalen a " + E + " euros");
        }
        else if (moneda == "R")
        {
            Debug.Log(monto + " pesos argentinos equivalen a " + R + " reales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
