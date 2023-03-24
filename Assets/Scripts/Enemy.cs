using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	private GridManager gridmanager;
	void	Start()
	{
		gridmanager = FindObjectOfType<GridManager>();
		string[] map = gridmanager.Map;
		transform.Translate(0, 1, 0);
	}
	void	Update()
	{
		transform.position += new Vector3(0, 2, 0) * Time.deltaTime;
	}
	// public void moveEnemy()
	// {

	// }
}
