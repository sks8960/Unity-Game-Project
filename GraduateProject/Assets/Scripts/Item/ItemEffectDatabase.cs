using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffectDatabase : MonoBehaviour
{
    [SerializeField]
    private ArtifactDescription theSlotToolTip;

    public void ShowToolTip(Item _item, Vector3 _pos)
    {
        theSlotToolTip.ShowToolTip(_item, _pos);
    }

    public void HideToolTip()
    {
        theSlotToolTip.HideToolTip();
    }
}
