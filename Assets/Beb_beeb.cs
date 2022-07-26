using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beb_beeb : MonoBehaviour
{
    // Start is called before the first frame update
    int update;
    void Start()
    {
        update = 0;
    }

    // Update is called once per frame
    void Update()
    {
        update++;
        Debug.Log("beb beeb "+ update);
        if (update == 3)
        {
            int x = fib(50);
            Debug.Log("updated ["+update+"] = "+Time.deltaTime+" -- "+x);
        }
        Debug.Log("beb beeb -- "+update);

    }
    private int fib(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return fib(n - 1) + fib(n - 2);
    }
}
