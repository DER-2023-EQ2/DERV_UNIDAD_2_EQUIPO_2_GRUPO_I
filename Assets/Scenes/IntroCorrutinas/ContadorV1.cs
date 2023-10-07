using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorV1 : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI txt_contador;
    [SerializeField] int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        contador = 10;
    }

    // Update is called once per frame
    void Update()
    {
        txt_contador.text = contador.ToString();
        if (contador > 0)
        {
            contador--;
        }
    }
}
