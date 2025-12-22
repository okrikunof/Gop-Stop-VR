using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GeneratorButton : MonoBehaviour
{
    public Generator generator;
    private bool pressed;

    void Awake()
    {
        var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.activated.AddListener(OnActivated);
    }

    void OnActivated(ActivateEventArgs args)
    {
        if (pressed) return;

        // 1. Проверка батарейки
        if (!generator.batteryInserted)
        {
            Debug.Log("Сначала вставьте батарейку в генератор");
            return;
        }

        // 2. Кнопка срабатывает
        pressed = true;
        Debug.Log("Кнопка генератора нажата");

        generator.buttonDone = true;
        generator.CheckGenerator();
    }
}
