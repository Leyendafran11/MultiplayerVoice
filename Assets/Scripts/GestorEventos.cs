using Fusion;
using Fusion.Sockets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestorEventos : MonoBehaviour, INetworkRunnerCallbacks
{

	public GameObject playerPrefab;

	

	private InputData inputData;

	


	public void OnConnectedToServer(NetworkRunner runner)
	{
		
	}

	public void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
	{
		
	}

	public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token)
	{
		
	}

	public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
	{
		
	}

	public void OnDisconnectedFromServer(NetworkRunner runner, NetDisconnectReason reason)
	{
		
	}

	public void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
	{
		
	}

	public void OnInput(NetworkRunner runner, NetworkInput input)
	{

		

			inputData.movimiento = 0;
			inputData.rotacion = 0;
			inputData.disparo = false;

			if (Input.GetKey(KeyCode.W))
			{
				inputData.movimiento = 1;
			}
			if (Input.GetKey(KeyCode.S))
			{
				inputData.movimiento = -1;
			}

			if (Input.GetKey(KeyCode.A))
			{
				inputData.rotacion = -1;
			}

			if (Input.GetKey(KeyCode.D))
			{
				inputData.rotacion = 1;
			}
			if (Input.GetMouseButtonDown(0))
			{
				inputData.disparo = true;
			}
			if (Input.GetKey(KeyCode.H))
			{
				inputData.hablar = true;
			}

			input.Set(inputData);
		


	}

	public void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
	{
		
	}

	public void OnObjectEnterAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player)
	{
		
	}

	public void OnObjectExitAOI(NetworkRunner runner, NetworkObject obj, PlayerRef player)
	{
		
	}

	public void OnPlayerJoined(NetworkRunner runner, PlayerRef player)
	{
		if (runner.IsServer)
		{
			Debug.Log(player.PlayerId);

			if (player.PlayerId == 1)
			{
				NetworkObject p = runner.Spawn(playerPrefab, new Vector3(7.67000008f, 10f, -7.82999992f), Quaternion.identity, player);
				
			}
			else
			{
				NetworkObject p = runner.Spawn(playerPrefab, new Vector3(-8.39999962f, 10f, 9.06000042f), Quaternion.identity, player);
				
			}

			
		}

		
	}

	public void OnPlayerLeft(NetworkRunner runner, PlayerRef player)
	{
		
	}

	public void OnReliableDataProgress(NetworkRunner runner, PlayerRef player, ReliableKey key, float progress)
	{
		
	}

	public void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ReliableKey key, ArraySegment<byte> data)
	{
		
	}

	public void OnSceneLoadDone(NetworkRunner runner)
	{
		
		
	}

	public void OnSceneLoadStart(NetworkRunner runner)
	{
		
	}

	public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
	{
		
	}

	public void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
	{
		
	}

	public void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message)
	{
		
	}
}
