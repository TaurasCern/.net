using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Domain.Enums;

namespace Inheritance.Domain.Models
{
    public class Society
    {
        

        public void FillPeople()
        {
            var people = new List<Person>();
            foreach (var person in InitialData.PersonInitialData.DataSeed)
            {
                people.Add(person);
            }
            People = people;
            FillMen(people);
            FillWomen(people);
        }        
        public void FillMen(List<Person> people)
        {
            foreach (var person in people)
            {
                if((int)person.Gender == (int)EGenderType.MALE)
                {
                    Men.Add(person);
                }
            }
        }        
        public void FillWomen(List<Person> people)
        {
            foreach (var person in people)
            {
                if(person.Gender == EGenderType.FEMALE)
                {
                    Women.Add(person);
                }
            }
        }
        public void SortByAge()
        {
            Person temp = new Person();
            for(int i = 0; i < Men.Count; i++)
            {
                for(int j = 0; j < Men.Count - 1; j++)
                {
                    if (Men[j].Age > Men[j + 1].Age)
                    {
                        temp = Men[j + 1];
                        Men[j + 1] = Men[j];
                        Men[j] = temp;
                    }
                }
            }

            for (int i = 0; i < Women.Count; i++)
            {
                for (int j = 0; j < Women.Count - 1; j++)
                {
                    if (Women[j].Age > Women[j + 1].Age)
                    {
                        temp = Women[j + 1];
                        Women[j + 1] = Women[j];
                        Women[j] = temp;
                    }
                }
            }
        }
        public Society SortByFirstName()
        {
            this._sortState = 1;
            return this;
        }
        public Society SortByLastName()
        {
            this._sortState = 2;
            return this;
        }
        public void Asc()
        {
            Person temp = new Person();

            for (int i = 0; i < Men.Count; i++)
            {
                for (int j = 0; j < Men.Count - 1; j++)
                {
                    if(this._sortState == 1)
                    {
                        if (Men[j].FirstName.CompareTo(Men[j + 1].FirstName) > 0)
                        {
                            temp = Men[j + 1];
                            Men[j + 1] = Men[j];
                            Men[j] = temp;
                        }
                    }
                    else if(this._sortState == 2)
                    {
                        if (Men[j].LastName.CompareTo(Men[j + 1].LastName) > 0)
                        {
                            temp = Men[j + 1];
                            Men[j + 1] = Men[j];
                            Men[j] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < Women.Count; i++)
            {
                for (int j = 0; j < Women.Count - 1; j++)
                {
                    if (this._sortState == 1)
                    {
                        if (Women[j].FirstName.CompareTo(Women[j + 1].FirstName) > 0)
                        {
                            temp = Women[j + 1];
                            Women[j + 1] = Women[j];
                            Women[j] = temp;
                        }
                    }
                    else if(this._sortState == 2)
                    {
                        if (Women[j].LastName.CompareTo(Women[j + 1].LastName) > 0)
                        {
                            temp = Women[j + 1];
                            Women[j + 1] = Women[j];
                            Women[j] = temp;
                        }
                    }

                }
            }

            for (int i = 0; i < People.Count; i++)
            {
                for (int j = 0; j < People.Count - 1; j++)
                {
                    if (this._sortState == 1)
                    {
                        if (People[j].FirstName.CompareTo(People[j + 1].FirstName) > 0)
                        {
                            temp = People[j + 1];
                            People[j + 1] = People[j];
                            People[j] = temp;
                        }
                    }
                    else if (this._sortState == 2)
                    {
                        if (People[j].LastName.CompareTo(People[j + 1].LastName) > 0)
                        {
                            temp = People[j + 1];
                            People[j + 1] = People[j];
                            People[j] = temp;
                        }
                    }
                }
            }
        }
        public void Dsc()
        {
            Person temp = new Person();
            for (int i = 0; i < Men.Count; i++)
            {
                for (int j = 0; j < Men.Count - 1; j++)
                {
                    if (this._sortState == 1)
                    {
                        if (Men[j].FirstName.CompareTo(Men[j + 1].FirstName) < 0)
                        {
                            temp = Men[j + 1];
                            Men[j + 1] = Men[j];
                            Men[j] = temp;
                        }
                    }
                    else if (this._sortState == 2)
                    {
                        if (Men[j].LastName.CompareTo(Men[j + 1].LastName) < 0)
                        {
                            temp = Men[j + 1];
                            Men[j + 1] = Men[j];
                            Men[j] = temp;
                        }
                    }
                }
            }

            for (int i = 0; i < Women.Count; i++)
            {
                for (int j = 0; j < Women.Count - 1; j++)
                {
                    if (this._sortState == 1)
                    {
                        if (Women[j].FirstName.CompareTo(Women[j + 1].FirstName) < 0)
                        {
                            temp = Women[j + 1];
                            Women[j + 1] = Women[j];
                            Women[j] = temp;
                        }
                    }
                    else if(this._sortState == 2)
                    {
                        if (Women[j].LastName.CompareTo(Women[j + 1].LastName) < 0)
                        {
                            temp = Women[j + 1];
                            Women[j + 1] = Women[j];
                            Women[j] = temp;
                        }
                    }
                }
            }

            for (int j = 0; j < People.Count - 1; j++)
            {
                if (this._sortState == 1)
                {
                    if (People[j].FirstName.CompareTo(People[j + 1].FirstName) < 0)
                    {
                        temp = People[j + 1];
                        People[j + 1] = People[j];
                        People[j] = temp;
                    }
                }
                else if (this._sortState == 2)
                {
                    if (People[j].LastName.CompareTo(People[j + 1].LastName) < 0)
                    {
                        temp = People[j + 1];
                        People[j + 1] = People[j];
                        People[j] = temp;
                    }
                }
            }
        }

       
        public List<Person> People { get; set; }  = new List<Person>();
        public List<Person> Men { get; set; }  = new List<Person>();
        public List<Person> Women { get; set; }  = new List<Person>();
        private int _sortState; // 1 - first name || 2 - last name
        public List<Person> OldPeople
        {
            get
            {
                var temp = new List<Person>();
                foreach(var person in People)
                {
                    if(person.BirthDate == null)
                    {
                        continue;
                    }
                    else if(((DateTime)person.BirthDate).Year < 2001)
                    {
                        temp.Add(person);
                    }
                }
                return temp;
            }
        }

    }
}
