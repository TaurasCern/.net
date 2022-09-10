﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.Domain.Models;

namespace LINQ.Domain.InitialData
{
    public static class PersonInicialData
    {
        static public List<Person> DataSeed => new List<Person>
        {
            new Person { FirstName = "Laurynas", LastName = "Laurynaitis", BirthDate = DateTime.Parse("1976-01-05"), Biography = "Laurynas is a 45-year-old intelligence researcher who enjoys extreme ironing, checking news stories against Snopes and eating out. He is intelligent and reliable, but can also be very pessimistic and a bit moody. Physically, Laurynas is in good shape. He is very short with bronze skin, grey hair and brown eyes. Laurynas's best friend is an intelligence researcher called Sidney O'Ryan. They get on well most of the time. He also hangs around with an intelligence researcher called Ralph O'Brien. They enjoy worship together. "},

            new Person { FirstName = "Antanas", LastName = "Antanaitis", BirthDate = DateTime.Parse("2000-05-12"), Biography = "Antanas is a 20-year-old admin assistant who enjoys football, donating blood and horse riding. He is intelligent and reliable, but can also be very pessimistic and a bit untidy. Physically, Antanas is not in great shape. He needs to lose quite a lot of weight. He is tall with walnut skin, brown hair and black eyes. Antanas's best friend is an admin assistant called Alvin Roberts. They are inseparable. He also hangs around with an admin assistant called Jerome King. They enjoy repressing minorities together. " },

            new Person { FirstName = "Adomas", LastName = "Adomaitis", BirthDate = DateTime.Parse("2000-03-01"), Biography = "Adomas is a 20-year-old teenager who enjoys tennis, relaxing and spreading fake news on Facebook. He is friendly and creative, but can also be very pessimistic and a bit untidy. Physically, Adomas is in good shape. He is short with pale skin, red hair and green eyes. Adomas's best friend is a teenager called Loretta Matthews. They get on well most of the time. He also hangs around with Marian Holmes and Wendy Bird. They enjoy photography together. " },

            new Person { FirstName = "Linas", LastName = "Linasis", BirthDate = DateTime.Parse("2002-12-05"), Biography = "Linas is a 18-year-old P.P.E. student who enjoys photography, glamping and attending museums. He is intelligent and caring, but can also be very pessimistic and a bit impatient. Physically, Linas is in good shape. He is very tall with bronze skin, grey hair and black eyes. Linas's best friend is a P.P.E. student called Edna Bryant. They get on well most of the time. He also hangs around with Jeffery Stephenson and Franklin Wilson. They enjoy cookery together. " },

            new Person { FirstName = "Matas ", LastName = "Matalas", BirthDate = DateTime.Parse("2001-05-03"), Biography = "Matas is a 19-year-old local activist who enjoys competitive dog grooming, extreme ironing and meditation. He is kind and creative, but can also be very rude and a bit untidy. Physically, Matas is in good shape. He is very short with bronze skin, auburn hair and brown eyes. Matas's best friend is a local activist called Ibrahim Finch. They get on well most of the time. He also hangs around with Elliot Robertson and Muhammad Love. They enjoy painting together. " },

            new Person { FirstName = "Andrius", LastName = "Andriulaitis", BirthDate = DateTime.Parse("2000-03-03"), Biography = "Andrius is a friendly personal trainer who is obsessed with the murder of his friend Anita, seventeen years ago. Physically, Andrius is in good shape. He is short with bronze skin, brown hair and green eyes. He has a tattoo of a silhouetted hill runner on his lower back. Andrius's best friend is a personal trainer called Regina Baldwin. They get on well most of the time. They enjoy watching television together. " },

            new Person { FirstName = "Irma", LastName = "Irmiene", BirthDate = DateTime.Parse("1999-01-24"), Biography = "Irma is a 21-year-old tradesperson's assistant who enjoys photography, binge-watching boxed sets and helping old ladies across the road. She is stable and reliable, but can also be very lazy and a bit grumpy. Physically, Irma is in pretty good shape. She is short with bronze skin, black hair and green eyes. She has an unusually long nose. Irma's best friend is a tradesperson's assistant called Ted Morris. They get on well most of the time. She also hangs around with Clifford Browne and Norma Leigh. They enjoy worship together. "  },

            new Person { FirstName = "Karolina", LastName = "Karolinaite", BirthDate = DateTime.Parse("2000-01-25"), Biography = "Karolina is a 20-year-old town counsellor who enjoys donating blood, reading and eating out. She is kind and caring, but can also be very lazy and a bit untidy. Physically, Karolina is in good shape. She is short with pale skin, blonde hair and black eyes. She is obsessed with running. Karolina's best friend is a town counsellor called Rory Frost. They are inseparable. She also hangs around with Jo Pritchard and Karan Hughes. They enjoy running together. " },

            new Person { FirstName = "Ieva", LastName = "Ievaite", BirthDate = DateTime.Parse("2000-02-09"), Biography = "Ieva is a 20-year-old gym assistant who enjoys recycling, tennis and playing card games. She is kind and caring, but can also be very pessimistic and a bit untidy. Physically, Ieva is not in great shape. She needs to lose quite a lot of weight. She is very short with olive skin, grey hair and brown eyes. Ieva's best friend is a gym assistant called Roger Mills. They have a very firey friendship. She also hangs around with Franklin Graves and Gordon Parsons. They enjoy relaxing together. " },

            new Person { FirstName = "Vilte", LastName = "Vilte", BirthDate = DateTime.Parse("2000-02-09"), Biography = "Vilte is a 20-year-old teenager who enjoys donating blood, working on cars and Rubix cube. She is intelligent and careful, but can also be very rude and a bit impatient. Physically, Vilte is in good shape. She is tall with chocolate skin, brown hair and blue eyes. Vilte's best friend is a teenager called Jeff Sullivan. They get on well most of the time. She also hangs around with Alice Rogers and Ariel Campbell. They enjoy social card games together. " },

            new Person { FirstName = "Julija", LastName = "Julijiene", BirthDate = DateTime.Parse("1998-02-07"), Biography = "Julija is a 22-year-old local activist who enjoys planking, theatre and adult colouring books. She is intelligent and caring, but can also be very pessimistic and a bit moody. Physically, Julija is in good shape. She is tall with brown skin, black hair and brown eyes. Julija's best friend is a local activist called Matas Matalas. They get on well most of the time. She also hangs around with Anita Mcintyre and Jan Baxter. They enjoy photography together. " },

            new Person { FirstName = "Rasa", LastName = "Rasiene",BirthDate = DateTime.Parse("2000-12-05"), Biography = "Rasa is a 20-year-old health centre receptionist who enjoys cookery, bridge and watching sport. She is friendly and reliable, but can also be very cowardly and a bit untidy. She is allergic to soy. Rasa's best friend is a health centre receptionist called Lydia Newton. They have a very firey friendship. She also hangs around with Clara Nichols and Elliott Nelson. They enjoy planking together. " },

        };
    }
}
