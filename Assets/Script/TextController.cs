// using UnityEngine;
// using UnityEngine.UI;
// using PixelBattleText;
// using TMPro;

// namespace AnimatedBattleText.Examples
// {
// 	public class TextController : MonoBehaviour
// 	{
//         public static TextController Instance;
// 		private Vector3 textSpawnPosition = new Vector3(0.5f, 0.65f, 0);

// 		public TextAnimation koAnimation;
		
// 		void Start()
// 		{
// 			textSpawnPosition = new Vector3(0.5f,0.65f,0);
// 		}

// 		public Color[] outlineColors;
// #region UI DUMMY CONTROLS
// 		public void DisplayKO()
// 		{
// 			PixelBattleTextController.DisplayText(
// 				"KO",
// 				koAnimation,
// 				textSpawnPosition
//             );
// 		}
// #endregion
// 	}
// }