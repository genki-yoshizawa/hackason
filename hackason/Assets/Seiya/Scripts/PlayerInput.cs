using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField, Header("ケーキを取るボタンの設定")]
    private KeyCode Key;
    [SerializeField, Header("ケーキを取るクールタイム")]
    private float CoolTime;

    private float frame;

    // Start is called before the first frame update
    void Start()
    {
        frame = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //スペースで入力
        if(Input.GetKeyDown(Key))
        {

        }

        Debug.Log(frame);
        frame += Time.deltaTime;
    }
}
