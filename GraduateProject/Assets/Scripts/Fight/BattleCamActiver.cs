using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleCamActiver : MonoBehaviour
{
    string EStringname;
    public int Ename;
    public Button dice;
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            EStringname = gameObject.name;
            Ename = int.Parse(EStringname);
            Destroy(gameObject);
            GameObject.Find("CameraManager").GetComponent<CameraManager>().subCameraOn();
            GameObject.Find("player").GetComponent<PlayerClickItem>().enabled = false;
            GameObject.Find("Dice 1").gameObject.SetActive(false);
<<<<<<< HEAD
            GameObject.Find("HP_MP_GUI").gameObject.SetActive(false);
=======
>>>>>>> f9133e3071e381a27f4021ca6b84cb9fcab5d037
            GameObject.Find("BattleSYSTEM").transform.Find("Battle System").gameObject.SetActive(true);
            GameObject.Find("Battle System").GetComponent<BattleSystem>().i = Ename;
            GameObject.Find("Battle System").GetComponent<BattleSystem>().StartBattle();
            Debug.Log("��������");
            GameObject.Find("player").GetComponent<Click_Move>().click = false;
            GameObject.Find("player").GetComponent<player_random>().roll = false;
        }
    }
}
