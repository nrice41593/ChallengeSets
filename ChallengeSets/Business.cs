using System;
namespace ChallengeSets
{
    public class Business
    {
        public string Name { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalExpenses { get; set; }
        public Business ParentCompany { get; set; }
        public int Length { get; internal set; }

        internal string ToString(object p)
        {
            throw new NotImplementedException();
        }
    }
}
