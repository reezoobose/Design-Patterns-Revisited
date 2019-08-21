using UnityEngine;

namespace _Script
{
    public abstract class Command
    {
        public abstract void Execute(Animator targetAnimator);
        public abstract void Revert(Animator targetAnimator);
    }
}