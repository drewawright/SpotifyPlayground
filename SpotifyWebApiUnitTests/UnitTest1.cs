using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;

namespace SpotifyWebApiUnitTests
{
    [TestClass]
    public class UnitTest1
    {

        private string _auth = "Bearer BQA80V4Ec9LijrW9UHUtoiDHWVAeNXFZ38wSzV0OCbPaGcT6_zvGtMdZ-IXUCHyOHYGoBBAJ6g-tRxIKqLa1sDeLga7Dz1haTNk1Yk31Ml-2ikrpivTQROyGMGLbGM9fjnrFujDQHB7XWuUYvfuDDIdQ5r8JNh0kCqlze5rIu-rxAnMnCfYJafBY_NnIlMqIOweh-XYyurC0g14kC4EwhDen5HXetTHgpqVValiC8mhu2i8lpRCxRRV4d4uz3zQa7i8mr4zITJ02DxnSN--e";
        [TestMethod]
        public void TestMethod1()
        {
            SpotifyWebAPI api = new SpotifyWebAPI
            {
                AccessToken = "BQA80V4Ec9LijrW9UHUtoiDHWVAeNXFZ38wSzV0OCbPaGcT6_zvGtMdZ-IXUCHyOHYGoBBAJ6g-tRxIKqLa1sDeLga7Dz1haTNk1Yk31Ml-2ikrpivTQROyGMGLbGM9fjnrFujDQHB7XWuUYvfuDDIdQ5r8JNh0kCqlze5rIu-rxAnMnCfYJafBY_NnIlMqIOweh-XYyurC0g14kC4EwhDen5HXetTHgpqVValiC8mhu2i8lpRCxRRV4d4uz3zQa7i8mr4zITJ02DxnSN--e",
                TokenType = "Bearer"
            };

            PrivateProfile profile = api.GetPrivateProfile();
            if (!profile.HasError())
            {
                Console.WriteLine(profile.DisplayName);
            }
        }

        [TestMethod]
        public void GetPlaylists()
        {
            SpotifyWebAPI api = new SpotifyWebAPI
            {
                AccessToken = "BQA80V4Ec9LijrW9UHUtoiDHWVAeNXFZ38wSzV0OCbPaGcT6_zvGtMdZ-IXUCHyOHYGoBBAJ6g-tRxIKqLa1sDeLga7Dz1haTNk1Yk31Ml-2ikrpivTQROyGMGLbGM9fjnrFujDQHB7XWuUYvfuDDIdQ5r8JNh0kCqlze5rIu-rxAnMnCfYJafBY_NnIlMqIOweh-XYyurC0g14kC4EwhDen5HXetTHgpqVValiC8mhu2i8lpRCxRRV4d4uz3zQa7i8mr4zITJ02DxnSN--e",
                TokenType = "Bearer"
            };

            PrivateProfile profile = api.GetPrivateProfile();
            if (!profile.HasError())
            {
                //Console.WriteLine(profile.DisplayName);
            }

            Paging<SimplePlaylist> playlists = api.GetUserPlaylists(profile.Id);
            if (!playlists.HasError())
            {
                Console.WriteLine(playlists.Items[2].Id);
            }

            Paging<PlaylistTrack> playlistTracks = api.GetPlaylistTracks("0RNQIe8IxhaLvIQDWM7Pur");
            if (!playlistTracks.HasError())
            {
                Console.WriteLine(playlistTracks.Items[2].Track.Id);
            }

            AudioFeatures audioFeature = api.GetAudioFeatures("3E3pWLixkFdKw7Ylj1NFoc");
            if (!audioFeature.HasError())
            {
                Console.WriteLine(audioFeature.Speechiness);
            }
        }
    }
}
