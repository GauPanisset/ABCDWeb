#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2016 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 16.60Release
// Tag = production-akw-16.60.00-0-g5d3d436
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;


namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the Activity profile message.
    /// </summary>
    public class ActivityMesg : Mesg
    {
        #region Fields
        #endregion

        #region Constructors
        public ActivityMesg() : base(Profile.GetMesg(MesgNum.Activity))
        {
        }

        public ActivityMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));
        }

        

        

        /// <summary>
        /// Set Timestamp field</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TotalTimerTime field
        /// Units: s
        /// Comment: Exclude pauses</summary>
        /// <returns>Returns nullable float representing the TotalTimerTime field</returns>
        public float? GetTotalTimerTime()
        {
            return (float?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set TotalTimerTime field
        /// Units: s
        /// Comment: Exclude pauses</summary>
        /// <param name="totalTimerTime_">Nullable field value to be set</param>
        public void SetTotalTimerTime(float? totalTimerTime_)
        {
            SetFieldValue(0, 0, totalTimerTime_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the NumSessions field</summary>
        /// <returns>Returns nullable ushort representing the NumSessions field</returns>
        public ushort? GetNumSessions()
        {
            return (ushort?)GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set NumSessions field</summary>
        /// <param name="numSessions_">Nullable field value to be set</param>
        public void SetNumSessions(ushort? numSessions_)
        {
            SetFieldValue(1, 0, numSessions_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Type field</summary>
        /// <returns>Returns nullable Activity enum representing the Type field</returns>
        new public Activity? GetType()
        {
            object obj = GetFieldValue(2, 0, Fit.SubfieldIndexMainField);
            Activity? value = obj == null ? (Activity?)null : (Activity)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set Type field</summary>
        /// <param name="type_">Nullable field value to be set</param>
        public void SetType(Activity? type_)
        {
            SetFieldValue(2, 0, type_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Event field</summary>
        /// <returns>Returns nullable Event enum representing the Event field</returns>
        public Event? GetEvent()
        {
            object obj = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            Event? value = obj == null ? (Event?)null : (Event)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set Event field</summary>
        /// <param name="event_">Nullable field value to be set</param>
        public void SetEvent(Event? event_)
        {
            SetFieldValue(3, 0, event_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the EventType field</summary>
        /// <returns>Returns nullable EventType enum representing the EventType field</returns>
        public EventType? GetEventType()
        {
            object obj = GetFieldValue(4, 0, Fit.SubfieldIndexMainField);
            EventType? value = obj == null ? (EventType?)null : (EventType)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set EventType field</summary>
        /// <param name="eventType_">Nullable field value to be set</param>
        public void SetEventType(EventType? eventType_)
        {
            SetFieldValue(4, 0, eventType_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the LocalTimestamp field
        /// Comment: timestamp epoch expressed in local time, used to convert activity timestamps to local time </summary>
        /// <returns>Returns nullable uint representing the LocalTimestamp field</returns>
        public uint? GetLocalTimestamp()
        {
            return (uint?)GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set LocalTimestamp field
        /// Comment: timestamp epoch expressed in local time, used to convert activity timestamps to local time </summary>
        /// <param name="localTimestamp_">Nullable field value to be set</param>
        public void SetLocalTimestamp(uint? localTimestamp_)
        {
            SetFieldValue(5, 0, localTimestamp_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the EventGroup field</summary>
        /// <returns>Returns nullable byte representing the EventGroup field</returns>
        public byte? GetEventGroup()
        {
            return (byte?)GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set EventGroup field</summary>
        /// <param name="eventGroup_">Nullable field value to be set</param>
        public void SetEventGroup(byte? eventGroup_)
        {
            SetFieldValue(6, 0, eventGroup_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
