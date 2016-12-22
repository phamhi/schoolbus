/*
 * REST API Documentation for Schoolbus
 *
 * API Sample
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SchoolBusAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class GroupMembership :  IEquatable<GroupMembership>
    {

        /// <summary>
        /// Default constructor, required by entity framework
        /// </summary>
        public GroupMembership()
        {
            this.Id = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMembership" /> class.
        /// </summary>
        /// <param name="Id">Primary Key (required).</param>
        /// <param name="Active">Active (required).</param>
        /// <param name="Group">Group.</param>
        /// <param name="User">User.</param>
        public GroupMembership(int Id, bool Active, Group Group = null, User User = null)
        {
            
            this.Id = Id;            
            
            this.Active = Active;            
            this.Group = Group;
            this.User = User;
            
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        /// <value>Primary Key</value>
        [DataMember(Name="id")]
        [MetaDataExtension (Description = "Primary Key")]        
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active")]
                
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group")]
                
        public Group Group { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user")]
                
        public User User { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMembership {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            if (obj.GetType() != GetType()) { return false; }
            return Equals((GroupMembership)obj);
        }

        /// <summary>
        /// Returns true if GroupMembership instances are equal
        /// </summary>
        /// <param name="other">Instance of GroupMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMembership other)
        {

            if (ReferenceEquals(null, other)) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks 
                    if (this.Id != null)
                    { 
                        hash = hash * 59 + this.Id.GetHashCode();
                    }
                    if (this.Active != null)
                    { 
                        hash = hash * 59 + this.Active.GetHashCode();
                    }
                    if (this.Group != null)
                    { 
                        hash = hash * 59 + this.Group.GetHashCode();
                    }
                    if (this.User != null)
                    { 
                        hash = hash * 59 + this.User.GetHashCode();
                    }
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(GroupMembership left, GroupMembership right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GroupMembership left, GroupMembership right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}