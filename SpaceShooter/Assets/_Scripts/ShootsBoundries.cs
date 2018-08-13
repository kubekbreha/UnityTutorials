using UnityEngine;

public class ShootsBoundries : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.transform.parent.gameObject);
    }
}
