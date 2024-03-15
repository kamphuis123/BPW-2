using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float LR;
    public float UD;
    public float mSpeed;
    public float rSpeed; 


    // Update is called once per frame
    void Update()
    {
        walkAnim();
        playerMovement();



    }


    void walkAnim()
    {
        Animator anim = GetComponent<Animator>();
        anim.SetFloat("animMultiplier", UD);
    }

    void playerMovement()
    {

        LR = Input.GetAxis("Horizontal");
        UD = Input.GetAxis("Vertical");

        mSpeed = moveSpeed * UD; 

        print(LR);
        print(UD);

        transform.position += transform.forward * Time.deltaTime * mSpeed;
        transform.Rotate(new Vector3(0, LR *rSpeed, 0) * Time.deltaTime);




    }

    
        
    
}
