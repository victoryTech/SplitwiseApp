using SplitwiseExpenseApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitwiseExpenseApp.Controller
{
    public class GroupController
    {
        List<Group> groupList;

        public GroupController()
        {
            groupList = new List<Group>();
        }

        //create group
        public void createNewGroup(String groupId, String groupName, User createdByUser)
        {

            //create a new group
            Group group = new Group();
            group.setGroupId(groupId);
            group.setGroupName(groupName);

            //add the user into the group, as it is created by the USER
            group.addMember(createdByUser);

            //add the group in the list of overall groups
            groupList.Add(group);
        }

        public Group getGroup(String groupId)
        {

            foreach (Group group in groupList)
            {

                if (group.getGroupId().Equals(groupId))
                {
                    return group;
                }
            }
            return null;
        }
    }
}
