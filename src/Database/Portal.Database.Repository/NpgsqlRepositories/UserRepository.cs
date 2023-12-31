﻿using Microsoft.EntityFrameworkCore;
using Portal.Common.Converter;
using Portal.Common.Core;
using Portal.Common.Enums;
using Portal.Database.Context;
using Portal.Database.Core.Repositories;

namespace Portal.Database.Repositories.NpgsqlRepositories;

public class UserRepository: BaseRepository, IUserRepository
{
    private readonly PortalDbContext _context;

    public UserRepository(PortalDbContext context)
    {
        _context = context;
    }
    
    public Task<List<User>> GetAllUsersAsync()
    {
        return _context.Users
            .Select(u => UserConverter.ConvertDBToCoreModel(u))
            .ToListAsync();
    }

    public async Task<User> GetUserByIdAsync(Guid userId)
    {
        var user = await _context.Users.FirstAsync(u => u.Id == userId);

        return UserConverter.ConvertDBToCoreModel(user);
    }

    public Task<List<User>> GetAdmins()
    {
        return _context.Users.Where(u => u.Role == Role.Administrator)
            .Select(u => UserConverter.ConvertDBToCoreModel(u))
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        var user = await _context.Users.FirstAsync(u => u.Email == email);

        return UserConverter.ConvertDBToCoreModel(user);
    }

    public async Task InsertUserAsync(User user)
    {
        var userDb = UserConverter.ConvertCoreToDBModel(user);
        
        await _context.Users.AddAsync(userDb);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(User user)
    {
        var userDb = await _context.Users.FirstAsync(u => u.Id == user.Id);

        userDb.LastName = user.LastName;
        userDb.FirstName = user.FirstName;
        userDb.MiddleName = user.MiddleName;
        userDb.Birthday = user.Birthday;
        userDb.Email = user.Email;
        userDb.Gender = user.Gender;
        userDb.Phone = user.Phone;
        userDb.Role = user.Role;
        userDb.PasswordHash = user.PasswordHash;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(Guid userId)
    {
        var user = await _context.Users.FirstAsync(u => u.Id == userId);
        
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}