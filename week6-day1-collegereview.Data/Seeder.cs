using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week6_day1_collegereview.Data.Model;
using System.Data.Entity.Migrations;


namespace week6_day1_collegereview.Data
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext db, bool colleges = true, bool reviews = true)
        {
            if (colleges) SeedColleges(db);
            if (reviews) SeedReviews(db);

        }

        private static void SeedColleges(ApplicationDbContext db)
        {
            db.Colleges.AddOrUpdate(x => x.Name,
                new College() { Name = "Weber State University", Location = "Ogden, UT", CollegeId = 1, Rank = 1, Tuition = 17908 },
                new College() { Name = "Virginia Tech", Location = "Blackburg, VA", CollegeId = 2, Rank = 2, Tuition = 19764 },
                new College() { Name = "Arkansas State University", Location = "Jonesboro, AR", CollegeId = 3, Rank = 3, Tuition = 23454 },
                new College() { Name = "Ohio State University", Location = "Columbus, OH", CollegeId = 4, Rank = 4, Tuition = 22483 },
                new College() { Name = "University of Texas - Austin", Location = "Austin, TX", CollegeId = 5, Rank = 5, Tuition = 21677 },
                new College() { Name = "Syracuse University", Location = "Syracuse, NY", CollegeId = 6, Rank = 6, Tuition = 20345 },
                new College() { Name = "Purdue University", Location = "West Lafayette, IN", CollegeId = 7, Rank = 7, Tuition = 14678 },
                new College() { Name = "Whitman College", Location = "Walla Walla, WA", CollegeId = 8, Rank = 8, Tuition = 26543 },
                new College() { Name = "Florida State University", Location = "Tallahassee, FL", CollegeId = 9, Rank = 9, Tuition = 22345 },
                new College() { Name = "Georgia Southern University", Location = "Statesboro, GA", CollegeId = 10, Rank = 10, Tuition = 16765 },
                new College() { Name = "University of Kansas", Location = "Lawrence, KS", CollegeId = 11, Rank = 11, Tuition = 13465 },
                new College() { Name = "Michigan State University", Location = "East Lansing, MI", CollegeId = 12, Rank = 12, Tuition = 12356 },
                new College() { Name = "Texas A & M University College Station", Location = "College Station, TX", CollegeId = 13, Rank = 13, Tuition = 17908 },
                new College() { Name = "University of Houston", Location = "Houston, TX", CollegeId = 14, Rank = 14, Tuition = 13434 },
                new College() { Name = "Cornell University", Location = "Ithaca, NY", CollegeId = 15, Rank = 15, Tuition = 175843 }

                );
        }

        private static void SeedReviews(ApplicationDbContext db)
        {
            db.Reviews.AddOrUpdate(x => x.Reviewer,
                new Review() { Reviewer = "Joe H.", ReviewText = "Nice school.", ReviewId = 1, Stars = 3, CollegeId = 1 },
                new Review() { Reviewer = "Steven W.", ReviewText = "Love it here!", ReviewId = 1, Stars = 5, CollegeId = 1 },
                new Review() { Reviewer = "Dee T.", ReviewText = "Dorms suck.", ReviewId = 1, Stars = 3, CollegeId = 2 },
                new Review() { Reviewer = "Ricky S.", ReviewText = "The Science dept is fantastic.", ReviewId = 1, Stars = 5, CollegeId = 3 },
                new Review() { Reviewer = "Tammy W.", ReviewText = "Needs improvement.", ReviewId = 1, Stars = 4, CollegeId = 4 },
                new Review() { Reviewer = "Jim M.", ReviewText = "I like it.", ReviewId = 1, Stars = 5, CollegeId = 5 },
                new Review() { Reviewer = "Sue B.", ReviewText = "Nice school.", ReviewId = 1, Stars = 3, CollegeId = 6 },
                new Review() { Reviewer = "Karli W.", ReviewText = "I miss my mommy.", ReviewId = 1, Stars = 1, CollegeId = 6 },
                new Review() { Reviewer = "Frank Q.", ReviewText = "No air conditioning in the whole school.", ReviewId = 1, Stars = 2, CollegeId = 6 },
                new Review() { Reviewer = "Sally D.", ReviewText = "Loving it here.", ReviewId = 1, Stars = 5, CollegeId = 7 },
                new Review() { Reviewer = "George L.", ReviewText = "Nice school.", ReviewId = 1, Stars = 4, CollegeId = 7 },
                new Review() { Reviewer = "Karl H", ReviewText = "Its school.", ReviewId = 1, Stars = 3, CollegeId = 7 },
                new Review() { Reviewer = "Vicci R.", ReviewText = "I love the Art program.", ReviewId = 1, Stars = 5, CollegeId = 8 },
                new Review() { Reviewer = "Ann N.", ReviewText = "Nice school.", ReviewId = 1, Stars = 5, CollegeId = 8 },
                new Review() { Reviewer = "Kim B.", ReviewText = " I hate it here.", ReviewId = 1, Stars = 1, CollegeId = 9 },
                new Review() { Reviewer = "Cliff R.", ReviewText = "Nice school.", ReviewId = 1, Stars = 4, CollegeId = 9 },
                new Review() { Reviewer = "Jacky E.", ReviewText = "Needs more student parking.", ReviewId = 1, Stars = 3, CollegeId = 10 },
                new Review() { Reviewer = "Bobby B.", ReviewText = "Nice school.", ReviewId = 1, Stars = 5, CollegeId = 11 },
                new Review() { Reviewer = "Jack U.", ReviewText = "Its cool.", ReviewId = 1, Stars = 3, CollegeId = 11 },
                new Review() { Reviewer = "Olva J.", ReviewText = "Best professors ever!", ReviewId = 1, Stars = 5, CollegeId = 12 },
                new Review() { Reviewer = "AJ T.", ReviewText = "Nice school.", ReviewId = 1, Stars = 3, CollegeId = 13 },
                new Review() { Reviewer = "Greg W.", ReviewText = "Nice school.", ReviewId = 1, Stars = 5, CollegeId = 14 },
                new Review() { Reviewer = "Peter A.", ReviewText = "Wonderful.", ReviewId = 1, Stars = 5, CollegeId = 15 }
                );
        }
    }
}
