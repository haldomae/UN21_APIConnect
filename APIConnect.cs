using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// TMPを使うために必要
using TMPro;
// 外部と通信する際に必要
using UnityEngine.Networking;

public class APIConnect : MonoBehaviour
{
    // TMPのコンポーネントを格納する変数
    private TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        // TMPのコンポーネントを取得
        tmp = GetComponet<TextMeshProUGUI>();
        // 情報を取得したいURL(文字列 : string)
        string url 
        = "https://pokeapi.co/api/v2/pokemon/ditto";

        // 非同期通信(コルーチン)で指定したURLから情報を取得
        StartCoroutine(
            // 実行したい関数
            
        )
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
