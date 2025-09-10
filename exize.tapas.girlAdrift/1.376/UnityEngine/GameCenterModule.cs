class <Module>
{
}

namespace UnityEngine
{
    class Social
    {
        static /*0x115d484*/ UnityEngine.SocialPlatforms.ISocialPlatform get_Active();
        static /*0x115d4f0*/ void set_Active(UnityEngine.SocialPlatforms.ISocialPlatform value);
        static /*0x115d588*/ UnityEngine.SocialPlatforms.ILocalUser get_localUser();
        static /*0x115d620*/ void ReportProgress(string achievementID, double progress, System.Action<bool> callback);
        static /*0x115d6e4*/ void ReportScore(long score, string board, System.Action<bool> callback);
        static /*0x115d7a8*/ void ShowAchievementsUI();
        static /*0x115d844*/ void ShowLeaderboardUI();
    }

    namespace SocialPlatforms
    {
        class Local : UnityEngine.SocialPlatforms.ISocialPlatform
        {
            static /*0x0*/ UnityEngine.SocialPlatforms.Impl.LocalUser m_LocalUser;
            /*0x10*/ System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.UserProfile> m_Friends;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.UserProfile> m_Users;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.AchievementDescription> m_AchievementDescriptions;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.Achievement> m_Achievements;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.SocialPlatforms.Impl.Leaderboard> m_Leaderboards;

            /*0x115e720*/ Local();
            /*0x115d8e0*/ UnityEngine.SocialPlatforms.ILocalUser get_localUser();
            /*0x115d9cc*/ void ReportProgress(string id, double progress, System.Action<bool> callback);
            /*0x115e008*/ void ReportScore(long score, string board, System.Action<bool> callback);
            /*0x115e50c*/ bool UnityEngine.SocialPlatforms.ISocialPlatform.GetLoading(UnityEngine.SocialPlatforms.ILeaderboard board);
            /*0x115e650*/ void ShowAchievementsUI();
            /*0x115e6b8*/ void ShowLeaderboardUI();
            /*0x115dea4*/ bool VerifyUser();
        }

        class ActivePlatform
        {
            static /*0x0*/ UnityEngine.SocialPlatforms.ISocialPlatform _active;

            static /*0x115d488*/ UnityEngine.SocialPlatforms.ISocialPlatform get_Instance();
            static /*0x115d53c*/ void set_Instance(UnityEngine.SocialPlatforms.ISocialPlatform value);
            static /*0x115e88c*/ UnityEngine.SocialPlatforms.ISocialPlatform SelectSocialPlatform();
        }

        interface ISocialPlatform
        {
            UnityEngine.SocialPlatforms.ILocalUser get_localUser();
            void ReportProgress(string achievementID, double progress, System.Action<bool> callback);
            void ReportScore(long score, string board, System.Action<bool> callback);
            void ShowAchievementsUI();
            void ShowLeaderboardUI();
            bool GetLoading(UnityEngine.SocialPlatforms.ILeaderboard board);
        }

        interface ILocalUser : UnityEngine.SocialPlatforms.IUserProfile
        {
            bool get_authenticated();
        }

        enum UserState
        {
            Online = 0,
            OnlineAndAway = 1,
            OnlineAndBusy = 2,
            Offline = 3,
            Playing = 4,
        }

        interface IUserProfile
        {
            string get_userName();
            string get_id();
        }

        interface IAchievement
        {
        }

        interface IAchievementDescription
        {
        }

        interface IScore
        {
        }

        enum UserScope
        {
            Global = 0,
            FriendsOnly = 1,
        }

        enum TimeScope
        {
            Today = 0,
            Week = 1,
            AllTime = 2,
        }

        struct Range
        {
            /*0x10*/ int from;
            /*0x14*/ int count;
        }

        interface ILeaderboard
        {
            bool get_loading();
            string get_id();
            UnityEngine.SocialPlatforms.UserScope get_userScope();
            UnityEngine.SocialPlatforms.Range get_range();
            UnityEngine.SocialPlatforms.TimeScope get_timeScope();
        }

        namespace Impl
        {
            class LocalUser : UnityEngine.SocialPlatforms.Impl.UserProfile, UnityEngine.SocialPlatforms.ILocalUser, UnityEngine.SocialPlatforms.IUserProfile
            {
                /*0x38*/ UnityEngine.SocialPlatforms.IUserProfile[] m_Friends;
                /*0x40*/ bool m_Authenticated;
                /*0x41*/ bool m_Underage;

