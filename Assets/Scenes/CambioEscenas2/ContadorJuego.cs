using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorJuego: MonoBehaviour
{
    [SerializeField]TextMeshProUGUI txt_contador;
    [SerializeField] int contador = 0;

    UIManegerr2 manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<UIManegerr2>();

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
        manager.changeScene(5); //Fin del Juego
    }
} 
