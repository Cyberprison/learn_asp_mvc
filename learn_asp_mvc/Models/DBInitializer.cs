using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace learn_asp_mvc.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone()
            {
                Name = "сяоми",
                Price = 5000,
                Producer = "чайна"
            });

            context.Phones.Add(new Phone()
            {
                Name = "умоляю",
                Price = 3500,
                Producer = "девять мышей"
            });

            context.Phones.Add(new Phone()
            {
                Name = "хуавей",
                Price = 1000,
                Producer = "тайвань"
            });

            base.Seed(context);
        }
    }
}