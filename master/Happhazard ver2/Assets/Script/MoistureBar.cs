using UnityEngine;
using System.Collections;
using UnityEngine.UI; // ←※これを忘れずに入れる

public class MoistureBar : MonoBehaviour
{

    Slider _slider;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("MoistureSlider").GetComponent<Slider>();
    }

    float _hp = 100;
    void Update()
    {
        // HP減少
        _hp -= 0.01f;
        if (_hp > 100)
        {
            //// 最大を超えたら0に戻す
            //_hp = 0;
        }

        // HPゲージに値を設定
        _slider.value = _hp;
    }
}
