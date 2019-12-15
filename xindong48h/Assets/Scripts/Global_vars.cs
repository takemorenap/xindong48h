using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_vars : MonoBehaviour
{
    public static string[] left_text = new string[11111];
    public static string[] right_text = new string[11111];
    public static string nxt;
    void test_ini()
    {
        for (int i = 0; i < 1110; ++i)
        {
            left_text[i] = i+" L!";
            right_text[i] = i + " R!";
        }
    }
    public static int dialog_numl = 0, dialog_numr = 0;
    public static bool can_move = true;
    public static int direction = 0 , ok = 0;
    public static bool moving = false;
    public static float add_force_ = 75f;
    public static float fear = 0;

}

