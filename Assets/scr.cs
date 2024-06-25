using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    public GameObject[] cosas;

    int index = 0;
    void Start()
    {
        for (int i = 0; i < cosas.Length; i++)
        {
            cosas[i].SetActive(false);
        }
        cosas[index].SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            cosas[index].SetActive(false);
            if (index == 0)
            {
                index = cosas.Length - 1;
            }
            else
            {
                index--;
            }
            cosas[index].SetActive(true);
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            cosas[index].SetActive(false);
            if (index == cosas.Length-1) 
            {
                index = 0;
            }
            else 
            {
            index++;
            }
            cosas[index].SetActive(true);
        }
        
    }
    
}
