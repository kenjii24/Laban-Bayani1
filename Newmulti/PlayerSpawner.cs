using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject[] playerPrefabs;
    public Transform[] spawnPoints;
 

    camerafollowmulti camerafollow;

    void Awake()
    {
      
        camerafollow = FindObjectOfType<camerafollowmulti>();
      
    }
    private void Start()
    {
        int randomNumber = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomNumber];

        GameObject playerToSpawn = playerPrefabs[(int)PhotonNetwork.LocalPlayer.CustomProperties["playerAvatar"]];
        GameObject player = PhotonNetwork.Instantiate(playerToSpawn.name,spawnPoint.position,Quaternion.identity);
       

        camerafollow.SetCameraTarget(player.transform);
        
        // GameObject Player;
        // GameObject Player2;


        //if (PhotonNetwork.IsMasterClient)
        // {
        //    Player =  PhotonNetwork.Instantiate(playerPrefabs[0].name, spawnPoint.position, Quaternion.identity);
        //     camerafollow.SetCameraTarget(Player.transform);

        // }
        // else
        //  {
        //     Player2 = PhotonNetwork.Instantiate(playerPrefabs[1].name, spawnPoint.position, Quaternion.identity);

        //     camerafollow.SetCameraTarget(Player2.transform);
        // }

    }
    
}
 