#region Copyright notice and license

// Protocol Buffers - Google's data interchange format
// Copyright 2008 Google Inc.  All rights reserved.
// http://github.com/jskeet/dotnet-protobufs/
// Original C++/Java/Python code:
// http://code.google.com/p/protobuf/
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

#endregion

using Google.ProtocolBuffers.Descriptors;

namespace Google.ProtocolBuffers
{
    public sealed class ExtensionInfo : IGeneratedExtensionLite
    {
        /// <summary>
        /// The extension's descriptor
        /// </summary>
        public FieldDescriptor Descriptor { get; private set; }

        IFieldDescriptorLite IGeneratedExtensionLite.Descriptor
        {
            get { return Descriptor; }
        }

        /// <summary>
        /// A default instance of the extensions's type, if it has a message type,
        /// or null otherwise.
        /// </summary>
        public IMessageLite DefaultInstance { get; private set; }

        public ExtensionInfo(FieldDescriptor descriptor) : this(descriptor, null)
        {
        }

        public ExtensionInfo(FieldDescriptor descriptor, IMessageLite defaultInstance)
        {
            Descriptor = descriptor;
            DefaultInstance = defaultInstance;
        }

        #region IGeneratedExtensionLite Members

        int IGeneratedExtensionLite.Number
        {
            get { return Descriptor.FieldNumber; }
        }

        object IGeneratedExtensionLite.ContainingType
        {
            get { return Descriptor.ContainingType; }
        }

        IMessageLite IGeneratedExtensionLite.MessageDefaultInstance
        {
            get { return DefaultInstance; }
        }

        #endregion
    }
}