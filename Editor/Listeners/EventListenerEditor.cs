using UnityEngine;

namespace UnderLogic.Channels.Listeners.Editor
{
    public abstract class EventListenerEditor<TChannel> : UnityEditor.Editor where TChannel : EventChannel
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
                if (target is EventListener<TChannel> listener)
                    listener.RaiseEvent();
            }
        }
    }
}
