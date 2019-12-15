using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Global_vars.nxt = "我都和你说了走右边";
        Invoke("Right", 3.5f);
        Global_vars.nxt = "近那么多";
        Invoke("Right", 0.5f);
        Global_vars.nxt = "干嘛浪费体力走左边";
        Invoke("Right", 1.5f);
        Global_vars.nxt = "但是我真的好怕";
        Invoke("Left", 1.5f);
        Global_vars.nxt = "你又不在我旁边";
        Invoke("Left", 1.5f);
        Global_vars.nxt = "没事的忍忍就过去了这点小事";
        Invoke("Right", 0.5f);
        Global_vars.nxt = "每次都是这样";
        Invoke("Left", 0.5f);
        Global_vars.nxt = "我遇到什么了什么事";
        Invoke("Left", 0.5f);
        Global_vars.nxt = "每次都告诉我忍忍就过去了";
        Invoke("Left", 0.5f);
        Global_vars.nxt = "你懂不懂怎么陪着我";
        Invoke("Left", 0.5f);
        Global_vars.nxt = "你到底明不明白这些";
        Invoke("Left", 0.5f);
        Global_vars.nxt = "你不陪在我身边";
        Invoke("Left", 0.5f);
        Global_vars.nxt = "又要我一个人强撑";
        Invoke("Left", 0.5f);
        Global_vars.nxt = "你知不知道";
        Invoke("Left", 0.5f);
       // Global_vars.nxt = "如果你陪着我我会坚强很多";
        Invoke("Left", 0.5f);



    }
    void Left()
    {
        GameObject.FindWithTag("can").GetComponent<Text_event>().SendMessage("Update_left_global");
    }
    void Right()
    {
        GameObject.FindWithTag("can").GetComponent<Text_event>().SendMessage("Update_right_global");
    }
}
