using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
   public void onClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
