using UnityEditor;
using UnityEngine;

namespace UnderLogic.Channels.Editor
{
    [CustomEditor(typeof(EventChannel), true)]
    public class EventChannelEditor : UnityEditor.Editor
    {
        private static readonly GUILayoutOption[] ButtonLayout =
        {
            GUILayout.MinWidth(192),
            GUILayout.MinHeight(28),
        };

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            GUILayout.Space(4);
            if (GUILayout.Button("Raise Event", ButtonLayout))
            {
                if (target is EventChannel channel)
                    channel.RaiseEvent();
            }
        }
    }
}
