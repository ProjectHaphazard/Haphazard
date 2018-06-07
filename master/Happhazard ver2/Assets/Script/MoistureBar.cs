using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class MoistureBar : MonoBehaviour
{
    public float _mb = 50000;
    Slider _slider;
    void Start()
    {
        _mb = 40000;
        // スライダーを取得する
        _slider = GameObject.Find("MoistureSlider").GetComponent<Slider>();
    }

    
    void Update()
    {
        _mb -= Time.deltaTime * 1;
        if (_mb > 100)
        {
            //ゲームオーバー処理
        }

        // HPゲージに値を設定
        //_slider.value = _mb;
    }
}
