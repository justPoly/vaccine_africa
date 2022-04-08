using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAfterTime : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 5f;
   
    
    private float timeElapsed;
    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}