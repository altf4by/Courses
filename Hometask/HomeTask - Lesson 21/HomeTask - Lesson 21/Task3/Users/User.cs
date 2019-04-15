using System;
using Task3.Interfaces;
using Task3.Behavoirs;

namespace Task3
{
    abstract class User
    {
        protected IEditable editBehavior;
        protected IAddable addBehavior;
        protected IDeletable deleteBehavior;


        public string Name { get; set; }


        public User()
        {
            editBehavior = new NoEditBehavior();
            addBehavior = new NoAddBehavior();
            deleteBehavior = new NoDeleteBehavior();
        }
        public User(IEditable editBehavior, IAddable addBehavior, IDeletable deleteBehavior)
        {
            this.editBehavior = editBehavior;
            this.addBehavior = addBehavior;
            this.deleteBehavior = deleteBehavior;
        }

        public abstract void Read();
        public void Add() { addBehavior.Add(); }
        public void Edit() { editBehavior.Edit(); }
        public void Delete() { deleteBehavior.Delete(); }

    }
}
