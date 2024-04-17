using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    float moveSpeed, LR, UD, rSpeed;

    void Update()
    {
        walkAnim();
        playerMovement();
    }

    #region movementStuff
    void walkAnim()
    {
        Animator anim = GetComponent<Animator>();
        anim.SetFloat("animMultiplier", UD);
    }

    void playerMovement()
    {
        LR = Input.GetAxis("Horizontal");
        UD = Input.GetAxis("Vertical");

        float mSpeed = moveSpeed * UD; 

        print(LR);
        print(UD);

        transform.position += transform.forward * Time.deltaTime * mSpeed;
        transform.Rotate(new Vector3(0, LR *rSpeed, 0) * Time.deltaTime);
    }
    #endregion




}
