using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private SpriteRenderer sr;
    private UIManager ui;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        SetRandomColor();
        ui = FindObjectOfType<UIManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        SpriteRenderer gateSR = other.GetComponent<SpriteRenderer>();
        if (gateSR != null)
        {
            string playerColor = ColorUtility.ToHtmlStringRGB(sr.color);
            string gateColor = ColorUtility.ToHtmlStringRGB(gateSR.color);

            if (playerColor == gateColor)
            {
                ui.AddScore();
            }
            else
            {
                ui.ShowResult("Game Over");
            }
        }
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        transform.Translate(moveX * moveSpeed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetRandomColor();
        }
    }

    void SetRandomColor()
    {
        int random = Random.Range(0, 3); // 0, 1, or 2

        if (random == 0)
            sr.color = Color.red;
        else if (random == 1)
            sr.color = Color.green;
        else
            sr.color = Color.blue;
    }
}