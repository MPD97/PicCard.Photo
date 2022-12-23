﻿namespace PicCard.Photo.Api.Services
{
    public interface IDateTimeProvider
    {
        public DateTime Now { get; }
    }

    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now => DateTime.Now;
    }
}
