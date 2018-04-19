using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public CharacterController characterController;
    public Rigidbody Controller;
    public VirtualJoystick VirtualJoystick;
	public GameObject BellCanvas;

    private Transform _camTransform;

    public float MoveSpeed = 5.0f;
    public float drag = 0.5f;
    public float TerminalRotationSpeed = 25.0f;

	public LayerMask Ground;
	private bool _isGrounded = true;
	private Transform _groundChecker;
	public float GroundDistance = 0.2f;
	private Vector3 _velocity;
	public Vector3 Drag;
	public float Gravity = -9.81f;

	public Animator _animationModel;
	public bool interacting;


	void Start () {
        Controller.maxAngularVelocity = TerminalRotationSpeed;
        Controller.drag = drag;

        _camTransform = Camera.main.transform;

		_groundChecker = transform.GetChild(0);
    }
	
	void Update () 
	{
		_isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);
		if (_isGrounded && _velocity.y < 0)
			_velocity.y = 0f;


        Vector3 dir = Vector3.zero;
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        if (dir.magnitude > 1) {
            dir.Normalize();
        }


        if (VirtualJoystick.InputVector != Vector3.zero) {
            dir = VirtualJoystick.InputVector;
        }

        Vector3 rotatedDir = _camTransform.TransformDirection(dir);
        rotatedDir = new Vector3(rotatedDir.x, 0, rotatedDir.z);
        rotatedDir = rotatedDir.normalized * dir.magnitude;

		//Controller.GetComponent<Rigidbody>().MovePosition(rotatedDir * MoveSpeed);
		characterController.Move (rotatedDir * MoveSpeed);

		if (rotatedDir != Vector3.zero)
			transform.forward = rotatedDir;

		_velocity.y += Gravity * Time.deltaTime;

		_velocity.x /= 1 + Drag.x * Time.deltaTime;
		_velocity.y /= 1 + Drag.y * Time.deltaTime;
		_velocity.z /= 1 + Drag.z * Time.deltaTime;

		characterController.Move(_velocity * Time.deltaTime);

		if (VirtualJoystick.InputVector != Vector3.zero) 
		{
			Debug.Log ("Moving");
			if (!_animationModel.GetCurrentAnimatorStateInfo (0).IsName ("walk"))
				_animationModel.Play ("walk");
		}
		else
		{
			Debug.Log ("Not Moving");
			if (!_animationModel.GetCurrentAnimatorStateInfo (0).IsName ("idle"))
				_animationModel.Play ("idle");
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.transform.tag == "InfoCollider") {
			//VirtualJoystick.gameObject.SetActive (false);
			BellCanvas.SetActive (true);
		}
	}

	void OnControllerColliderHit(ControllerColliderHit hit) 
	{
		if (hit.gameObject.tag == "NPC" && !hit.gameObject.GetComponent<NPC>().iInteracted) 
		{
			hit.gameObject.SendMessage ("PlayerInnterrogation", this.gameObject);
		}
	}



	public void SetDeactiveAnimator()
	{
		StartCoroutine (deactivation ());
	}


	IEnumerator deactivation()
	{
		yield return new WaitForSeconds (2.1f);
		VirtualJoystick.gameObject.SetActive (true);
		GetComponentInParent<Animator> ().enabled = false;
		_camTransform.GetComponent<CompleteProject.CameraFollow> ().enabled = true;

	}


}