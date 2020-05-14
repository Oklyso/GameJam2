using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
     if (col.gameObject.tag == "victory2"){
        SceneManager.LoadScene(2);

    }
    if (col.gameObject.tag == "victory3"){
        SceneManager.LoadScene(3);

    }
    if (col.gameObject.tag == "victory4"){
        SceneManager.LoadScene(4);

    }
    if (col.gameObject.tag == "loss"){
        SceneManager.LoadScene(0);

    }
    if (col.gameObject.tag == "platformTrigger"){
        Destroy(GameObject.Find("destroyblock"));
        Destroy(GameObject.Find("TriggerPlatform"));

    }
    if (col.gameObject.tag == "platformTrigger2"){
        Destroy(GameObject.Find("destreyblock"));
        Destroy(GameObject.Find("TriggerPlatform2"));

    }
     if (col.gameObject.tag == "platformTrigger3"){
        Destroy(GameObject.Find("coobdestroy"));
        Destroy(GameObject.Find("PlatformTrigger"));

    }
    

}
}
