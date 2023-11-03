using UnityEngine;

public class CharacterFloorTrigger : MonoBehaviour
{
    public bool IsOnFloor { get; private set; }

    private void OnTriggerStay(Collider other)
    {
        if (!IsOnFloor)
        {
            AudioManager.Instance.PlaySFX("Jump End");
            Debug.Log("Vient de toucher le sol");
        }
        IsOnFloor = true;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Vient de quitter le sol");
        IsOnFloor = false;
    }
}
