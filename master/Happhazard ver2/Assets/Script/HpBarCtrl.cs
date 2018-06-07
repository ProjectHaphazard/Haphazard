using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class HpBarCtrl : MonoBehaviour
{
    public float _hp = 50000;
    Slider _slider;
    void Start()
    {
        _hp = 40000;
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void Update()
    {
        // HP減少
        _hp -= Time.deltaTime * 1;
        if (_hp > 50000)
        {
          
        }



        // HPゲージに値を設定
        _slider.value = _hp;
    }
}
