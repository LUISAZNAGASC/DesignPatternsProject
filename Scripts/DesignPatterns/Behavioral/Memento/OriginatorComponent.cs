// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Memento
{
    using System;
    using System.Text;

    public sealed class OriginatorComponent<Template1> where Template1 : class, IPrototypeComponent<Template1>, new()
    {
        public Template1 OriginatorComponentReference { get; }

        public OriginatorComponent() : base()
        {
            OriginatorComponentReference = new Template1();
        }

        public MementoComponent<Template1> SaveOriginatorComponentReference()
        {
            if (OriginatorComponentReference is null)
            {
                StringBuilder originatorComponentStringBuilder = new();

                originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"There was an issue in '{nameof(OriginatorComponent<Template1>)}' class");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

                throw new InvalidOperationException(message: originatorComponentStringBuilder.ToString(), innerException: new Exception());
            }

            Template1 originatorComponentReferenceClonation = OriginatorComponentReference.GetPrototypeComponentClonation();

            return new MementoComponent<Template1>(mementoComponentReference: originatorComponentReferenceClonation);
        }

        public void RestoreOriginatorComponentReference(in MementoComponent<Template1> originatorComponentMementoComponent)
        {
            if (OriginatorComponentReference is null)
            {
                StringBuilder originatorComponentStringBuilder = new();

                originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"There was an issue in '{nameof(OriginatorComponent<Template1>)}' class");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

                throw new InvalidOperationException(message: originatorComponentStringBuilder.ToString(), innerException: new Exception());
            }

            if (originatorComponentMementoComponent is null || originatorComponentMementoComponent.MementoComponentReference is null)
            {
                StringBuilder originatorComponentStringBuilder = new();

                originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"There was an issue in '{nameof(OriginatorComponent<Template1>)}' class");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

                throw new InvalidOperationException(message: originatorComponentStringBuilder.ToString(), innerException: new Exception());
            }

            originatorComponentMementoComponent.MementoComponentReference.SetPrototypeComponentClonation(prototypeComponentClonation: OriginatorComponentReference);
        }

        public override bool Equals(object? uncastedOriginatorComponent)
        {
            StringBuilder originatorComponentStringBuilder = new();

            originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
            originatorComponentStringBuilder.AppendLine(value: string.Empty);
            originatorComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(OriginatorComponent<Template1>)}' class");
            originatorComponentStringBuilder.AppendLine(value: string.Empty);
            originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

            throw new NotImplementedException(message: originatorComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder originatorComponentStringBuilder = new();

            originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
            originatorComponentStringBuilder.AppendLine(value: string.Empty);
            originatorComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(OriginatorComponent<Template1>)}' class");
            originatorComponentStringBuilder.AppendLine(value: string.Empty);
            originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

            throw new NotImplementedException(message: originatorComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder originatorComponentStringBuilder = new();

            originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
            originatorComponentStringBuilder.AppendLine(value: string.Empty);
            originatorComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(OriginatorComponent<Template1>)}' class");
            originatorComponentStringBuilder.AppendLine(value: string.Empty);
            originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

            throw new NotImplementedException(message: originatorComponentStringBuilder.ToString(), inner: new Exception());
        }
    }
}