using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move_scene : MonoBehaviour
{
    public string namaScene;
    public void MoveScene()
    {
        Scene sceneIni = SceneManager.GetActiveScene ();

        if(sceneIni.name != namaScene)
        {
            SceneManager.LoadScene(namaScene);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
