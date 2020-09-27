using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class script : MonoBehaviour
{
	public Button Button1;

	void Start()
	{
		Button btn = Button1.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
	}
}
