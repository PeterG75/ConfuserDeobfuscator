/*
    Copyright (C) 2012-2013 de4dot@gmail.com

    Permission is hereby granted, free of charge, to any person obtaining
    a copy of this software and associated documentation files (the
    "Software"), to deal in the Software without restriction, including
    without limitation the rights to use, copy, modify, merge, publish,
    distribute, sublicense, and/or sell copies of the Software, and to
    permit persons to whom the Software is furnished to do so, subject to
    the following conditions:

    The above copyright notice and this permission notice shall be
    included in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
    CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
    TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
    SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

﻿using dnlib.IO;

namespace dnlib.PE {
	/// <summary>
	/// Converts a <see cref="FileOffset"/> to/from an <see cref="RVA"/>
	/// </summary>
	interface IPEType {
		/// <summary>
		/// Converts a <see cref="FileOffset"/> to an <see cref="RVA"/>
		/// </summary>
		/// <param name="peInfo">The PEInfo context</param>
		/// <param name="offset">The file offset to convert</param>
		/// <returns>The RVA</returns>
		RVA ToRVA(PEInfo peInfo, FileOffset offset);

		/// <summary>
		/// Converts an <see cref="RVA"/> to a <see cref="FileOffset"/>
		/// </summary>
		/// <param name="peInfo">The PEInfo context</param>
		/// <param name="rva">The RVA to convert</param>
		/// <returns>The file offset</returns>
		FileOffset ToFileOffset(PEInfo peInfo, RVA rva);
	}
}
