using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToastManager : Singleton<ToastManager> 
{
	public GameObject ToastPrefab;

	RectTransform _objectRef;


	public void Toaster()
	{
		Debug.Log("Show Toast Called");
		ShowToast("Template Toast Created Without Data, Going to destroy after 2 sec");
	}

	public void ShowToast(string text, float duration = 2)
	{
		_objectRef = Instantiate(ToastPrefab).GetComponent<RectTransform>();
		_objectRef.SetParent(transform.GetComponentInChildren<GridLayoutGroup>().transform);

		_objectRef.anchorMin = Vector2.zero;
		_objectRef.anchorMax = new Vector2(1,0);
		_objectRef.pivot = new Vector2(0.5f,0);
		_objectRef.localPosition = Vector3.zero;
		_objectRef.anchoredPosition = Vector2.zero;
		_objectRef.localRotation = Quaternion.identity;
		_objectRef.localScale = Vector3.one;
		_objectRef.GetComponentInChildren<Text>().text = text;
		Destroy(_objectRef.gameObject,duration);
	} 
//
//
//	IEnumerator DestroyAfter(float time)
//	{
//		yield return new WaitForSeconds(time);
//
//		Dest
//	}
}
