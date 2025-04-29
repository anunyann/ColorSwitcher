using UnityEngine;

public class GateSpawner : MonoBehaviour
{
    public GameObject gatePrefab;
    public int numberOfGates = 100;
    public float spacing = 4f;

    void Start()
    {
        float startX = 4f;
        float y = gatePrefab.transform.position.y;

        for (int i = 0; i < numberOfGates; i++)
        {
            GameObject newGate = Instantiate(gatePrefab);
            newGate.transform.position = new Vector3(startX + i * spacing, y, 0);

            // Random color
            SpriteRenderer sr = newGate.GetComponent<SpriteRenderer>();
            int rand = Random.Range(0, 3);
            sr.color = rand == 0 ? Color.red : rand == 1 ? Color.green : Color.blue;
        }
    }
}