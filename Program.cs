using ObjectOfYourAffection;

Profile _sam = new Profile("Sam Drakilla", 30, "NY", "USA", "he/him");
_sam.SetHobbies(new string[] { "Ridding bikes", "Ridding Horses" });
Console.WriteLine(_sam.ViewProfile());