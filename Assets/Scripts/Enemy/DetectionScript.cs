using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectionScript : MonoBehaviour
{
    private GameObject player;
    private Collider2D playerCollider;

	[SerializeField] private LayerMask playerLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerCollider = player.GetComponent<Collider2D>();
    }

    private void OnTriggerStay2D(Collider2D plc)
    {
		print(plc);
		//if (playerCollider == plc){ // Check if Collider is the player.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		//}
    }
}
