using UnityEngine;

public class Node : MonoBehaviour
{
	public Color hoverColor;

	Renderer rend;
	Color startColor;

	void Start()
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
	}

	void OnMouseEnter()
	{
		rend.material.color = hoverColor;
	}

	void OnMouseExit()
	{
		rend.material.color = startColor;
	}
}
