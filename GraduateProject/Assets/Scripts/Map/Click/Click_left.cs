using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_left : MonoBehaviour
{
    SoundManager SoundEffect;
    private void OnMouseDown() 
    {
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        SoundEffect.SFXPlay("audioMove");
        GameObject.Find("player").GetComponent<Click_Move>().ButtonLeft(); //�̵� ��ũ��Ʈ�� �����ϴ� ��� ��ư �� ��Ȱ��ȭ �Լ�
    }
}

