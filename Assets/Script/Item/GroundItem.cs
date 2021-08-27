﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GroundItem : MonoBehaviour, ISerializationCallbackReceiver
{
    public ItemObject item;

    public void OnAfterDeserialize()
    {
    }

    public void OnBeforeSerialize()
    {
        GetComponent<SpriteRenderer>().sprite = item.uiDysplay;
        EditorUtility.SetDirty(GetComponent<SpriteRenderer>());
    }
}
