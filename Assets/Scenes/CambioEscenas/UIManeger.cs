using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManeger : MonoBehaviour
{
    public void changeScene(int indexnewScene)
    {
        SceneManager.LoadScene(indexnewScene); 
    }

    public void Update()
    {
        int temp = SceneManager.GetActiveScene().buildIndex;
        if ( temp == 1) //Escena del juego
         {
            if (Input.GetKeyDown(KeyCode.P))
            {
                changeScene(2); //Escena Final
            }
         }
    }
}
