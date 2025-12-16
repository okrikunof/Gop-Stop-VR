using UnityEngine;

public class GeneratorManager : MonoBehaviour
{
    public int totalGenerators = 3;

    private int activeGenerators = 0;

    public void OnGeneratorActivated()
    {
        activeGenerators++;
        Debug.Log($"Генераторы: {activeGenerators}/{totalGenerators}");

        if (activeGenerators >= totalGenerators)
        {
            AllGeneratorsActivated();
        }
    }

    void AllGeneratorsActivated()
    {
        Debug.Log("ВСЕ ГЕНЕРАТОРЫ АКТИВНЫ");
        // сюда позже подключим ворота
    }
}
