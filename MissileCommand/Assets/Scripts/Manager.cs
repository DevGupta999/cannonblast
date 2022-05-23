using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public static float selector=1;


    

    private void Update()
    {
        if(Time.timeSinceLevelLoad>200)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        Debug.Log(Time.timeSinceLevelLoad);


    }


}
