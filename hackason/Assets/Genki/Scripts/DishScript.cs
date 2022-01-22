using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishScript : MonoBehaviour
{
    private int _PancakeNum = 0;
    private PancakeTowerScript[] _PancakeTowerScriptArray;
    private bool[] _isArrivePancakeTower;
    
    private int _PancakeTowerNum = 3;

    // Start is called before the first frame update
    void Start()
    {
        _PancakeTowerScriptArray = new PancakeTowerScript[_PancakeTowerNum];
        _isArrivePancakeTower = new bool[_PancakeTowerNum];
        for (int i = 0; i < transform.childCount; ++i)
        {
            _PancakeTowerScriptArray[i] = transform.GetChild(i).GetComponent<PancakeTowerScript>();
            _isArrivePancakeTower[i] = true;
        }


        _PancakeNum = CountPancake();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private int CountPancake()
    {
        int num = 0;

        for (int i = 0; i < transform.childCount; ++i)
        {
            num += _PancakeTowerScriptArray[i].CountPancake();
        }

        return num; 
    }

    // プレイヤーがパンケーキを減らすときに呼ぶ関数
    public bool DecresePancake()
    {


        if (CountPancake() == 0)
            return true;

        return false;
    }

    // 新しい皿の生成関数
    // スライド移動中は他の処理を止める注文
    //private ChangeDish()
    //{ }
}
