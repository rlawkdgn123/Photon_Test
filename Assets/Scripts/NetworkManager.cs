using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class NetworkManager : MonoBehaviourPunCallbacks // MonoBehaviour + Photon�� PunCallbacks �Բ� ���� (�������̵� �޼��� ���)
{
    void Awake()
    {
        PhotonNetwork.ConnectUsingSettings(); // ���� ���� ���� ������ ������� ������ �������ش�.
    }

    public override void OnConnectedToMaster() { // ���� �� �ڵ������
        Debug.Log("Connected");
    }

}
