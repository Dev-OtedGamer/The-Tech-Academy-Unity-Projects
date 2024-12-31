using UnityEngine;

public class Player : MonoBehaviour
{
	public float moveSpeed = 5f;
	public float jumpForce = 5f;
	private bool isGrounded = true;
	private Rigidbody rb;

	public void Start()
	{
		rb = GetComponent<Rigidbody>();
	}


	void Update()
	{
		PlayerMove();
		PlayerJump();

	}

	void PlayerMove()
	{
		float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		float moveZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

		transform.Translate(new Vector3(moveX, 0, moveZ));
	}

	void PlayerJump()
	{
		if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
			isGrounded = false;
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			isGrounded = true;
		}
	}
}
