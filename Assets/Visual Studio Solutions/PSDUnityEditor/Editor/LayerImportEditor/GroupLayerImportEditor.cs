﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

namespace PSDUnity.UGUI
{
    [CustomEditor(typeof(GroupLayerImport))]
    public class GroupLayerImportEditor : UGUI.LayerImportEditor
    {
        public override Texture Icon
        {
            get
            {
                return EditorGUIUtility.IconContent("GridLayoutGroup Icon").image;
            }
        }
    }
}
