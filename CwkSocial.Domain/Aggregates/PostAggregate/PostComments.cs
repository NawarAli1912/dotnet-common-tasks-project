namespace CwkSocial.Domain.Aggregates.PostAggregate
{
    public class PostComment
    {
        public Guid Id { get; private set; }
        public Guid PostId { get; private set; }
        public string Text { get; private set; }
        public Guid UserProfileId { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }

        private PostComment() { }

        // Factories
        public static PostComment Create(Guid postId, string text, Guid userPorfileId)
        {
            return new PostComment
            {
                PostId = postId,
                Text = text,
                UserProfileId = userPorfileId,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }

        // public methods
        public void UpdateText(string newText)
        {
            Text = newText;
            LastModified = DateTime.UtcNow;
        }
    }
}
