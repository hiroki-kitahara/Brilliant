﻿using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace Brilliant
{
	/// <summary>
	/// プレイヤーデータ.
	/// </summary>
	public class PlayerData
	{
		public List<Item> Items{ private set; get; }

		public List<Weapon> Weapons{ private set; get; }

		public Wallet Wallet{ private set; get; }

		public PlayerData()
		{
			this.Items = new List<Item>();
			this.Weapons = new List<Weapon>();
			this.Wallet = new Wallet();
		}
	}
}
