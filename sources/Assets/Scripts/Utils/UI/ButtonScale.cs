﻿using UnityEngine;

namespace Assets.Scripts.Utils.UI
{
	public class ButtonScale : MonoBehaviourBase
	{
		private Vector3 _originalScale;
		private bool _isScaled;
		public float Scale = 1.1f;

		public void OnMouseEnter()
		{
			_originalScale = Transform.localScale;
			Transform.localScale = _originalScale*Scale;
			_isScaled = true;
		}

		public void OnMouseExit()
		{
			ResetScale();
		}

		public void OnDisable()
		{
			ResetScale();
		}

		private void ResetScale()
		{
			if (_isScaled)
				Transform.localScale = _originalScale;
		}
	}
}