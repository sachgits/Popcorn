﻿using GalaSoft.MvvmLight;
using RestSharp.Deserializers;

namespace Popcorn.Models.Cast
{
    public class Actor : ObservableObject
    {
        private string _characterName;
        private string _mediumImage;
        private string _name;
        private string _smallImage;
        private string _smallImagePath = string.Empty;

        [DeserializeAs(Name = "name")]
        public string Name
        {
            get { return _name; }
            set { Set(() => Name, ref _name, value); }
        }

        [DeserializeAs(Name = "character_name")]
        public string CharacterName
        {
            get { return _characterName; }
            set { Set(() => CharacterName, ref _characterName, value); }
        }

        [DeserializeAs(Name = "small_image")]
        public string SmallImage
        {
            get { return _smallImage; }
            set { Set(() => SmallImage, ref _smallImage, value); }
        }

        [DeserializeAs(Name = "medium_image")]
        public string MediumImage
        {
            get { return _mediumImage; }
            set { Set(() => MediumImage, ref _mediumImage, value); }
        }

        /// <summary>
        /// Local path of the downloaded actor's small-sized image
        /// </summary>
        public string SmallImagePath
        {
            get { return _smallImagePath; }
            set { Set(() => SmallImagePath, ref _smallImagePath, value); }
        }
    }
}