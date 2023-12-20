using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform avatar; // アバターのTransform
    public Transform lightRing; // 光の輪のTransform

    private void Update()
    {
        if (avatar != null && lightRing != null)
        {
            // アバターの位置に光の輪を追従させる
            lightRing.position = avatar.position;
        }
    }
}
