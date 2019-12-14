using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Issue
{
    public class Query
    {
        public Task<IEnumerable<string>> Contact(Criteria criteria)
        {
            return Task.FromResult(criteria.Messages.Select(t => t.Message));
        }
    }


}