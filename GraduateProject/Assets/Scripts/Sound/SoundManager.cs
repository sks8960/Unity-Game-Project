using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip audioMove;
    public AudioClip audioPAttack;
    public AudioClip audioPBigAtk;
    public AudioClip audioPCriticalAtk;
    public AudioClip audioEAttack;
    public AudioClip audioPHeal;
    public AudioClip audioOInven;
    public AudioClip audioCInven;
    public AudioClip audioShop;
    public AudioClip audioIChange;
    public AudioClip audioHealCenter;
    public AudioClip audioCardSelect;
    public AudioClip audioCardList;
    public AudioClip audioIDiscard;
    public AudioClip audioDice1;
    public AudioClip audioDice2;
    public AudioClip audioDice3;
    AudioSource audioSource;

    public void SFXPlay(string sfxName)
    {
        this.audioSource = GetComponent<AudioSource>();

        switch (sfxName)
        {
            case "audioMove":
                audioSource.clip = audioMove;
                break;

            case "audioPAttack":
                audioSource.clip = audioPAttack;
                break;

            case "audioPBigAtk":
                audioSource.clip = audioPBigAtk;
                break;

            case "audioPCriticalAtk":
                audioSource.clip = audioPCriticalAtk;
                break;

            case "audioEAttack":
                audioSource.clip = audioEAttack;
                break;

            case "audioPHeal":
                audioSource.clip = audioPHeal;
                break;

            case "audioOInven":// �κ��丮 ����
                audioSource.clip = audioOInven;
                break;

            case "audioCInven": // �κ��丮 �ݱ�
                audioSource.clip = audioCInven;
                break;

            case "audioCardSelect"://ī�� ����
                audioSource.clip = audioCardSelect;
                break;

            case "audioCardList"://ī�� ��ġ
                audioSource.clip = audioCardList;
                break;

            case "audioShop"://���� �Ҹ�
                audioSource.clip = audioShop;
                break;

            case "audioIChange"://������ ��ġ ��ȯ
                audioSource.clip = audioIChange;
                break;

            case "audioHealCenter": //ȸ�� ������
                audioSource.clip = audioHealCenter;
                break;

            case "audioIDiscard"://������ ����
                audioSource.clip = audioIDiscard;
                break;

            case "audioDice1":
                audioSource.clip = audioDice1;
                break;

            case "audioDice2":
                audioSource.clip = audioDice2;
                break;

            case "audioDice3":
                audioSource.clip = audioDice3;
                break;
        }
        audioSource.Play();
    }
}
