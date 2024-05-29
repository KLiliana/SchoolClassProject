using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SchoolClassProject
{
    public class SchoolClassRepoTests
    {
        [Fact]
        public void GetMostPaidSchoolClass_EmptyRepo_ReturnsNull()
        {
            // Arrange
            SchoolClassRepo repo = new SchoolClassRepo();

            // Act
            SchoolClass result = repo.GetMostPaidSchoolClass();

            // Assert
            Assert.Null(result);
        }

    }
}