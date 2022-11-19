using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// ������ ������ ������ �������̽�
public interface IObjectItem
{
    Item ClickItem();
}

// ������ ���濡 ���� ��ũ��Ʈ
public class ObjectItem : MonoBehaviour, IObjectItem
{
    [Header("������")]
    public Item item;
    [Header("������ �̹���")]
    public SpriteRenderer image;

    public Item ClickItem()
    {
        GameObject.Find("player").GetComponent<Click_Move>().click = true;
        GameObject.Find("player").GetComponent<player_random>().roll = true;
        GameObject.Find("player").GetComponent<EnemyContact>().enemy = false;
        return this.item;
    }
    public void SetItem(Item _item)
    {
        item.itemName = _item.itemName;
        item.itemImage = _item.itemImage;
    }
}
