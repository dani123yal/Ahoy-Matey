using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkManager : NetworkManager
{
    private NetworkManager networkManager;
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MyStartHost()
    {
        Debug.Log("Starting host at: " + Time.timeSinceLevelLoad);
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log("host started at:" + Time.timeSinceLevelLoad);
    }
}
