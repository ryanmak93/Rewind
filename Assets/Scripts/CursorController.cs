// Author: Shi Yin, Kamil Piekutowski
// Date: 2/9/2016
// This script is responsible for switching cursor texture upon hovering over specific areas

using UnityEngine;
using System.Collections;

public class CursorController : MonoBehaviour {
	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;
	// Use this for initialization
	void Start () {
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);

	}

	// Update is called once per frame
	void Update () {

	}


	void OnMouseEnter()
	{
		
	}
	void OnMouseExit()
	{
		Cursor.SetCursor(null, Vector2.zero, cursorMode);
	}
}
