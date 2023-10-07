using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorV2: MonoBehaviour
{
    [SerializeField]TextMeshProUGUI txt_contador;
    [SerializeField] int contador = 0;

    [SerializeField] float tiempoTranscurrido;
    // Start is called before the first frame update
    void Start()
    {
        contador = 10;
        tiempoTranscurrido = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;
        Debug.Log("Tiempo transcurrido: " + tiempoTranscurrido.ToString());
        if (tiempoTranscurrido > 1f)
        {
            txt_contador.text = contador.ToString();
            if (contador > 0)
            {
                contador--;
            }
            tiempoTranscurrido = 0;
        }
    }
}
