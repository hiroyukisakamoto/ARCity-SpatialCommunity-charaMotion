using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class particleSuki : MonoBehaviour
{
    public GameObject suki;
    public Animator animator;  // �A�j���[�^�[�R���g���[�����Q��

    void Update()
    {
        // �A�j���[�^�[�̌��݂̃X�e�[�g���擾
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // �A�j���[�V�����X�e�[�g�̖��O���uJoyful Jump�v�ł���ꍇ�� suki ���A�N�e�B�u�ɂ���
        if (stateInfo.IsName("Joyful Jump"))
            suki.SetActive(true);
        else
            suki.SetActive(false); // �uJoyful Jump�v�ȊO�̃A�j���[�V�����X�e�[�g�̏ꍇ�͔�A�N�e�B�u�ɂ���
    }
}
