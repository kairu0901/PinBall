using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    // Materialを入れる
    Material myMaterial;

    public int total_point;

    //ゲームオーバを表示するテキスト
    private GameObject point_text;

    // Start is called before the first frame update
    void Start()
    {
        
        //シーン中のGameOverTextオブジェクトを取得
        this.point_text = GameObject.Find("PointText");
        UpdatePointText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //衝突時に呼ばれる関数
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
        //GameoverTextにゲームオーバを表示
        this.point_text.GetComponent<Text>().text = "ポイント：" + this.total_point;
    }
}
