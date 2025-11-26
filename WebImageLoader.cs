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
            LoadImage(imageUrl)
        );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 非同期通信(コルーチン)で画像を取得する関数
    IEnumerator LoadImage(string imageUrl)
    {
        // 依頼先(リクエスト)を作成
        // 画像を取得する依頼(リクエスト)なので、Jsonとは違う
        UnityWebRequest request = 
        UnityWebRequestTexture.GetTexture(imageUrl);

        // リクエスト送信
        // データが到着するまで一時停止
        // データが到着したら再開
        yield return request.SendWebRequest();

        // 通信に成功したかチェック
        if(request.result == UnityWebRequest.Result.Success){
            // 成功
            // 画像をテクスチャとして取得
            Texture2D texture = 
            DownloadHandlerTexture.GetContent(request);

            // Rendererコンポーネント(見た目)を取得
            Renderer renderer = GetComponent<Renderer>();
            // オブジェクトにRendererコンポーネントが付いているかチェック
            if(renderer != null){
                // Rendererコンポーネントがある
                // 取得した画像をCubeに張り付ける
                renderer.material.mainTexture = texture;
            }
        }else{
            // 失敗
            // 失敗した場合にはLogを出力
            Debug.Log("通信に失敗");
        }
    }
}
