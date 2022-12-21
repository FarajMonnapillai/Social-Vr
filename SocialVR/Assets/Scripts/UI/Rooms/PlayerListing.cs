using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListing : MonoBehaviour
{
    [SerializeField]
    private Text _text;

    private Player _player;

    public Player Player {get; private set;}

    public void SetPlayerInfo(Player player)
    {
        _player = player;
        _text.text = player.NickName;
    }
}