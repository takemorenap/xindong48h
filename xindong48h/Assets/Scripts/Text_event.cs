using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_event : MonoBehaviour
{
    public GameObject textleft;
    public GameObject textright;
    Transform left, right;
    GameObject new_left, new_right;
    // Update is called once per frame
    private void Start()
    {
        left = GameObject.FindWithTag("textl").transform;
        right = GameObject.FindWithTag("txtr").transform;
    }
    void Update()
    {
        textleft.GetComponentInChildren<Text>().text = "asdasd";
    }
    
}
