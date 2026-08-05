////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

﻿using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour, IDamageable {

	public void OnDamage(Attack a)
	{
		PlayerManager.Instance.TakeDamage(a);
	}
}
