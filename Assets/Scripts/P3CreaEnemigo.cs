using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class P3CreaEnemigo : MonoBehaviour
{

    [SerializeField] GameObject PlantillaEnemigo;

    [SerializeField] List<GameObject> Spawns;

    public  int index_new_enemy; //spawn select to instantiate a new enemy
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            {
            index_new_enemy = Random.Range(0, 5); //[0 - 4]

            GameObject nlocation = Spawns[index_new_enemy];

            GameObject objNuevo = Instantiate(PlantillaEnemigo, 
            nlocation.transform.position,
            nlocation.transform.rotation);
            }
    }
}
