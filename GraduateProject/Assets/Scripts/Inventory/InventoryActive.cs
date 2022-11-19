using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InventoryActive : MonoBehaviour
{
    public GameObject inventoryPanel;
    public bool activeInventory = false;
    SoundManager SoundEffect;
    Click_Move ClickMove;
    bool enemy;
    bool roll;
    // Start is called before the first frame update
    public void Start()
    {
        enemy = GameObject.Find("player").GetComponent<EnemyContact>().enemy;
        roll = GameObject.Find("player").GetComponent<player_random>().roll;
    }
    // Update is called once per frame
    void Update()
    {
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        ClickMove = GameObject.Find("player").GetComponent<Click_Move>();
        inventoryPanel.SetActive(activeInventory);
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!GameObject.Find("player").GetComponent<EnemyContact>().delete_on && !GameObject.Find("player").GetComponent<EnemyContact>().swap_on)
            {
                if (activeInventory == false)
                {
                    SoundEffect.SFXPlay("audioOInven");
                    activeInventory = true;
                    ClickMove.ButtonSetFalse();
                }
                else if (activeInventory == true)
                {
                    SoundEffect.SFXPlay("audioCInven");
                    activeInventory = false;
                    try
                    {
<<<<<<< HEAD
                    GameObject.Find("ToolTip_Outer").SetActive(false);
                    }
                    catch (NullReferenceException e)
                    {
                    Debug.Log("�������ϴ�. ���� �����Դϴ�.");
=======
                        GameObject.Find("ToolTip_Outer").SetActive(false);
                    }
                    catch (NullReferenceException e)
                    {
                        Debug.Log("�������ϴ�. ���� �����Դϴ�.");
>>>>>>> f9133e3071e381a27f4021ca6b84cb9fcab5d037
                    }
                }
            }
            if (enemy == true)
            {
                ClickMove.click = false;
            }
            else
            {
                if (activeInventory == false)
                {
                    ClickMove.click = true;
                    GameObject.Find("player").GetComponent<player_random>().roll = true;
                }
                else
                {
                    ClickMove.click = false;
                    GameObject.Find("player").GetComponent<player_random>().roll = false;
                }
            }
        }
    }
    public void Inven_On()
    {
        if (!GameObject.Find("player").GetComponent<EnemyContact>().delete_on && !GameObject.Find("player").GetComponent<EnemyContact>().swap_on)
        {
            if (activeInventory == false)
            {
                SoundEffect.SFXPlay("audioOInven");
                activeInventory = true;
                ClickMove.ButtonSetFalse();
            }
            else if (activeInventory == true)
            {
                SoundEffect.SFXPlay("audioCInven");
                activeInventory = false;
                try
                {
                    GameObject.Find("ToolTip_Outer").SetActive(false);
                }
                catch (NullReferenceException e)
                {
                    Debug.Log("�������ϴ�. ���� �����Դϴ�.");
                }
            }
        }
        if (enemy == true)
        {
            ClickMove.click = false;
        }
        else
        {
            if (activeInventory == false)
            {
                ClickMove.click = true;
                GameObject.Find("player").GetComponent<player_random>().roll = true;
            }
            else
            {
                ClickMove.click = false;
                GameObject.Find("player").GetComponent<player_random>().roll = false;
            }
        }
    }
}
