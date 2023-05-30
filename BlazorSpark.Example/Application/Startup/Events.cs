﻿using BlazorSpark.Example.Application.Events.Listeners;
using BlazorSpark.Example.Application.Events;
using Coravel.Events.Interfaces;
using Coravel;

namespace BlazorSpark.Example.Application.Startup
{
    public static class Events
    {
        public static IServiceProvider RegisterEvents(this IServiceProvider services)
        {
            IEventRegistration registration = services.ConfigureEvents();

            // add events and listeners here
            registration
                .Register<UserCreated>()
                .Subscribe<EmailNewUser>();

            return services;
        }
    }
}
