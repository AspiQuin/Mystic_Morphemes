using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{

    int health = 3; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       for(int i =0; i < 3; i++)
        {
            if(i <= health)
            {
                GetComponentInChildren<i>()
            }
        }
    }
}
