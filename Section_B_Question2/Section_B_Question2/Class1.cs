using System;

public class CitizenProfile
{
    public string FullName { get; set; }
    public string IDNumber { get; set; }
    public string CitizenshipStatus { get; set; }
    public int Age { get; private set; }

    public CitizenProfile(string name, string id, string status)
    {
        FullName = name;
        IDNumber = id;
        CitizenshipStatus = status;
        CalculateAge();
    }

    private void CalculateAge()
    {
        // 1. Extract values
        int yy = int.Parse(IDNumber.Substring(0, 2));
        int mm = int.Parse(IDNumber.Substring(2, 2));
        int dd = int.Parse(IDNumber.Substring(4, 2));

        // 2. Validate the date components before creating a DateTime
        if (mm < 1 || mm > 12 || dd < 1 || dd > 31)
        {
            throw new ArgumentException("Invalid birth date encoded in ID number.");
        }

        // Determine century (Standard South African ID logic)
        int yearPrefix = (yy <= DateTime.Now.Year % 100) ? 2000 : 1900;
        int birthYear = yearPrefix + yy;

        // 3. Final safety check using DateTime.DaysInMonth
        if (dd > DateTime.DaysInMonth(birthYear, mm))
        {
            throw new ArgumentException("Invalid day for the given month.");
        }

        DateTime birthDate = new DateTime(birthYear, mm, dd);
        DateTime today = DateTime.Today;

        Age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-Age)) Age--;
    }
}