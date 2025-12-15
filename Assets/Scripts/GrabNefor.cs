using UnityEngine;

public class GrabNefor : MonoBehaviour
{
    public float grabTime = 2f;
    private float timer;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Nefor"))
        {
            timer += Time.deltaTime;
            Debug.Log($"Хват нефора: {timer:F2}");

            if (timer >= grabTime)
            {
                Debug.Log("ГОПНИК ПОБЕДИЛ");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Nefor"))
        {
            timer = 0f;
        }
    }
}
