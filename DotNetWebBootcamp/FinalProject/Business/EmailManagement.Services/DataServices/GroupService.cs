using EmailManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailManagement.Services.DataServices
{
    public class GroupService
    {
        private IList<GroupModel> groups = new List<GroupModel>();

        public List<GroupModel> GetAll()
        {
            groups.Add(new GroupModel
            {
                Id = 1,
                Title = "First Group",
                Description = "First Group Description"
            });
            groups.Add(new GroupModel
            {
                Id = 2,
                Title = "Second Group",
                Description = "Second Group Description"
            });

            return groups.ToList();
        }
        

    }
}
