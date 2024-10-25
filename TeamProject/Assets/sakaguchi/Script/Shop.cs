using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shop : MonoBehaviour
{
    public GameObject objectToShowS;
    public float displayDelayS = 30.0f; // �\���܂ł̑ҋ@���ԁi�b�j

    private float timerS;
    private bool isDisplayedS;



    private void Start()
    {
        // �������i�o���j
        timerS = 0.0f;
        isDisplayedS = false;
        objectToShowS.SetActive(false); // �Q�[���J�n���ɃI�u�W�F�N�g���\���ɂ���



    }

    private void Update()
    {
        //�o���̏���
        if (!isDisplayedS)
        {
            timerS += Time.deltaTime; // �o�ߎ��Ԃ��J�E���g

            if (timerS >= displayDelayS)
            {
                // ��莞�Ԍo�߂�����I�u�W�F�N�g��\��
                objectToShowS.SetActive(true);
                isDisplayedS= true;

            }
        }
    }
}

