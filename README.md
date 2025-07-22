# NonEditableAttribute

NonEditableAttributeは、Unityのインスペクター上でフィールドを編集不可にするカスタム属性です。  
`NonEditable` 属性をフィールドに付与することで、インスペクター上で値の表示のみが可能となり、編集できなくなります。

![Image](https://github-production-user-asset-6210df.s3.amazonaws.com/124390814/469060407-4537023c-4e81-450e-93ab-cb4db4087445.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20250722%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20250722T075202Z&X-Amz-Expires=300&X-Amz-Signature=2026bce72f31ac9b19bf55de77c572b01ed9daec58f40b541ba3d5e076417c07&X-Amz-SignedHeaders=host)

## 特長

- Unityエディターのインスペクターで値を表示専用にできる
- さまざまな型（int, float, bool, Vector2, Vector3, Color, string など）に対応
- 誤操作による値の変更を防止

## 使用例

```csharp
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
```

上記のように、`NonEditable` 属性を付与したフィールドはインスペクター上で編集できなくなり、値の確認のみが可能です。
