using Abp;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MediumDdd.Domain.Article
{
    public class Article // Aggregate Root
    {
        [NotNull]
        public Guid Id { get; private set; }

        [NotNull]
        public Guid UserId { get; private set; } // No navigation property to another aggregate root!

        [NotNull]
        public string Title { get; private set; }

        public string Text { get; private set; }

        public int ClapCount { get; private set; }

        public bool IsPublihed { get; private set; }
        public bool IsEditing { get; private set; }

        //TODO:: Add article labels Collection.

        public Article(
            [NotNull] Guid id,
            [NotNull] Guid userId,
            [NotNull] string title,
            string text)
        {
            Id = id;
            UserId = userId;
            Title = title;
            Text = text;
            ClapCount = 0;
            IsEditing = true;
        }

        private Article() { }
        

        public void SetText(string text)
        {
            Text = Check.NotNullOrWhiteSpace(value: text, nameof(text));
        }
        public void Publish()
        {
            if(IsEditing == true)
            {
                IsEditing = false;
                IsPublihed = true;
            } 
        }

        public void Edit()
        {
            if (IsPublihed == true)
            {
                IsPublihed = false;
                IsEditing = true;
            }
        }

        public void AddClap()
        {
            ClapCount++;
        }
    }
}
