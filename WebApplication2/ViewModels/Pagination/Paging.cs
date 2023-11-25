namespace WebApplication2.ViewModels.Pagination;

public class Paging<T>
{
    public Paging()
    {
        Page = 1;
        Take = 2;
        HowManyPagesShowAfterBefore = 3;
    }
    public int AllEntitiesCount { get; set; }
    public int Take { get; set; }
    public int Skip { get; set; }
    public int Page { get; set; }
    public int PagesCount { get; set; }
    public int StartPage { get; set; }
    public int EndPage { get; set; }
    public int HowManyPagesShowAfterBefore { get; set; }
    public List<T> Entities { get; set; }

    public void SetPaging(IQueryable<T> query)
    {
        if (Page<=0) Page = 1;
        AllEntitiesCount = query.Count();
        PagesCount = (int)Math.Ceiling(AllEntitiesCount / (double)Take);
        Skip = (Page - 1) * Take;
        Entities = query.Skip(Skip).Take(Take).ToList();
    }
}