using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Calorie1 : MonoBehaviour
{
        private
         float CalorieM;//�J�����[�̏����l
         float CalorieO;//��Q���ɂ�錸��
         float CalorieS;//�X�C�[�c�ɂ�鑝��
        public
         Text CalorieText;//�J�����[�̕����̕ϐ�
         
    void Start()
    {
        CalorieM = 100.0f;//�͂��߂�100
    }
    
    void Update()
    {
        CalorieText.text = "Calorie:" + CalorieM.ToString();//�J�����[�̃e�L�X�g�������J�����[�̏����l�ɂ���
        CalorieM -= Time.deltaTime*2 ;//���Ԃɂ�錸���̏���
        if(CalorieM == 0.0f)
       {
            SceneManager.LoadScene("GameOver"); 
       }
    }

 
}

