using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Engine
{
	// MonoBehaviour
	// ��� ����Ƽ ��ũ��Ʈ�� ����ϴ� �⺻ Ŭ����
	// ������Ʈ, �̺�Ʈ, �ڷ�ƾ�� ����� �����ϰ� ����

	// �̺�Ʈ : ��ũ��Ʈ�� ���� ���ԵǾ� �ִ� ��� ����Ƽ �޽����� �����ϴ� �Լ�
	public class ScriptEventFunc : MonoBehaviour
	{
		private void Awake()
		{
			// ��ũ��Ʈ�� ���� ���ԵǾ��� �� 1ȸ ȣ��Ǵ� �Լ�
			// ��ũ��Ʈ�� ������ �ִ� ���ӿ�����Ʈ�� �ʱ�ȭ �Ǿ��� �� ȣ���
			// ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ� �ִ� ��쿡�� ȣ���

			// ���� : ���� �Ǵ� ���¸� �ʱ�ȭ �۾� ����
			Debug.Log("Awake");
		}

		private void OnEnable()
		{
			// ��ũ��Ʈ�� Ȱ��ȭ�� ������ ȣ��

			// ���� : ��ũ��Ʈ�� Ȱ��ȭ �Ǿ��� �� �۾� ����
			Debug.Log("OnEnable");
		}

		private void Start()
		{
			// ��ũ��Ʈ�� ���� ó������ Update�ϱ� ������ 1ȸ ȣ���
			// ��ũ��Ʈ�� ��Ȱ��ȭ�� ��� ȣ����� ����

			// ���� : 1. Awake���� �ʱ�ȭ�� ����� �ʿ��� �ʱ�ȭ �۾��� ����
			//		  2. �ڷ�ƾ ����
			Debug.Log("Start");
		}

		private void Update()
		{
			// ������ �����Ӹ��� ȣ��

			// ���� : �ٽ� ���� ���� ����
			Debug.Log("Update");
		}

		private void LateUpdate()
		{
			// ���� ��� ���ӿ�����Ʈ�� Update�� ����� �� ȣ��

			// ���� : ������������ ���� ����� �ʿ��� ������ �ִ� ��� ����
			// ex) �÷��̾��� ��ġ�� ������ �Ŀ� ī�޶��� ��ġ ����
			Debug.Log("LateUpdate");
		}

		private void FixedUpdate()
		{
			// ����Ƽ�� �������� �����ð����� ȣ�� (�⺻ 1�ʿ� 50��)
			// Update�� �ٸ��� �����Ӵ� ����� �����ð��� ����

			// ���� : �����ð��� �־ ������ �޾Ƽ��� �ȵǴ� �۾�
			Debug.Log("FixedUpdate");
		}

		private void OnDisable()
		{
			// ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ȣ��

			// ���� : ��ũ��Ʈ�� ��Ȱ��ȭ �Ǿ��� �� �۾� ����
			Debug.Log("OnDisable");
		}

		private void OnDestroy()
		{
			// ��ũ��Ʈ�� �����Ǿ��� ��� ȣ��

			// ���� : ��ũ��Ʈ�� ������ ����
			Debug.Log("OnDestory");
		}
	}
}