                /*0x115d970*/ LocalUser();
                /*0x115e9a4*/ bool get_authenticated();
            }

            class UserProfile : UnityEngine.SocialPlatforms.IUserProfile
            {
                /*0x10*/ string m_UserName;
                /*0x18*/ string m_ID;
                /*0x20*/ string m_legacyID;
                /*0x28*/ bool m_IsFriend;
                /*0x2c*/ UnityEngine.SocialPlatforms.UserState m_State;
                /*0x30*/ UnityEngine.Texture2D m_Image;

                /*0x115e8e4*/ UserProfile();
                /*0x115e9ac*/ string ToString();
                /*0x115ebc8*/ string get_userName();
                /*0x115ebc0*/ string get_id();
                /*0x115ebd0*/ bool get_isFriend();
                /*0x115ebd8*/ UnityEngine.SocialPlatforms.UserState get_state();
            }

            class Achievement : UnityEngine.SocialPlatforms.IAchievement
            {
                /*0x10*/ bool m_Completed;
                /*0x11*/ bool m_Hidden;
                /*0x18*/ System.DateTime m_LastReportedDate;
                /*0x20*/ string <id>k__BackingField;
                /*0x28*/ double <percentCompleted>k__BackingField;

                /*0x115dfb4*/ Achievement(string id, double percentCompleted, bool completed, bool hidden, System.DateTime lastReportedDate);
                /*0x115ebe0*/ string ToString();
                /*0x115df94*/ void SetCompleted(bool value);
                /*0x115dfa0*/ void SetHidden(bool value);
                /*0x115dfac*/ void SetLastReportedDate(System.DateTime date);
                /*0x115ee74*/ string get_id();
                /*0x115ee7c*/ void set_id(string value);
                /*0x115ee84*/ double get_percentCompleted();
                /*0x115ee8c*/ void set_percentCompleted(double value);
                /*0x115ee5c*/ bool get_completed();
                /*0x115ee64*/ bool get_hidden();
                /*0x115ee6c*/ System.DateTime get_lastReportedDate();
            }

            class AchievementDescription : UnityEngine.SocialPlatforms.IAchievementDescription
            {
                /*0x10*/ string <id>k__BackingField;

                /*0x115ee94*/ string get_id();
            }

            class Score : UnityEngine.SocialPlatforms.IScore
            {
                /*0x10*/ System.DateTime m_Date;
                /*0x18*/ string m_FormattedValue;
                /*0x20*/ string m_UserID;
                /*0x28*/ int m_Rank;
                /*0x30*/ string <leaderboardID>k__BackingField;
                /*0x38*/ long <value>k__BackingField;

                /*0x115e4ac*/ Score(string leaderboardID, long value, string userID, System.DateTime date, string formattedValue, int rank);
                /*0x115ee9c*/ string ToString();
                /*0x115f160*/ string get_leaderboardID();
                /*0x115f168*/ void set_leaderboardID(string value);
                /*0x115f170*/ long get_value();
                /*0x115f178*/ void set_value(long value);
            }

            class Leaderboard : UnityEngine.SocialPlatforms.ILeaderboard
            {
                /*0x10*/ UnityEngine.SocialPlatforms.IScore[] m_Scores;
                /*0x18*/ string <id>k__BackingField;
                /*0x20*/ UnityEngine.SocialPlatforms.UserScope <userScope>k__BackingField;
                /*0x24*/ UnityEngine.SocialPlatforms.Range <range>k__BackingField;
                /*0x2c*/ UnityEngine.SocialPlatforms.TimeScope <timeScope>k__BackingField;

                /*0x115e5a4*/ bool get_loading();
                /*0x115e504*/ void SetScores(UnityEngine.SocialPlatforms.IScore[] scores);
                /*0x115f180*/ string get_id();
                /*0x115f188*/ UnityEngine.SocialPlatforms.UserScope get_userScope();
                /*0x115f190*/ UnityEngine.SocialPlatforms.Range get_range();
                /*0x115f198*/ UnityEngine.SocialPlatforms.TimeScope get_timeScope();
                /*0x115e4a4*/ UnityEngine.SocialPlatforms.IScore[] get_scores();
            }
        }
    }
}
