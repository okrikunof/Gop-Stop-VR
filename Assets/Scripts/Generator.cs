using UnityEngine;

public class Generator : MonoBehaviour
{
    public bool buttonDone;
    public bool batteryInserted;

    public GeneratorManager manager;

    private bool activated;

    public void CheckGenerator()
    {
        if (activated) return;

        if (buttonDone && batteryInserted)
        {
            activated = true;
            Debug.Log($"{name} запущен");

            manager.OnGeneratorActivated();
        }
    }
}
