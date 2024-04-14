using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    private void Awake() => Instance = this;

    public event Action<int> OnReposition;
    public event Action OnSeekPlayer;
    public event Action OnSelectSkin;
    public void Reposition(int id) => OnReposition?.Invoke(id);
    public void SeekPlayer() => OnSeekPlayer?.Invoke();
    public void SelectSkin() => OnSelectSkin?.Invoke();
}
