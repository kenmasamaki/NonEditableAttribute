using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonEditableAttributeSample : MonoBehaviour
{
	[NonEditable]
	public int number = 1;

	[NonEditable]
	public float value = 3.14f;

	[NonEditable]
	public bool isActive = true;

	[NonEditable]
	public Vector2 vector2 = new Vector2(1.0f, 2.0f);

	[NonEditable]
	public Vector3 vector3 = new Vector3(1.0f, 2.0f, 3.0f);

	[NonEditable]
	public Color color = Color.magenta;

	[NonEditable]
	public string text = "Hello, World!";
}
