using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    //�L�����N�^�[�̏�Ԃ����锠��p��
    public Rigidbody2D chara;
    //�L�����N�^�[�̃W�����v�͂̐ݒ�
    public float jumpForce = 10f;
    //�n�ʂɂ��邩�ǂ����̔���ݒ�
    private bool isGrounded;

    void Start()
    {
        //�L�����N�^�[�̏�Ԃ��擾
        chara = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //�X�y�[�X�L�[�������ꂽ���ǂ����𔻒�
        if (Input.GetButtonDown("Jump"))
        {
            //�L�����N�^�[�ɃW�����v������
            chara.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            //�W�����v������A�n�ʂ��痣�ꂽ�Ɣ���
            isGrounded = false;
        }
    }

    // �n�ʂɐG��Ă��邩�̔���
    void OnCollisionEnter2D(Collision2D other)
    {
        //�ڐG�����I�u�W�F�N�g�̖��O���uAsufaruto�v��������쓮����
        if (other.gameObject.CompareTag("Asufaruto"))
        {
            //�n�ʂƐڐG���Ă���Ɣ���
            isGrounded = true;
        }
    }
}
