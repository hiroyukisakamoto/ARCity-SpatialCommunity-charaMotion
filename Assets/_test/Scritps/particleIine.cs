using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleIine : MonoBehaviour
{
    public GameObject iine;
    public Animator animator;  // アニメーターコントローラを参照

    void Update()
    {
        // アニメーターの現在のステートを取得
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // アニメーションステートの名前が「iine」であることを確認
        if (stateInfo.IsName("Cheering"))
            iine.SetActive(true);
        else
            iine.SetActive(false); // 「iine」以外のアニメーションステートの場合は非アクティブにする

    }
}
