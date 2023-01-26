using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{

    //float weaponAttackTime, timeBetweenAttacks;
    Animator swordSwing;

    [SerializeField]
    public int damage;
    public int speed;
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

         transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if(hit.tag == "Enemy" && swordSwing.GetBool("stickSwing")== true)
        {
            
            hit.GetComponent<Enemy>().TakeDamage(damage);

        }
    }
}
