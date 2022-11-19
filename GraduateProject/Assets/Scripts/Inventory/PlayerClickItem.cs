using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerClickItem : MonoBehaviour
{
    // �÷��̾ �������� �����ϴ� ������ �����ϴ� ��ũ��Ʈ
    [Header("�κ��丮")]
    public Inventory inventory;
    public List<string> item_array;
    public string clickItemName;
    public string clickItemTag;
    public int artifactFlag;
    public Item sitem;
    SoundManager SoundEffect;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                HitCheckObject(hit);
            }
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log(GameObject.Find("player").GetComponent<calculator>().cal(0, item_array)); // ���
        }
    }
    void HitCheckObject(RaycastHit2D hit)
    {
        IObjectItem clickInterface = hit.transform.gameObject.GetComponent<IObjectItem>();
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        
        if (clickInterface != null)
        {
            Item item = clickInterface.ClickItem();
            //print($"{item.itemName}");
            SoundEffect.SFXPlay("audioCardSelect");
            clickItemName = item.itemName;
            clickItemTag = item.tag;

            if (clickItemTag == "artifact")
            {
                sitem = item;
                inventory.AddSslot(item);
                Debug.Log(inventory.sslot.item.condition);
                artifactFlag++;          
            }
            else
            {
                if(clickItemTag == "store")
                {
                    GameObject.Find("PlayerStat").GetComponent<Unit>().UseStore();
                    inventory.AddItem(item);
                    item_array.Add(item.abc);
                }
                else if(clickItemTag == "reward")
                {
                    inventory.AddItem(item);
                    item_array.Add(item.abc);
                }
                else if(clickItemTag == "hpincrease")
                {
                    GameObject.Find("PlayerStat").GetComponent<Unit>().MaxHPIncrease();
                }
            }
            //������Ʈ ������ ���⼭ �ؾ���
            GameObject.Find("player").GetComponent<ItemSelect>().DeleteItemList();
            //���� : HitCheckObject���� Ŭ�� �̺�Ʈ�� ó�����ֹǷ�, ���⼭ �κ��丮 �ݿ��� ���ÿ� �ı��� ó���ϸ��
        }
    }
}