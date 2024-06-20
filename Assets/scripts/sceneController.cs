using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void SwitchScenes(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }    
}
