using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform avatar; // �A�o�^�[��Transform
    public Transform lightRing; // ���̗ւ�Transform

    private void Update()
    {
        if (avatar != null && lightRing != null)
        {
            // �A�o�^�[�̈ʒu�Ɍ��̗ւ�Ǐ]������
            lightRing.position = avatar.position;
        }
    }
}
