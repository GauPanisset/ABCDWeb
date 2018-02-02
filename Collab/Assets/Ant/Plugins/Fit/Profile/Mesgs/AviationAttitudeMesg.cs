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
    /// Implements the AviationAttitude profile message.
    /// </summary>
    public class AviationAttitudeMesg : Mesg
    {
        #region Fields
        #endregion

        #region Constructors
        public AviationAttitudeMesg() : base(Profile.GetMesg(MesgNum.AviationAttitude))
        {
        }

        public AviationAttitudeMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Timestamp message was output</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));
        }

        

        

        /// <summary>
        /// Set Timestamp field
        /// Units: s
        /// Comment: Timestamp message was output</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TimestampMs field
        /// Units: ms
        /// Comment: Fractional part of timestamp, added to timestamp</summary>
        /// <returns>Returns nullable ushort representing the TimestampMs field</returns>
        public ushort? GetTimestampMs()
        {
            return (ushort?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set TimestampMs field
        /// Units: ms
        /// Comment: Fractional part of timestamp, added to timestamp</summary>
        /// <param name="timestampMs_">Nullable field value to be set</param>
        public void SetTimestampMs(ushort? timestampMs_)
        {
            SetFieldValue(0, 0, timestampMs_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field SystemTime</returns>
        public int GetNumSystemTime()
        {
            return GetNumFieldValues(1, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the SystemTime field
        /// Units: ms
        /// Comment: System time associated with sample expressed in ms.</summary>
        /// <param name="index">0 based index of SystemTime element to retrieve</param>
        /// <returns>Returns nullable uint representing the SystemTime field</returns>
        public uint? GetSystemTime(int index)
        {
            return (uint?)GetFieldValue(1, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set SystemTime field
        /// Units: ms
        /// Comment: System time associated with sample expressed in ms.</summary>
        /// <param name="index">0 based index of system_time</param>
        /// <param name="systemTime_">Nullable field value to be set</param>
        public void SetSystemTime(int index, uint? systemTime_)
        {
            SetFieldValue(1, index, systemTime_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Pitch</returns>
        public int GetNumPitch()
        {
            return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Pitch field
        /// Units: radians
        /// Comment: Range -PI/2 to +PI/2</summary>
        /// <param name="index">0 based index of Pitch element to retrieve</param>
        /// <returns>Returns nullable short representing the Pitch field</returns>
        public short? GetPitch(int index)
        {
            return (short?)GetFieldValue(2, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set Pitch field
        /// Units: radians
        /// Comment: Range -PI/2 to +PI/2</summary>
        /// <param name="index">0 based index of pitch</param>
        /// <param name="pitch_">Nullable field value to be set</param>
        public void SetPitch(int index, short? pitch_)
        {
            SetFieldValue(2, index, pitch_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Roll</returns>
        public int GetNumRoll()
        {
            return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Roll field
        /// Units: radians
        /// Comment: Range -PI to +PI</summary>
        /// <param name="index">0 based index of Roll element to retrieve</param>
        /// <returns>Returns nullable short representing the Roll field</returns>
        public short? GetRoll(int index)
        {
            return (short?)GetFieldValue(3, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set Roll field
        /// Units: radians
        /// Comment: Range -PI to +PI</summary>
        /// <param name="index">0 based index of roll</param>
        /// <param name="roll_">Nullable field value to be set</param>
        public void SetRoll(int index, short? roll_)
        {
            SetFieldValue(3, index, roll_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field AccelLateral</returns>
        public int GetNumAccelLateral()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the AccelLateral field
        /// Units: m/s^2
        /// Comment: Range -78.4 to +78.4 (-8 Gs to 8 Gs)</summary>
        /// <param name="index">0 based index of AccelLateral element to retrieve</param>
        /// <returns>Returns nullable float representing the AccelLateral field</returns>
        public float? GetAccelLateral(int index)
        {
            return (float?)GetFieldValue(4, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set AccelLateral field
        /// Units: m/s^2
        /// Comment: Range -78.4 to +78.4 (-8 Gs to 8 Gs)</summary>
        /// <param name="index">0 based index of accel_lateral</param>
        /// <param name="accelLateral_">Nullable field value to be set</param>
        public void SetAccelLateral(int index, float? accelLateral_)
        {
            SetFieldValue(4, index, accelLateral_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field AccelNormal</returns>
        public int GetNumAccelNormal()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the AccelNormal field
        /// Units: m/s^2
        /// Comment: Range -78.4 to +78.4 (-8 Gs to 8 Gs)</summary>
        /// <param name="index">0 based index of AccelNormal element to retrieve</param>
        /// <returns>Returns nullable float representing the AccelNormal field</returns>
        public float? GetAccelNormal(int index)
        {
            return (float?)GetFieldValue(5, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set AccelNormal field
        /// Units: m/s^2
        /// Comment: Range -78.4 to +78.4 (-8 Gs to 8 Gs)</summary>
        /// <param name="index">0 based index of accel_normal</param>
        /// <param name="accelNormal_">Nullable field value to be set</param>
        public void SetAccelNormal(int index, float? accelNormal_)
        {
            SetFieldValue(5, index, accelNormal_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field TurnRate</returns>
        public int GetNumTurnRate()
        {
            return GetNumFieldValues(6, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the TurnRate field
        /// Units: radians/second
        /// Comment: Range -8.727 to +8.727 (-500 degs/sec to +500 degs/sec)</summary>
        /// <param name="index">0 based index of TurnRate element to retrieve</param>
        /// <returns>Returns nullable float representing the TurnRate field</returns>
        public float? GetTurnRate(int index)
        {
            return (float?)GetFieldValue(6, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set TurnRate field
        /// Units: radians/second
        /// Comment: Range -8.727 to +8.727 (-500 degs/sec to +500 degs/sec)</summary>
        /// <param name="index">0 based index of turn_rate</param>
        /// <param name="turnRate_">Nullable field value to be set</param>
        public void SetTurnRate(int index, float? turnRate_)
        {
            SetFieldValue(6, index, turnRate_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Stage</returns>
        public int GetNumStage()
        {
            return GetNumFieldValues(7, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Stage field</summary>
        /// <param name="index">0 based index of Stage element to retrieve</param>
        /// <returns>Returns nullable AttitudeStage enum representing the Stage field</returns>
        public AttitudeStage? GetStage(int index)
        {
            object obj = GetFieldValue(7, index, Fit.SubfieldIndexMainField);
            AttitudeStage? value = obj == null ? (AttitudeStage?)null : (AttitudeStage)obj;
            return value;
        }

        

        

        /// <summary>
        /// Set Stage field</summary>
        /// <param name="index">0 based index of stage</param>
        /// <param name="stage_">Nullable field value to be set</param>
        public void SetStage(int index, AttitudeStage? stage_)
        {
            SetFieldValue(7, index, stage_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field AttitudeStageComplete</returns>
        public int GetNumAttitudeStageComplete()
        {
            return GetNumFieldValues(8, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the AttitudeStageComplete field
        /// Units: %
        /// Comment: The percent complete of the current attitude stage.  Set to 0 for attitude stages 0, 1 and 2 and to 100 for attitude stage 3 by AHRS modules that do not support it.  Range - 100</summary>
        /// <param name="index">0 based index of AttitudeStageComplete element to retrieve</param>
        /// <returns>Returns nullable byte representing the AttitudeStageComplete field</returns>
        public byte? GetAttitudeStageComplete(int index)
        {
            return (byte?)GetFieldValue(8, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set AttitudeStageComplete field
        /// Units: %
        /// Comment: The percent complete of the current attitude stage.  Set to 0 for attitude stages 0, 1 and 2 and to 100 for attitude stage 3 by AHRS modules that do not support it.  Range - 100</summary>
        /// <param name="index">0 based index of attitude_stage_complete</param>
        /// <param name="attitudeStageComplete_">Nullable field value to be set</param>
        public void SetAttitudeStageComplete(int index, byte? attitudeStageComplete_)
        {
            SetFieldValue(8, index, attitudeStageComplete_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Track</returns>
        public int GetNumTrack()
        {
            return GetNumFieldValues(9, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Track field
        /// Units: radians
        /// Comment: Track Angle/Heading Range 0 - 2pi</summary>
        /// <param name="index">0 based index of Track element to retrieve</param>
        /// <returns>Returns nullable ushort representing the Track field</returns>
        public ushort? GetTrack(int index)
        {
            return (ushort?)GetFieldValue(9, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set Track field
        /// Units: radians
        /// Comment: Track Angle/Heading Range 0 - 2pi</summary>
        /// <param name="index">0 based index of track</param>
        /// <param name="track_">Nullable field value to be set</param>
        public void SetTrack(int index, ushort? track_)
        {
            SetFieldValue(9, index, track_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field Validity</returns>
        public int GetNumValidity()
        {
            return GetNumFieldValues(10, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the Validity field</summary>
        /// <param name="index">0 based index of Validity element to retrieve</param>
        /// <returns>Returns nullable ushort representing the Validity field</returns>
        public ushort? GetValidity(int index)
        {
            return (ushort?)GetFieldValue(10, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set Validity field</summary>
        /// <param name="index">0 based index of validity</param>
        /// <param name="validity_">Nullable field value to be set</param>
        public void SetValidity(int index, ushort? validity_)
        {
            SetFieldValue(10, index, validity_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
