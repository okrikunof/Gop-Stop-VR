using UnityEngine;


public class Generator : MonoBehaviour
{
    public GeneratorManager manager;
    public UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;

    private bool activated;

    void Start()
    {
        Debug.Log("Generator Start called");

        if (interactable == null)
        {
            Debug.LogError("Interactable НЕ назначен!");
            return;
        }

        interactable.selectEntered.AddListener(_ => Activate());
    }

    void Activate()
    {
        if (activated) return;

        activated = true;
        Debug.Log($"{name} активирован");
        manager.OnGeneratorActivated();
    }
}
