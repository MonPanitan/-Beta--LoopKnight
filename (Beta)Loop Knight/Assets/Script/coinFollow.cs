using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinFollow : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = enemy.transform.position;
    }
}
