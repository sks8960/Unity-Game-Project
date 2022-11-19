using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BattleClickItem : MonoBehaviour
{
    Camera CamerSub;
    public string NameOfCard;
    public string[] ValueOfCardList;
    public string TypeOfCard;

    public bool isClickSuccess = false;
    void Update()
    {
        CamerSub = GameObject.Find("CameraManager").GetComponent<CameraManager>().subCamera;

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = CamerSub.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                HitCheckObject(hit);
            }
        }
    }
    void HitCheckObject(RaycastHit2D hit)
    {
        Debug.Log(hit.collider.gameObject.name);
        NameOfCard = hit.collider.gameObject.name;
        BattleCardNamesplit();

        if (TypeOfCard == "ATK")
        {
            //Ŭ�� ������ ȣ���� �Ŀ� �ı��ϸ� ���?
            isClickSuccess = true;
            GameObject.Find("Battle System").GetComponent<BattleSystem>().OnAttackButton();
        }
        else if(TypeOfCard == "HEAL")
        {
            //Ŭ�� ������ ȣ���� �Ŀ� �ı��ϸ� ���?
            isClickSuccess = true;
            GameObject.Find("Battle System").GetComponent<BattleSystem>().OnHealButton();
        }
        
        if (isClickSuccess == true)
        {
            GameObject.Find("Battle System").GetComponent<BattleSelectItem>().DeleteBattleItemList();
        }
        else
        {
            Debug.Log("�����ý��� ����");
        }
    }

    public void BattleCardNamesplit()
    {
        ValueOfCardList = NameOfCard.Split(' ');
        TypeOfCard = ValueOfCardList[0];
    }
}
