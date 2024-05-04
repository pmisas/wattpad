using System.Collections.Generic;
using System.Threading.Tasks; 
using BooksContent.Models; 
public interface IChapterService
{
    Task<IEnumerable<Chapter>> GetChaptersAsync(string bookId);
    Task<Chapter?> GetChapterByIDAsync(string id, string bookId);
    Task<Chapter> CreateChapterAsync(Chapter chapter);
    Task<bool> DeleteChapterAsync(string id);
    Task<bool> UpdateChapterAsync(string id, string bookId, Chapter chapter);
}
