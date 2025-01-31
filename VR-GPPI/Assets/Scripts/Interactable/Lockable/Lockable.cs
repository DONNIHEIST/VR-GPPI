using UnityEngine;

public abstract class Lockable<TThing> : MonoBehaviour, ILockable where TThing : IThing
{
    [SerializeField] protected bool isLocked = true;

    public abstract bool IsLocked { get; set; }

    protected TThing lockableThing;

    private void Awake() => lockableThing = transform.parent.GetComponent<TThing>();

    private void Update() => IsLocked = isLocked;
}