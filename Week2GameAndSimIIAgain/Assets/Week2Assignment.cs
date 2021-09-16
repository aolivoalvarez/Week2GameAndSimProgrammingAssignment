using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Assignment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Function1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Function1()
    {
        for (int i = 1; i <= 1000; i++)
        {
            string num = i.ToString();
            
            foreach (char s in num)
            {
                if ((s == '3') || (s == '7'))
                {
                    Debug.Log(i);
                }
            }
        }
    }
}
