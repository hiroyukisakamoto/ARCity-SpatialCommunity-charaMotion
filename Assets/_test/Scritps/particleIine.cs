using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleIine : MonoBehaviour
{
    public GameObject iine;
    public Animator animator;  // �A�j���[�^�[�R���g���[�����Q��

    void Update()
    {
        // �A�j���[�^�[�̌��݂̃X�e�[�g���擾
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // �A�j���[�V�����X�e�[�g�̖��O���uiine�v�ł��邱�Ƃ��m�F
        if (stateInfo.IsName("Cheering"))
            iine.SetActive(true);
        else
            iine.SetActive(false); // �uiine�v�ȊO�̃A�j���[�V�����X�e�[�g�̏ꍇ�͔�A�N�e�B�u�ɂ���

    }
}
