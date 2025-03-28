// LAST UPDATED DATE : 28/03/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Creational.Prototype
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