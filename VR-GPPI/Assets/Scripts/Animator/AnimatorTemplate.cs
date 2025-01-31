using UnityEngine;

public abstract class AnimatorTemplate : MonoBehaviour
{
    protected INotifier<string> notifier;

    protected void Awake()
    {
        notifier = transform.parent.parent.GetComponent<INotifier<string>>();
        notifier.OnAllChanged += Play;
    }

    protected abstract void Play(string animatorParameter);

    protected void OnDestroy()
    {
        notifier.OnAllChanged -= Play;
        notifier = null;
    }
}