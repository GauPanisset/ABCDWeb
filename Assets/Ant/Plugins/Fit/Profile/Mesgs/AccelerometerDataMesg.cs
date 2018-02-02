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
    /// Implements the AccelerometerData profile message.
    /// </summary>
    public class AccelerometerDataMesg : Mesg
    {
        #region Fields
        #endregion

        #region Constructors
        public AccelerometerDataMesg() : base(Profile.GetMesg(MesgNum.AccelerometerData))
        {
        }

        public AccelerometerDataMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Timestamp field
        /// Units: s
        /// Comment: Whole second part of the timestamp</summary>
        /// <returns>Returns DateTime representing the Timestamp field</returns>
        public DateTime GetTimestamp()
        {
            return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));
        }

        

        

        /// <summary>
        /// Set Timestamp field
        /// Units: s
        /// Comment: Whole second part of the timestamp</summary>
        /// <param name="timestamp_">Nullable field value to be set</param>
        public void SetTimestamp(DateTime timestamp_)
        {
            SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the TimestampMs field
        /// Units: ms
        /// Comment: Millisecond part of the timestamp.</summary>
        /// <returns>Returns nullable ushort representing the TimestampMs field</returns>
        public ushort? GetTimestampMs()
        {
            return (ushort?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set TimestampMs field
        /// Units: ms
        /// Comment: Millisecond part of the timestamp.</summary>
        /// <param name="timestampMs_">Nullable field value to be set</param>
        public void SetTimestampMs(ushort? timestampMs_)
        {
            SetFieldValue(0, 0, timestampMs_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field SampleTimeOffset</returns>
        public int GetNumSampleTimeOffset()
        {
            return GetNumFieldValues(1, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the SampleTimeOffset field
        /// Units: ms
        /// Comment: Each time in the array describes the time at which the accelerometer sample with the corrosponding index was taken. Limited to 30 samples in each message. The samples may span across seconds. Array size must match the number of samples in accel_x and accel_y and accel_z</summary>
        /// <param name="index">0 based index of SampleTimeOffset element to retrieve</param>
        /// <returns>Returns nullable ushort representing the SampleTimeOffset field</returns>
        public ushort? GetSampleTimeOffset(int index)
        {
            return (ushort?)GetFieldValue(1, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set SampleTimeOffset field
        /// Units: ms
        /// Comment: Each time in the array describes the time at which the accelerometer sample with the corrosponding index was taken. Limited to 30 samples in each message. The samples may span across seconds. Array size must match the number of samples in accel_x and accel_y and accel_z</summary>
        /// <param name="index">0 based index of sample_time_offset</param>
        /// <param name="sampleTimeOffset_">Nullable field value to be set</param>
        public void SetSampleTimeOffset(int index, ushort? sampleTimeOffset_)
        {
            SetFieldValue(1, index, sampleTimeOffset_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field AccelX</returns>
        public int GetNumAccelX()
        {
            return GetNumFieldValues(2, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the AccelX field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of AccelX element to retrieve</param>
        /// <returns>Returns nullable ushort representing the AccelX field</returns>
        public ushort? GetAccelX(int index)
        {
            return (ushort?)GetFieldValue(2, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set AccelX field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of accel_x</param>
        /// <param name="accelX_">Nullable field value to be set</param>
        public void SetAccelX(int index, ushort? accelX_)
        {
            SetFieldValue(2, index, accelX_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field AccelY</returns>
        public int GetNumAccelY()
        {
            return GetNumFieldValues(3, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the AccelY field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of AccelY element to retrieve</param>
        /// <returns>Returns nullable ushort representing the AccelY field</returns>
        public ushort? GetAccelY(int index)
        {
            return (ushort?)GetFieldValue(3, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set AccelY field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of accel_y</param>
        /// <param name="accelY_">Nullable field value to be set</param>
        public void SetAccelY(int index, ushort? accelY_)
        {
            SetFieldValue(3, index, accelY_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field AccelZ</returns>
        public int GetNumAccelZ()
        {
            return GetNumFieldValues(4, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the AccelZ field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of AccelZ element to retrieve</param>
        /// <returns>Returns nullable ushort representing the AccelZ field</returns>
        public ushort? GetAccelZ(int index)
        {
            return (ushort?)GetFieldValue(4, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set AccelZ field
        /// Units: counts
        /// Comment: These are the raw ADC reading. Maximum number of samples is 30 in each message. The samples may span across seconds. A conversion will need to be done on this data once read.</summary>
        /// <param name="index">0 based index of accel_z</param>
        /// <param name="accelZ_">Nullable field value to be set</param>
        public void SetAccelZ(int index, ushort? accelZ_)
        {
            SetFieldValue(4, index, accelZ_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedAccelX</returns>
        public int GetNumCalibratedAccelX()
        {
            return GetNumFieldValues(5, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedAccelX field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of CalibratedAccelX element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedAccelX field</returns>
        public float? GetCalibratedAccelX(int index)
        {
            return (float?)GetFieldValue(5, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set CalibratedAccelX field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of calibrated_accel_x</param>
        /// <param name="calibratedAccelX_">Nullable field value to be set</param>
        public void SetCalibratedAccelX(int index, float? calibratedAccelX_)
        {
            SetFieldValue(5, index, calibratedAccelX_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedAccelY</returns>
        public int GetNumCalibratedAccelY()
        {
            return GetNumFieldValues(6, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedAccelY field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of CalibratedAccelY element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedAccelY field</returns>
        public float? GetCalibratedAccelY(int index)
        {
            return (float?)GetFieldValue(6, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set CalibratedAccelY field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of calibrated_accel_y</param>
        /// <param name="calibratedAccelY_">Nullable field value to be set</param>
        public void SetCalibratedAccelY(int index, float? calibratedAccelY_)
        {
            SetFieldValue(6, index, calibratedAccelY_, Fit.SubfieldIndexMainField);
        }
        
        
        /// <summary>
        ///
        /// </summary>
        /// <returns>returns number of elements in field CalibratedAccelZ</returns>
        public int GetNumCalibratedAccelZ()
        {
            return GetNumFieldValues(7, Fit.SubfieldIndexMainField);
        }

        ///<summary>
        /// Retrieves the CalibratedAccelZ field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of CalibratedAccelZ element to retrieve</param>
        /// <returns>Returns nullable float representing the CalibratedAccelZ field</returns>
        public float? GetCalibratedAccelZ(int index)
        {
            return (float?)GetFieldValue(7, index, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set CalibratedAccelZ field
        /// Units: g
        /// Comment: Calibrated accel reading</summary>
        /// <param name="index">0 based index of calibrated_accel_z</param>
        /// <param name="calibratedAccelZ_">Nullable field value to be set</param>
        public void SetCalibratedAccelZ(int index, float? calibratedAccelZ_)
        {
            SetFieldValue(7, index, calibratedAccelZ_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
