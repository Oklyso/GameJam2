using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colliders : MonoBehaviour
{
    public Controls controls;
    private AssetBundle assetBundle;
    
    // Start is called before the first frame update
    void Start()
    {
        

        controls = GetComponent<Controls>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void  OnCollisionEnter2D(Collision2D col)
{   Debug.Log("Working");
    if (col.gameObject.tag == "ground") 
    {
        controls.isJumping = false;
    }
}


private void OnTriggerEnter2D(Collider2D col){
    if (col.gameObject.tag == "victory"){
        SceneManager.LoadScene(1);

    }
    if (col.gameObject.tag == "loss"){
        SceneManager.LoadScene(0);

    }

}
}
