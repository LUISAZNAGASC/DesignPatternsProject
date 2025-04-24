// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Memento
{
    using System;
    using System.Text;

    public sealed class MementoComponent<Template1> where Template1 : class
    {
        public Template1 MementoComponentReference { get; }

        public MementoComponent(in Template1 mementoComponentReference) : base()
        {
            if (mementoComponentReference is null)
            {
                StringBuilder mementoComponentStringBuilder = new();

                mementoComponentStringBuilder.Append(value: $"[START]{nameof(MementoComponent<Template1>)}[START]");
                mementoComponentStringBuilder.AppendLine(value: string.Empty);
                mementoComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoComponent<Template1>)}' class");
                mementoComponentStringBuilder.AppendLine(value: string.Empty);
                mementoComponentStringBuilder.Append(value: $"[END]{nameof(MementoComponent<Template1>)}[END]");

                throw new NotImplementedException(message: mementoComponentStringBuilder.ToString(), inner: new Exception());
            }

            MementoComponentReference = mementoComponentReference;
        }

        public override bool Equals(object? uncastedMementoComponent)
        {
            StringBuilder mementoComponentStringBuilder = new();

            mementoComponentStringBuilder.Append(value: $"[START]{nameof(MementoComponent<Template1>)}[START]");
            mementoComponentStringBuilder.AppendLine(value: string.Empty);
            mementoComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoComponent<Template1>)}' class");
            mementoComponentStringBuilder.AppendLine(value: string.Empty);
            mementoComponentStringBuilder.Append(value: $"[END]{nameof(MementoComponent<Template1>)}[END]");

            throw new NotImplementedException(message: mementoComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder mementoComponentStringBuilder = new();

            mementoComponentStringBuilder.Append(value: $"[START]{nameof(MementoComponent<Template1>)}[START]");
            mementoComponentStringBuilder.AppendLine(value: string.Empty);
            mementoComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoComponent<Template1>)}' class");
            mementoComponentStringBuilder.AppendLine(value: string.Empty);
            mementoComponentStringBuilder.Append(value: $"[END]{nameof(MementoComponent<Template1>)}[END]");

            throw new NotImplementedException(message: mementoComponentStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder mementoComponentStringBuilder = new();

            mementoComponentStringBuilder.Append(value: $"[START]{nameof(MementoComponent<Template1>)}[START]");
            mementoComponentStringBuilder.AppendLine(value: string.Empty);
            mementoComponentStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoComponent<Template1>)}' class");
            mementoComponentStringBuilder.AppendLine(value: string.Empty);
            mementoComponentStringBuilder.Append(value: $"[END]{nameof(MementoComponent<Template1>)}[END]");

            throw new NotImplementedException(message: mementoComponentStringBuilder.ToString(), inner: new Exception());
        }
    }
}