// LAST UPDATED DATE : 28/03/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Memento
{
    using System;
    using System.Text;

    public sealed class OriginatorComponent<Template1> where Template1 : class, IPrototypeComponent<Template1>, new()
    {
        private Template1 OriginatorComponentReference { get; set; }

        public OriginatorComponent() : base()
        {
            OriginatorComponentReference = new Template1();
        }

        public bool TryOriginatorComponentReferenceIsNotNull(out Template1 originatorComponentReference)
        {
            originatorComponentReference = OriginatorComponentReference;

            return originatorComponentReference is not null;
        }

        public MementoComponent<Template1> SaveOriginatorComponentReference()
        {
            if (!TryOriginatorComponentReferenceIsNotNull(originatorComponentReference: out Template1 originatorComponentReference))
            {
                StringBuilder originatorComponentStringBuilder = new();

                originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"There was an issue in '{nameof(OriginatorComponent<Template1>)}' class");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

                throw new InvalidOperationException(message: originatorComponentStringBuilder.ToString(), innerException: new Exception());
            }

            Template1 originatorComponentReferenceClonation = originatorComponentReference.GetPrototypeComponentClonation();

            return new MementoComponent<Template1>(mementoComponentReference: originatorComponentReferenceClonation);
        }

        public void RestoreOriginatorComponentReference(in MementoComponent<Template1> originatorComponentMementoComponent)
        {
            if (!TryOriginatorComponentReferenceIsNotNull(originatorComponentReference: out Template1 originatorComponentReference))
            {
                StringBuilder originatorComponentStringBuilder = new();

                originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"There was an issue in '{nameof(OriginatorComponent<Template1>)}' class");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

                throw new InvalidOperationException(message: originatorComponentStringBuilder.ToString(), innerException: new Exception());
            }

            if (originatorComponentMementoComponent is null)
            {
                StringBuilder originatorComponentStringBuilder = new();

                originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"There was an issue in '{nameof(OriginatorComponent<Template1>)}' class");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

                throw new InvalidOperationException(message: originatorComponentStringBuilder.ToString(), innerException: new Exception());
            }

            if (!originatorComponentMementoComponent.TryMementoComponentReferenceIsNotNull(mementoComponentReference: out Template1 originatorComponentMementoComponentReference))
            {
                StringBuilder originatorComponentStringBuilder = new();

                originatorComponentStringBuilder.Append(value: $"[START]{nameof(OriginatorComponent<Template1>)}[START]");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"There was an issue in '{nameof(OriginatorComponent<Template1>)}' class");
                originatorComponentStringBuilder.AppendLine(value: string.Empty);
                originatorComponentStringBuilder.Append(value: $"[END]{nameof(OriginatorComponent<Template1>)}[END]");

                throw new InvalidOperationException(message: originatorComponentStringBuilder.ToString(), innerException: new Exception());
            }

            originatorComponentMementoComponentReference.SetPrototypeComponentClonation(prototypeComponentClonation: originatorComponentReference);
        }

        public override bool Equals(object uncastedOriginatorComponent)
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