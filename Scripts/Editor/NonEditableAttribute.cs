using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#if UNITY_EDITOR
using UnityEditor;
#endif



/// <summary>
/// インスペクタ上で編集不可にするための属性 <para/>
/// この属性を付与されたフィールドは、Unityエディタのインスペクタ上で編集できなくなります。
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class NonEditableAttribute : PropertyAttribute
{
}

#if UNITY_EDITOR
/// <summary>
/// インスペクタ上で編集不可にするためのPropertyDrawer <para/>
/// このPropertyDrawerは、NonEditableAttributeが付与されたフィールドに対して適用されます。
/// </summary>
[CustomPropertyDrawer(typeof(NonEditableAttribute))]
public class NonEditableAttributeDrawer : PropertyDrawer
{
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		GUI.enabled = false;
		EditorGUI.PropertyField(position, property, label, true);
		GUI.enabled = true;
	}

	/// <summary>
	/// プロパティの高さを調整する
	/// </summary>
	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		return EditorGUI.GetPropertyHeight(property, label, true);
	}
}
#endif

