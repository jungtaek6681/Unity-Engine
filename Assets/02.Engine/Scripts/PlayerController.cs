using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine
{
	public class PlayerController : MonoBehaviour
	{
		public Rigidbody rigid;

		public float movePower = 10f;
		public float jumpPower = 10f;

		private void Update()
		{
			Move();
			Jump();
		}

		private void Move()
		{
			if (Input.GetKey(KeyCode.LeftArrow))
				rigid.AddForce(Vector3.left * movePower * Time.deltaTime, ForceMode.Impulse);

			if (Input.GetKey(KeyCode.RightArrow))
				rigid.AddForce(Vector3.right * movePower * Time.deltaTime, ForceMode.Impulse);

			if (Input.GetKey(KeyCode.UpArrow))
				rigid.AddForce(Vector3.forward * movePower * Time.deltaTime, ForceMode.Impulse);

			if (Input.GetKey(KeyCode.DownArrow))
				rigid.AddForce(Vector3.back * movePower * Time.deltaTime, ForceMode.Impulse);
		}

		private void Jump()
		{
			if (Input.GetKeyDown(KeyCode.Space))
				rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
		}
	}
}

