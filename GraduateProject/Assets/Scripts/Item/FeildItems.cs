using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FieldItems : MonoBehaviour
{
    // SO(Scriptable Object�� ���ǵ� Item�� ���ؼ� �����ڸ� ���� �ʱ�ȭ�� �������ش�)
    public Item item;
    public SpriteRenderer image;

    public void SetItem(Item _item)
    {
        item.itemName = _item.itemName;
        item.itemImage = _item.itemImage;
        image.sprite = item.itemImage;
    }
}
