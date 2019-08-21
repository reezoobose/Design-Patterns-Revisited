using UnityEngine;

namespace _Script
{
    public class PerformDancing : Command
    {
        private static readonly int IsDancing =
            Animator.StringToHash("IsDancing");

        private static readonly int IsReverseDancing =
            Animator.StringToHash("IsReverseDancing");

        public override void Execute(Animator targetAnimator)
        {
           targetAnimator.SetTrigger(IsDancing);
        }

        public override void Revert(Animator targetAnimator)
        {
            targetAnimator.SetTrigger(IsReverseDancing);
        }
    }

    public class PerformRunning : Command
    {
        private static readonly int IsRunning =
            Animator.StringToHash("IsRunning");

        private static readonly int IsReverseRunning =
            Animator.StringToHash("IsReverseRunning");
        public override void Execute(Animator targetAnimator)
        {
            targetAnimator.SetTrigger(IsRunning);
        }
        public override void Revert(Animator targetAnimator)
        {
            targetAnimator.SetTrigger(IsReverseRunning);
        }
    }


    public class PerformPunch : Command
    {
        private static readonly int IsPunching =
            Animator.StringToHash("IsPunching");

        private static readonly  int IsReversePunching =
            Animator.StringToHash("IsReversePunching");
        public override void Execute(Animator targetAnimator)
        {
            targetAnimator.SetTrigger(IsPunching);
        }
        public override void Revert(Animator targetAnimator)
        {
            targetAnimator.SetTrigger(IsReversePunching);
        }
    }

    public class PerformWalking : Command
    {
        private static readonly int IsWalking = Animator.StringToHash("IsWalking");
        private static readonly int IsReverseWalking = Animator.StringToHash("IsReverseWalking");

        public override void Execute(Animator targetAnimator)
        {
            targetAnimator.SetTrigger(IsWalking);
        }

        public override void Revert(Animator targetAnimator)
        {
            targetAnimator.SetTrigger(IsReverseWalking);
        }
    }


    public class Idle : Command
    {
        public override void Execute(Animator targetAnimator)
        {
            
        }

        public override void Revert(Animator targetAnimator)
        {

        }
    }

}
