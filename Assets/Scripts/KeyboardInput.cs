using System;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    public event Action SpaceKeyDown;
    public event Action QKeyDown;
    public event Action EKeyDown;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SpaceKeyDown?.Invoke();

        if (Input.GetKeyDown(KeyCode.Q))
            QKeyDown?.Invoke();

        if (Input.GetKeyDown(KeyCode.E))
            EKeyDown?.Invoke();
    }
}
