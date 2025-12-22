using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GeneratorBatterySocket : MonoBehaviour
{
    public Generator generator;

    void Awake()
    {
        var socket = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor>();
        socket.selectEntered.AddListener(OnBatteryInserted);
    }

    void OnBatteryInserted(SelectEnterEventArgs args)
    {
        Debug.Log("Батарейка вставлена");

        generator.batteryInserted = true;
        generator.CheckGenerator();
    }
}
