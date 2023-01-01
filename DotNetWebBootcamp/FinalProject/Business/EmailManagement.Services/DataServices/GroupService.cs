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
            return groups.ToList();
        }

        public void Add(GroupModel model)
        {
            Random random = new Random();
            int tempNewId = 0;

            bool hasGenerated = false;

            while(true)
            {
                tempNewId = random.Next(1, 99999999);
                GroupModel searchedModel = groups.FirstOrDefault(x => x.Id == tempNewId);
                if(searchedModel == null)
                {
                    break;
                }
            }

            model.Id = tempNewId;
            groups.Add(model);
        }

        public GroupModel GetById(int id)
        {
           return groups.FirstOrDefault(x => x.Id == id);
        }
        public void Remove(int id)
        {
            GroupModel model = groups.FirstOrDefault(x => x.Id == id);
            if(model != null)
            {
                groups.Remove(model);
            }
        }

        public void Update(GroupModel model)
        {
            GroupModel modelToUpdate = groups.FirstOrDefault(x => x.Id == model.Id);
            if (modelToUpdate != null)
            {
                modelToUpdate.Title = model.Title;
                modelToUpdate.Description = model.Description;
            }
        }

        public List<GroupModel> GetSearch(string query)
        {
            query = query.ToLower().Trim();
            return groups.Where(x=> x.Title.ToLower().Contains(query) 
            || x.Description.ToLower().Contains(query)).ToList();
        }
    }
}
