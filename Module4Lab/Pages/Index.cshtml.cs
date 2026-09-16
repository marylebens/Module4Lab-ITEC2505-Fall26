using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4Lab.Pages;

public class IndexModel : PageModel
{
    //Declare an array that holds a list of plays at the Guthrie
    public string[] Shows = { "Hamlet", "Cabaret", "Fire"};

    //Variable to hold the number of shows with long titles
    public int LongTitleCount = 0;

    // OnGet is automatically called when the web page loads
    public void OnGet()
    {
        // Counter variable for loop
        int  i = 0;

        // While loop is going to loop through (iterate) through the array
        // of shows titles and count how many total shows have more than 5 letters
        // in the name
        while (i < Shows.Length) {
            //Test is the length of the current show name is greater than 5
            if (Shows[i].Length > 5) {
                //Increment the total for the number of long titles
                LongTitleCount++;
            }

            //Increment the counter
            i++;
        }
    }
}
