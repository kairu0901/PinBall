using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    // Material������
    Material myMaterial;

    public int total_point;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject point_text;

    // Start is called before the first frame update
    void Start()
    {
        
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.point_text = GameObject.Find("PointText");
        UpdatePointText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SmallCloudTag"))
        {
            this.total_point += 10;
            UpdatePointText();
        }
        else if (other.gameObject.CompareTag("LargeCloudTag"))
        {
            this.total_point += 20;
            UpdatePointText();
        }
    }
    void UpdatePointText()
    {
        //GameoverText�ɃQ�[���I�[�o��\��
        this.point_text.GetComponent<Text>().text = "�|�C���g�F" + this.total_point;
    }
}
