﻿// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Memento
{
    public interface IPrototypeComponent<Template1> where Template1 : class, IPrototypeComponent<Template1>, new()
    {
        public Template1 GetPrototypeComponentClonation()
        {
            IPrototypeComponent<Template1> prototypeComponentClonation = new Template1();

            SetPrototypeComponentClonation(prototypeComponentClonation: (Template1)prototypeComponentClonation);

            return (Template1)prototypeComponentClonation;
        }

        public void SetPrototypeComponentClonation(in Template1 prototypeComponentClonation);
    }
}