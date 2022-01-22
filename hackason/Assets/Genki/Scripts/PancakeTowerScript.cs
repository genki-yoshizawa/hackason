using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeTowerScript : MonoBehaviour
{
    private List<Sprite> _Pancake = null;
    [Header("パンケーキ画像")]
    [SerializeField] private Sprite _PancakeSprite;

    [Header("パンケーキタワー一棟あたりの最大パンケーキ生成数")]
    [SerializeField]private int _MaxPancakeNum = 10;

    [Header("パンケーキタワー一棟あたりランダムで減らすパンケーキの最大値")]
    [SerializeField] private int _DecresePancakeMax = 3;

    private void Awake()
    {
        // パンケーキ生成

    }

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
