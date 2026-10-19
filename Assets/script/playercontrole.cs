using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    private Rigidbody rb;
    private int count;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("PickUpGold"))
        {
            other.gameObject.SetActive(false);
            count = count + 5;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Pontos: " + count.ToString();
        if (count >= 22)
        {
            winTextObject.SetActive(true);
        }

    }
}