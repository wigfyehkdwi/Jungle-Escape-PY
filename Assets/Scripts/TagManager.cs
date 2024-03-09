using UnityEngine;
using System.Collections;
using UnityEditor;
[InitializeOnLoad]
public static class LayerUtils
{
    static LayerUtils()
    {
        CreateFalsePlatforms();
    }

    static void CreateFalsePlatforms()
    {
        SerializedObject tagManager = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
        SerializedProperty layers = tagManager.FindProperty("layers");
        layers.GetArrayElementAtIndex(8).stringValue = "FalsePlatforms";
        tagManager.ApplyModifiedProperties();
        Debug.Log("Created layer 8 named FalsePlatforms");
    }
}