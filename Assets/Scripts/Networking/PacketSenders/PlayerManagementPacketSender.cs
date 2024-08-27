// ================================================================================================================================
// File:        PlayerManagementPacketSender.cs
// Description:	Sends packets to the game server providing our local character controllers updated position values
// Author:	    Harley Laurie https://www.github.com/Swaelo/
// ================================================================================================================================

using System;
using UnityEngine;

public class PlayerManagementPacketSender : MonoBehaviour
{
    //Singleton Instance
    public static PlayerManagementPacketSender Instance = null;
    void Awake() { Instance = this; }

    /// <summary>
    /// Sends the updated local player characters values to the game server
    /// </summary>
    /// <param name="Position">Player characters new location values</param>
    /// <param name="Movement">Player characters new movement input values</param>
    /// <param name="Rotation">Player characters new rotation values</param>
    public void SendLocalPlayerCharacterUpdate(Vector3 Position, Vector3 Movement, Quaternion Rotation)
    {
        //Log a message showing what packet is being sent out
        Log.Out("Local Player Character Update");

        ////Create a new network packet to store all the update values, first add in the packet type enumerator
        //NetworkPacket Packet = new NetworkPacket();
        //Packet.WriteType(ClientPacketType.PlayerCharacterUpdate);

        ////Now fill in all the values that were passed into this function
        //Packet.WriteVector3(Position);
        //Packet.WriteVector3(Movement);
        //Packet.WriteQuaternion(Rotation);

        ////Queue the packet ready for transmission
        //ConnectionManager.Instance.PacketQueue.QueuePacket(Packet);

        SendPlayerPositionUpdate(Position);
        SendPlayerRotationUpdate(Rotation);
    }

    public void SendPlayerPositionUpdate(Vector3 Position)
    {
        NetworkPacket Packet = new NetworkPacket();
        Packet.WriteType(ClientPacketType.PlayerPositionUpdate);
        Packet.WriteVector3(Position);
        ConnectionManager.Instance.PacketQueue.QueuePacket(Packet);
    }

    public void SendPlayerRotationUpdate(Quaternion Rotation)
    {
        NetworkPacket Packet = new NetworkPacket();
        Packet.WriteType(ClientPacketType.PlayerRotationUpdate);
        Packet.WriteQuaternion(Rotation);
        ConnectionManager.Instance.PacketQueue.QueuePacket(Packet);
    }

    /// <summary>
    /// Sends the updated local player cameras values to the game server
    /// </summary>
    /// <param name="Zoom">Player cameras new zoom level</param>
    /// <param name="XRotation">Player cameras new x rotation value</param>
    /// <param name="YRotation">Player cameras new y rotation value</param>
    public void SendLocalPlayerCameraUpdate(float Zoom, float XRotation, float YRotation)
    {
        //Log a message showing what packet is going out
        Log.Out("Local Player Camera Update");

        //Create a new packet with the type enumerator in it
        NetworkPacket Packet = new NetworkPacket();
        Packet.WriteType(ClientPacketType.PlayerCameraUpdate);

        //Fill in all the values that it needs
        Packet.WriteFloat(Zoom);
        Packet.WriteFloat(XRotation);
        Packet.WriteFloat(YRotation);

        //Queue the packet for transmission
        ConnectionManager.Instance.PacketQueue.QueuePacket(Packet);
    }

    public void SendPlayAnimationAlert(string AnimationName)
    {
        Log.Out("Local Player Play Animation Alert");
        NetworkPacket Packet = new NetworkPacket();
        Packet.WriteType(ClientPacketType.PlayAnimationAlert);
        Packet.WriteString(AnimationName);
        ConnectionManager.Instance.PacketQueue.QueuePacket(Packet);
    }
}
