﻿using System;

namespace Marketplace.Domain
{
    public class ClassifiedAd
    {
        public ClassifiedAdId Id { get; }
        private UserId _ownerId;

        public ClassifiedAd(ClassifiedAdId id, UserId ownerId)
        {
            if (id == default)
                throw new ArgumentException(
                    "Identity must be specified", nameof(id));
           
            Id = id;
            _ownerId = ownerId;
        }

        public void SetTitle(string title) => _title = title;
        public void UpdateText(string text) => _text = text;
        public void UpdatePrice(decimal price) => _price = price;


        private string _title;
        private string _text;
        private decimal _price;
    }
}