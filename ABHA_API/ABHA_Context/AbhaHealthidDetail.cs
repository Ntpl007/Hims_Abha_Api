using System;
using System.Collections.Generic;

#nullable disable

namespace ABHA_API.ABHA_Context
{
    public partial class AbhaHealthidDetail
    {
        public string HealthIdNumber { get; set; }
        public string HealthId { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Gender { get; set; }
        public string Districtname { get; set; }
        public string Statename { get; set; }
        public string Mobile { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string StateCode { get; set; }
        public string DistrictCode { get; set; }
        public string ProfilePhoto { get; set; }
        public string TownName { get; set; }
        public string TownCode { get; set; }
        public string PhrAddress { get; set; }
        public string VillageName { get; set; }
        public string VillageCode { get; set; }
        public string SubdistrictName { get; set; }
        public string SubDistrictCode { get; set; }
        public string Address { get; set; }
        public string KycPhoto { get; set; }
        public string ClientId { get; set; }
        public long? PatientId { get; set; }
    }
}
