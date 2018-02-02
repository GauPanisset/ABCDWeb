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
    /// Implements the VideoDescription profile message.
    /// </summary>
    public class VideoDescriptionMesg : Mesg
    {
        #region Fields
        #endregion

        #region Constructors
        public VideoDescriptionMesg() : base(Profile.GetMesg(MesgNum.VideoDescription))
        {
        }

        public VideoDescriptionMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the MessageIndex field
        /// Comment: Long descriptions will be split into multiple parts</summary>
        /// <returns>Returns nullable ushort representing the MessageIndex field</returns>
        public ushort? GetMessageIndex()
        {
            return (ushort?)GetFieldValue(254, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set MessageIndex field
        /// Comment: Long descriptions will be split into multiple parts</summary>
        /// <param name="messageIndex_">Nullable field value to be set</param>
        public void SetMessageIndex(ushort? messageIndex_)
        {
            SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the MessageCount field
        /// Comment: Total number of description parts</summary>
        /// <returns>Returns nullable ushort representing the MessageCount field</returns>
        public ushort? GetMessageCount()
        {
            return (ushort?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
        }

        

        

        /// <summary>
        /// Set MessageCount field
        /// Comment: Total number of description parts</summary>
        /// <param name="messageCount_">Nullable field value to be set</param>
        public void SetMessageCount(ushort? messageCount_)
        {
            SetFieldValue(0, 0, messageCount_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Text field</summary>
        /// <returns>Returns byte[] representing the Text field</returns>
        public byte[] GetText()
        {
            return (byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
        }

        
        ///<summary>
        /// Retrieves the Text field</summary>
        /// <returns>Returns String representing the Text field</returns>
        public String GetTextAsString()
        {
            return Encoding.UTF8.GetString((byte[])GetFieldValue(1, 0, Fit.SubfieldIndexMainField));
        }
        

        
        ///<summary>
        /// Set Text field</summary>
        /// <param name="text_"> field value to be set</param>
        public void SetText(String text_)
        {
            SetFieldValue(1, 0, System.Text.Encoding.UTF8.GetBytes(text_), Fit.SubfieldIndexMainField);
        }
        

        /// <summary>
        /// Set Text field</summary>
        /// <param name="text_">field value to be set</param>
        public void SetText(byte[] text_)
        {
            SetFieldValue(1, 0, text_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
