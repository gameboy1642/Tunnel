using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chapter2HitSceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SceneChange", 0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SceneChange()
    {
        SceneManager.LoadScene("Title");
    }
}
