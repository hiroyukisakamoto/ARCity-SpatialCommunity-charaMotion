using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class particleSuki : MonoBehaviour
{
    public GameObject suki;
    public Animator animator;  // アニメーターコントローラを参照

    void Update()
    {
        // アニメーターの現在のステートを取得
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // アニメーションステートの名前が「Joyful Jump」である場合は suki をアクティブにする
        if (stateInfo.IsName("Joyful Jump"))
            suki.SetActive(true);
        else
            suki.SetActive(false); // 「Joyful Jump」以外のアニメーションステートの場合は非アクティブにする
    }
}
