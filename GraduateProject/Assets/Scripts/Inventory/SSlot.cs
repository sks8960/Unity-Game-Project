using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Image image;   //Image Component ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½

    public ItemEffectDatabase theItemEffectDatabase;

<<<<<<< HEAD
    public Item _item; //item ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½
    public Item item //Item ï¿½ï¿½Ã¼ï¿½ï¿½ ï¿½Þ¾Æ¿ï¿½ ï¿½ï¿½ ï¿½Ö´ï¿½ ï¿½ï¿½Å©ï¿½ï¿½Æ®
=======
    public Item _item; //item Á¤º¸ÀÇ °ªÀ» ÀúÀå
    public Item item //Item °´Ã¼¸¦ ¹Þ¾Æ¿Ã ¼ö ÀÖ´Â ½ºÅ©¸³Æ®
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
    // ï¿½ï¿½ï¿½ì½º Ä¿ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½Ô¿ï¿½ ï¿½ï¿½î°¥ ï¿½ï¿½ ï¿½ßµï¿½
=======
    // ¸¶¿ì½º Ä¿¼­°¡ ½½·Ô¿¡ µé¾î°¥ ¶§ ¹ßµ¿
>>>>>>> f9133e3071e381a27f4021ca6b84cb9fcab5d037
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (_item != null)
            theItemEffectDatabase.ShowToolTip(_item, transform.position);
    }

<<<<<<< HEAD
    // ï¿½ï¿½ï¿½ì½º Ä¿ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½Ô¿ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ ï¿½ßµï¿½
=======
    // ¸¶¿ì½º Ä¿¼­°¡ ½½·Ô¿¡¼­ ³ª¿Ã ¶§ ¹ßµ¿
>>>>>>> f9133e3071e381a27f4021ca6b84cb9fcab5d037
    public void OnPointerExit(PointerEventData eventData)
    {
        theItemEffectDatabase.HideToolTip();
    }
}
