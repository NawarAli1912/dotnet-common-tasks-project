using CwkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CwkSocial.Domain.Aggregates.PostAggregate
{
    public class Post
    {
        // back-fileds
        private readonly List<PostComment> _comments = new();
        private readonly List<PostInteraction> _interactions = new();

        public Guid Id { get; private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfile UserProfile { get; private set; }
        public string TextContent { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }
        public IEnumerable<PostComment> Comments { get => _comments; }
        public IEnumerable<PostInteraction> Interactions { get => _interactions; }

        private Post() 
        {
        }

        // Factories
        public static Post Create(Guid userProfileId, string textContent)
        {
            return new Post
            {
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }

        // public methods
        public void UpdateText(string newText)
        {
            TextContent = newText;
            LastModified = DateTime.UtcNow;
        }

        public void AddComment(PostComment newComment)
        {
            _comments.Add(newComment);
        }

        public void RemoveComment(PostComment commentToBeRemoved)
        {
            // TO DO validation
            _comments.Remove(commentToBeRemoved);
        }

        public void AddInteraction(PostInteraction newInteraction)
        {
            _interactions.Add(newInteraction);
        }

        public void RemoveInteraction(PostInteraction interactionToBeRemover)
        {
            _interactions.Remove(interactionToBeRemover);
        }


    }
}
