using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 650;
    public bool isJumping;
    public float jumpHeight;
    public Colliders col;
    private Rigidbody2D a;
    private Vector2 smooth;
   
    void Start()
    {
         a = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Hortizontal = Input.GetAxis("Horizontal"); //*  Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") ; //* Time.deltaTime;
        Vector2 movement = new Vector2(Hortizontal,Vertical);
        smooth = new Vector2(Hortizontal * Time.deltaTime * speed,movement.y);
        
        a.AddForce(smooth);

       

     
}
void Update(){
     if(Input.GetAxis("Jump") > 0 && !isJumping){
            a.AddForce(new Vector2(0,jumpHeight),ForceMode2D.Impulse);
            isJumping = true;

        }
}

  

}
