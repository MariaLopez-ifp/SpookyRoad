using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
	[System.Serializable]
	public struct Points
	{
		public Transform point;
		public bool taken;
	}
	
	public Points[] pointsGroup;
	static int numFollowers;

	public static event Action<int> datosFollow = delegate { };

	public Transform Enter()
	{
		for(int i = 0; i < pointsGroup.Length; i++)
		{
			if (!pointsGroup[i].taken)
			{
				pointsGroup[i].taken = true;
				numFollowers++;
				datosFollow(numFollowers);
				return pointsGroup[i].point;
			}
		}
		return null;
	}

	public void Exit(Transform place)
	{
		for (int i = 0; i < pointsGroup.Length; i++)
		{
			if (pointsGroup[i].point == place)
            {
				pointsGroup[i].taken = false;
				numFollowers--;
			}
		}
		datosFollow(numFollowers);
	}
}
