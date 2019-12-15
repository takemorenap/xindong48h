using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    bool flag = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player" && flag)
        {
            flag = false;
            Invoke("F1", 1.5f);
            Invoke("F2", 3f);
            Invoke("F3", 4.5f);
            Invoke("F4", 6f);
            Invoke("F5", 7.5f);
            Invoke("F6", 8.5f);
            Invoke("F7", 10f);
            Invoke("F8", 11.5f);
            Invoke("F9", 12.5f);
        }
    }
    void F1()
    {
        Global_vars.nxt = "我看到岔路口了";
        Left();
    }
    void F2()
    {
        Global_vars.nxt = "你能看到前面怎么走吗";
        Left();
    }
    void F3()
    {
        Global_vars.nxt = "能看到";
        Left();
    }
    void F4()
    {
        Global_vars.nxt = "两条路都可以走";
        Left();
    }
    void F5()
    {
        Global_vars.nxt = "但是左边太远了";
        Left();
    }
    void F6()
    {
        Global_vars.nxt = "还是走右边吧";
        Left();
    }
    void F7()
    {
        Global_vars.nxt = "我不想走右边";
        Left();
    }
    void F8()
    {
        Global_vars.nxt = "右边好像有血迹";
        Left();
    }
    void F9()
    {
        Global_vars.nxt = "我不敢走";
        Left();
        Display_click();
    }


    void Display_click()
    {
        GameObject.FindWithTag("click").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.FindWithTag("click1").GetComponent<SpriteRenderer>().enabled = true;
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
