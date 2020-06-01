using System.Collections.Generic;

namespace Innoscripta.Pizza.Contracts
{
    public class PartialLoadDataResponse<TData>: BaseResponse
    {
        public IEnumerable<TData> Items { get; set; }
        public bool MoreItemsExists { get; set; }
        public long TotalCount { get; set; }

        public static PartialLoadDataResponse<TData> Empty
        {
            get => new PartialLoadDataResponse<TData>()
            {
                Items = new List<TData>(),
                TotalCount = 0,
                MoreItemsExists = false
            };
        }
    }
}