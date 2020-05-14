using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformY : MonoBehaviour
{
    // Start is called before the first frame update
   public float speed = 1;
    public float maxDistY = 2.68f;
    public float minDistY = -4.25f;
    bool moving = true;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.y);
        if(transform.position.y >= maxDistY){
            moving = false;
        }
        if(transform.position.y <= minDistY){
            moving = true;
        }
        if(moving){
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
            }
        else{
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
        
    }

    
}
