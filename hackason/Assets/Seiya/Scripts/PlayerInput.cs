using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField, Header("�P�[�L�����{�^���̐ݒ�")]
    private KeyCode Key;
    [SerializeField, Header("�P�[�L�����N�[���^�C��")]
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
        //�X�y�[�X�œ���
        if(Input.GetKeyDown(Key))
        {

        }

        Debug.Log(frame);
        frame += Time.deltaTime;
    }
}
