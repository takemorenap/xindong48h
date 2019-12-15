using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_event : MonoBehaviour
{
    public static GameObject[] textleft = new GameObject[1111];
    public static GameObject[] textright = new GameObject[1111];
    public Canvas can;
    public static Canvas c;
    private Vector3 left, right;
    // Update is called once per frame
    private void Start()
    {
        c = can;
        textleft[0] = GameObject.FindGameObjectWithTag("textl");
        textright[0] = GameObject.FindGameObjectWithTag("textr");
        left = new Vector3(textleft[0].transform.position.x, textleft[0].transform.position.y, textleft[0].transform.position.z);
        right = new Vector3(textright[0].transform.position.x, textright[0].transform.position.y, textright[0].transform.position.z);
        textright[Global_vars.dialog_numr].GetComponentInChildren<Text>().text = "";
        GameObject.FindWithTag("click").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.FindWithTag("click1").GetComponent<SpriteRenderer>().enabled = false;
        // Destroy(GameObject.FindWithTag("start"));
        textleft[Global_vars.dialog_numl].GetComponentInChildren<Text>().text = "我现在不知道在哪";
        textright[0].transform.Translate(Vector2.up * 500f);
        Invoke("Fun1", 2f);
        Invoke("Fun2", 4f);
        Invoke("Fun3", 6f);
        Invoke("Fun4", 8f);
        Invoke("Fun5", 10f);
        Invoke("Fun6", 12f);
        Invoke("Fun7", 13f);
    }
    void Fun1()
    {
        Update_left_with_string("你的电话也打不通");
        //textleft[Global_vars.dialog_numl].GetComponentInChildren<Text>().text += "\n456";
    }
    void Fun2()
    {
        Update_left_with_string("只能和你发消息");
        //        textleft[Global_vars.dialog_numl].GetComponentInChildren<Text>().text += "\n123";
    }
    void Fun3()
    {
        Update_right_with_string("咋回事啊");
        //        textleft[Global_vars.dialog_numl].GetComponentInChildren<Text>().text += "\n";
        //      textright[Global_vars.dialog_numr].GetComponentInChildren<Text>().text = "456";
    }
    void Fun4()
    {
        Update_left_with_string("我不知道 快想想办法");
        //        textright[Global_vars.dialog_numr].GetComponentInChildren<Text>().text += "\n";
        //      textleft[Global_vars.dialog_numl].GetComponentInChildren<Text>().text += "\n1232";
    }
    void Fun5()
    {
        Update_right_with_string("我这里有个监控");
        Update_right_with_string("能看到你");
    }
    void Fun6()
    {
        Update_left_with_string("真的?");
        Update_left_with_string("你看到我动了吗");
    }
    void Fun7()
    {
        Update_right_with_string("别动了看到了");
    }
    void Update()
    {

    }
    //void Update_left()
    //{

    //    Global_vars.ok = 0;
    //    // if (Global_vars.ok == 1)
    //    {
    //        Global_vars.dialog_numl++;
    //        textleft[Global_vars.dialog_numl] = Instantiate(textleft[0], left, textleft[0].transform.rotation);
    //        textleft[Global_vars.dialog_numl].transform.SetParent(can.transform);
    //        textleft[Global_vars.dialog_numl].GetComponentInChildren<Text>().text = "1111";// Global_vars.left_text[Global_vars.dialog_numl];
    //        for (int i = 0; i < Global_vars.dialog_numl; i++)
    //            textleft[i].transform.Translate(Vector2.up * 50f);
    //        for (int i = 0; i <= Global_vars.dialog_numr; i++)
    //            textright[i].transform.Translate(Vector2.up * 50f);
    //    }
    //}
    void Update_left_with_string(string s)
    {
        GetComponent<AudioSource>().Play();
        Global_vars.dialog_numl++;
        textleft[Global_vars.dialog_numl] = Instantiate(textleft[0], left, textleft[0].transform.rotation);
        textleft[Global_vars.dialog_numl].transform.SetParent(can.transform);
        textleft[Global_vars.dialog_numl].GetComponentInChildren<Text>().text = s;// Global_vars.left_text[Global_vars.dialog_numl];
        for (int i = 0; i < Global_vars.dialog_numl; i++)
            textleft[i].transform.Translate(Vector2.up * 33f);
        for (int i = 0; i <= Global_vars.dialog_numr; i++)
            textright[i].transform.Translate(Vector2.up * 33f);

    }
    void Update_left_global()
    {
        GetComponent<AudioSource>().Play();
        Global_vars.dialog_numl++;
        textleft[Global_vars.dialog_numl] = Instantiate(textleft[0], left, textleft[0].transform.rotation);
        textleft[Global_vars.dialog_numl].transform.SetParent(can.transform);
        textleft[Global_vars.dialog_numl].GetComponentInChildren<Text>().text = Global_vars.nxt;// Global_vars.left_text[Global_vars.dialog_numl];
        for (int i = 0; i < Global_vars.dialog_numl; i++)
            textleft[i].transform.Translate(Vector2.up * 33f);
        for (int i = 0; i <= Global_vars.dialog_numr; i++)
            textright[i].transform.Translate(Vector2.up * 33f);

    }
    //void Update_right()
    //{
    //    Global_vars.ok = 0;
    //    // if (Global_vars.ok ==2 )
    //    {
    //        Global_vars.dialog_numr++;
    //        textright[Global_vars.dialog_numr] = Instantiate(textright[0], right, textright[0].transform.rotation);
    //        textright[Global_vars.dialog_numr].transform.SetParent(can.transform);
    //        textright[Global_vars.dialog_numr].GetComponentInChildren<Text>().text = "2222";// Global_vars.right_text[Global_vars.dialog_numr];
    //        for (int i = 0; i < Global_vars.dialog_numr; i++)
    //            textright[i].transform.Translate(Vector2.up * 33f);
    //        for (int i = 0; i <= Global_vars.dialog_numl; i++)
    //            textleft[i].transform.Translate(Vector2.up * 33f);

    //    }
    //}
    void Update_right_global()
    {

        Global_vars.dialog_numr++;
        textright[Global_vars.dialog_numr] = Instantiate(textright[0], right, textright[0].transform.rotation);
        textright[Global_vars.dialog_numr].transform.SetParent(can.transform);
        textright[Global_vars.dialog_numr].GetComponentInChildren<Text>().text = Global_vars.nxt;// Global_vars.right_text[Global_vars.dialog_numr];
        for (int i = 0; i < Global_vars.dialog_numr; i++)
            textright[i].transform.Translate(Vector2.up * 33f);
        for (int i = 0; i <= Global_vars.dialog_numl; i++)
            textleft[i].transform.Translate(Vector2.up * 33f);


    }
    void Update_right_with_string(string s)
    {

        Global_vars.dialog_numr++;
        textright[Global_vars.dialog_numr] = Instantiate(textright[0], right, textright[0].transform.rotation);
        textright[Global_vars.dialog_numr].transform.SetParent(can.transform);
        textright[Global_vars.dialog_numr].GetComponentInChildren<Text>().text = s;// Global_vars.right_text[Global_vars.dialog_numr];
        for (int i = 0; i < Global_vars.dialog_numr; i++)
            textright[i].transform.Translate(Vector2.up * 33f);
        for (int i = 0; i <= Global_vars.dialog_numl; i++)
            textleft[i].transform.Translate(Vector2.up * 33f);


    }
}
