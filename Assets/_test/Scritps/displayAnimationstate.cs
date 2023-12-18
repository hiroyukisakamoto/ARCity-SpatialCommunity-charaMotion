using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AnimationStateTitle : MonoBehaviour
{
    public Animator animator;  // アニメーターコントローラを参照
    public Text titleText;     // タイトルを表示するUI Text

    public List<string> stateNames = new List<string> { "Idle", "Cheering", "Walking With Shopping Bag", "Victory Idle", "Pointing", "Waving", "Left Turn", "Standard Walk", "Right Turn", "Joyful Jump", "Clapping" };


    void Update()
    {
        // アニメーターの現在のステートを取得
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        //Debug.Log(stateInfo);

        // ステートの名前をUI Textに表示
        foreach (string stateName in stateNames)
        {
            if (stateInfo.IsName(stateName))
            {
                titleText.text = stateName;
                return; // 一致するステートが見つかればループを抜ける
            }
        }

        // 一致するステートがない場合はテキストを空にする
        titleText.text = "";
    }
}
