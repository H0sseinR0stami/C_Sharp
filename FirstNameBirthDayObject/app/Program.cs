using static System.Console;

using IdentityClass;
using Microsoft.VisualBasic;

Person Adam = new()
{
    FirstName = "Adam",
    LastName = "Green",
    DateOfBirth = new DateTime(1366, 11, 19)
};

WriteLine($"{Adam.FirstName} {Adam.LastName}'s Birthday is on {Adam.DateOfBirth}");