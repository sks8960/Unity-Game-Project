using UnityEngine;
using System;

// Project Ã¢ï¿½ï¿½ï¿½ï¿½ Item ï¿½ï¿½Ã¼ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½Ö´ï¿½ ï¿½ï¿½Å©ï¿½ï¿½Æ®
[CreateAssetMenu]
[System.Serializable]

public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public Item item;
    
    [TextArea]  // ¿©·¯ ÁÙ °¡´ÉÇØÁü
    public string itemDesc; // ¾ÆÀÌÅÛÀÇ ¼³¸í

    public string abc;

    [TextArea]
    public string itemDesc;
    
    public string rank;
    public string condition;
    public string tag; // ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½
}