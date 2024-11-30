using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BasicDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("BasicDbContextString")));
            
            services.AddControllersWithViews();
        }
    }
}