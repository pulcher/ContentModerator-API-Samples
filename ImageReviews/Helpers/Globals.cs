﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageReviews
{
    class Globals
    {
        public enum CallType { POST, GET };

        public const int REVIEWS = 2; 
        public const int REVIEW_TAGS = 2; // Adult and Racy 
        public const int REVIEW_TAGS_KEYVALUE_PAIRS = 4; // Boolean and Score
        
        public const int CALLSTATUSOK = 200;
        public const int CALLVOLUMEEXCEEDED = 403;
        public const int CALLRATEEXCEEDED = 429;
        public const int CALLWAITTIME = 1000;

        public const string TOP_DIR = @"d:\repos\ContentModerator-API-Samples\ImageReviews\Sample files\";
        public const string IMAGE_URL = "http://pulcher.biz/samples/images/"; // + Index + ".jpg"
        public const string MODERATED_JSONFILE = TOP_DIR + "moderationoutput"; // + "Index" + ".json"
        public const string REVIEW_REQUEST_CREATION_JSONFILE = TOP_DIR + "reviewrequest.json";

        //Content Moderator Key 
        public const string CONTENTMODERATOR_APIKEY = Secrets.CONTENTMODERATOR_APIKEY;
        public const string REVIEW_TEAM_ID = Secrets.REVIEW_TEAM_ID;

        // All Uris
        public const string APIURI = "https://westus.api.cognitive.microsoft.com/contentmoderator/review/v1.0/teams/YOUR_TEAM_ID/reviews";
    }
}
