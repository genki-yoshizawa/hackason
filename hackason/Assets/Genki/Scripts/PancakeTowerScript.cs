using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PancakeTowerScript : MonoBehaviour
{
    private List<Sprite> _Pancake = null;
    [Header("�p���P�[�L�摜")]
    [SerializeField] private Sprite _PancakeSprite;

    [Header("�p���P�[�L�^���[�꓏������̍ő�p���P�[�L������")]
    [SerializeField]private int _MaxPancakeNum = 10;

    [Header("�p���P�[�L�^���[�꓏�����胉���_���Ō��炷�p���P�[�L�̍ő�l")]
    [SerializeField] private int _DecresePancakeMax = 3;

    private void Awake()
    {
        // �p���P�[�L����

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
