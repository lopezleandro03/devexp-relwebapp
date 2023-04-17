using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Relecloud.Web;

public class BadCode
{
   

    //SQL injection vulnerability
    public async Task SqlInjectionProcessRequest(HttpContext ctx)
    {
        var page = ctx.Request.Query["page"];
        var sql = "SELECT * FROM pages WHERE name = '" + page + "'";
        var cmd = new SqlCommand(sql, new SqlConnection("..."));
        var reader = await cmd.ExecuteReaderAsync();
        
    }

    //Regex DDOS
    public void RegExProcessRequest(HttpContext ctx)
    {
        string userInput = ctx.Request.Query["userInput"];

        // BAD: User input is matched against a regex with exponential worst case behavior
        new Regex("^([a-z]*)*$").Match(userInput);

        
    }

    
}
