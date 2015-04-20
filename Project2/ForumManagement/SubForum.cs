using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopForum
{
    public class SubForum
    {
        private String name;
        private List<Moderator> moderators;
        private List<Discussion> discussions;
       
        public SubForum(String name, Moderator firstMod)
        {
            this.name = name;
            this.moderators = new List<Moderator>();
            this.moderators.Add(firstMod);
            this.discussions = new List<Discussion>();
        }
       
        public Discussion getDiscussion(String discussionTitle)
        {
            foreach (Discussion disc in discussions)
                if (disc.getTitle() == discussionTitle)
                    return disc;
            return null;
        }

        public List<Discussion> getDiscussions()
        {
            return this.discussions;
        }

        public void addDiscussion(Discussion newDiscussion)
        {
            this.discussions.Add(newDiscussion);
        }

        public String getName()
        {
            return this.name;
        }

        public void addModerator(Moderator mod)
        {
            this.moderators.Add(mod);
        }

        public Moderator getSubForumModerator(String mod)
        {
            foreach (Moderator moder in this.moderators)
                if (mod.Equals(moder.getName()))
                    return moder;
            return null;
        }

    }
}
