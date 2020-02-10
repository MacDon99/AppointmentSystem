using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSystem.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext appDbContext)
        {
            if (!appDbContext.Appointments.Any())
            {
                appDbContext.Appointments.AddRange
                    (
                    new Appointment { CustomerFirstName = "Maciej", CustomerLastName = "Dończyk", CustomerPhoneNumber = "536710649", CustomerEmail = "donczyk.maciej@gmail.com", AppointmentDate = new DateTime(2020, 1, 20, hour: 16, minute: 30, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Kamil", CustomerLastName = "Steffann", CustomerPhoneNumber = "234567890", CustomerEmail = "steffann.kamil@gmail.com", AppointmentDate = new DateTime(2020, 1, 22, hour:12, minute:15, second:0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Piotr", CustomerLastName = "Kowalski", CustomerPhoneNumber = "123456789", CustomerEmail = "kowalski.piotr@gmail.com", AppointmentDate = new DateTime(2020, 1, 24, hour:14, minute:45, second:0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Andrzej", CustomerLastName = "Nowak", CustomerPhoneNumber = "234789456", CustomerEmail = "nowak.andrzej@gmail.com", AppointmentDate = new DateTime(2020, 1, 26, hour: 16, minute: 30, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Ola", CustomerLastName = "Cyman", CustomerPhoneNumber = "768980234", CustomerEmail = "cyman.ola@gmail.com", AppointmentDate = new DateTime(2020, 1, 27, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Fryderyk", CustomerLastName = "Pięta", CustomerPhoneNumber = "345123567", CustomerEmail = "pieta.fryderyk@gmail.com", AppointmentDate = new DateTime(2020, 1, 28, hour: 14, minute: 45, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Filip", CustomerLastName = "Łajdak", CustomerPhoneNumber = "536710649", CustomerEmail = "lajdak.filip@gmail.com", AppointmentDate = new DateTime(2020, 2, 19, hour: 16, minute: 30, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Renata", CustomerLastName = "Skrzynia", CustomerPhoneNumber = "234567890", CustomerEmail = "skrzynia.renata@gmail.com", AppointmentDate = new DateTime(2020, 2, 05, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Żaneta", CustomerLastName = "Słup", CustomerPhoneNumber = "123456789", CustomerEmail = "slup.zaneta@gmail.com", AppointmentDate = new DateTime(2020, 2, 02, hour: 14, minute: 45, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Zofia", CustomerLastName = "Płatek", CustomerPhoneNumber = "536710649", CustomerEmail = "platek.zofia@gmail.com", AppointmentDate = new DateTime(2020, 2, 04, hour: 16, minute: 30, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Henryk", CustomerLastName = "Tęcza", CustomerPhoneNumber = "234567890", CustomerEmail = "tecza.henryk@gmail.com", AppointmentDate = new DateTime(2020, 1, 10, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Kryspin", CustomerLastName = "Ogień", CustomerPhoneNumber = "123456789", CustomerEmail = "ogien.kryspin@gmail.com", AppointmentDate = new DateTime(2020, 1, 12, hour: 14, minute: 45, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Jonasz", CustomerLastName = "Pustynia", CustomerPhoneNumber = "536710649", CustomerEmail = "jonasz.pustynia@gmail.com", AppointmentDate = new DateTime(2020, 1, 15, hour: 16, minute: 30, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Eliasz", CustomerLastName = "Ryba", CustomerPhoneNumber = "234567890", CustomerEmail = "ryba.eliasz@gmail.com", AppointmentDate = new DateTime(2020, 2, 13, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Małgorzata", CustomerLastName = "Płacz", CustomerPhoneNumber = "123456789", CustomerEmail = "placz.malgorzata@gmail.com", AppointmentDate = new DateTime(2020, 1, 01, hour: 14, minute: 45, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Aurelia", CustomerLastName = "Klon", CustomerPhoneNumber = "536710649", CustomerEmail = "klon.aurelia@gmail.com", AppointmentDate = new DateTime(2020, 3, 03, hour: 16, minute: 30, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Mirek", CustomerLastName = "Dzięcioł", CustomerPhoneNumber = "234567890", CustomerEmail = "dzieciol.mirek@gmail.com", AppointmentDate = new DateTime(2020, 3, 05, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Fatima", CustomerLastName = "Borówka", CustomerPhoneNumber = "123456789", CustomerEmail = "borowka.fatima@gmail.com", AppointmentDate = new DateTime(2020, 3, 02, hour: 14, minute: 45, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Aurora", CustomerLastName = "Krzywa", CustomerPhoneNumber = "536710649", CustomerEmail = "krzywa.aurora@gmail.com", AppointmentDate = new DateTime(2020, 3, 05, hour: 16, minute: 30, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Bożydar", CustomerLastName = "Prosty", CustomerPhoneNumber = "234567890", CustomerEmail = "prosty.bozydar@gmail.com", AppointmentDate = new DateTime(2020, 3, 06, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Mieszko", CustomerLastName = "Ciągły", CustomerPhoneNumber = "123456789", CustomerEmail = "ciagly.mieszko@gmail.com", AppointmentDate = new DateTime(2020, 3, 24, hour: 14, minute: 45, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Pola", CustomerLastName = "Futro", CustomerPhoneNumber = "536710649", CustomerEmail = "futro.pola@gmail.com", AppointmentDate = new DateTime(2020, 4, 20, hour: 16, minute: 30, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Mieczysław", CustomerLastName = "Norka", CustomerPhoneNumber = "234567890", CustomerEmail = "norka.mieczyslaw@gmail.com", AppointmentDate = new DateTime(2020, 4, 22, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Zygmunt", CustomerLastName = "Szpadel", CustomerPhoneNumber = "123456789", CustomerEmail = "szpadel.zygmunt@gmail.com", AppointmentDate = new DateTime(2020, 4, 24, hour: 14, minute: 45, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Julia", CustomerLastName = "Kieliszek", CustomerPhoneNumber = "536710649", CustomerEmail = "kieliszek.julia@gmail.com", AppointmentDate = new DateTime(2020, 4, 14, hour: 16, minute: 30, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Harry", CustomerLastName = "Szampan", CustomerPhoneNumber = "234567890", CustomerEmail = "szampan.harry@gmail.com", AppointmentDate = new DateTime(2020, 2, 17, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Oskar", CustomerLastName = "Zakrętka", CustomerPhoneNumber = "123456789", CustomerEmail = "zakretka.oskar@gmail.com", AppointmentDate = new DateTime(2020, 2, 28, hour: 14, minute: 45, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Grzegorz", CustomerLastName = "Etykieta", CustomerPhoneNumber = "536710649", CustomerEmail = "etykieta.grzegorz@gmail.com", AppointmentDate = new DateTime(2020, 2, 14, hour: 16, minute: 30, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Wiktoria", CustomerLastName = "Napis", CustomerPhoneNumber = "234567890", CustomerEmail = "napis.wiktoria@gmail.com", AppointmentDate = new DateTime(2020, 2, 08, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Sabina", CustomerLastName = "Druk", CustomerPhoneNumber = "123456789", CustomerEmail = "druk.sabina@gmail.com", AppointmentDate = new DateTime(2020, 2, 01, hour: 14, minute: 45, second: 0), isConfirmed = true, isDone = false },
                    new Appointment { CustomerFirstName = "Mściwój", CustomerLastName = "Procent", CustomerPhoneNumber = "536710649", CustomerEmail = "procent.msciwoj@gmail.com", AppointmentDate = new DateTime(2020, 2, 02, hour: 16, minute: 30, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Agata", CustomerLastName = "Korek", CustomerPhoneNumber = "234567890", CustomerEmail = "korek.agata@gmail.com", AppointmentDate = new DateTime(2020, 2, 03, hour: 12, minute: 15, second: 0), isConfirmed = false, isDone = false },
                    new Appointment { CustomerFirstName = "Sylwester", CustomerLastName = "Nalewka", CustomerPhoneNumber = "123456789", CustomerEmail = "nalewka.sylwester@gmail.com", AppointmentDate = new DateTime(2020, 1, 25, hour: 14, minute: 45, second: 0), isConfirmed = true, isDone = false }
                    );
            }
            if (!appDbContext.Comments.Any())
            {
                appDbContext.Comments.AddRange
                    (
                    new Comment { UserName = "MacDon99", Message = "Can I change the date?", AppointmentId = 1 },
                    new Comment { UserName = "Kamiltcz", Message = "Koza chuj", AppointmentId = 2}
                    );
            }
            if (!appDbContext.Opinions.Any())
            {
                appDbContext.AddRange
                    (
                    new Opinion { UserName = "MacDon99", Message = "I strongly recommend this specialists, he helped me with all my issues." },
                    new Opinion { UserName = "Martyna245", Message = "He's a very calm and peacefull therapists."}
                    );
            }
            appDbContext.SaveChanges();
        }
    }
}
