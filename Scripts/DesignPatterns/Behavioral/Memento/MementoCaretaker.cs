// LAST UPDATED DATE : 24/04/2025

namespace DesignPatternsProject.Scripts.DesignPatterns.Behavioral.Memento
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class MementoCaretaker<Template1> where Template1 : class, IPrototypeComponent<Template1>, new()
    {
        private OriginatorComponent<Template1> MementoCaretakerOriginatorComponent { get; } = new OriginatorComponent<Template1>();

        private Stack<MementoComponent<Template1>> MementoCaretakerUndoCollection { get; } = new Stack<MementoComponent<Template1>>(collection: []);

        private Stack<MementoComponent<Template1>> MementoCaretakerRedoCollection { get; } = new Stack<MementoComponent<Template1>>(collection: []);

        public MementoCaretaker(in OriginatorComponent<Template1> mementoCaretakerOriginatorComponent) : base()
        {
            if (mementoCaretakerOriginatorComponent is null)
            {
                StringBuilder mementoCaretakerStringBuilder = new();

                mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

                throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
            }

            MementoCaretakerOriginatorComponent = mementoCaretakerOriginatorComponent;

            MementoCaretakerUndoCollection = new Stack<MementoComponent<Template1>>(collection: []);

            MementoCaretakerRedoCollection = new Stack<MementoComponent<Template1>>(collection: []);
        }

        public void ExecuteMementoCaretakerBackupOperation()
        {
            if (MementoCaretakerOriginatorComponent is null)
            {
                StringBuilder mementoCaretakerStringBuilder = new();

                mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

                throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
            }

            if (MementoCaretakerUndoCollection is null || MementoCaretakerRedoCollection is null)
            {
                StringBuilder mementoCaretakerStringBuilder = new();

                mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

                throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
            }

            MementoCaretakerUndoCollection.Push(item: MementoCaretakerOriginatorComponent.SaveOriginatorComponentReference());

            MementoCaretakerRedoCollection.Clear();
        }

        public bool ExecuteMementoCaretakerUndoOperation()
        {
            if (MementoCaretakerOriginatorComponent is null)
            {
                StringBuilder mementoCaretakerStringBuilder = new();

                mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

                throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
            }

            if (MementoCaretakerUndoCollection is null || MementoCaretakerRedoCollection is null)
            {
                StringBuilder mementoCaretakerStringBuilder = new();

                mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

                throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
            }

            if (!MementoCaretakerUndoCollection.TryPop(result: out MementoComponent<Template1>? mementoCaretakerMementoComponent))
            {
                return false;
            }

            if (mementoCaretakerMementoComponent is null)
            {
                StringBuilder mementoCaretakerStringBuilder = new();

                mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

                throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
            }

            MementoCaretakerRedoCollection.Push(item: MementoCaretakerOriginatorComponent.SaveOriginatorComponentReference());

            MementoCaretakerOriginatorComponent.RestoreOriginatorComponentReference(originatorComponentMementoComponent: mementoCaretakerMementoComponent);

            return true;
        }

        public bool ExecuteMementoCaretakerRedoOperation()
        {
            if (MementoCaretakerOriginatorComponent is null)
            {
                StringBuilder mementoCaretakerStringBuilder = new();

                mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

                throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
            }

            if (MementoCaretakerUndoCollection is null || MementoCaretakerRedoCollection is null)
            {
                StringBuilder mementoCaretakerStringBuilder = new();

                mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

                throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
            }

            if (!MementoCaretakerRedoCollection.TryPop(result: out MementoComponent<Template1>? mementoCaretakerMementoComponent))
            {
                return false;
            }

            if (mementoCaretakerMementoComponent is null)
            {
                StringBuilder mementoCaretakerStringBuilder = new();

                mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
                mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
                mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

                throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
            }

            MementoCaretakerUndoCollection.Push(item: MementoCaretakerOriginatorComponent.SaveOriginatorComponentReference());

            MementoCaretakerOriginatorComponent.RestoreOriginatorComponentReference(originatorComponentMementoComponent: mementoCaretakerMementoComponent);

            return true;
        }

        public override bool Equals(object? uncastedMementoCaretaker)
        {
            StringBuilder mementoCaretakerStringBuilder = new();

            mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
            mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
            mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
            mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
            mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

            throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
        }

        public override int GetHashCode()
        {
            StringBuilder mementoCaretakerStringBuilder = new();

            mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
            mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
            mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
            mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
            mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

            throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
        }

        public override string ToString()
        {
            StringBuilder mementoCaretakerStringBuilder = new();

            mementoCaretakerStringBuilder.Append(value: $"[START]{nameof(MementoCaretaker<Template1>)}[START]");
            mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
            mementoCaretakerStringBuilder.Append(value: $"Method not implemented in '{nameof(MementoCaretaker<Template1>)}' class");
            mementoCaretakerStringBuilder.AppendLine(value: string.Empty);
            mementoCaretakerStringBuilder.Append(value: $"[END]{nameof(MementoCaretaker<Template1>)}[END]");

            throw new NotImplementedException(message: mementoCaretakerStringBuilder.ToString(), inner: new Exception());
        }
    }
}