
using UnityEngine;

public class GUIHomework : MonoBehaviour
{
    public string livesAmount;
    public Texture2D _icon;
    private float sliderValue;

    void OnGUI()
    {
        //количество жизней игрока (пример)
        GUI.Box(new Rect(10, 10, 100, 50), new GUIContent(livesAmount, _icon));
        

        //GUILayout.BeginArea(new Rect(10, 10, 200, 100));
        //GUILayout.BeginHorizontal();
        //GUILayout.BeginVertical();
        //if (GUILayout.RepeatButton("Min"))
        //    sliderValue = 0.0f;
        //if (GUILayout.RepeatButton("Max"))
        //    sliderValue = 10.0f;
        //GUILayout.EndVertical();
        //GUILayout.BeginVertical();
        //GUILayout.Label("Some slider: ");
        //sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, 10.0f);
        //GUILayout.EndVertical();
        //GUILayout.EndHorizontal();
        //GUILayout.EndArea();
    }

}
