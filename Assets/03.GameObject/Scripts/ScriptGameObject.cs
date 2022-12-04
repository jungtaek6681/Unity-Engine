using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptGameObject
{
	// GameObject : ���� �����ϴ� ��� ������Ʈ�� �⺻ Ŭ����
	// ���ӿ�����Ʈ�����δ� �������� ����� ����. �������� ����� ������Ʈ���� ����
	// ���ӿ�����Ʈ�� ������Ʈ���� ������ ���� �����̳�
	// ���ӿ�����Ʈ�� Ʈ������ ������Ʈ�� �ݵ�� ������ ������ �� ����

	public class ScriptGameObject : MonoBehaviour
	{
		private void GameObject()
		{
			/*
			 * ���ӿ�����Ʈ ����
			 * name			: ���ӿ�����Ʈ�� �̸�
			 * activeSelf	: ���ӿ�����Ʈ�� Ȱ��ȭ ����, ��Ȱ��ȭ�� ��� ���� ���� ���ӿ�����Ʈ�� ��޵�
			 * tag			: ���ӿ�����Ʈ�� �±�, ���ӿ�����Ʈ�� Ư���ϱ� ���� �������� ���
			 * layer		: ���ӿ�����Ʈ�� ���̾�, ������ ���ӿ�����Ʈ�� �и��ϴ� ���� (ī�޶��� ������ ǥ��, �浹 �׷�, ���̾� ����ũ � ���)
			 * transfrom	: ���ӿ�����Ʈ�� ���Ե� Ʈ������ ������Ʈ, �ݵ�� ���ԵǾ� ����
			 */

			// ���ӿ�����Ʈ �Լ�

			// SetActive : ���ӿ�����Ʈ�� Ȱ��ȭ ���� ����
			gameObject.SetActive(true);

			// AddComponent<{Ÿ��}>() : ���ӿ�����Ʈ�� ������Ʈ �߰�
			gameObject.AddComponent<Transform>();
			// Transform component = new Transform();	// error, ������Ʈ�� �ν��Ͻ��� ���� ���� �ǹ� ����, �ݵ�� ���ӿ�����Ʈ�� ������ ���� ��

			// transform.parent : ���ӿ�����Ʈ�� �������� ����
			gameObject.transform.parent = null;

			// ������Ʈ ���� �Լ���, ������Ʈ�� �����ϰ� ��� ����

			// GetComponent<{Ÿ��}>() : ���ӿ�����Ʈ���� ������ Ÿ���� ������Ʈ�� ��ȯ (������� �߰��� ������Ʈ ��ȯ)
			Transform component = GetComponent<Transform>();

			// GetComponents<{Ÿ��}>() : ���ӿ�����Ʈ���� ������ Ÿ���� ��� ������Ʈ���� ��ȯ (���� �߰��� ������� ��ȯ)
			Transform[] components = GetComponents<Transform>();

			// GetComponentInChildren<{Ÿ��}>() : ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ�鿡�� ������ Ÿ���� ������Ʈ�� ��ȯ (���̿켱 Ž������ ������� �߰��� ������Ʈ ��ȯ)
			component = GetComponentInChildren<Transform>();

			// GetComponentsInChildrend<{Ÿ��}>() : ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ�鿡�� ������ Ÿ���� ������Ʈ���� ��ȯ (���̿켱 Ž��������� ��ȯ)
			components = GetComponentsInChildren<Transform>();

			// GetComponentInParent<{Ÿ��}>() : ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ�鿡�� ������ Ÿ���� ������Ʈ�� ��ȯ (������� �߰��� ������Ʈ ��ȯ)
			component = GetComponentInParent<Transform>();

			// GetComponentsInParent<{Ÿ��}>() : ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ�鿡�� ������ Ÿ���� ������Ʈ���� ��ȯ  (���� �߰��� ������� ��ȯ)
			components = GetComponentsInParent<Transform>();
		}
	}

}
