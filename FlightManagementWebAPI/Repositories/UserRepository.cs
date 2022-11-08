using DomainModel.Models;
using FlightManagementWebAPI.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagementWebAPI.Repositories
{
    public class UserRepository
    {
        private readonly AirportSystemContext _airportSystemContext;
        public UserRepository(AirportSystemContext airportSystemContext)
        {
            _airportSystemContext = airportSystemContext;
        }
        public List<User> GetUsers()
        {
            return _airportSystemContext.Users.ToList();
        }
        public void InsertUser(User user)
        {
            _airportSystemContext.Users.Add(user);
            _airportSystemContext.SaveChanges();
        }
        public User GetUser(int userId)
        {
            return _airportSystemContext.Users
                .FirstOrDefault(user => user.UserId == userId);
        }
        public User GetUserByUserName(string username)
        {
            var user = _airportSystemContext.Users.FirstOrDefault(user => user.Name == username);
            if (user != null)
                return user;
            else return null;
        }
        public User GetUserRole(string username, string password)
        {
            return _airportSystemContext.Users
                .FirstOrDefault(user => (user.Name == username && user.Password == password));
        }
        public void UpdateUser(User user)
        {
            var userForUpdate = GetUser(user.UserId);
            if (userForUpdate != null)
            {
                userForUpdate.UserRole = user.UserRole;
                userForUpdate.Name = user.Name;
                userForUpdate.Email = user.Email;
                userForUpdate.Password = user.Password;

                _airportSystemContext.SaveChanges();
            }
        }
        public string CheckUser(User user)
        {
            var userForValidate = GetUser(user.UserId);
            if(userForValidate != null)
            {
                if (userForValidate.Name == user.Name &&
                    userForValidate.Password == user.Password)
                    return user.UserRole;
                else return null;
            }
            else return null;

        }
        public void DeleteUser(int userId)
        {
            var userForDelete = GetUser(userId);
            if (userForDelete != null)
            {
                _airportSystemContext.Users.Remove(userForDelete);
                _airportSystemContext.SaveChanges();
            }
        }
    }
}
