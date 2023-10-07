using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorV3: MonoBehaviour
{
    [SerializeField]TextMeshProUGUI txt_contador;
    [SerializeField] int contador = 0;

    [SerializeField] float tiempoTranscurrido;
    // Start is called before the first frame update
    void Start()
    {
        contador = 10;

        StopAllCoroutines();
        StartCoroutine("Contador");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Contador()
    {
        while (contador>=0)
        {
            txt_contador.text = contador.ToString();
            contador--;
            yield return new WaitForSeconds(1);
        }
    }
} 
