using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Item
    {
        string id;
        char gender;
        public Item(string id, char gender)
        {
            this.gender = gender;
            this.id = id;
        }
        public string GetId() => id;
        public char GetGender() => gender;
        public void SetId(string id)
        {
            this.id = id;
        }
        public void SetGender(char gender)
        {
            this.gender = gender;
        }
        public override string ToString()
        {
            return $"id: {id}, gender: {gender}\n";
        }
    }
}
