using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Mywebproject_core.Models.Mymodel;

namespace Mywebproject_core.Models
{
    public class Mymodel
    {
        //    public class Candidatedetail
        //    {

        //        public int Candidate_ID { get; set; }
        //        public string Candidate_Name { get; set; }
        //        public string Candidate_State { get; set; }
        //        public string Candidate_status {get; set;}
        //    public ICollection<Electionyear> Electionyears { get; set; }
        //}

        //public class Electionyear
        //{

        //    public string Electionyears_ID { get; set; }
        //    public string Election_district { get; set; }
        //    public string Election_districtnumber { get; set; }
        //    public virtual Candidatedetail Candidatedetail { get; set; }
        //    public virtual Party Party { get; set; }
        //}

        //public class Party
        //{
        //    public int Party_ID { get; set; }
        //    public string committee_Id { get; set; }
        //    public string committee_type { get; set; }
        //    public string committee_treasurername { get; set; }
        //    public ICollection<Electionyear> Electionyears { get; set; }
        //}

        public class Candidates
        {
            public string api_version { get; set; }
            public Pagination pagination { get; set; }
            public CandidateDetail[] results { get; set; }
        }

        public class Pagination
        {
            public int pages { get; set; }
            public int per_page { get; set; }
            public int page { get; set; }
            public int count { get; set; }
        }

        public class CandidateDetail
        {
            public bool has_raised_funds { get; set; }
            public string first_file_date { get; set; }
            public string party { get; set; }
            public string party_full { get; set; }
            public string last_f2_date { get; set; }
            public string office { get; set; }
            public int[] cycles { get; set; }
            public object inactive_election_years { get; set; }
            public string candidate_status { get; set; }
            public string district { get; set; }
            public string incumbent_challenge_full { get; set; }
            public string name { get; set; }
            public int active_through { get; set; }
            public DateTime load_date { get; set; }
            public string last_file_date { get; set; }
            public string candidate_id { get; set; }
            public bool candidate_inactive { get; set; }
            public string incumbent_challenge { get; set; }
            public string flags { get; set; }
            public string office_full { get; set; }
            public string[] election_districts { get; set; }
            public bool federal_funds_flag { get; set; }
            public int district_number { get; set; }
            public string state { get; set; }
            public int[] election_years { get; set; }

            public Candidates[] candidateresults { get; set; }
        }


    }
}

