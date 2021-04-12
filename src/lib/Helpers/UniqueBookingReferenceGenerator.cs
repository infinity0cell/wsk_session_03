using session_03.src.logic.db;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_03.src.lib.Helpers
{
    public static class UniqueBookingReferenceGenerator
    {
        async public static Task<string> Generate(DatabaseContext db, int length = 6, int maxAttempts = 100)
        {
            var tmp = await db.Tickets.Select(t => t.BookingReference).Distinct().ToListAsync();
            var allReferenceNumbers = new HashSet<string>();
            foreach (var reff in tmp)
                allReferenceNumbers.Add(reff);
            for (int i = 0; i < maxAttempts; i++)
            {
                var reference = RandomString(length);
                if (!allReferenceNumbers.Contains(reference))
                    return reference;
            }
            throw new Exception($"Couldn't generate unique booking reference after {maxAttempts} attempts");
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
