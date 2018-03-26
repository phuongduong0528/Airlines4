using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Services.Dto
{
    [DataContract]
    public class SurveyResult
    {
        [DataMember(Name = "all", Order = 0)]
        [DisplayName("All")]
        public int All { get; set; }

        //[DataMember(Name = "name", Order = 0)]
        //[DisplayName("Name")]
        //public string Name { get; set; }

        [DataMember(Name = "male", Order = 1)]
        [DisplayName("Male")]
        public int Male { get; set; }

        [DataMember(Name = "female", Order = 2)]
        [DisplayName("Female")]
        public int Female { get; set; }

        [DataMember(Name = "a_18_24", Order = 3)]
        [DisplayName("18-24")]
        public int A_18_24 { get; set; }

        [DataMember(Name = "a_25_39", Order = 4)]
        [DisplayName("25-39")]
        public int A_25_39 { get; set; }

        [DataMember(Name = "a_40_59", Order = 5)]
        [DisplayName("40-59")]
        public int A_40_59 { get; set; }

        [DataMember(Name = "a_60p", Order = 6)]
        [DisplayName("60+")]
        public int A_60P { get; set; }

        [DataMember(Name = "economy", Order = 7)]
        [DisplayName("Economy")]
        public int Economy { get; set; }

        [DataMember(Name = "business", Order = 8)]
        [DisplayName("Business")]
        public int Business { get; set; }

        [DataMember(Name = "first", Order = 9)]
        [DisplayName("First")]
        public int First { get; set; }

        [DataMember(Name = "auh", Order = 10)]
        [DisplayName("AUH")]
        public int AUH { get; set; }

        [DataMember(Name = "bah", Order = 11)]
        [DisplayName("BAH")]
        public int BAH { get; set; }

        [DataMember(Name = "doh", Order = 12)]
        [DisplayName("DOH")]
        public int DOH { get; set; }

        [DataMember(Name = "ruh", Order = 13)]
        [DisplayName("RUH")]
        public int RUH { get; set; }

        [DataMember(Name = "cai", Order = 14)]
        [DisplayName("CAI")]
        public int CAI { get; set; }
}
}
