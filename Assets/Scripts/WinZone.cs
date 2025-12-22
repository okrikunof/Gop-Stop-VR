using UnityEngine;

public class WinZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Untagged"))
        {
            Debug.Log("НЕФОР ПОБЕДИЛ");
            // здесь позже будет конец игры
        }
    }
}
