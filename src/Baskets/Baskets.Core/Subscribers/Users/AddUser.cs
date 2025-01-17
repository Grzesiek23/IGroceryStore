﻿using IGroceryStore.Baskets.Core.Entities;
using IGroceryStore.Baskets.Core.Persistence;
using IGroceryStore.Users.Contracts.Events;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IGroceryStore.Baskets.Core.Subscribers.Users;

public class AddUser : IConsumer<UserCreated>
{
    private readonly ILogger<AddUser> _logger;
    private readonly BasketsDbContext _basketsDbContext;

    public AddUser(ILogger<AddUser> logger, BasketsDbContext basketsDbContext)
    {
        _logger = logger;
        _basketsDbContext = basketsDbContext;
    }

    public async Task Consume(ConsumeContext<UserCreated> context)
    {
        var (userId, firstName, lastName) = context.Message;
        if (await _basketsDbContext.Users.AnyAsync(x => x.Id.Equals(userId))) return;

        var user = new User(userId, firstName, lastName);
        await _basketsDbContext.Users.AddAsync(user);
        await _basketsDbContext.SaveChangesAsync();
        _logger.LogInformation("User {UserId} added to basket database", userId);
    }
}