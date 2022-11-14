using DAL_SN.Interfaces;
using Models_SN;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SN.Concrete
{
    public class PostDAL : IPostDAL
    {
        public void create(Post post)
        {
            Connection.postCollection.InsertOne(post);
        }

        public void delete(Post post)
        {
            Connection.postCollection.DeleteOne(p => p.Id == post.Id);
        }

        public Post read(string Field, string Value)
        {
            var filterBuilder = Builders<Post>.Filter;
            var filter = filterBuilder.Eq(Field, Value);
            List<Post> post = Connection.postCollection.Find(filter).ToList();
            CheckIfLikesCommentsNotNull(post[0]);
            return post[0];
        }

        public void update(Post post)
        {
            var filter = Builders<Post>.Filter.Eq(s => s.Id, post.Id);
            var result = Connection.postCollection.ReplaceOneAsync(filter, post);
        }

        public List<Post> readManyByDate(int skip,int limit)
        {
            //List<Post> posts = Connection.postCollection.Find.SortBy.Ascending("date").ToList();
            var posts = Connection.postCollection.Find(e => true).SortByDescending(e => e.Date).Skip(skip).Limit(limit).ToList();
            for(int i = 0; i < posts.Count; i++)
            {
                //CheckIfLikesCommentsNotNull(posts[i]);
            }
            return posts;
        }

        public List<Comment> getComments(Post post,int skip,int limit)
        {
            var comments = Connection.commentCollection.Find(e => post.Comments.Contains(e.Id)).SortByDescending(e => e.Date).Skip(skip).Limit(limit).ToList();
            return comments;
        }

        public List<Like> getLikes(Post post, int skip, int limit)
        {
            var likes = Connection.likeCollection.Find(e => post.Likes.Contains(e.Id)).SortByDescending(e => e.Date).Skip(skip).Limit(limit).ToList();
            return likes;
        }

        private void CheckIfLikesCommentsNotNull(Post post)
        {
            if (post.Likes == null)
            {
                post.Likes = new List<string>();
            }
            if (post.Comments == null)
            {
                post.Comments = new List<string>();
            }
        }

        public bool UserLikedPost(Post post,User user)
        {
            var db = Connection.database;
            IMongoCollection<BsonDocument> postCollectionBSon = db.GetCollection<BsonDocument>("posts");
            IMongoCollection<BsonDocument> likeCollectionBSon = db.GetCollection<BsonDocument>("likes");
            var filterPost = Builders<BsonDocument>.Filter.ElemMatch<BsonDocument>("posts", Builders<BsonDocument>.Filter.Eq(c => c["_id"], ObjectId.Parse(post.Id)));
            var filterLike = Builders<BsonDocument>.Filter.ElemMatch<BsonDocument>("likes", Builders<BsonDocument>.Filter.Eq(c => c["author._id"], ObjectId.Parse(user.Id)));
            List<BsonDocument> post_likes =  postCollectionBSon.Aggregate().Lookup("likes", "likes", "{ {$toString: \"_id\"} }","post_likes").Match(filterPost).Match(filterLike).ToList();
            int counter = post_likes.Count();
            if(counter == 0)
            {
                return false;
            }
            return true;
        }
    }
}
