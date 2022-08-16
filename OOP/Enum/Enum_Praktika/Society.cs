﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Praktika
{
    internal class Society
    {
        

        public void FillPeople()
        {
            foreach (var person in InitialData.PersonInitialData.DataSeed)
            {
                People.Add(person);
            }
        }        
        public void FillMen()
        {
            foreach (var person in InitialData.PersonInitialData.DataSeed)
            {
                if((int)person.Gender == (int)EGenderType.MALE)
                {
                    Men.Add(person);
                }
            }
        }        
        public void FillWomen()
        {
            foreach (var person in InitialData.PersonInitialData.DataSeed)
            {
                if(person.Gender == EGenderType.FEMALE)
                {
                    People.Add(person);
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


            temp = new Person();
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
            return this;
        }
        public void Asc()
        {
            Person temp = new Person();
            for (int i = 0; i < Men.Count; i++)
            {
                for (int j = 0; j < Men.Count - 1; j++)
                {
                    if (Men[j].FirstName.CompareTo(Men[j + 1].FirstName) > 0)
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
                    if (Women[j].FirstName.CompareTo(Women[j + 1].FirstName) > 0)
                    {
                        temp = Women[j + 1];
                        Women[j + 1] = Women[j];
                        Women[j] = temp;
                    }
                }
            }

            for (int i = 0; i < People.Count; i++)
            {
                for (int j = 0; j < People.Count - 1; j++)
                {
                    if (People[j].FirstName.CompareTo(People[j + 1].FirstName) > 0)
                    {
                        temp = People[j + 1];
                        People[j + 1] = People[j];
                        People[j] = temp;
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
                    if (Men[j].FirstName.CompareTo(Men[j + 1].FirstName) < 0)
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
                    if (Women[j].FirstName.CompareTo(Women[j + 1].FirstName) < 0)
                    {
                        temp = Women[j + 1];
                        Women[j + 1] = Women[j];
                        Women[j] = temp;
                    }
                }
            }

            for (int i = 0; i < People.Count; i++)
            {
                for (int j = 0; j < People.Count - 1; j++)
                {
                    if (People[j].FirstName.CompareTo(People[j + 1].FirstName) < 0)
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
