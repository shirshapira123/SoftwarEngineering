using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Parent
    {
        string name, phone;
        public Parent(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }
        public string GetPhone() => phone;
        public string GetName() => name;
        public void SetPhone(string phone)
        {
            this.phone = phone;
        }
        public bool ParentsCompare(Parent parent)
        {
            if (name == parent.GetName() && phone == parent.GetPhone())
                return true;
            return false;
        }
        public override string ToString() => $"parent name: {name}, phone number: {phone}.";
    }
}
