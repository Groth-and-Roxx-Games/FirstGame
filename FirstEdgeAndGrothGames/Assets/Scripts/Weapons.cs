using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{

    //float weaponAttackTime, timeBetweenAttacks;
    Animator swordSwing;
    // Start is called before the first frame update
    void Start()
    {
        swordSwing = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            swordSwing.SetBool("stickSwing",true);

        }
        else
        {
            swordSwing.SetBool("stickSwing",false);
        }
    }
}
