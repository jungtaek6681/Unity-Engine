using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptGameObject
{
	// GameObject : 씬을 구성하는 모든 오브젝트의 기본 클래스
	// 게임오브젝트만으로는 독자적인 기능이 없음. 실질적인 기능은 컴포넌트들이 수행
	// 게임오브젝트는 컴포넌트들을 가지기 위한 컨테이너
	// 게임오브젝트는 트랜스폼 컴포넌트를 반드시 가지며 제거할 수 없음

	public class ScriptGameObject : MonoBehaviour
	{
		private void GameObject()
		{
			/*
			 * 게임오브젝트 변수
			 * name			: 게임오브젝트의 이름
			 * activeSelf	: 게임오브젝트의 활성화 여부, 비활성화인 경우 씬에 없는 게임오브젝트로 취급됨
			 * tag			: 게임오브젝트의 태그, 게임오브젝트를 특정하기 위한 수단으로 사용
			 * layer		: 게임오브젝트의 레이어, 씬에서 게임오브젝트를 분리하는 기준 (카메라의 선별적 표현, 충돌 그룹, 레이어 마스크 등에 사용)
			 * transfrom	: 게임오브젝트에 포함된 트랜스폼 컴포넌트, 반드시 포함되어 있음
			 */

			// 게임오브젝트 함수

			// SetActive : 게임오브젝트의 활성화 여부 변경
			gameObject.SetActive(true);

			// AddComponent<{타입}>() : 게임오브젝트에 컴포넌트 추가
			gameObject.AddComponent<Transform>();
			// Transform component = new Transform();	// error, 컴포넌트가 인스턴스를 갖는 것은 의미 없음, 반드시 게임오브젝트에 부착해 놓을 것

			// transform.parent : 게임오브젝트의 계층구조 변경
			gameObject.transform.parent = null;

			// 컴포넌트 관련 함수들, 컴포넌트와 동일하게 사용 가능

			// GetComponent<{타입}>() : 게임오브젝트에서 지정한 타입의 컴포넌트를 반환 (가장먼저 발견한 컴포넌트 반환)
			Transform component = GetComponent<Transform>();

			// GetComponents<{타입}>() : 게임오브젝트에서 지정한 타입의 모든 컴포넌트들을 반환 (먼저 발견한 순서대로 반환)
			Transform[] components = GetComponents<Transform>();

			// GetComponentInChildren<{타입}>() : 게임오브젝트와 자식게임오브젝트들에서 지정한 타입의 컴포넌트를 반환 (깊이우선 탐색으로 가장먼저 발견한 컴포넌트 반환)
			component = GetComponentInChildren<Transform>();

			// GetComponentsInChildrend<{타입}>() : 게임오브젝트와 자식게임오브젝트들에서 지정한 타입의 컴포넌트들을 반환 (깊이우선 탐색순서대로 반환)
			components = GetComponentsInChildren<Transform>();

			// GetComponentInParent<{타입}>() : 게임오브젝트와 부모게임오브젝트들에서 지정한 타입의 컴포넌트를 반환 (가장먼저 발견한 컴포넌트 반환)
			component = GetComponentInParent<Transform>();

			// GetComponentsInParent<{타입}>() : 게임오브젝트와 부모게임오브젝트들에서 지정한 타입의 컴포넌트들을 반환  (먼저 발견한 순서대로 반환)
			components = GetComponentsInParent<Transform>();
		}
	}

}
