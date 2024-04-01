using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RepositionPlayer : MonoBehaviour
{
    [SerializeField] private int id ;
    private void OnEnable()
    {
        id = PlayerInputManager.instance.playerCount;
        GameEvents.Instance.Reposition(id);
        GameEvents.Instance.SeekPlayer();
        //id = PlayerInputManager.instance.playerCount;
    }
   
}
