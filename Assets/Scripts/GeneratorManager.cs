using UnityEngine;

public class GeneratorManager : MonoBehaviour
{
    public int totalGenerators = 3;
    private int activeGenerators = 0;

    public GameObject winTrigger;

    public void OnGeneratorActivated()
    {
        activeGenerators++;
        Debug.Log($"Генераторы активированы: {activeGenerators}/{totalGenerators}");

        if (activeGenerators >= totalGenerators)
        {
            AllGeneratorsActivated();
        }
    }

    void AllGeneratorsActivated()
    {
        Debug.Log("ВСЕ ГЕНЕРАТОРЫ АКТИВНЫ");

        winTrigger.SetActive(true);
    }
}
