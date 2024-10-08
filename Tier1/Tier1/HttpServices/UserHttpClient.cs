﻿using System.Text.Json;
using Contracts;
using Entities.Models;

namespace HttpServices;

public class UserHttpClient : IUserService
{
    public async Task CreateUserAsync(User user)
    {
        try
        {
            string client = await ClientAPI.getContent(Methods.Post, "/user", user);
            User user1 = JsonSerializer.Deserialize<User>(client, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })!;
            Console.Write(user1.Username);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<User> GetUserAsync(string username)
    {
        try
        {
            string content = await ClientAPI.getContent(Methods.Get, $"/user/{username}");
            
            User user  = JsonSerializer.Deserialize<User>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })!;
            return user;

        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public async Task<User> GetUserLogin(string username, string password)
    {
        try
        {
            string content = await ClientAPI.getContent(Methods.Get, $"/user/{username}/{password}");
            
            User user  = JsonSerializer.Deserialize<User>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })!;
            return user;

        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public Task DeleteUser(string id)
    {
        throw new NotImplementedException();
    }

    public Task Update(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUserById(string id)
    {
        throw new NotImplementedException();
    }
}