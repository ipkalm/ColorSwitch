using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static int score = 0;

    public string curColor;
    public float jumpForce = 7f;

    public Text scoreText;
    public Rigidbody2D circle;
    public SpriteRenderer sr;
    public GameObject obsticle;
    public GameObject colorChanger;

    public Color purple;
    public Color yellow;
    public Color green;
    public Color red;

    // Use this for initialization
    void Start()
    {
        SetRanomColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            circle.velocity = Vector2.up * jumpForce;
        }
        scoreText.text = score.ToString();

        if(circle.transform.position.y < -10.0f)
        {
            Die();
        }
    }

    private void SetRanomColor()
    {
        int random = Random.Range(0, 4);

        switch (random)
        {
            case 0:
                curColor = "Purple";
                sr.color = purple;
                break;
            case 1:
                curColor = "Yellow";
                sr.color = yellow;
                break;
            case 2:
                curColor = "Green";
                sr.color = green;
                break;
            case 3:
                curColor = "Red";
                sr.color = red;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            score++;
            Destroy(collision.gameObject);
            Instantiate(obsticle, new Vector2(transform.position.x, transform.position.y + 8.5f), transform.rotation);
            return;
        }

        if (collision.tag == "ColorChanger")
        {
            SetRanomColor();
            Destroy(collision.gameObject);
            Instantiate(colorChanger, new Vector2(transform.position.x, transform.position.y + 8.5f), transform.rotation);
            return;
        }

        if (collision.tag != curColor)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("DIE");
        score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
