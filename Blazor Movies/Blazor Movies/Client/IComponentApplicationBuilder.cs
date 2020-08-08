namespace BlazorMovies.Client
{
    public interface IComponentApplicationBuilder
    {
        void AddComponent<T>(string v);
        void AddComponent<T>(IComponentApplicationBuilder app);
    }
}