﻿using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// GameSystemHistoryからGameSystemを切り替えるコンポーネント.
	/// </summary>
	public class ChangeGameSystemFromHistory : MonoBehaviour
	{
		[SerializeField]
		private GameObject exceptionSystemObject;

		public void Change()
		{
			var poppedSystem = GameSystemHolder.Instance.History.Pop;
			if(poppedSystem == null)
			{
				poppedSystem = exceptionSystemObject;
			}

			GameSystemHolder.Change(poppedSystem, false);
		}
	}
}