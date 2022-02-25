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
		public Followers followerAssigned;
	}
	
	public Points[] pointsGroup;
	static int numFollowers;

	public static event Action<int> datosFollow = delegate { };

	public Transform Enter(Followers f)
	{
		for(int i = 0; i < pointsGroup.Length; i++)
		{
			if (!pointsGroup[i].followerAssigned)
			{
				pointsGroup[i].followerAssigned = f;
				numFollowers++;
				datosFollow(numFollowers);
				return pointsGroup[i].point;
			}
		}
		return null;
	}

	public void Exit(Followers f)
	{
		for (int i = 0; i < pointsGroup.Length; i++)
		{
			if (pointsGroup[i].followerAssigned == f)
            {
				pointsGroup[i].followerAssigned = null;
				numFollowers--;
			}
		}
		datosFollow(numFollowers);
	}

	public void RemoveLast()
    {
		for (int i = 0; i < pointsGroup.Length; i++)
		{
			if (pointsGroup[i].followerAssigned)
			{
				pointsGroup[i].followerAssigned.GetComponent<DieSystem>().Dead();
				pointsGroup[i].followerAssigned = null;
				return ;
			}
		}
	}
}
