using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello,World");
        int age;
        age =30;
        age += 5;
        Debug.Log(age);
        float height1 = 165.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);
        string name;
        name ="kitamura";
        Debug.Log(name);
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);
        answer = 3 - 4;
        Debug.Log(answer);
        answer = 5 * 6;
        Debug.Log(answer);
        answer = 8 / 4;
        Debug.Log(answer);
        answer = 10;
        answer++;
        Debug.Log(answer);
        answer--;
        Debug.Log(answer);
        string str1 = "happy";
        string str2 = "birthday";
        string message;
        message = str1 + str2;
        Debug.Log(message);
        int herbNum = 4;
        if(herbNum <=3)
        {
            Debug.Log("薬草はあと3個未満です");
        }
        if (herbNum == 1)
        {
            Debug.Log("HPが50回復");
        }
       
       else if (herbNum ==2)
        {
            Debug.Log("HPが100回復");
        }else
        {
            Debug.Log("薬草が多すぎます");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
