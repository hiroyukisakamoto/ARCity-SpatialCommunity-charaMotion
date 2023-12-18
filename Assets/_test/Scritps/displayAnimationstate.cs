using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AnimationStateTitle : MonoBehaviour
{
    public Animator animator;  // �A�j���[�^�[�R���g���[�����Q��
    public Text titleText;     // �^�C�g����\������UI Text

    public List<string> stateNames = new List<string> { "Idle", "Cheering", "Walking With Shopping Bag", "Victory Idle", "Pointing", "Waving", "Left Turn", "Standard Walk", "Right Turn", "Joyful Jump", "Clapping" };


    void Update()
    {
        // �A�j���[�^�[�̌��݂̃X�e�[�g���擾
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        //Debug.Log(stateInfo);

        // �X�e�[�g�̖��O��UI Text�ɕ\��
        foreach (string stateName in stateNames)
        {
            if (stateInfo.IsName(stateName))
            {
                titleText.text = stateName;
                return; // ��v����X�e�[�g��������΃��[�v�𔲂���
            }
        }

        // ��v����X�e�[�g���Ȃ��ꍇ�̓e�L�X�g����ɂ���
        titleText.text = "";
    }
}
