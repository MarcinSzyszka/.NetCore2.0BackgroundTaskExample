using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FakeDb _fakeDb;

        public IndexModel(FakeDb fakeDb)
        {
            _fakeDb = fakeDb;
        }

        public void OnGet()
        {

        }

        public int GetDbValue()
        {
            return _fakeDb.GetDbValue();
        }
    }
}
