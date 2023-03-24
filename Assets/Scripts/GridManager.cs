using System.Globalization;
using System.Net.Mail;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

	public TextAsset	mapFile;
	public GameObject	wall;
	public GameObject	floor;
	public GameObject	start;
	public GameObject	end;
	public Camera		cam1;
	public Transform	cam2;
	public string[]		Map;

	void Start()
	{
		Map = mapFile.ToString().Split('\n');
		int 		Rows = Map.Length;
		int			Cols = 0;

		for (int i = 0; i < Rows; i++)
			Map[i] = Map[i].Replace("\r", "").Replace("\n", "");
		Cols = Map[0].Length;
		for (int x = 0; x < Cols; x++)
		{
			for (int y = 0; y < Rows; y++)
			{
				if (Map[y][x] == '1')
				{
					var spawnedTile = Instantiate(wall, new Vector3(x,y), Quaternion.identity);
					spawnedTile.name = $"Wall {x} {y}";
				}
				else if (Map[y][x] == '0')
				{
					var spawnedTile = Instantiate(floor, new Vector3(x,y), Quaternion.identity);
					spawnedTile.name = $"Floor {x} {y}";
				}
				else if (Map[y][x] == 'S')
				{
					var spawnedTile = Instantiate(start, new Vector3(x,y), Quaternion.identity);
					spawnedTile.name = "Start";
				}
				else if (Map[y][x] == 'E')
				{
					var spawnedTile = Instantiate(end, new Vector3(x,y), Quaternion.identity);
					spawnedTile.name = "End";
				}
			}
		}
		cam1.orthographicSize = (((float)Cols) + ((float)Rows)) / 4.5f;
		cam2.transform.position = new Vector3((float)Cols/2 - 0.5f, (float)Rows/2 - 0.5f, -10);
	}
}
