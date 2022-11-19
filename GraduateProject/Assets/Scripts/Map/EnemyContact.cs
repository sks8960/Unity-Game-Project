using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContact : MonoBehaviour
{

    public bool delete_on = false;
    public bool swap_on = false;
    public bool enemy = false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "event")
        {
            enemy = true;
            GameObject.Find("player").GetComponent<player_random>().roll = false;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Delete")
        {
            if (GameObject.Find("player").GetComponent<PlayerClickItem>().item_array.Count >= 1)
            {
                enemy = true;
                Destroy(other.gameObject);
                GameObject.Find("CanvasInventory").GetComponent<InventoryActive>().activeInventory = true;
                delete_on = true;
                GameObject.Find("player").GetComponent<Click_Move>().click = false;
                GameObject.Find("player").GetComponent<player_random>().roll = false;
            }
            else
                Debug.Log("�ƹ��͵� �����ϴ�.");
        }
        if (other.gameObject.tag == "Swap")
        {
            if (GameObject.Find("player").GetComponent<PlayerClickItem>().item_array.Count >= 2)
            {
                enemy = true;
                Destroy(other.gameObject);
                GameObject.Find("CanvasInventory").GetComponent<InventoryActive>().activeInventory = true;
                swap_on = true;
                GameObject.Find("player").GetComponent<Click_Move>().click = false;
                GameObject.Find("player").GetComponent<player_random>().roll = false;
            }
            else
                Debug.Log("�κ��丮�� 2���̻��� �������� �ʿ��մϴ�.");
        }
        if (other.gameObject.tag == "Heal")
        {
            Destroy(other.gameObject);
            GameObject.Find("PlayerStat").GetComponent<Unit>().HealField();
        }
        if (other.gameObject.tag == "Artifact")
        {
            Destroy(other.gameObject);
<<<<<<< HEAD
            GameObject.Find("player").GetComponent<ItemSelect>().Special();
=======
            GameObject.Find("player").GetComponent<ItemSelect>().CreateSpecial();
>>>>>>> f9133e3071e381a27f4021ca6b84cb9fcab5d037
        }
    }
}