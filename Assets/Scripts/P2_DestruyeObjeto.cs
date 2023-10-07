using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_DestruyeObjeto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject g = collision.gameObject;

        if (g.CompareTag("Enemigo"))
        {

            //Destroy(g, 3f); //Destruye el objeto 3 segundos despues de tocarlo
            Destroy(g);
        }
    }
}
