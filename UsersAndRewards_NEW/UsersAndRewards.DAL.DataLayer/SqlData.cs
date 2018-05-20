using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using UsersAndRewards.Shared;

namespace UsersAndRewards.DAL.DataLayer
{
    public class SqlData : IData
    {
        public void AddReward(Reward reward)
        {
            {
                var connectionString = ConfigurationManager
                    .ConnectionStrings["myConnectionString"]
                    .ConnectionString;
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand();
                    command.CommandText = "InsertReward";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@Title", reward.Title);
                    command.Parameters.AddWithValue("@Description", reward.Description);
                    // command.Parameters.AddWithValue("@rewardIds", );

                    connection.Open();
                    var result = command.ExecuteScalar();
                    var rewardId = result as int?;
                    if (rewardId.HasValue)
                    {
                        reward.RewardId = rewardId.Value;
                    }

                }
            }
        }

        public void AddUser(User user)
        {
            var connectionString = ConfigurationManager
                .ConnectionStrings["myConnectionString"]
                .ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "InsertUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthdate", user.Birthdate);
                //command.Parameters.AddWithValue("@rewardIds", user.Rewards);

                connection.Open();
                var result = command.ExecuteScalar();
                var userId = result as int?;
                if (userId.HasValue)
                {
                    user.UserId = userId.Value;
                }

            }
        }

        public void DeleteReward(int rewardId)
        {
            var connectionString = ConfigurationManager
            .ConnectionStrings["myConnectionString"]
            .ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "DeleteReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@rewardId", rewardId);
                connection.Open();
                var result = command.ExecuteScalar();
            }
        }

        public void DeleteUser(int userId)
        {
            var connectionString = ConfigurationManager
            .ConnectionStrings["myConnectionString"]
            .ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                var result = command.ExecuteScalar();
            }
        }

        public Reward GetRewardById(int rewardId)
        {
            throw new NotImplementedException();
        }

        public List<Reward> GetRewards()
        {
            var rewards = new List<Reward>();
            var connectionString = ConfigurationManager
                .ConnectionStrings["myConnectionString"]
                .ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "GetRewards";
                command.Connection = connection;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rewardId = reader.GetInt32(0);
                        var title = reader.GetString(1);
                        var description = reader.GetString(2);
                        var reward = new Reward();
                        reward.RewardId = rewardId;
                        reward.Title = title;
                        reward.Description = description;
                        rewards.Add(reward);
                    }
                }
            }

            return rewards;
        }

        public User GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            var connectionString = ConfigurationManager
                .ConnectionStrings["myConnectionString"]
                .ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                // command.CommandText = "SELECT UserId, FirstName, LastName, Birthdate FROM [User]";
                command.CommandText = "GetUsers";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userId = reader.GetInt32(0);
                        var firstName = (string)reader["FirstName"];
                        var lastName = reader.GetString(2);
                        var birthdate = reader.GetDateTime(3);
                        var user = new User();
                        user.UserId = userId;
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.Birthdate = birthdate;

                        users.Add(user);
                    }
                }
            }

            return users;
        }

        public void UpdateReward(Reward reward)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            var connectionString = ConfigurationManager
           .ConnectionStrings["myConnectionString"]
            .ConnectionString;
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "UpdateUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@birthdate", user.Birthdate);
                command.Parameters.AddWithValue("@userId", user.UserId);
                connection.Open();
                var result = command.ExecuteScalar();
            }
        }
    }
}
