namespace designPatterns.uj_design_patterns_assignments.facade;


class PatronRecord
{
    internal string PatronID { get; init; }
    internal string Type { get; init; }
    internal DateTime DateOfMembership { get; init; }
    internal int NoBooksIssued { get; set; } = 0;
    internal int MaxBookLimit { get; set; }
    internal string Name { get; set; }
    internal string Address { get; set; }
    internal string PhoneNo { get; set; }
    internal decimal FinesOwed { get; set; } = 0.0M;

    public PatronRecord(string patronID, string type, int maxBookLimit, string name, string address, string phoneNo)
    {
        PatronID = patronID;
        Type = type;
        DateOfMembership = DateTime.Now;
        MaxBookLimit = maxBookLimit;
        Name = name;
        Address = address;
        PhoneNo = phoneNo;
    }
}
