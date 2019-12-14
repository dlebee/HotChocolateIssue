using System.Collections.Generic;

namespace Issue
{
    public class Criteria
    {
        public List<CriteriaMessage> Messages { get; set; }
    }

    public class CriteriaMessage
    {
        public string Message { get; set; }
    }
}