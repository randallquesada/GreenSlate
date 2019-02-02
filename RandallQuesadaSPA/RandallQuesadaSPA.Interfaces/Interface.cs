using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RandallQuesadaSPA.Interfaces
{    
    public interface IUser
    {
        #region Attributes
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        #endregion
    }

    public interface IProject
    {
        #region Attributes
        int Id { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int Credits { get; set; }
        #endregion
    }

    public interface IUserProject
    {
        #region Attributes
        int UserId { get; set; }
        int ProjectId { get; set; }
        bool IsActive { get; set; }
        DateTime AssignedDate { get; set; }
        #endregion
    }

    public interface IUserProjectView
    {
        #region Attributes
        int ProjectId{ get; set; }
        int  UserId{ get; set; }
        DateTime StartDate{ get; set; }
        int TimeToStart{ get; set; }
        DateTime EndDate{ get; set; }
        int Credits{ get; set; }
        string Status{ get; set; }
        #endregion
    }


    public class UserBase : IUser
    {
        public UserBase()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
        }
        [Key]
        public int Id
        { get; set; }

        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }
    }

    public class ProjectBase : IProject
    {
        public ProjectBase()
        {
            this.Credits = 0;
            this.EndDate = DateTime.MinValue;
            this.StartDate = DateTime.MinValue;

        }

        [Key]
        public int Id
        { get; set; }

        public int Credits
        { get; set; }

        public DateTime EndDate
        { get; set; }

        public DateTime StartDate
        { get; set; }
    }

    public class UserProjectBase : IUserProject
    {
        public UserProjectBase()
        {
            this.AssignedDate = DateTime.Now;                  
        }
        [Key]
        [Column(Order = 0)]
        public int UserId
        { get; set; }

        [Key]
        [Column(Order = 1)]
        public int ProjectId
        { get; set; }

        public DateTime AssignedDate
        { get; set; }

        public bool IsActive
        { get; set; }

    }

    public class UserProjectViewBase : IUserProjectView
    {
        public UserProjectViewBase()
        {
                       
        }

        [Key]
        [Column(Order = 0)]
        public int ProjectId
        { get; set; }

        [Key]
        [Column(Order = 1)]
        public int UserId
        { get; set; }

        public int Credits
        { get; set; }

        public DateTime EndDate
        { get; set; }

        public DateTime StartDate
        { get; set; }

        public string Status
        { get; set; }

        public int TimeToStart
        { get; set; }

    
    }


}
