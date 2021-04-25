using System.ComponentModel.DataAnnotations;

namespace Mywebproject_core.Models
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

        public string name { get; set; }
        public string party { get; set; }
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
        [Key]

        [Required]
        public string candidate_id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string party { get; set; }

        [Required]
        public string candidate_status { get; set; }
        [Required]
        public string state { get; set; }
    }


    }

