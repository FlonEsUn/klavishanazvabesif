using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardInput : MonoBehaviour
{
    private Keyboard _keyboard;

    private void Awake()
    {
        _keyboard = InputSystem.GetDevice<Keyboard>();
    }

    private void Update()
    {
        foreach (var key in _keyboard.allKeys)
        {
            if (!key.wasPressedThisFrame) continue;
            Debug.Log($"������ {key.displayName} ���� ���������");
        }
    }
}
