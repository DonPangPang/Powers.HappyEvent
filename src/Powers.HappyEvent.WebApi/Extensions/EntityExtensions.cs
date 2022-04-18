using Powers.HappyEvent.Abstracts;
using Powers.HappyEvent.Shared;
using Powers.HappyEvent.WebApi.Manager;

namespace Powers.HappyEvent.WebApi.Extensions
{
    public static class EntityExtensions
    {
        public static SessionManagerService _sessionManagerService { get; set; }

        public static void Configure(SessionManagerService sessionManagerService)
        {
            _sessionManagerService = sessionManagerService;
        }
        
        public static IApplicationBuilder UseEntity(this IApplicationBuilder app)
        {
            using(var scoped = app.ApplicationServices.CreateScope())
            {
                var sessionManagerService = scoped.ServiceProvider.GetService<SessionManagerService>();
                Configure(sessionManagerService);
            }
            
            return app;
        }

        public static void Update<T>(this T entity) where T : EntityBase
        {
            if(_sessionManagerService.Get<User>("happy-login") is { } user)
            {
                entity.ModifyUserId = user.Id;
                entity.ModifyUserName = user.Name;
            }
        }
        
        public static void Create<T>(this T entity) where T : EntityBase
        {
            entity.Id = Guid.NewGuid();
            if(_sessionManagerService.Get<User>("happy-login") is { } user)
            {
                entity.CreateUserId = user.Id;
                entity.CreateUserName = user.Name;
            }
        }
    }
}
