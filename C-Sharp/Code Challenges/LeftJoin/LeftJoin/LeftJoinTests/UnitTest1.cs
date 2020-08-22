using Xunit;
using static LeftJoin.LeftJoin;
using System.Collections.Generic;

namespace LeftJoinTests
{
    public class UnitTest1
    {
        [Fact]
        public void JoinWorks()
        {
            // Assign
            Dictionary<string, string> synonyms = new Dictionary<string, string>();
            Dictionary<string, string> antonyms = new Dictionary<string, string>();
            synonyms.Add("Happy", "Joyful");
            antonyms.Add("Happy", "Sad");
            // Act
            var expected = new string[][]
            {
                new string[] { "Happy", "Joyful", "Sad" }
            };
            var actual = Join(synonyms, antonyms);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void JoinWorksWithANullRightValue()
        {
            // Assign
            Dictionary<string, string> synonyms = new Dictionary<string, string>();
            Dictionary<string, string> antonyms = new Dictionary<string, string>();
            synonyms.Add("Happy", "Joyful");
            synonyms.Add("Light", "Reveal");
            antonyms.Add("Happy", "Sad");
            // Act
            var expected = new string[][]
            {
                new string[] { "Happy", "Joyful", "Sad" },
                new string[] { "Light", "Reveal", "null" }
            };
            var actual = Join(synonyms, antonyms);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void JoinWorksWithABigGrouping()
        {
            // Assign
            Dictionary<string, string> synonyms = new Dictionary<string, string>();
            Dictionary<string, string> antonyms = new Dictionary<string, string>();

            synonyms.Add("Happy", "Joyful");
            synonyms.Add("Light", "Reveal");
            synonyms.Add("Fond", "Enamored");
            synonyms.Add("Wrath", "Anger");
            synonyms.Add("Diligent", "Employed");
            synonyms.Add("Guide", "Usher");
            synonyms.Add("Smooth", "Frictionless");

            antonyms.Add("Happy", "Sad");
            antonyms.Add("Light", "Darken");
            antonyms.Add("Fond", "Averse");
            antonyms.Add("Wrath", "Delight");
            antonyms.Add("Diligent", "Idle");
            antonyms.Add("Guide", "Follow");
            antonyms.Add("Smooth", "Rough");

            // Act
            var expected = new string[][]
            {
                new string[] { "Happy", "Joyful", "Sad" },
                new string[] { "Light", "Reveal", "Darken" },
                new string[] { "Fond", "Enamored", "Averse" },
                new string[] { "Wrath", "Anger", "Delight" },
                new string[] { "Diligent", "Employed", "Idle" },
                new string[] { "Guide", "Usher", "Follow" },
                new string[] { "Smooth", "Frictionless", "Rough" },
            };
            var actual = Join(synonyms, antonyms);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
