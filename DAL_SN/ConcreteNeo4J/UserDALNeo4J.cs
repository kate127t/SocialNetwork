using DAL_SN.Interfaces;
using Models_SN;
using Models_SN.ModelsNeo4J;
using Neo4jClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SN.ConcreteNeo4J
{
    public class UserDALNeo4J 
    {
        BoltGraphClient client;
        public UserDALNeo4J()
        {
            client = new BoltGraphClient("neo4j+s://a44b087c.databases.neo4j.io:7687", "neo4j", "fs0omvt7OadR3S-Hx7QA3CothZi0UGH17JW2Tq5iW6A");
            client.ConnectAsync().Wait();
        }
        public void create(UserNeo4J user)
        {
            client.Cypher
                .Create("(nu:User $newUser)")
                .WithParam("newUser", user)
                .ExecuteWithoutResultsAsync().Wait();
        }

        public void delete(UserNeo4J user)
        {
            client.Cypher
                .Match("(u:User {_id: $UserID})")
                .WithParam("UserID", user.Id)
                .Delete("u")
                .ExecuteWithoutResultsAsync().Wait();
        }

        public void follow(string personFollowsId, string personToFollowId)
        {
            client.Cypher
                .Match("(u1:User {_id: $UserID1})", "(u2:User {_id: $UserID2})")
                .WithParam("UserID1", personFollowsId)
                .WithParam("UserID2", personToFollowId)
                .Create("(u1) -[:FOLLOWS]->(u2)")
                .ExecuteWithoutResultsAsync().Wait();
        }

        public void unfollow(string personUnfollowsId, string personToUnfollowId)
        {
            client.Cypher
                .Match("(u1:User {_id: $UserID1}) -[r:FOLLOWS]->(u2:User {_id: $UserID2})")
                .WithParam("UserID1", personUnfollowsId)
                .WithParam("UserID2", personToUnfollowId)
                .Delete("r")
                .ExecuteWithoutResultsAsync().Wait();
        }

        public int countFollowers(string userId)
        {
            var followersCount = client.Cypher
                .Match(" (u1:User {_id: $UserID})")
                .WithParam("UserID", userId)
                .Return<int>("COUNT { (u1)-[:FOLLOWS]->(:User) }")
                .ResultsAsync
                .Result;

            return  followersCount.ElementAt(0);
        }

        public int countFollows(string userId)
        {
            var followsCount = client.Cypher
                .Match(" (u1:User {_id: $UserID})")
                .WithParam("UserID", userId)
                .Return<int>("COUNT { (u1)<-[:FOLLOWS]-(:User) }")
                .ResultsAsync
                .Result;

            return followsCount.ElementAt(0);
        }

        public int countShortestPath(string user1Id, string user2Id)
        {
            var shortestPathCount = client.Cypher
               .Match(" (u1:User {_id: $UserID1}),(u2:User {_id: $UserID2}),p = shortestPath((u1)-[*]-(u2))")
               .WithParam("UserID1", user1Id)
               .WithParam("UserID2", user2Id)
               .Return<int>("length(p)")
               .ResultsAsync
               .Result;

            if(shortestPathCount.Count() != 0)
            {
                return shortestPathCount.ElementAt(0);
            }
            return 0;
        }

        public bool CheckIfFollows(string user1Id, string user2Id)
        {
            // Check if user1 ollows user2
            var follows = client.Cypher
                .Match(" (u1:User {_id: $UserID1}),(u2:User {_id: $UserID2})")
                .WithParam("UserID1", user1Id)
                .WithParam("UserID2", user2Id)
                .Return<bool>("exists ((u1) -[:Follows]->(u2))")
                .ResultsAsync
                .Result;

            return follows.ElementAt(0);
        }
    }
}
