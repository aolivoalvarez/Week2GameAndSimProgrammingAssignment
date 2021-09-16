using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Week2Assignment : MonoBehaviour
{
    public string sentence = " ";
    // Start is called before the first frame update
    void Start()
    {
        Function1();
        Function2(sentence);
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
                    Debug.Log(i + " contains a 3 or a 7");
                }
            }
        }
    }

    void Function2(string s)
    {
        char[] alphabet = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o',
                                           'p','q','r','s','t','u','v','w','x','y','z'};
        int[] counter = new int[26];

        int largest = 0;
        char most = ' ';

        foreach (char c in s)
        {
            int position = Array.IndexOf(alphabet, c);
            counter[position]++;
        }

        foreach (int num in counter)
        {
            if (num > largest)
            {
                largest = num;
                int index = Array.IndexOf(counter, largest);
                most = alphabet[index];
          
            }
      
        }

        Debug.Log("The letter \"" + most + "\" appears the most in your sentence");
    }
}
