using System;
using Assets.Scripts.Utils.Tweens;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
	public class CanvasGroupExamples : MonoBehaviour
	{
		public Graphic Panel;

		public float Duration;

		public void OnGUI()
		{
			GUILayout.BeginVertical();

			if (GUILayout.Button("Cross Fade Alpha 0"))
			{
				Panel.CrossFadeAlpha(0f, Duration, false);
			}

			if (GUILayout.Button("Cross Fade Alpha 1"))
			{
				Panel.CrossFadeAlpha(1f, Duration, false);
			}

			if (GUILayout.Button("Fade Out/In"))
			{
				TweenSequence.Run(
					() => FadeOutTween.Run(Panel.gameObject, Duration),
					() => FadeInTween.Run(Panel.gameObject, Duration).SetDelay(0.25f));
			}

			GUILayout.EndVertical();
		}

	}
}
