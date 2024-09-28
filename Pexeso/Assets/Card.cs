using UnityEngine;

public class Card : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(Vector3.up, 180);
    }

    private void OnMouseDown()
    {
        transform.Rotate(Vector3.up, 180);
    }
}
