using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeTowerScript : MonoBehaviour
{
    private List<Sprite> _Pancake = null;
    [SerializeField]private int _MaxPancakeNum = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int CountPancake()
    {
        return _Pancake.Count;
    }
}
