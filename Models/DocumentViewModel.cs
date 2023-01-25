using System;
namespace DocumentingSwagger.Models
{
	public class DocumentViewModel
	{
        public DocumentViewModel(string title, string content)
        {
            Id = Guid.NewGuid();
            Title = title;
            Content = content;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
    }
}

