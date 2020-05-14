using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   public float speed = 1;
    public float maxDist = 2.68f;
    public float minDist = -4.25f;
    bool moving = true;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= maxDist){
            moving = false;
        }
        if(transform.position.x <= minDist){
            moving = true;
        }
        if(moving){
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y,-10f);
            }
        else{
            transform.position = new Vector3(transform.position.x , transform.position.y,-10f);
        }
        
    }
}
