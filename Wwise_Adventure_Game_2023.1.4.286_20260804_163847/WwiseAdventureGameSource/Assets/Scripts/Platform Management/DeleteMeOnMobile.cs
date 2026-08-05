////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

﻿using UnityEngine;

public class DeleteMeOnMobile : MonoBehaviour {
	#if UNITY_IOS || UNITY_ANDROID
	void Awake(){
		Destroy (gameObject);
	}
	#endif
}
