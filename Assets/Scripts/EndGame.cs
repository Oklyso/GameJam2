using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    public GameObject win;
    // Start is called before the first frame update

    void Start(){
        win.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D col){
    if (col.gameObject.tag == "gameFinish"){
        win.SetActive(true);

     }
 }

}
