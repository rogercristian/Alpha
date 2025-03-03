using Cinemachine;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    [SerializeField] List<Room> rooms;
    [SerializeField] CinemachineTargetGroup targetGroup;

   [field:SerializeField] private Room currentRoom;

    public Room CurrentRoom {
        get { return currentRoom; } 
        set
        {
            currentRoom?.DisableCamera();
            currentRoom = value;
            currentRoom.EnableCamera(targetGroup.transform);
        }
    }
    private void Awake() => instance = this;

    private void Start()
    {
        rooms.ForEach(room => room.OnRoomChange += HandlerRoomChange);
    }
    private void OnDestroy()
    {
        rooms.ForEach(room => room.OnRoomChange -= HandlerRoomChange);

    }
    private void HandlerRoomChange(Room room)
    {
        CurrentRoom = room;
    }
}
