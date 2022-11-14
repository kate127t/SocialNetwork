using DAL_SN.Concrete;
using DAL_SN.ConcreteNeo4J;
using DAL_SN.Interfaces;
using Models_SN;
using Models_SN.ModelsNeo4J;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SN
{
    public class UsersBLL
    {
        IUserDAL userDALmongoDB;
        UserDALNeo4J userDALNeo4J;
        UsersBLL()
        {
            this.userDALmongoDB = new UserDAL();
            this.userDALNeo4J = new UserDALNeo4J();
        }

        public void create(User user)
        {
            UserNeo4J userNeo4J = new UserNeo4J();
            userDALmongoDB.create(user);
            User userWithNewID = userDALmongoDB.read("email",user.Email);
            userNeo4J.SetValuesFromUser(userWithNewID);
            userDALNeo4J.create(userNeo4J);
        }

        public void delete(User user)
        {
            UserNeo4J userNeo4J = new UserNeo4J();
            userNeo4J.SetValuesFromUser(user);
            userDALmongoDB.delete(user);
            userDALNeo4J.delete(userNeo4J);
        }

        public int countFollowers(User user)
        {
            return userDALNeo4J.countFollowers(user.Id);
        }

        public int countFollows(User user)
        {
            return userDALNeo4J.countFollows(user.Id);
        }

        public int countShortestPath(User user1,User user2)
        {
            return userDALNeo4J.countShortestPath(user1.Id,user2.Id);
        }

        public bool CheckIfFollows(User user1, User user2)
        {
            return userDALNeo4J.CheckIfFollows(user1.Id, user2.Id);
        }

        public void follow (User userFollows,User userToFollow)
        {
            userFollows.Following.Add(userToFollow.Id);
            userToFollow.Followers.Add(userFollows.Id);

            userDALmongoDB.update(userFollows);
            userDALmongoDB.update(userToFollow);

            userDALNeo4J.follow(userFollows.Id, userToFollow.Id);
        }

        public void unfollow(User userUnfollows, User userToUnfollow)
        {
            userUnfollows.Following.Remove(userToUnfollow.Id);
            userToUnfollow.Followers.Remove(userUnfollows.Id);

            userDALmongoDB.update(userUnfollows);
            userDALmongoDB.update(userToUnfollow);

            userDALNeo4J.follow(userUnfollows.Id, userToUnfollow.Id);
        }

    }
}
