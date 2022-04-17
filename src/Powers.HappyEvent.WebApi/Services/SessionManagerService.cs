using Newtonsoft.Json;

namespace Powers.HappyEvent.WebApi.Manager
{
    public class SessionManagerService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext?.Session;

        public SessionManagerService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void Set(string key, object value)
        {
            _session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public T Get<T>(string key)
        {
            return JsonConvert.DeserializeObject<T>(_session.GetString(key));
        }
    }
}
