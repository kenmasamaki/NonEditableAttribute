# NonEditableAttribute

NonEditableAttributeは、Unityのインスペクター上でフィールドを編集不可にするカスタム属性です。  
`NonEditable` 属性をフィールドに付与することで、インスペクター上で値の表示のみが可能となり、編集できなくなります。

<img width="50%" alt="スクリーンショット 2026-01-30 123031" src="https://github.com/user-attachments/assets/74d491d5-ce20-4c84-9b19-83660054a3d7" />


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
