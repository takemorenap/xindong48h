using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_move : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject up, down, left, right;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            gameObject.GetComponent<Animator>().enabled = false;
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = up.GetComponent<SpriteRenderer>().sprite;
            transform.localScale = up.transform.localScale;
            gameObject.GetComponent<Animator>().runtimeAnimatorController= up.GetComponent<Animator>().runtimeAnimatorController;
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = right.GetComponent<SpriteRenderer>().sprite;
            transform.localScale = right.transform.localScale;
            gameObject.GetComponent<Animator>().runtimeAnimatorController = right.GetComponent<Animator>().runtimeAnimatorController;
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = down.GetComponent<SpriteRenderer>().sprite;
            transform.localScale = down.transform.localScale;
            gameObject.GetComponent<Animator>().runtimeAnimatorController = down.GetComponent<Animator>().runtimeAnimatorController;
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().sprite = left.GetComponent<SpriteRenderer>().sprite;
            transform.localScale = left.transform.localScale;
            gameObject.GetComponent<Animator>().runtimeAnimatorController = left.GetComponent<Animator>().runtimeAnimatorController;
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }
    }
}
