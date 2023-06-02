using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    // float型でbounce変数を宣言し10を代入
    public float bounce = 10f;

    void OnCollisionEnter(Collision other)
    {
        // 衝突したオブジェクトが"Ball"タグを持つ場合の処理
        if (other.gameObject.tag == "Ball")
        {
            // 衝突したオブジェクトのRigidbodyに力を加える
            // X軸方向には0の力を，Y軸方向には bouce/6の力を，Z軸方向にはbounceの力を与える
            // 力は瞬間的に与えれる（ForecMode.Inpulse）
            other.rigidbody.AddForce(0f, bounce / 6, bounce, ForceMode.Impulse);
        }
    }
}
