namespace Innoscripta.Pizza.Contracts.Comment
{
    public class AddCommentRequest
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Text { get; set; }
        public byte Stars { get; set; }
    }
}