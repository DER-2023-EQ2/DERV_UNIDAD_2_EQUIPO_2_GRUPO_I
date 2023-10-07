using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUsuarioName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string usu = PlayerPrefs.GetString("usuario");
        Debug.Log("nombre del usuario que jugó: " + usu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
