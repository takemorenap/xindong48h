using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_move : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * Global_vars.add_force_);
    }
    void Update()
    {

    }
}
