using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_right : MonoBehaviour    // Ŭ�� �� ���� �̵�
{
    SoundManager SoundEffect;
    private void OnMouseDown()
    {
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        SoundEffect.SFXPlay("audioMove");
        GameObject.Find("player").GetComponent<Click_Move>().ButtonRight(); //�̵� ��ũ��Ʈ�� �����ϴ� ��� ��ư �� ��Ȱ��ȭ �Լ�
    }
}
