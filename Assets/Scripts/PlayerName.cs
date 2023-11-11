using Mirror;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : NetworkBehaviour
{
    [SerializeField] TMP_Text playerNicknameText;
    [SyncVar(hook =nameof(ChangeNameHandler))] string playerNickname;
    public override void OnStartServer()
    {
        playerNickname = "Player" + connectionToClient.connectionId;
    }
    private void ChangeNameHandler(string oldValue, string newValue)
    {
        playerNicknameText.text = playerNickname;
    }


}
