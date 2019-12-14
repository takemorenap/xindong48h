using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall_ : MonoBehaviour
{
    private Vector2[] direction = new Vector2[4];
    public GameObject target;
    private GameObject txt;
    void Start()
    {
        direction[0] = Vector2.up;
        direction[1] = Vector2.left;
        direction[2] = Vector2.down;
        direction[3] = Vector2.right;
        txt = GameObject.FindWithTag("text");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Global_vars.can_move && collision.tag == "player")
        {
            Global_vars.can_move = false;
            Global_vars.ok = 0;
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            collision.transform.position = transform.position;
            if (target != null)
                collision.GetComponent<Rigidbody2D>().AddForce((target.transform.position - transform.position) / Vector2.Distance(target.transform.position, transform.position) * Global_vars.add_force_);
            else
            {
                //call text event;
              //  while (Global_vars.ok == 0) ;
                collision.GetComponent<Rigidbody2D>().AddForce(direction[Global_vars.direction] * Global_vars.add_force_);
            }
        }
    }
    
}
