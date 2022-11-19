using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Image image;   //Image Component ������ ���

    public ItemEffectDatabase theItemEffectDatabase;

<<<<<<< HEAD
    public Item _item; //item ������ ���� ����
    public Item item //Item ��ü�� �޾ƿ� �� �ִ� ��ũ��Ʈ
=======
    public Item _item; //item ������ ���� ����
    public Item item //Item ��ü�� �޾ƿ� �� �ִ� ��ũ��Ʈ
>>>>>>> f9133e3071e381a27f4021ca6b84cb9fcab5d037
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item != null)
            {
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }

<<<<<<< HEAD
    // ���콺 Ŀ���� ���Կ� �� �� �ߵ�
=======
    // ���콺 Ŀ���� ���Կ� �� �� �ߵ�
>>>>>>> f9133e3071e381a27f4021ca6b84cb9fcab5d037
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_item != null)
            theItemEffectDatabase.ShowToolTip(_item, transform.position);
    }

<<<<<<< HEAD
    // ���콺 Ŀ���� ���Կ��� ���� �� �ߵ�
=======
    // ���콺 Ŀ���� ���Կ��� ���� �� �ߵ�
>>>>>>> f9133e3071e381a27f4021ca6b84cb9fcab5d037
    public void OnPointerExit(PointerEventData eventData)
    {
        theItemEffectDatabase.HideToolTip();
    }
}
