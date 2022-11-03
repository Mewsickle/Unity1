using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallEvent : MonoBehaviour
{
    [SerializeField] GameObject[] enemy;
    [SerializeField] GameObject wall;
    // Update is called once per frame
    void Update()
    {
        if (enemy[0] == null && enemy[1] == null)
        {
            DestroyObject(wall);
        }
    }
}
