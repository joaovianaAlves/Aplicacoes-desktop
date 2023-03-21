using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhoneList
    {
        public List<Person> PersonList { get; set; } = new List<Person>() { };
        

        public void add(Person pessoa)
        {
            PersonList.Add(pessoa);
        }

        public Person FindPerson(string name)
        {
            foreach (Person person in PersonList)
            {
                if (person.Name == name)
                {
                    return person;
                }
            }
            return null;
        }

        public void remove(Person person)
        {
            int index = PersonList.IndexOf(person);
            PersonList.RemoveAt(index);
            PersonList.Remove(person);
            
        }
    }
}
