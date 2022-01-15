﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RoomItem : MonoBehaviour
{
    public Text roomName;
    LobbyManagerr manager;

    private void Start()
    {
        manager = FindObjectOfType<LobbyManagerr>();
    }
    public void SetRoomName(string _roomName)
    {
        roomName.text = _roomName;
    }

    public void OnClickItem()
    {
        manager.JoinRoom(roomName.text);
    }
}
