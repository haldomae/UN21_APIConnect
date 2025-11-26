using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 外部通信するために必要
using UnityEngine.Networking;

public class WebImageLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 画像取得先のURL
        string imageUrl = "https://zukan.pokemon.co.jp/zukan-api/up/images/index/5ffae3dea956fddfeeb55d5c50060a08.png";
        // 非同期通信(コルーチン)で画像を取得
        StartCoroutine(
            // 非同期通信(コルーチン)で実行したい関数

        )
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
