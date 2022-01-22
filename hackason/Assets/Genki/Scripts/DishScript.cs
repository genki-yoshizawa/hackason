using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishScript : MonoBehaviour
{
    private int _PancakeNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        CountPancake();
    }

    // Update is called once per frame
    void Update()
    {
        CountPancake();
    }

    private void CountPancake()
    {
        for (int i = 0; i < transform.childCount; ++i)
        {
            _PancakeNum += transform.GetChild(i).GetComponent<PancakeTowerScript>().CountPancake();
        }
    }
}
