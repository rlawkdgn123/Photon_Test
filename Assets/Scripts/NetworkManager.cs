using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class NetworkManager : MonoBehaviourPunCallbacks // MonoBehaviour + Photon의 PunCallbacks 함께 실행 (오버라이드 메서드 사용)
{
    void Awake()
    {
        PhotonNetwork.ConnectUsingSettings(); // 포톤 세팅 버전 내역을 기반으로 서버를 세팅해준다.
    }

    public override void OnConnectedToMaster() { // 연결 시 자동실행됨
        Debug.Log("Connected");
    }

}
