using UnityEngine;

public class Remover : MonoBehaviour
{
    [SerializeField] private Transform planeTransform;
    private void OnTriggerEnter(Collider other)
    {
        if (Mathf.Abs(other.gameObject.transform.position.x - planeTransform.position.x) <
            planeTransform.localScale.x / 2)
        {
            ScoreManager.Score += 3;
        }
        Destroy(other);
    }
}
