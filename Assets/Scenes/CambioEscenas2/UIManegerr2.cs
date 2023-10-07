using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManegerr2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI usuario;
    public void changeScene(int indexnewScene)
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.buildIndex == 3) //usuario
        {
            string usu = usuario.text;
            PlayerPrefs.SetString("usuario", usu);
        }

        SceneManager.LoadScene(indexnewScene); 
    }

    public void Update()
    {
        
    }
}
