using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    private float minX, maxX;

    void Start() {
        if(CompareTag("Cat"))
        {
            minX = -2.2f;
            maxX = 1.4f;
        }
        else if (CompareTag("Elephant"))
        {
            minX = 0.1f;
            maxX = 2.6f;
        }
        else if (CompareTag("Tiger"))
        {
            minX = -0.8f;
            maxX = 2.4f;
        }
        else
        {

            minX = -1.8f;
            maxX = 1.8f;
        }
    }

    void Update() {
        Vector3 temp = transform.position;
        if (temp.x > maxX) {
            temp.x = maxX;
		}
        if (temp.x < minX) {
            temp.x = minX;
		}
        transform.position = temp;
    }
}
