📦
197000 /dump-only.js
✄
var __getOwnPropNames = Object.getOwnPropertyNames;
var __esm = (fn, res) => function __init() {
  return fn && (res = (0, fn[__getOwnPropNames(fn)[0]])(fn = 0)), res;
};
var __commonJS = (cb, mod) => function __require() {
  return mod || (0, cb[__getOwnPropNames(cb)[0]])((mod = { exports: {} }).exports, mod), mod.exports;
};

// frida-shim:node_modules/@frida/base64-js/index.js
function getLens(b64) {
  const len = b64.length;
  if (len % 4 > 0) {
    throw new Error("Invalid string. Length must be a multiple of 4");
  }
  let validLen = b64.indexOf("=");
  if (validLen === -1) validLen = len;
  const placeHoldersLen = validLen === len ? 0 : 4 - validLen % 4;
  return [validLen, placeHoldersLen];
}
function _byteLength(b64, validLen, placeHoldersLen) {
  return (validLen + placeHoldersLen) * 3 / 4 - placeHoldersLen;
}
function toByteArray(b64) {
  const lens = getLens(b64);
  const validLen = lens[0];
  const placeHoldersLen = lens[1];
  const arr = new Uint8Array(_byteLength(b64, validLen, placeHoldersLen));
  let curByte = 0;
  const len = placeHoldersLen > 0 ? validLen - 4 : validLen;
  let i;
  for (i = 0; i < len; i += 4) {
    const tmp = revLookup[b64.charCodeAt(i)] << 18 | revLookup[b64.charCodeAt(i + 1)] << 12 | revLookup[b64.charCodeAt(i + 2)] << 6 | revLookup[b64.charCodeAt(i + 3)];
    arr[curByte++] = tmp >> 16 & 255;
    arr[curByte++] = tmp >> 8 & 255;
    arr[curByte++] = tmp & 255;
  }
  if (placeHoldersLen === 2) {
    const tmp = revLookup[b64.charCodeAt(i)] << 2 | revLookup[b64.charCodeAt(i + 1)] >> 4;
    arr[curByte++] = tmp & 255;
  }
  if (placeHoldersLen === 1) {
    const tmp = revLookup[b64.charCodeAt(i)] << 10 | revLookup[b64.charCodeAt(i + 1)] << 4 | revLookup[b64.charCodeAt(i + 2)] >> 2;
    arr[curByte++] = tmp >> 8 & 255;
    arr[curByte++] = tmp & 255;
  }
  return arr;
}
function tripletToBase64(num) {
  return lookup[num >> 18 & 63] + lookup[num >> 12 & 63] + lookup[num >> 6 & 63] + lookup[num & 63];
}
function encodeChunk(uint8, start, end) {
  const output = [];
  for (let i = start; i < end; i += 3) {
    const tmp = (uint8[i] << 16 & 16711680) + (uint8[i + 1] << 8 & 65280) + (uint8[i + 2] & 255);
    output.push(tripletToBase64(tmp));
  }
  return output.join("");
}
function fromByteArray(uint8) {
  const len = uint8.length;
  const extraBytes = len % 3;
  const parts = [];
  const maxChunkLength = 16383;
  for (let i = 0, len2 = len - extraBytes; i < len2; i += maxChunkLength) {
    parts.push(encodeChunk(uint8, i, i + maxChunkLength > len2 ? len2 : i + maxChunkLength));
  }
  if (extraBytes === 1) {
    const tmp = uint8[len - 1];
    parts.push(
      lookup[tmp >> 2] + lookup[tmp << 4 & 63] + "=="
    );
  } else if (extraBytes === 2) {
    const tmp = (uint8[len - 2] << 8) + uint8[len - 1];
    parts.push(
      lookup[tmp >> 10] + lookup[tmp >> 4 & 63] + lookup[tmp << 2 & 63] + "="
    );
  }
  return parts.join("");
}
var lookup, revLookup, code;
var init_base64_js = __esm({
  "frida-shim:node_modules/@frida/base64-js/index.js"() {
    init_node_globals();
    lookup = [];
    revLookup = [];
    code = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
    for (let i = 0, len = code.length; i < len; ++i) {
      lookup[i] = code[i];
      revLookup[code.charCodeAt(i)] = i;
    }
    revLookup["-".charCodeAt(0)] = 62;
    revLookup["_".charCodeAt(0)] = 63;
  }
});

// frida-shim:node_modules/@frida/ieee754/index.js
function read(buffer, offset, isLE, mLen, nBytes) {
  let e, m;
  const eLen = nBytes * 8 - mLen - 1;
  const eMax = (1 << eLen) - 1;
  const eBias = eMax >> 1;
  let nBits = -7;
  let i = isLE ? nBytes - 1 : 0;
  const d = isLE ? -1 : 1;
  let s = buffer[offset + i];
  i += d;
  e = s & (1 << -nBits) - 1;
  s >>= -nBits;
  nBits += eLen;
  while (nBits > 0) {
    e = e * 256 + buffer[offset + i];
    i += d;
    nBits -= 8;
  }
  m = e & (1 << -nBits) - 1;
  e >>= -nBits;
  nBits += mLen;
  while (nBits > 0) {
    m = m * 256 + buffer[offset + i];
    i += d;
    nBits -= 8;
  }
  if (e === 0) {
    e = 1 - eBias;
  } else if (e === eMax) {
    return m ? NaN : (s ? -1 : 1) * Infinity;
  } else {
    m = m + Math.pow(2, mLen);
    e = e - eBias;
  }
  return (s ? -1 : 1) * m * Math.pow(2, e - mLen);
}
function write(buffer, value, offset, isLE, mLen, nBytes) {
  let e, m, c;
  let eLen = nBytes * 8 - mLen - 1;
  const eMax = (1 << eLen) - 1;
  const eBias = eMax >> 1;
  const rt = mLen === 23 ? Math.pow(2, -24) - Math.pow(2, -77) : 0;
  let i = isLE ? 0 : nBytes - 1;
  const d = isLE ? 1 : -1;
  const s = value < 0 || value === 0 && 1 / value < 0 ? 1 : 0;
  value = Math.abs(value);
  if (isNaN(value) || value === Infinity) {
    m = isNaN(value) ? 1 : 0;
    e = eMax;
  } else {
    e = Math.floor(Math.log(value) / Math.LN2);
    if (value * (c = Math.pow(2, -e)) < 1) {
      e--;
      c *= 2;
    }
    if (e + eBias >= 1) {
      value += rt / c;
    } else {
      value += rt * Math.pow(2, 1 - eBias);
    }
    if (value * c >= 2) {
      e++;
      c /= 2;
    }
    if (e + eBias >= eMax) {
      m = 0;
      e = eMax;
    } else if (e + eBias >= 1) {
      m = (value * c - 1) * Math.pow(2, mLen);
      e = e + eBias;
    } else {
      m = value * Math.pow(2, eBias - 1) * Math.pow(2, mLen);
      e = 0;
    }
  }
  while (mLen >= 8) {
    buffer[offset + i] = m & 255;
    i += d;
    m /= 256;
    mLen -= 8;
  }
  e = e << mLen | m;
  eLen += mLen;
  while (eLen > 0) {
    buffer[offset + i] = e & 255;
    i += d;
    e /= 256;
    eLen -= 8;
  }
  buffer[offset + i - d] |= s * 128;
}
var init_ieee754 = __esm({
  "frida-shim:node_modules/@frida/ieee754/index.js"() {
    init_node_globals();
  }
});

// frida-shim:node_modules/@frida/buffer/index.js
function createBuffer(length) {
  if (length > K_MAX_LENGTH) {
    throw new RangeError('The value "' + length + '" is invalid for option "size"');
  }
  const buf = new Uint8Array(length);
  Object.setPrototypeOf(buf, Buffer2.prototype);
  return buf;
}
function Buffer2(arg, encodingOrOffset, length) {
  if (typeof arg === "number") {
    if (typeof encodingOrOffset === "string") {
      throw new TypeError(
        'The "string" argument must be of type string. Received type number'
      );
    }
    return allocUnsafe(arg);
  }
  return from(arg, encodingOrOffset, length);
}
function from(value, encodingOrOffset, length) {
  if (typeof value === "string") {
    return fromString(value, encodingOrOffset);
  }
  if (ArrayBuffer.isView(value)) {
    return fromArrayView(value);
  }
  if (value == null) {
    throw new TypeError(
      "The first argument must be one of type string, Buffer, ArrayBuffer, Array, or Array-like Object. Received type " + typeof value
    );
  }
  if (value instanceof ArrayBuffer || value && value.buffer instanceof ArrayBuffer) {
    return fromArrayBuffer(value, encodingOrOffset, length);
  }
  if (value instanceof SharedArrayBuffer || value && value.buffer instanceof SharedArrayBuffer) {
    return fromArrayBuffer(value, encodingOrOffset, length);
  }
  if (typeof value === "number") {
    throw new TypeError(
      'The "value" argument must not be of type number. Received type number'
    );
  }
  const valueOf = value.valueOf && value.valueOf();
  if (valueOf != null && valueOf !== value) {
    return Buffer2.from(valueOf, encodingOrOffset, length);
  }
  const b = fromObject(value);
  if (b) return b;
  if (typeof Symbol !== "undefined" && Symbol.toPrimitive != null && typeof value[Symbol.toPrimitive] === "function") {
    return Buffer2.from(value[Symbol.toPrimitive]("string"), encodingOrOffset, length);
  }
  throw new TypeError(
    "The first argument must be one of type string, Buffer, ArrayBuffer, Array, or Array-like Object. Received type " + typeof value
  );
}
function assertSize(size) {
  if (typeof size !== "number") {
    throw new TypeError('"size" argument must be of type number');
  } else if (size < 0) {
    throw new RangeError('The value "' + size + '" is invalid for option "size"');
  }
}
function alloc(size, fill2, encoding) {
  assertSize(size);
  if (size <= 0) {
    return createBuffer(size);
  }
  if (fill2 !== void 0) {
    return typeof encoding === "string" ? createBuffer(size).fill(fill2, encoding) : createBuffer(size).fill(fill2);
  }
  return createBuffer(size);
}
function allocUnsafe(size) {
  assertSize(size);
  return createBuffer(size < 0 ? 0 : checked(size) | 0);
}
function fromString(string, encoding) {
  if (typeof encoding !== "string" || encoding === "") {
    encoding = "utf8";
  }
  if (!Buffer2.isEncoding(encoding)) {
    throw new TypeError("Unknown encoding: " + encoding);
  }
  const length = byteLength(string, encoding) | 0;
  let buf = createBuffer(length);
  const actual = buf.write(string, encoding);
  if (actual !== length) {
    buf = buf.slice(0, actual);
  }
  return buf;
}
function fromArrayLike(array) {
  const length = array.length < 0 ? 0 : checked(array.length) | 0;
  const buf = createBuffer(length);
  for (let i = 0; i < length; i += 1) {
    buf[i] = array[i] & 255;
  }
  return buf;
}
function fromArrayView(arrayView) {
  if (arrayView instanceof Uint8Array) {
    const copy2 = new Uint8Array(arrayView);
    return fromArrayBuffer(copy2.buffer, copy2.byteOffset, copy2.byteLength);
  }
  return fromArrayLike(arrayView);
}
function fromArrayBuffer(array, byteOffset, length) {
  if (byteOffset < 0 || array.byteLength < byteOffset) {
    throw new RangeError('"offset" is outside of buffer bounds');
  }
  if (array.byteLength < byteOffset + (length || 0)) {
    throw new RangeError('"length" is outside of buffer bounds');
  }
  let buf;
  if (byteOffset === void 0 && length === void 0) {
    buf = new Uint8Array(array);
  } else if (length === void 0) {
    buf = new Uint8Array(array, byteOffset);
  } else {
    buf = new Uint8Array(array, byteOffset, length);
  }
  Object.setPrototypeOf(buf, Buffer2.prototype);
  return buf;
}
function fromObject(obj) {
  if (Buffer2.isBuffer(obj)) {
    const len = checked(obj.length) | 0;
    const buf = createBuffer(len);
    if (buf.length === 0) {
      return buf;
    }
    obj.copy(buf, 0, 0, len);
    return buf;
  }
  if (obj.length !== void 0) {
    if (typeof obj.length !== "number" || Number.isNaN(obj.length)) {
      return createBuffer(0);
    }
    return fromArrayLike(obj);
  }
  if (obj.type === "Buffer" && Array.isArray(obj.data)) {
    return fromArrayLike(obj.data);
  }
}
function checked(length) {
  if (length >= K_MAX_LENGTH) {
    throw new RangeError("Attempt to allocate Buffer larger than maximum size: 0x" + K_MAX_LENGTH.toString(16) + " bytes");
  }
  return length | 0;
}
function byteLength(string, encoding) {
  if (Buffer2.isBuffer(string)) {
    return string.length;
  }
  if (ArrayBuffer.isView(string) || string instanceof ArrayBuffer) {
    return string.byteLength;
  }
  if (typeof string !== "string") {
    throw new TypeError(
      'The "string" argument must be one of type string, Buffer, or ArrayBuffer. Received type ' + typeof string
    );
  }
  const len = string.length;
  const mustMatch = arguments.length > 2 && arguments[2] === true;
  if (!mustMatch && len === 0) return 0;
  let loweredCase = false;
  for (; ; ) {
    switch (encoding) {
      case "ascii":
      case "latin1":
      case "binary":
        return len;
      case "utf8":
      case "utf-8":
        return utf8ToBytes(string).length;
      case "ucs2":
      case "ucs-2":
      case "utf16le":
      case "utf-16le":
        return len * 2;
      case "hex":
        return len >>> 1;
      case "base64":
        return base64ToBytes(string).length;
      default:
        if (loweredCase) {
          return mustMatch ? -1 : utf8ToBytes(string).length;
        }
        encoding = ("" + encoding).toLowerCase();
        loweredCase = true;
    }
  }
}
function slowToString(encoding, start, end) {
  let loweredCase = false;
  if (start === void 0 || start < 0) {
    start = 0;
  }
  if (start > this.length) {
    return "";
  }
  if (end === void 0 || end > this.length) {
    end = this.length;
  }
  if (end <= 0) {
    return "";
  }
  end >>>= 0;
  start >>>= 0;
  if (end <= start) {
    return "";
  }
  if (!encoding) encoding = "utf8";
  while (true) {
    switch (encoding) {
      case "hex":
        return hexSlice(this, start, end);
      case "utf8":
      case "utf-8":
        return utf8Slice(this, start, end);
      case "ascii":
        return asciiSlice(this, start, end);
      case "latin1":
      case "binary":
        return latin1Slice(this, start, end);
      case "base64":
        return base64Slice(this, start, end);
      case "ucs2":
      case "ucs-2":
      case "utf16le":
      case "utf-16le":
        return utf16leSlice(this, start, end);
      default:
        if (loweredCase) throw new TypeError("Unknown encoding: " + encoding);
        encoding = (encoding + "").toLowerCase();
        loweredCase = true;
    }
  }
}
function swap(b, n, m) {
  const i = b[n];
  b[n] = b[m];
  b[m] = i;
}
function bidirectionalIndexOf(buffer, val, byteOffset, encoding, dir) {
  if (buffer.length === 0) return -1;
  if (typeof byteOffset === "string") {
    encoding = byteOffset;
    byteOffset = 0;
  } else if (byteOffset > 2147483647) {
    byteOffset = 2147483647;
  } else if (byteOffset < -2147483648) {
    byteOffset = -2147483648;
  }
  byteOffset = +byteOffset;
  if (Number.isNaN(byteOffset)) {
    byteOffset = dir ? 0 : buffer.length - 1;
  }
  if (byteOffset < 0) byteOffset = buffer.length + byteOffset;
  if (byteOffset >= buffer.length) {
    if (dir) return -1;
    else byteOffset = buffer.length - 1;
  } else if (byteOffset < 0) {
    if (dir) byteOffset = 0;
    else return -1;
  }
  if (typeof val === "string") {
    val = Buffer2.from(val, encoding);
  }
  if (Buffer2.isBuffer(val)) {
    if (val.length === 0) {
      return -1;
    }
    return arrayIndexOf(buffer, val, byteOffset, encoding, dir);
  } else if (typeof val === "number") {
    val = val & 255;
    if (typeof Uint8Array.prototype.indexOf === "function") {
      if (dir) {
        return Uint8Array.prototype.indexOf.call(buffer, val, byteOffset);
      } else {
        return Uint8Array.prototype.lastIndexOf.call(buffer, val, byteOffset);
      }
    }
    return arrayIndexOf(buffer, [val], byteOffset, encoding, dir);
  }
  throw new TypeError("val must be string, number or Buffer");
}
function arrayIndexOf(arr, val, byteOffset, encoding, dir) {
  let indexSize = 1;
  let arrLength = arr.length;
  let valLength = val.length;
  if (encoding !== void 0) {
    encoding = String(encoding).toLowerCase();
    if (encoding === "ucs2" || encoding === "ucs-2" || encoding === "utf16le" || encoding === "utf-16le") {
      if (arr.length < 2 || val.length < 2) {
        return -1;
      }
      indexSize = 2;
      arrLength /= 2;
      valLength /= 2;
      byteOffset /= 2;
    }
  }
  function read2(buf, i2) {
    if (indexSize === 1) {
      return buf[i2];
    } else {
      return buf.readUInt16BE(i2 * indexSize);
    }
  }
  let i;
  if (dir) {
    let foundIndex = -1;
    for (i = byteOffset; i < arrLength; i++) {
      if (read2(arr, i) === read2(val, foundIndex === -1 ? 0 : i - foundIndex)) {
        if (foundIndex === -1) foundIndex = i;
        if (i - foundIndex + 1 === valLength) return foundIndex * indexSize;
      } else {
        if (foundIndex !== -1) i -= i - foundIndex;
        foundIndex = -1;
      }
    }
  } else {
    if (byteOffset + valLength > arrLength) byteOffset = arrLength - valLength;
    for (i = byteOffset; i >= 0; i--) {
      let found = true;
      for (let j = 0; j < valLength; j++) {
        if (read2(arr, i + j) !== read2(val, j)) {
          found = false;
          break;
        }
      }
      if (found) return i;
    }
  }
  return -1;
}
function hexWrite(buf, string, offset, length) {
  offset = Number(offset) || 0;
  const remaining = buf.length - offset;
  if (!length) {
    length = remaining;
  } else {
    length = Number(length);
    if (length > remaining) {
      length = remaining;
    }
  }
  const strLen = string.length;
  if (length > strLen / 2) {
    length = strLen / 2;
  }
  let i;
  for (i = 0; i < length; ++i) {
    const parsed = parseInt(string.substr(i * 2, 2), 16);
    if (Number.isNaN(parsed)) return i;
    buf[offset + i] = parsed;
  }
  return i;
}
function utf8Write(buf, string, offset, length) {
  return blitBuffer(utf8ToBytes(string, buf.length - offset), buf, offset, length);
}
function asciiWrite(buf, string, offset, length) {
  return blitBuffer(asciiToBytes(string), buf, offset, length);
}
function base64Write(buf, string, offset, length) {
  return blitBuffer(base64ToBytes(string), buf, offset, length);
}
function ucs2Write(buf, string, offset, length) {
  return blitBuffer(utf16leToBytes(string, buf.length - offset), buf, offset, length);
}
function base64Slice(buf, start, end) {
  if (start === 0 && end === buf.length) {
    return fromByteArray(buf);
  } else {
    return fromByteArray(buf.slice(start, end));
  }
}
function utf8Slice(buf, start, end) {
  end = Math.min(buf.length, end);
  const res = [];
  let i = start;
  while (i < end) {
    const firstByte = buf[i];
    let codePoint = null;
    let bytesPerSequence = firstByte > 239 ? 4 : firstByte > 223 ? 3 : firstByte > 191 ? 2 : 1;
    if (i + bytesPerSequence <= end) {
      let secondByte, thirdByte, fourthByte, tempCodePoint;
      switch (bytesPerSequence) {
        case 1:
          if (firstByte < 128) {
            codePoint = firstByte;
          }
          break;
        case 2:
          secondByte = buf[i + 1];
          if ((secondByte & 192) === 128) {
            tempCodePoint = (firstByte & 31) << 6 | secondByte & 63;
            if (tempCodePoint > 127) {
              codePoint = tempCodePoint;
            }
          }
          break;
        case 3:
          secondByte = buf[i + 1];
          thirdByte = buf[i + 2];
          if ((secondByte & 192) === 128 && (thirdByte & 192) === 128) {
            tempCodePoint = (firstByte & 15) << 12 | (secondByte & 63) << 6 | thirdByte & 63;
            if (tempCodePoint > 2047 && (tempCodePoint < 55296 || tempCodePoint > 57343)) {
              codePoint = tempCodePoint;
            }
          }
          break;
        case 4:
          secondByte = buf[i + 1];
          thirdByte = buf[i + 2];
          fourthByte = buf[i + 3];
          if ((secondByte & 192) === 128 && (thirdByte & 192) === 128 && (fourthByte & 192) === 128) {
            tempCodePoint = (firstByte & 15) << 18 | (secondByte & 63) << 12 | (thirdByte & 63) << 6 | fourthByte & 63;
            if (tempCodePoint > 65535 && tempCodePoint < 1114112) {
              codePoint = tempCodePoint;
            }
          }
      }
    }
    if (codePoint === null) {
      codePoint = 65533;
      bytesPerSequence = 1;
    } else if (codePoint > 65535) {
      codePoint -= 65536;
      res.push(codePoint >>> 10 & 1023 | 55296);
      codePoint = 56320 | codePoint & 1023;
    }
    res.push(codePoint);
    i += bytesPerSequence;
  }
  return decodeCodePointsArray(res);
}
function decodeCodePointsArray(codePoints) {
  const len = codePoints.length;
  if (len <= MAX_ARGUMENTS_LENGTH) {
    return String.fromCharCode.apply(String, codePoints);
  }
  let res = "";
  let i = 0;
  while (i < len) {
    res += String.fromCharCode.apply(
      String,
      codePoints.slice(i, i += MAX_ARGUMENTS_LENGTH)
    );
  }
  return res;
}
function asciiSlice(buf, start, end) {
  let ret = "";
  end = Math.min(buf.length, end);
  for (let i = start; i < end; ++i) {
    ret += String.fromCharCode(buf[i] & 127);
  }
  return ret;
}
function latin1Slice(buf, start, end) {
  let ret = "";
  end = Math.min(buf.length, end);
  for (let i = start; i < end; ++i) {
    ret += String.fromCharCode(buf[i]);
  }
  return ret;
}
function hexSlice(buf, start, end) {
  const len = buf.length;
  if (!start || start < 0) start = 0;
  if (!end || end < 0 || end > len) end = len;
  let out = "";
  for (let i = start; i < end; ++i) {
    out += hexSliceLookupTable[buf[i]];
  }
  return out;
}
function utf16leSlice(buf, start, end) {
  const bytes = buf.slice(start, end);
  let res = "";
  for (let i = 0; i < bytes.length - 1; i += 2) {
    res += String.fromCharCode(bytes[i] + bytes[i + 1] * 256);
  }
  return res;
}
function checkOffset(offset, ext, length) {
  if (offset % 1 !== 0 || offset < 0) throw new RangeError("offset is not uint");
  if (offset + ext > length) throw new RangeError("Trying to access beyond buffer length");
}
function checkInt(buf, value, offset, ext, max, min) {
  if (!Buffer2.isBuffer(buf)) throw new TypeError('"buffer" argument must be a Buffer instance');
  if (value > max || value < min) throw new RangeError('"value" argument is out of bounds');
  if (offset + ext > buf.length) throw new RangeError("Index out of range");
}
function wrtBigUInt64LE(buf, value, offset, min, max) {
  checkIntBI(value, min, max, buf, offset, 7);
  let lo = Number(value & BigInt(4294967295));
  buf[offset++] = lo;
  lo = lo >> 8;
  buf[offset++] = lo;
  lo = lo >> 8;
  buf[offset++] = lo;
  lo = lo >> 8;
  buf[offset++] = lo;
  let hi = Number(value >> BigInt(32) & BigInt(4294967295));
  buf[offset++] = hi;
  hi = hi >> 8;
  buf[offset++] = hi;
  hi = hi >> 8;
  buf[offset++] = hi;
  hi = hi >> 8;
  buf[offset++] = hi;
  return offset;
}
function wrtBigUInt64BE(buf, value, offset, min, max) {
  checkIntBI(value, min, max, buf, offset, 7);
  let lo = Number(value & BigInt(4294967295));
  buf[offset + 7] = lo;
  lo = lo >> 8;
  buf[offset + 6] = lo;
  lo = lo >> 8;
  buf[offset + 5] = lo;
  lo = lo >> 8;
  buf[offset + 4] = lo;
  let hi = Number(value >> BigInt(32) & BigInt(4294967295));
  buf[offset + 3] = hi;
  hi = hi >> 8;
  buf[offset + 2] = hi;
  hi = hi >> 8;
  buf[offset + 1] = hi;
  hi = hi >> 8;
  buf[offset] = hi;
  return offset + 8;
}
function checkIEEE754(buf, value, offset, ext, max, min) {
  if (offset + ext > buf.length) throw new RangeError("Index out of range");
  if (offset < 0) throw new RangeError("Index out of range");
}
function writeFloat(buf, value, offset, littleEndian, noAssert) {
  value = +value;
  offset = offset >>> 0;
  if (!noAssert) {
    checkIEEE754(buf, value, offset, 4, 34028234663852886e22, -34028234663852886e22);
  }
  write(buf, value, offset, littleEndian, 23, 4);
  return offset + 4;
}
function writeDouble(buf, value, offset, littleEndian, noAssert) {
  value = +value;
  offset = offset >>> 0;
  if (!noAssert) {
    checkIEEE754(buf, value, offset, 8, 17976931348623157e292, -17976931348623157e292);
  }
  write(buf, value, offset, littleEndian, 52, 8);
  return offset + 8;
}
function E(sym, getMessage, Base) {
  errors[sym] = class NodeError extends Base {
    constructor() {
      super();
      Object.defineProperty(this, "message", {
        value: getMessage.apply(this, arguments),
        writable: true,
        configurable: true
      });
      this.name = `${this.name} [${sym}]`;
      this.stack;
      delete this.name;
    }
    get code() {
      return sym;
    }
    set code(value) {
      Object.defineProperty(this, "code", {
        configurable: true,
        enumerable: true,
        value,
        writable: true
      });
    }
    toString() {
      return `${this.name} [${sym}]: ${this.message}`;
    }
  };
}
function addNumericalSeparator(val) {
  let res = "";
  let i = val.length;
  const start = val[0] === "-" ? 1 : 0;
  for (; i >= start + 4; i -= 3) {
    res = `_${val.slice(i - 3, i)}${res}`;
  }
  return `${val.slice(0, i)}${res}`;
}
function checkBounds(buf, offset, byteLength2) {
  validateNumber(offset, "offset");
  if (buf[offset] === void 0 || buf[offset + byteLength2] === void 0) {
    boundsError(offset, buf.length - (byteLength2 + 1));
  }
}
function checkIntBI(value, min, max, buf, offset, byteLength2) {
  if (value > max || value < min) {
    const n = typeof min === "bigint" ? "n" : "";
    let range;
    if (byteLength2 > 3) {
      if (min === 0 || min === BigInt(0)) {
        range = `>= 0${n} and < 2${n} ** ${(byteLength2 + 1) * 8}${n}`;
      } else {
        range = `>= -(2${n} ** ${(byteLength2 + 1) * 8 - 1}${n}) and < 2 ** ${(byteLength2 + 1) * 8 - 1}${n}`;
      }
    } else {
      range = `>= ${min}${n} and <= ${max}${n}`;
    }
    throw new errors.ERR_OUT_OF_RANGE("value", range, value);
  }
  checkBounds(buf, offset, byteLength2);
}
function validateNumber(value, name) {
  if (typeof value !== "number") {
    throw new errors.ERR_INVALID_ARG_TYPE(name, "number", value);
  }
}
function boundsError(value, length, type) {
  if (Math.floor(value) !== value) {
    validateNumber(value, type);
    throw new errors.ERR_OUT_OF_RANGE(type || "offset", "an integer", value);
  }
  if (length < 0) {
    throw new errors.ERR_BUFFER_OUT_OF_BOUNDS();
  }
  throw new errors.ERR_OUT_OF_RANGE(
    type || "offset",
    `>= ${type ? 1 : 0} and <= ${length}`,
    value
  );
}
function base64clean(str) {
  str = str.split("=")[0];
  str = str.trim().replace(INVALID_BASE64_RE, "");
  if (str.length < 2) return "";
  while (str.length % 4 !== 0) {
    str = str + "=";
  }
  return str;
}
function utf8ToBytes(string, units) {
  units = units || Infinity;
  let codePoint;
  const length = string.length;
  let leadSurrogate = null;
  const bytes = [];
  for (let i = 0; i < length; ++i) {
    codePoint = string.charCodeAt(i);
    if (codePoint > 55295 && codePoint < 57344) {
      if (!leadSurrogate) {
        if (codePoint > 56319) {
          if ((units -= 3) > -1) bytes.push(239, 191, 189);
          continue;
        } else if (i + 1 === length) {
          if ((units -= 3) > -1) bytes.push(239, 191, 189);
          continue;
        }
        leadSurrogate = codePoint;
        continue;
      }
      if (codePoint < 56320) {
        if ((units -= 3) > -1) bytes.push(239, 191, 189);
        leadSurrogate = codePoint;
        continue;
      }
      codePoint = (leadSurrogate - 55296 << 10 | codePoint - 56320) + 65536;
    } else if (leadSurrogate) {
      if ((units -= 3) > -1) bytes.push(239, 191, 189);
    }
    leadSurrogate = null;
    if (codePoint < 128) {
      if ((units -= 1) < 0) break;
      bytes.push(codePoint);
    } else if (codePoint < 2048) {
      if ((units -= 2) < 0) break;
      bytes.push(
        codePoint >> 6 | 192,
        codePoint & 63 | 128
      );
    } else if (codePoint < 65536) {
      if ((units -= 3) < 0) break;
      bytes.push(
        codePoint >> 12 | 224,
        codePoint >> 6 & 63 | 128,
        codePoint & 63 | 128
      );
    } else if (codePoint < 1114112) {
      if ((units -= 4) < 0) break;
      bytes.push(
        codePoint >> 18 | 240,
        codePoint >> 12 & 63 | 128,
        codePoint >> 6 & 63 | 128,
        codePoint & 63 | 128
      );
    } else {
      throw new Error("Invalid code point");
    }
  }
  return bytes;
}
function asciiToBytes(str) {
  const byteArray = [];
  for (let i = 0; i < str.length; ++i) {
    byteArray.push(str.charCodeAt(i) & 255);
  }
  return byteArray;
}
function utf16leToBytes(str, units) {
  let c, hi, lo;
  const byteArray = [];
  for (let i = 0; i < str.length; ++i) {
    if ((units -= 2) < 0) break;
    c = str.charCodeAt(i);
    hi = c >> 8;
    lo = c % 256;
    byteArray.push(lo);
    byteArray.push(hi);
  }
  return byteArray;
}
function base64ToBytes(str) {
  return toByteArray(base64clean(str));
}
function blitBuffer(src, dst, offset, length) {
  let i;
  for (i = 0; i < length; ++i) {
    if (i + offset >= dst.length || i >= src.length) break;
    dst[i + offset] = src[i];
  }
  return i;
}
var config, K_MAX_LENGTH, MAX_ARGUMENTS_LENGTH, errors, INVALID_BASE64_RE, hexSliceLookupTable;
var init_buffer = __esm({
  "frida-shim:node_modules/@frida/buffer/index.js"() {
    init_node_globals();
    init_base64_js();
    init_ieee754();
    config = {
      INSPECT_MAX_BYTES: 50
    };
    K_MAX_LENGTH = 2147483647;
    Buffer2.TYPED_ARRAY_SUPPORT = true;
    Object.defineProperty(Buffer2.prototype, "parent", {
      enumerable: true,
      get: function() {
        if (!Buffer2.isBuffer(this)) return void 0;
        return this.buffer;
      }
    });
    Object.defineProperty(Buffer2.prototype, "offset", {
      enumerable: true,
      get: function() {
        if (!Buffer2.isBuffer(this)) return void 0;
        return this.byteOffset;
      }
    });
    Buffer2.poolSize = 8192;
    Buffer2.from = function(value, encodingOrOffset, length) {
      return from(value, encodingOrOffset, length);
    };
    Object.setPrototypeOf(Buffer2.prototype, Uint8Array.prototype);
    Object.setPrototypeOf(Buffer2, Uint8Array);
    Buffer2.alloc = function(size, fill2, encoding) {
      return alloc(size, fill2, encoding);
    };
    Buffer2.allocUnsafe = function(size) {
      return allocUnsafe(size);
    };
    Buffer2.allocUnsafeSlow = function(size) {
      return allocUnsafe(size);
    };
    Buffer2.isBuffer = function isBuffer(b) {
      return b != null && b._isBuffer === true && b !== Buffer2.prototype;
    };
    Buffer2.compare = function compare(a, b) {
      if (a instanceof Uint8Array) a = Buffer2.from(a, a.offset, a.byteLength);
      if (b instanceof Uint8Array) b = Buffer2.from(b, b.offset, b.byteLength);
      if (!Buffer2.isBuffer(a) || !Buffer2.isBuffer(b)) {
        throw new TypeError(
          'The "buf1", "buf2" arguments must be one of type Buffer or Uint8Array'
        );
      }
      if (a === b) return 0;
      let x = a.length;
      let y = b.length;
      for (let i = 0, len = Math.min(x, y); i < len; ++i) {
        if (a[i] !== b[i]) {
          x = a[i];
          y = b[i];
          break;
        }
      }
      if (x < y) return -1;
      if (y < x) return 1;
      return 0;
    };
    Buffer2.isEncoding = function isEncoding(encoding) {
      switch (String(encoding).toLowerCase()) {
        case "hex":
        case "utf8":
        case "utf-8":
        case "ascii":
        case "latin1":
        case "binary":
        case "base64":
        case "ucs2":
        case "ucs-2":
        case "utf16le":
        case "utf-16le":
          return true;
        default:
          return false;
      }
    };
    Buffer2.concat = function concat(list, length) {
      if (!Array.isArray(list)) {
        throw new TypeError('"list" argument must be an Array of Buffers');
      }
      if (list.length === 0) {
        return Buffer2.alloc(0);
      }
      let i;
      if (length === void 0) {
        length = 0;
        for (i = 0; i < list.length; ++i) {
          length += list[i].length;
        }
      }
      const buffer = Buffer2.allocUnsafe(length);
      let pos = 0;
      for (i = 0; i < list.length; ++i) {
        let buf = list[i];
        if (buf instanceof Uint8Array) {
          if (pos + buf.length > buffer.length) {
            if (!Buffer2.isBuffer(buf)) {
              buf = Buffer2.from(buf.buffer, buf.byteOffset, buf.byteLength);
            }
            buf.copy(buffer, pos);
          } else {
            Uint8Array.prototype.set.call(
              buffer,
              buf,
              pos
            );
          }
        } else if (!Buffer2.isBuffer(buf)) {
          throw new TypeError('"list" argument must be an Array of Buffers');
        } else {
          buf.copy(buffer, pos);
        }
        pos += buf.length;
      }
      return buffer;
    };
    Buffer2.byteLength = byteLength;
    Buffer2.prototype._isBuffer = true;
    Buffer2.prototype.swap16 = function swap16() {
      const len = this.length;
      if (len % 2 !== 0) {
        throw new RangeError("Buffer size must be a multiple of 16-bits");
      }
      for (let i = 0; i < len; i += 2) {
        swap(this, i, i + 1);
      }
      return this;
    };
    Buffer2.prototype.swap32 = function swap32() {
      const len = this.length;
      if (len % 4 !== 0) {
        throw new RangeError("Buffer size must be a multiple of 32-bits");
      }
      for (let i = 0; i < len; i += 4) {
        swap(this, i, i + 3);
        swap(this, i + 1, i + 2);
      }
      return this;
    };
    Buffer2.prototype.swap64 = function swap64() {
      const len = this.length;
      if (len % 8 !== 0) {
        throw new RangeError("Buffer size must be a multiple of 64-bits");
      }
      for (let i = 0; i < len; i += 8) {
        swap(this, i, i + 7);
        swap(this, i + 1, i + 6);
        swap(this, i + 2, i + 5);
        swap(this, i + 3, i + 4);
      }
      return this;
    };
    Buffer2.prototype.toString = function toString() {
      const length = this.length;
      if (length === 0) return "";
      if (arguments.length === 0) return utf8Slice(this, 0, length);
      return slowToString.apply(this, arguments);
    };
    Buffer2.prototype.toLocaleString = Buffer2.prototype.toString;
    Buffer2.prototype.equals = function equals(b) {
      if (!Buffer2.isBuffer(b)) throw new TypeError("Argument must be a Buffer");
      if (this === b) return true;
      return Buffer2.compare(this, b) === 0;
    };
    Buffer2.prototype.inspect = function inspect() {
      let str = "";
      const max = config.INSPECT_MAX_BYTES;
      str = this.toString("hex", 0, max).replace(/(.{2})/g, "$1 ").trim();
      if (this.length > max) str += " ... ";
      return "<Buffer " + str + ">";
    };
    Buffer2.prototype[Symbol.for("nodejs.util.inspect.custom")] = Buffer2.prototype.inspect;
    Buffer2.prototype.compare = function compare2(target, start, end, thisStart, thisEnd) {
      if (target instanceof Uint8Array) {
        target = Buffer2.from(target, target.offset, target.byteLength);
      }
      if (!Buffer2.isBuffer(target)) {
        throw new TypeError(
          'The "target" argument must be one of type Buffer or Uint8Array. Received type ' + typeof target
        );
      }
      if (start === void 0) {
        start = 0;
      }
      if (end === void 0) {
        end = target ? target.length : 0;
      }
      if (thisStart === void 0) {
        thisStart = 0;
      }
      if (thisEnd === void 0) {
        thisEnd = this.length;
      }
      if (start < 0 || end > target.length || thisStart < 0 || thisEnd > this.length) {
        throw new RangeError("out of range index");
      }
      if (thisStart >= thisEnd && start >= end) {
        return 0;
      }
      if (thisStart >= thisEnd) {
        return -1;
      }
      if (start >= end) {
        return 1;
      }
      start >>>= 0;
      end >>>= 0;
      thisStart >>>= 0;
      thisEnd >>>= 0;
      if (this === target) return 0;
      let x = thisEnd - thisStart;
      let y = end - start;
      const len = Math.min(x, y);
      const thisCopy = this.slice(thisStart, thisEnd);
      const targetCopy = target.slice(start, end);
      for (let i = 0; i < len; ++i) {
        if (thisCopy[i] !== targetCopy[i]) {
          x = thisCopy[i];
          y = targetCopy[i];
          break;
        }
      }
      if (x < y) return -1;
      if (y < x) return 1;
      return 0;
    };
    Buffer2.prototype.includes = function includes(val, byteOffset, encoding) {
      return this.indexOf(val, byteOffset, encoding) !== -1;
    };
    Buffer2.prototype.indexOf = function indexOf(val, byteOffset, encoding) {
      return bidirectionalIndexOf(this, val, byteOffset, encoding, true);
    };
    Buffer2.prototype.lastIndexOf = function lastIndexOf(val, byteOffset, encoding) {
      return bidirectionalIndexOf(this, val, byteOffset, encoding, false);
    };
    Buffer2.prototype.write = function write2(string, offset, length, encoding) {
      if (offset === void 0) {
        encoding = "utf8";
        length = this.length;
        offset = 0;
      } else if (length === void 0 && typeof offset === "string") {
        encoding = offset;
        length = this.length;
        offset = 0;
      } else if (isFinite(offset)) {
        offset = offset >>> 0;
        if (isFinite(length)) {
          length = length >>> 0;
          if (encoding === void 0) encoding = "utf8";
        } else {
          encoding = length;
          length = void 0;
        }
      } else {
        throw new Error(
          "Buffer.write(string, encoding, offset[, length]) is no longer supported"
        );
      }
      const remaining = this.length - offset;
      if (length === void 0 || length > remaining) length = remaining;
      if (string.length > 0 && (length < 0 || offset < 0) || offset > this.length) {
        throw new RangeError("Attempt to write outside buffer bounds");
      }
      if (!encoding) encoding = "utf8";
      let loweredCase = false;
      for (; ; ) {
        switch (encoding) {
          case "hex":
            return hexWrite(this, string, offset, length);
          case "utf8":
          case "utf-8":
            return utf8Write(this, string, offset, length);
          case "ascii":
          case "latin1":
          case "binary":
            return asciiWrite(this, string, offset, length);
          case "base64":
            return base64Write(this, string, offset, length);
          case "ucs2":
          case "ucs-2":
          case "utf16le":
          case "utf-16le":
            return ucs2Write(this, string, offset, length);
          default:
            if (loweredCase) throw new TypeError("Unknown encoding: " + encoding);
            encoding = ("" + encoding).toLowerCase();
            loweredCase = true;
        }
      }
    };
    Buffer2.prototype.toJSON = function toJSON() {
      return {
        type: "Buffer",
        data: Array.prototype.slice.call(this._arr || this, 0)
      };
    };
    MAX_ARGUMENTS_LENGTH = 4096;
    Buffer2.prototype.slice = function slice(start, end) {
      const len = this.length;
      start = ~~start;
      end = end === void 0 ? len : ~~end;
      if (start < 0) {
        start += len;
        if (start < 0) start = 0;
      } else if (start > len) {
        start = len;
      }
      if (end < 0) {
        end += len;
        if (end < 0) end = 0;
      } else if (end > len) {
        end = len;
      }
      if (end < start) end = start;
      const newBuf = this.subarray(start, end);
      Object.setPrototypeOf(newBuf, Buffer2.prototype);
      return newBuf;
    };
    Buffer2.prototype.readUintLE = Buffer2.prototype.readUIntLE = function readUIntLE(offset, byteLength2, noAssert) {
      offset = offset >>> 0;
      byteLength2 = byteLength2 >>> 0;
      if (!noAssert) checkOffset(offset, byteLength2, this.length);
      let val = this[offset];
      let mul = 1;
      let i = 0;
      while (++i < byteLength2 && (mul *= 256)) {
        val += this[offset + i] * mul;
      }
      return val;
    };
    Buffer2.prototype.readUintBE = Buffer2.prototype.readUIntBE = function readUIntBE(offset, byteLength2, noAssert) {
      offset = offset >>> 0;
      byteLength2 = byteLength2 >>> 0;
      if (!noAssert) {
        checkOffset(offset, byteLength2, this.length);
      }
      let val = this[offset + --byteLength2];
      let mul = 1;
      while (byteLength2 > 0 && (mul *= 256)) {
        val += this[offset + --byteLength2] * mul;
      }
      return val;
    };
    Buffer2.prototype.readUint8 = Buffer2.prototype.readUInt8 = function readUInt8(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 1, this.length);
      return this[offset];
    };
    Buffer2.prototype.readUint16LE = Buffer2.prototype.readUInt16LE = function readUInt16LE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 2, this.length);
      return this[offset] | this[offset + 1] << 8;
    };
    Buffer2.prototype.readUint16BE = Buffer2.prototype.readUInt16BE = function readUInt16BE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 2, this.length);
      return this[offset] << 8 | this[offset + 1];
    };
    Buffer2.prototype.readUint32LE = Buffer2.prototype.readUInt32LE = function readUInt32LE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 4, this.length);
      return (this[offset] | this[offset + 1] << 8 | this[offset + 2] << 16) + this[offset + 3] * 16777216;
    };
    Buffer2.prototype.readUint32BE = Buffer2.prototype.readUInt32BE = function readUInt32BE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 4, this.length);
      return this[offset] * 16777216 + (this[offset + 1] << 16 | this[offset + 2] << 8 | this[offset + 3]);
    };
    Buffer2.prototype.readBigUInt64LE = function readBigUInt64LE(offset) {
      offset = offset >>> 0;
      validateNumber(offset, "offset");
      const first = this[offset];
      const last = this[offset + 7];
      if (first === void 0 || last === void 0) {
        boundsError(offset, this.length - 8);
      }
      const lo = first + this[++offset] * 2 ** 8 + this[++offset] * 2 ** 16 + this[++offset] * 2 ** 24;
      const hi = this[++offset] + this[++offset] * 2 ** 8 + this[++offset] * 2 ** 16 + last * 2 ** 24;
      return BigInt(lo) + (BigInt(hi) << BigInt(32));
    };
    Buffer2.prototype.readBigUInt64BE = function readBigUInt64BE(offset) {
      offset = offset >>> 0;
      validateNumber(offset, "offset");
      const first = this[offset];
      const last = this[offset + 7];
      if (first === void 0 || last === void 0) {
        boundsError(offset, this.length - 8);
      }
      const hi = first * 2 ** 24 + this[++offset] * 2 ** 16 + this[++offset] * 2 ** 8 + this[++offset];
      const lo = this[++offset] * 2 ** 24 + this[++offset] * 2 ** 16 + this[++offset] * 2 ** 8 + last;
      return (BigInt(hi) << BigInt(32)) + BigInt(lo);
    };
    Buffer2.prototype.readIntLE = function readIntLE(offset, byteLength2, noAssert) {
      offset = offset >>> 0;
      byteLength2 = byteLength2 >>> 0;
      if (!noAssert) checkOffset(offset, byteLength2, this.length);
      let val = this[offset];
      let mul = 1;
      let i = 0;
      while (++i < byteLength2 && (mul *= 256)) {
        val += this[offset + i] * mul;
      }
      mul *= 128;
      if (val >= mul) val -= Math.pow(2, 8 * byteLength2);
      return val;
    };
    Buffer2.prototype.readIntBE = function readIntBE(offset, byteLength2, noAssert) {
      offset = offset >>> 0;
      byteLength2 = byteLength2 >>> 0;
      if (!noAssert) checkOffset(offset, byteLength2, this.length);
      let i = byteLength2;
      let mul = 1;
      let val = this[offset + --i];
      while (i > 0 && (mul *= 256)) {
        val += this[offset + --i] * mul;
      }
      mul *= 128;
      if (val >= mul) val -= Math.pow(2, 8 * byteLength2);
      return val;
    };
    Buffer2.prototype.readInt8 = function readInt8(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 1, this.length);
      if (!(this[offset] & 128)) return this[offset];
      return (255 - this[offset] + 1) * -1;
    };
    Buffer2.prototype.readInt16LE = function readInt16LE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 2, this.length);
      const val = this[offset] | this[offset + 1] << 8;
      return val & 32768 ? val | 4294901760 : val;
    };
    Buffer2.prototype.readInt16BE = function readInt16BE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 2, this.length);
      const val = this[offset + 1] | this[offset] << 8;
      return val & 32768 ? val | 4294901760 : val;
    };
    Buffer2.prototype.readInt32LE = function readInt32LE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 4, this.length);
      return this[offset] | this[offset + 1] << 8 | this[offset + 2] << 16 | this[offset + 3] << 24;
    };
    Buffer2.prototype.readInt32BE = function readInt32BE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 4, this.length);
      return this[offset] << 24 | this[offset + 1] << 16 | this[offset + 2] << 8 | this[offset + 3];
    };
    Buffer2.prototype.readBigInt64LE = function readBigInt64LE(offset) {
      offset = offset >>> 0;
      validateNumber(offset, "offset");
      const first = this[offset];
      const last = this[offset + 7];
      if (first === void 0 || last === void 0) {
        boundsError(offset, this.length - 8);
      }
      const val = this[offset + 4] + this[offset + 5] * 2 ** 8 + this[offset + 6] * 2 ** 16 + (last << 24);
      return (BigInt(val) << BigInt(32)) + BigInt(first + this[++offset] * 2 ** 8 + this[++offset] * 2 ** 16 + this[++offset] * 2 ** 24);
    };
    Buffer2.prototype.readBigInt64BE = function readBigInt64BE(offset) {
      offset = offset >>> 0;
      validateNumber(offset, "offset");
      const first = this[offset];
      const last = this[offset + 7];
      if (first === void 0 || last === void 0) {
        boundsError(offset, this.length - 8);
      }
      const val = (first << 24) + // Overflow
      this[++offset] * 2 ** 16 + this[++offset] * 2 ** 8 + this[++offset];
      return (BigInt(val) << BigInt(32)) + BigInt(this[++offset] * 2 ** 24 + this[++offset] * 2 ** 16 + this[++offset] * 2 ** 8 + last);
    };
    Buffer2.prototype.readFloatLE = function readFloatLE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 4, this.length);
      return read(this, offset, true, 23, 4);
    };
    Buffer2.prototype.readFloatBE = function readFloatBE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 4, this.length);
      return read(this, offset, false, 23, 4);
    };
    Buffer2.prototype.readDoubleLE = function readDoubleLE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 8, this.length);
      return read(this, offset, true, 52, 8);
    };
    Buffer2.prototype.readDoubleBE = function readDoubleBE(offset, noAssert) {
      offset = offset >>> 0;
      if (!noAssert) checkOffset(offset, 8, this.length);
      return read(this, offset, false, 52, 8);
    };
    Buffer2.prototype.writeUintLE = Buffer2.prototype.writeUIntLE = function writeUIntLE(value, offset, byteLength2, noAssert) {
      value = +value;
      offset = offset >>> 0;
      byteLength2 = byteLength2 >>> 0;
      if (!noAssert) {
        const maxBytes = Math.pow(2, 8 * byteLength2) - 1;
        checkInt(this, value, offset, byteLength2, maxBytes, 0);
      }
      let mul = 1;
      let i = 0;
      this[offset] = value & 255;
      while (++i < byteLength2 && (mul *= 256)) {
        this[offset + i] = value / mul & 255;
      }
      return offset + byteLength2;
    };
    Buffer2.prototype.writeUintBE = Buffer2.prototype.writeUIntBE = function writeUIntBE(value, offset, byteLength2, noAssert) {
      value = +value;
      offset = offset >>> 0;
      byteLength2 = byteLength2 >>> 0;
      if (!noAssert) {
        const maxBytes = Math.pow(2, 8 * byteLength2) - 1;
        checkInt(this, value, offset, byteLength2, maxBytes, 0);
      }
      let i = byteLength2 - 1;
      let mul = 1;
      this[offset + i] = value & 255;
      while (--i >= 0 && (mul *= 256)) {
        this[offset + i] = value / mul & 255;
      }
      return offset + byteLength2;
    };
    Buffer2.prototype.writeUint8 = Buffer2.prototype.writeUInt8 = function writeUInt8(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 1, 255, 0);
      this[offset] = value & 255;
      return offset + 1;
    };
    Buffer2.prototype.writeUint16LE = Buffer2.prototype.writeUInt16LE = function writeUInt16LE(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 2, 65535, 0);
      this[offset] = value & 255;
      this[offset + 1] = value >>> 8;
      return offset + 2;
    };
    Buffer2.prototype.writeUint16BE = Buffer2.prototype.writeUInt16BE = function writeUInt16BE(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 2, 65535, 0);
      this[offset] = value >>> 8;
      this[offset + 1] = value & 255;
      return offset + 2;
    };
    Buffer2.prototype.writeUint32LE = Buffer2.prototype.writeUInt32LE = function writeUInt32LE(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 4, 4294967295, 0);
      this[offset + 3] = value >>> 24;
      this[offset + 2] = value >>> 16;
      this[offset + 1] = value >>> 8;
      this[offset] = value & 255;
      return offset + 4;
    };
    Buffer2.prototype.writeUint32BE = Buffer2.prototype.writeUInt32BE = function writeUInt32BE(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 4, 4294967295, 0);
      this[offset] = value >>> 24;
      this[offset + 1] = value >>> 16;
      this[offset + 2] = value >>> 8;
      this[offset + 3] = value & 255;
      return offset + 4;
    };
    Buffer2.prototype.writeBigUInt64LE = function writeBigUInt64LE(value, offset = 0) {
      return wrtBigUInt64LE(this, value, offset, BigInt(0), BigInt("0xffffffffffffffff"));
    };
    Buffer2.prototype.writeBigUInt64BE = function writeBigUInt64BE(value, offset = 0) {
      return wrtBigUInt64BE(this, value, offset, BigInt(0), BigInt("0xffffffffffffffff"));
    };
    Buffer2.prototype.writeIntLE = function writeIntLE(value, offset, byteLength2, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) {
        const limit = Math.pow(2, 8 * byteLength2 - 1);
        checkInt(this, value, offset, byteLength2, limit - 1, -limit);
      }
      let i = 0;
      let mul = 1;
      let sub = 0;
      this[offset] = value & 255;
      while (++i < byteLength2 && (mul *= 256)) {
        if (value < 0 && sub === 0 && this[offset + i - 1] !== 0) {
          sub = 1;
        }
        this[offset + i] = (value / mul >> 0) - sub & 255;
      }
      return offset + byteLength2;
    };
    Buffer2.prototype.writeIntBE = function writeIntBE(value, offset, byteLength2, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) {
        const limit = Math.pow(2, 8 * byteLength2 - 1);
        checkInt(this, value, offset, byteLength2, limit - 1, -limit);
      }
      let i = byteLength2 - 1;
      let mul = 1;
      let sub = 0;
      this[offset + i] = value & 255;
      while (--i >= 0 && (mul *= 256)) {
        if (value < 0 && sub === 0 && this[offset + i + 1] !== 0) {
          sub = 1;
        }
        this[offset + i] = (value / mul >> 0) - sub & 255;
      }
      return offset + byteLength2;
    };
    Buffer2.prototype.writeInt8 = function writeInt8(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 1, 127, -128);
      if (value < 0) value = 255 + value + 1;
      this[offset] = value & 255;
      return offset + 1;
    };
    Buffer2.prototype.writeInt16LE = function writeInt16LE(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 2, 32767, -32768);
      this[offset] = value & 255;
      this[offset + 1] = value >>> 8;
      return offset + 2;
    };
    Buffer2.prototype.writeInt16BE = function writeInt16BE(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 2, 32767, -32768);
      this[offset] = value >>> 8;
      this[offset + 1] = value & 255;
      return offset + 2;
    };
    Buffer2.prototype.writeInt32LE = function writeInt32LE(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 4, 2147483647, -2147483648);
      this[offset] = value & 255;
      this[offset + 1] = value >>> 8;
      this[offset + 2] = value >>> 16;
      this[offset + 3] = value >>> 24;
      return offset + 4;
    };
    Buffer2.prototype.writeInt32BE = function writeInt32BE(value, offset, noAssert) {
      value = +value;
      offset = offset >>> 0;
      if (!noAssert) checkInt(this, value, offset, 4, 2147483647, -2147483648);
      if (value < 0) value = 4294967295 + value + 1;
      this[offset] = value >>> 24;
      this[offset + 1] = value >>> 16;
      this[offset + 2] = value >>> 8;
      this[offset + 3] = value & 255;
      return offset + 4;
    };
    Buffer2.prototype.writeBigInt64LE = function writeBigInt64LE(value, offset = 0) {
      return wrtBigUInt64LE(this, value, offset, -BigInt("0x8000000000000000"), BigInt("0x7fffffffffffffff"));
    };
    Buffer2.prototype.writeBigInt64BE = function writeBigInt64BE(value, offset = 0) {
      return wrtBigUInt64BE(this, value, offset, -BigInt("0x8000000000000000"), BigInt("0x7fffffffffffffff"));
    };
    Buffer2.prototype.writeFloatLE = function writeFloatLE(value, offset, noAssert) {
      return writeFloat(this, value, offset, true, noAssert);
    };
    Buffer2.prototype.writeFloatBE = function writeFloatBE(value, offset, noAssert) {
      return writeFloat(this, value, offset, false, noAssert);
    };
    Buffer2.prototype.writeDoubleLE = function writeDoubleLE(value, offset, noAssert) {
      return writeDouble(this, value, offset, true, noAssert);
    };
    Buffer2.prototype.writeDoubleBE = function writeDoubleBE(value, offset, noAssert) {
      return writeDouble(this, value, offset, false, noAssert);
    };
    Buffer2.prototype.copy = function copy(target, targetStart, start, end) {
      if (!Buffer2.isBuffer(target)) throw new TypeError("argument should be a Buffer");
      if (!start) start = 0;
      if (!end && end !== 0) end = this.length;
      if (targetStart >= target.length) targetStart = target.length;
      if (!targetStart) targetStart = 0;
      if (end > 0 && end < start) end = start;
      if (end === start) return 0;
      if (target.length === 0 || this.length === 0) return 0;
      if (targetStart < 0) {
        throw new RangeError("targetStart out of bounds");
      }
      if (start < 0 || start >= this.length) throw new RangeError("Index out of range");
      if (end < 0) throw new RangeError("sourceEnd out of bounds");
      if (end > this.length) end = this.length;
      if (target.length - targetStart < end - start) {
        end = target.length - targetStart + start;
      }
      const len = end - start;
      if (this === target) {
        this.copyWithin(targetStart, start, end);
      } else {
        Uint8Array.prototype.set.call(
          target,
          this.subarray(start, end),
          targetStart
        );
      }
      return len;
    };
    Buffer2.prototype.fill = function fill(val, start, end, encoding) {
      if (typeof val === "string") {
        if (typeof start === "string") {
          encoding = start;
          start = 0;
          end = this.length;
        } else if (typeof end === "string") {
          encoding = end;
          end = this.length;
        }
        if (encoding !== void 0 && typeof encoding !== "string") {
          throw new TypeError("encoding must be a string");
        }
        if (typeof encoding === "string" && !Buffer2.isEncoding(encoding)) {
          throw new TypeError("Unknown encoding: " + encoding);
        }
        if (val.length === 1) {
          const code2 = val.charCodeAt(0);
          if (encoding === "utf8" && code2 < 128 || encoding === "latin1") {
            val = code2;
          }
        }
      } else if (typeof val === "number") {
        val = val & 255;
      } else if (typeof val === "boolean") {
        val = Number(val);
      }
      if (start < 0 || this.length < start || this.length < end) {
        throw new RangeError("Out of range index");
      }
      if (end <= start) {
        return this;
      }
      start = start >>> 0;
      end = end === void 0 ? this.length : end >>> 0;
      if (!val) val = 0;
      let i;
      if (typeof val === "number") {
        for (i = start; i < end; ++i) {
          this[i] = val;
        }
      } else {
        const bytes = Buffer2.isBuffer(val) ? val : Buffer2.from(val, encoding);
        const len = bytes.length;
        if (len === 0) {
          throw new TypeError('The value "' + val + '" is invalid for argument "value"');
        }
        for (i = 0; i < end - start; ++i) {
          this[i + start] = bytes[i % len];
        }
      }
      return this;
    };
    errors = {};
    E(
      "ERR_BUFFER_OUT_OF_BOUNDS",
      function(name) {
        if (name) {
          return `${name} is outside of buffer bounds`;
        }
        return "Attempt to access memory outside buffer bounds";
      },
      RangeError
    );
    E(
      "ERR_INVALID_ARG_TYPE",
      function(name, actual) {
        return `The "${name}" argument must be of type number. Received type ${typeof actual}`;
      },
      TypeError
    );
    E(
      "ERR_OUT_OF_RANGE",
      function(str, range, input) {
        let msg = `The value of "${str}" is out of range.`;
        let received = input;
        if (Number.isInteger(input) && Math.abs(input) > 2 ** 32) {
          received = addNumericalSeparator(String(input));
        } else if (typeof input === "bigint") {
          received = String(input);
          if (input > BigInt(2) ** BigInt(32) || input < -(BigInt(2) ** BigInt(32))) {
            received = addNumericalSeparator(received);
          }
          received += "n";
        }
        msg += ` It must be ${range}. Received ${received}`;
        return msg;
      },
      RangeError
    );
    INVALID_BASE64_RE = /[^+/0-9A-Za-z-_]/g;
    hexSliceLookupTable = function() {
      const alphabet = "0123456789abcdef";
      const table = new Array(256);
      for (let i = 0; i < 16; ++i) {
        const i16 = i * 16;
        for (let j = 0; j < 16; ++j) {
          table[i16 + j] = alphabet[i] + alphabet[j];
        }
      }
      return table;
    }();
  }
});

// frida-builtins:/node-globals.js
var init_node_globals = __esm({
  "frida-builtins:/node-globals.js"() {
    init_buffer();
  }
});

// node_modules/frida-il2cpp-bridge/dist/index.js
function raise(message) {
  const error = new Error(message);
  error.name = "Il2CppError";
  error.stack = error.stack?.replace(/^(Il2Cpp)?Error/, "\x1B[0m\x1B[38;5;9mil2cpp\x1B[0m")?.replace(/\n    at (.+) \((.+):(.+)\)/, "\x1B[3m\x1B[2m")?.concat("\x1B[0m");
  throw error;
}
function warn(message) {
  globalThis.console.log(`\x1B[38;5;11mil2cpp\x1B[0m: ${message}`);
}
function ok(message) {
  globalThis.console.log(`\x1B[38;5;10mil2cpp\x1B[0m: ${message}`);
}
function inform(message) {
  globalThis.console.log(`\x1B[38;5;12mil2cpp\x1B[0m: ${message}`);
}
function decorate(target, decorator, descriptors = Object.getOwnPropertyDescriptors(target)) {
  for (const key in descriptors) {
    descriptors[key] = decorator(target, key, descriptors[key]);
  }
  Object.defineProperties(target, descriptors);
  return target;
}
function getter(target, key, get, decorator) {
  globalThis.Object.defineProperty(target, key, decorator?.(target, key, { get, configurable: true }) ?? { get, configurable: true });
}
function cyrb53(str) {
  let h1 = 3735928559;
  let h2 = 1103547991;
  for (let i = 0, ch; i < str.length; i++) {
    ch = str.charCodeAt(i);
    h1 = Math.imul(h1 ^ ch, 2654435761);
    h2 = Math.imul(h2 ^ ch, 1597334677);
  }
  h1 = Math.imul(h1 ^ h1 >>> 16, 2246822507);
  h1 ^= Math.imul(h2 ^ h2 >>> 13, 3266489909);
  h2 = Math.imul(h2 ^ h2 >>> 16, 2246822507);
  h2 ^= Math.imul(h1 ^ h1 >>> 13, 3266489909);
  return 4294967296 * (2097151 & h2) + (h1 >>> 0);
}
function exportsHash(module) {
  return cyrb53(module.enumerateExports().sort((a, b) => a.name.localeCompare(b.name)).map((_) => _.name + _.address.sub(module.base)).join(""));
}
function lazy(_, propertyKey, descriptor) {
  const getter2 = descriptor.get;
  if (!getter2) {
    throw new Error("@lazy can only be applied to getter accessors");
  }
  descriptor.get = function() {
    const value = getter2.call(this);
    Object.defineProperty(this, propertyKey, {
      value,
      configurable: descriptor.configurable,
      enumerable: descriptor.enumerable,
      writable: false
    });
    return value;
  };
  return descriptor;
}
function addFlippedEntries(obj) {
  return Object.keys(obj).reduce((obj2, key) => (obj2[obj2[key]] = key, obj2), obj);
}
function readNativeIterator(block) {
  const array = [];
  const iterator = Memory.alloc(Process.pointerSize);
  let handle = block(iterator);
  while (!handle.isNull()) {
    array.push(handle);
    handle = block(iterator);
  }
  return array;
}
function readNativeList(block) {
  const lengthPointer = Memory.alloc(Process.pointerSize);
  const startPointer = block(lengthPointer);
  if (startPointer.isNull()) {
    return [];
  }
  const array = new Array(lengthPointer.readInt());
  for (let i = 0; i < array.length; i++) {
    array[i] = startPointer.add(i * Process.pointerSize).readPointer();
  }
  return array;
}
function recycle(Class) {
  return new Proxy(Class, {
    cache: /* @__PURE__ */ new Map(),
    construct(Target, argArray) {
      const handle = argArray[0].toUInt32();
      if (!this.cache.has(handle)) {
        this.cache.set(handle, new Target(argArray[0]));
      }
      return this.cache.get(handle);
    }
  });
}
var __decorate, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Android, NativeStruct, UnityVersion, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2, Il2Cpp2;
var init_dist = __esm({
  "node_modules/frida-il2cpp-bridge/dist/index.js"() {
    "use strict";
    init_node_globals();
    __decorate = function(decorators, target, key, desc) {
      var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
      if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
      else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
      return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    (function(Il2Cpp3) {
      Il2Cpp3.application = {
        /**
         * Gets the data path name of the current application, e.g.
         * `/data/emulated/0/Android/data/com.example.application/files`
         * on Android.
         *
         * **This information is not guaranteed to exist.**
         *
         * ```ts
         * Il2Cpp.perform(() => {
         *     // prints /data/emulated/0/Android/data/com.example.application/files
         *     console.log(Il2Cpp.application.dataPath);
         * });
         * ```
         */
        get dataPath() {
          return unityEngineCall("get_persistentDataPath");
        },
        /**
         * Gets the identifier name of the current application, e.g.
         * `com.example.application` on Android.
         *
         * In case the identifier cannot be retrieved, the main module name is
         * returned instead, which typically is the process name.
         *
         * ```ts
         * Il2Cpp.perform(() => {
         *     // prints com.example.application
         *     console.log(Il2Cpp.application.identifier);
         * });
         * ```
         */
        get identifier() {
          return unityEngineCall("get_identifier") ?? unityEngineCall("get_bundleIdentifier") ?? Process.mainModule.name;
        },
        /**
         * Gets the version name of the current application, e.g. `4.12.8`.
         *
         * In case the version cannot be retrieved, an hash of the IL2CPP
         * module is returned instead.
         *
         * ```ts
         * Il2Cpp.perform(() => {
         *     // prints 4.12.8
         *     console.log(Il2Cpp.application.version);
         * });
         * ```
         */
        get version() {
          return unityEngineCall("get_version") ?? exportsHash(Il2Cpp3.module).toString(16);
        }
      };
      getter(Il2Cpp3, "unityVersion", () => {
        try {
          const unityVersion = Il2Cpp3.$config.unityVersion ?? unityEngineCall("get_unityVersion");
          if (unityVersion != null) {
            return unityVersion;
          }
        } catch (_) {
        }
        const searchPattern = "69 6c 32 63 70 70";
        for (const range of Il2Cpp3.module.enumerateRanges("r--").concat(Process.getRangeByAddress(Il2Cpp3.module.base))) {
          for (let { address } of Memory.scanSync(range.base, range.size, searchPattern)) {
            while (address.readU8() != 0) {
              address = address.sub(1);
            }
            const match = UnityVersion.find(address.add(1).readCString());
            if (match != void 0) {
              return match;
            }
          }
        }
        raise("couldn't determine the Unity version, please specify it manually");
      }, lazy);
      getter(Il2Cpp3, "unityVersionIsBelow201830", () => {
        return UnityVersion.lt(Il2Cpp3.unityVersion, "2018.3.0");
      }, lazy);
      getter(Il2Cpp3, "unityVersionIsBelow202120", () => {
        return UnityVersion.lt(Il2Cpp3.unityVersion, "2021.2.0");
      }, lazy);
      function unityEngineCall(method) {
        const handle = Il2Cpp3.exports.resolveInternalCall(Memory.allocUtf8String("UnityEngine.Application::" + method));
        const nativeFunction = new NativeFunction(handle, "pointer", []);
        return nativeFunction.isNull() ? null : new Il2Cpp3.String(nativeFunction()).asNullable()?.content ?? null;
      }
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      function boxed(value, type) {
        const mapping = {
          int8: "System.SByte",
          uint8: "System.Byte",
          int16: "System.Int16",
          uint16: "System.UInt16",
          int32: "System.Int32",
          uint32: "System.UInt32",
          int64: "System.Int64",
          uint64: "System.UInt64",
          char: "System.Char",
          intptr: "System.IntPtr",
          uintptr: "System.UIntPtr"
        };
        const className = typeof value == "boolean" ? "System.Boolean" : typeof value == "number" ? mapping[type ?? "int32"] : value instanceof Int64 ? "System.Int64" : value instanceof UInt64 ? "System.UInt64" : value instanceof NativePointer ? mapping[type ?? "intptr"] : raise(`Cannot create boxed primitive using value of type '${typeof value}'`);
        const object = Il2Cpp3.corlib.class(className ?? raise(`Unknown primitive type name '${type}'`)).alloc();
        (object.tryField("m_value") ?? object.tryField("_pointer") ?? raise(`Could not find primitive field in class '${className}'`)).value = value;
        return object;
      }
      Il2Cpp3.boxed = boxed;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      Il2Cpp3.$config = {
        moduleName: void 0,
        unityVersion: void 0,
        exports: void 0
      };
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      function dump(fileName, path) {
        fileName = fileName ?? `${Il2Cpp3.application.identifier}_${Il2Cpp3.application.version}.cs`;
        path = path ?? Il2Cpp3.application.dataPath ?? Process.getCurrentDir();
        createDirectoryRecursively(path);
        const destination = `${path}/${fileName}`;
        const file = new File(destination, "w");
        for (const assembly of Il2Cpp3.domain.assemblies) {
          inform(`dumping ${assembly.name}...`);
          for (const klass of assembly.image.classes) {
            file.write(`${klass}

`);
          }
        }
        file.flush();
        file.close();
        ok(`dump saved to ${destination}`);
        showDeprecationNotice();
      }
      Il2Cpp3.dump = dump;
      function dumpTree(path, ignoreAlreadyExistingDirectory = false) {
        path = path ?? `${Il2Cpp3.application.dataPath ?? Process.getCurrentDir()}/${Il2Cpp3.application.identifier}_${Il2Cpp3.application.version}`;
        if (!ignoreAlreadyExistingDirectory && directoryExists(path)) {
          raise(`directory ${path} already exists - pass ignoreAlreadyExistingDirectory = true to skip this check`);
        }
        for (const assembly of Il2Cpp3.domain.assemblies) {
          inform(`dumping ${assembly.name}...`);
          const destination = `${path}/${assembly.name.replaceAll(".", "/")}.cs`;
          createDirectoryRecursively(destination.substring(0, destination.lastIndexOf("/")));
          const file = new File(destination, "w");
          for (const klass of assembly.image.classes) {
            file.write(`${klass}

`);
          }
          file.flush();
          file.close();
        }
        ok(`dump saved to ${path}`);
        showDeprecationNotice();
      }
      Il2Cpp3.dumpTree = dumpTree;
      function directoryExists(path) {
        return Il2Cpp3.corlib.class("System.IO.Directory").method("Exists").invoke(Il2Cpp3.string(path));
      }
      function createDirectoryRecursively(path) {
        Il2Cpp3.corlib.class("System.IO.Directory").method("CreateDirectory").invoke(Il2Cpp3.string(path));
      }
      function showDeprecationNotice() {
        warn("this api will be removed in a future release, please use `npx frida-il2cpp-bridge dump` instead");
      }
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      function installExceptionListener(targetThread = "current") {
        const currentThread = Il2Cpp3.exports.threadGetCurrent();
        return Interceptor.attach(Il2Cpp3.module.getExportByName("__cxa_throw"), function(args) {
          if (targetThread == "current" && !Il2Cpp3.exports.threadGetCurrent().equals(currentThread)) {
            return;
          }
          inform(new Il2Cpp3.Object(args[0].readPointer()));
        });
      }
      Il2Cpp3.installExceptionListener = installExceptionListener;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      Il2Cpp3.exports = {
        get alloc() {
          return r("il2cpp_alloc", "pointer", ["size_t"]);
        },
        get arrayGetLength() {
          return r("il2cpp_array_length", "uint32", ["pointer"]);
        },
        get arrayNew() {
          return r("il2cpp_array_new", "pointer", ["pointer", "uint32"]);
        },
        get assemblyGetImage() {
          return r("il2cpp_assembly_get_image", "pointer", ["pointer"]);
        },
        get classForEach() {
          return r("il2cpp_class_for_each", "void", ["pointer", "pointer"]);
        },
        get classFromName() {
          return r("il2cpp_class_from_name", "pointer", ["pointer", "pointer", "pointer"]);
        },
        get classFromObject() {
          return r("il2cpp_class_from_system_type", "pointer", ["pointer"]);
        },
        get classGetArrayClass() {
          return r("il2cpp_array_class_get", "pointer", ["pointer", "uint32"]);
        },
        get classGetArrayElementSize() {
          return r("il2cpp_class_array_element_size", "int", ["pointer"]);
        },
        get classGetAssemblyName() {
          return r("il2cpp_class_get_assemblyname", "pointer", ["pointer"]);
        },
        get classGetBaseType() {
          return r("il2cpp_class_enum_basetype", "pointer", ["pointer"]);
        },
        get classGetDeclaringType() {
          return r("il2cpp_class_get_declaring_type", "pointer", ["pointer"]);
        },
        get classGetElementClass() {
          return r("il2cpp_class_get_element_class", "pointer", ["pointer"]);
        },
        get classGetFieldFromName() {
          return r("il2cpp_class_get_field_from_name", "pointer", ["pointer", "pointer"]);
        },
        get classGetFields() {
          return r("il2cpp_class_get_fields", "pointer", ["pointer", "pointer"]);
        },
        get classGetFlags() {
          return r("il2cpp_class_get_flags", "int", ["pointer"]);
        },
        get classGetImage() {
          return r("il2cpp_class_get_image", "pointer", ["pointer"]);
        },
        get classGetInstanceSize() {
          return r("il2cpp_class_instance_size", "int32", ["pointer"]);
        },
        get classGetInterfaces() {
          return r("il2cpp_class_get_interfaces", "pointer", ["pointer", "pointer"]);
        },
        get classGetMethodFromName() {
          return r("il2cpp_class_get_method_from_name", "pointer", ["pointer", "pointer", "int"]);
        },
        get classGetMethods() {
          return r("il2cpp_class_get_methods", "pointer", ["pointer", "pointer"]);
        },
        get classGetName() {
          return r("il2cpp_class_get_name", "pointer", ["pointer"]);
        },
        get classGetNamespace() {
          return r("il2cpp_class_get_namespace", "pointer", ["pointer"]);
        },
        get classGetNestedClasses() {
          return r("il2cpp_class_get_nested_types", "pointer", ["pointer", "pointer"]);
        },
        get classGetParent() {
          return r("il2cpp_class_get_parent", "pointer", ["pointer"]);
        },
        get classGetStaticFieldData() {
          return r("il2cpp_class_get_static_field_data", "pointer", ["pointer"]);
        },
        get classGetValueTypeSize() {
          return r("il2cpp_class_value_size", "int32", ["pointer", "pointer"]);
        },
        get classGetType() {
          return r("il2cpp_class_get_type", "pointer", ["pointer"]);
        },
        get classHasReferences() {
          return r("il2cpp_class_has_references", "bool", ["pointer"]);
        },
        get classInitialize() {
          return r("il2cpp_runtime_class_init", "void", ["pointer"]);
        },
        get classIsAbstract() {
          return r("il2cpp_class_is_abstract", "bool", ["pointer"]);
        },
        get classIsAssignableFrom() {
          return r("il2cpp_class_is_assignable_from", "bool", ["pointer", "pointer"]);
        },
        get classIsBlittable() {
          return r("il2cpp_class_is_blittable", "bool", ["pointer"]);
        },
        get classIsEnum() {
          return r("il2cpp_class_is_enum", "bool", ["pointer"]);
        },
        get classIsGeneric() {
          return r("il2cpp_class_is_generic", "bool", ["pointer"]);
        },
        get classIsInflated() {
          return r("il2cpp_class_is_inflated", "bool", ["pointer"]);
        },
        get classIsInterface() {
          return r("il2cpp_class_is_interface", "bool", ["pointer"]);
        },
        get classIsSubclassOf() {
          return r("il2cpp_class_is_subclass_of", "bool", ["pointer", "pointer", "bool"]);
        },
        get classIsValueType() {
          return r("il2cpp_class_is_valuetype", "bool", ["pointer"]);
        },
        get domainGetAssemblyFromName() {
          return r("il2cpp_domain_assembly_open", "pointer", ["pointer", "pointer"]);
        },
        get domainGet() {
          return r("il2cpp_domain_get", "pointer", []);
        },
        get domainGetAssemblies() {
          return r("il2cpp_domain_get_assemblies", "pointer", ["pointer", "pointer"]);
        },
        get fieldGetClass() {
          return r("il2cpp_field_get_parent", "pointer", ["pointer"]);
        },
        get fieldGetFlags() {
          return r("il2cpp_field_get_flags", "int", ["pointer"]);
        },
        get fieldGetName() {
          return r("il2cpp_field_get_name", "pointer", ["pointer"]);
        },
        get fieldGetOffset() {
          return r("il2cpp_field_get_offset", "int32", ["pointer"]);
        },
        get fieldGetStaticValue() {
          return r("il2cpp_field_static_get_value", "void", ["pointer", "pointer"]);
        },
        get fieldGetType() {
          return r("il2cpp_field_get_type", "pointer", ["pointer"]);
        },
        get fieldSetStaticValue() {
          return r("il2cpp_field_static_set_value", "void", ["pointer", "pointer"]);
        },
        get free() {
          return r("il2cpp_free", "void", ["pointer"]);
        },
        get gcCollect() {
          return r("il2cpp_gc_collect", "void", ["int"]);
        },
        get gcCollectALittle() {
          return r("il2cpp_gc_collect_a_little", "void", []);
        },
        get gcDisable() {
          return r("il2cpp_gc_disable", "void", []);
        },
        get gcEnable() {
          return r("il2cpp_gc_enable", "void", []);
        },
        get gcGetHeapSize() {
          return r("il2cpp_gc_get_heap_size", "int64", []);
        },
        get gcGetMaxTimeSlice() {
          return r("il2cpp_gc_get_max_time_slice_ns", "int64", []);
        },
        get gcGetUsedSize() {
          return r("il2cpp_gc_get_used_size", "int64", []);
        },
        get gcHandleGetTarget() {
          return r("il2cpp_gchandle_get_target", "pointer", ["uint32"]);
        },
        get gcHandleFree() {
          return r("il2cpp_gchandle_free", "void", ["uint32"]);
        },
        get gcHandleNew() {
          return r("il2cpp_gchandle_new", "uint32", ["pointer", "bool"]);
        },
        get gcHandleNewWeakRef() {
          return r("il2cpp_gchandle_new_weakref", "uint32", ["pointer", "bool"]);
        },
        get gcIsDisabled() {
          return r("il2cpp_gc_is_disabled", "bool", []);
        },
        get gcIsIncremental() {
          return r("il2cpp_gc_is_incremental", "bool", []);
        },
        get gcSetMaxTimeSlice() {
          return r("il2cpp_gc_set_max_time_slice_ns", "void", ["int64"]);
        },
        get gcStartIncrementalCollection() {
          return r("il2cpp_gc_start_incremental_collection", "void", []);
        },
        get gcStartWorld() {
          return r("il2cpp_start_gc_world", "void", []);
        },
        get gcStopWorld() {
          return r("il2cpp_stop_gc_world", "void", []);
        },
        get getCorlib() {
          return r("il2cpp_get_corlib", "pointer", []);
        },
        get imageGetAssembly() {
          return r("il2cpp_image_get_assembly", "pointer", ["pointer"]);
        },
        get imageGetClass() {
          return r("il2cpp_image_get_class", "pointer", ["pointer", "uint"]);
        },
        get imageGetClassCount() {
          return r("il2cpp_image_get_class_count", "uint32", ["pointer"]);
        },
        get imageGetName() {
          return r("il2cpp_image_get_name", "pointer", ["pointer"]);
        },
        get initialize() {
          return r("il2cpp_init", "void", ["pointer"]);
        },
        get livenessAllocateStruct() {
          return r("il2cpp_unity_liveness_allocate_struct", "pointer", ["pointer", "int", "pointer", "pointer", "pointer"]);
        },
        get livenessCalculationBegin() {
          return r("il2cpp_unity_liveness_calculation_begin", "pointer", ["pointer", "int", "pointer", "pointer", "pointer", "pointer"]);
        },
        get livenessCalculationEnd() {
          return r("il2cpp_unity_liveness_calculation_end", "void", ["pointer"]);
        },
        get livenessCalculationFromStatics() {
          return r("il2cpp_unity_liveness_calculation_from_statics", "void", ["pointer"]);
        },
        get livenessFinalize() {
          return r("il2cpp_unity_liveness_finalize", "void", ["pointer"]);
        },
        get livenessFreeStruct() {
          return r("il2cpp_unity_liveness_free_struct", "void", ["pointer"]);
        },
        get memorySnapshotCapture() {
          return r("il2cpp_capture_memory_snapshot", "pointer", []);
        },
        get memorySnapshotFree() {
          return r("il2cpp_free_captured_memory_snapshot", "void", ["pointer"]);
        },
        get memorySnapshotGetClasses() {
          return r("il2cpp_memory_snapshot_get_classes", "pointer", ["pointer", "pointer"]);
        },
        get memorySnapshotGetObjects() {
          return r("il2cpp_memory_snapshot_get_objects", "pointer", ["pointer", "pointer"]);
        },
        get methodGetClass() {
          return r("il2cpp_method_get_class", "pointer", ["pointer"]);
        },
        get methodGetFlags() {
          return r("il2cpp_method_get_flags", "uint32", ["pointer", "pointer"]);
        },
        get methodGetName() {
          return r("il2cpp_method_get_name", "pointer", ["pointer"]);
        },
        get methodGetObject() {
          return r("il2cpp_method_get_object", "pointer", ["pointer", "pointer"]);
        },
        get methodGetParameterCount() {
          return r("il2cpp_method_get_param_count", "uint8", ["pointer"]);
        },
        get methodGetParameterName() {
          return r("il2cpp_method_get_param_name", "pointer", ["pointer", "uint32"]);
        },
        get methodGetParameters() {
          return r("il2cpp_method_get_parameters", "pointer", ["pointer", "pointer"]);
        },
        get methodGetParameterType() {
          return r("il2cpp_method_get_param", "pointer", ["pointer", "uint32"]);
        },
        get methodGetReturnType() {
          return r("il2cpp_method_get_return_type", "pointer", ["pointer"]);
        },
        get methodIsGeneric() {
          return r("il2cpp_method_is_generic", "bool", ["pointer"]);
        },
        get methodIsInflated() {
          return r("il2cpp_method_is_inflated", "bool", ["pointer"]);
        },
        get methodIsInstance() {
          return r("il2cpp_method_is_instance", "bool", ["pointer"]);
        },
        get monitorEnter() {
          return r("il2cpp_monitor_enter", "void", ["pointer"]);
        },
        get monitorExit() {
          return r("il2cpp_monitor_exit", "void", ["pointer"]);
        },
        get monitorPulse() {
          return r("il2cpp_monitor_pulse", "void", ["pointer"]);
        },
        get monitorPulseAll() {
          return r("il2cpp_monitor_pulse_all", "void", ["pointer"]);
        },
        get monitorTryEnter() {
          return r("il2cpp_monitor_try_enter", "bool", ["pointer", "uint32"]);
        },
        get monitorTryWait() {
          return r("il2cpp_monitor_try_wait", "bool", ["pointer", "uint32"]);
        },
        get monitorWait() {
          return r("il2cpp_monitor_wait", "void", ["pointer"]);
        },
        get objectGetClass() {
          return r("il2cpp_object_get_class", "pointer", ["pointer"]);
        },
        get objectGetVirtualMethod() {
          return r("il2cpp_object_get_virtual_method", "pointer", ["pointer", "pointer"]);
        },
        get objectInitialize() {
          return r("il2cpp_runtime_object_init_exception", "void", ["pointer", "pointer"]);
        },
        get objectNew() {
          return r("il2cpp_object_new", "pointer", ["pointer"]);
        },
        get objectGetSize() {
          return r("il2cpp_object_get_size", "uint32", ["pointer"]);
        },
        get objectUnbox() {
          return r("il2cpp_object_unbox", "pointer", ["pointer"]);
        },
        get resolveInternalCall() {
          return r("il2cpp_resolve_icall", "pointer", ["pointer"]);
        },
        get stringGetChars() {
          return r("il2cpp_string_chars", "pointer", ["pointer"]);
        },
        get stringGetLength() {
          return r("il2cpp_string_length", "int32", ["pointer"]);
        },
        get stringNew() {
          return r("il2cpp_string_new", "pointer", ["pointer"]);
        },
        get valueTypeBox() {
          return r("il2cpp_value_box", "pointer", ["pointer", "pointer"]);
        },
        get threadAttach() {
          return r("il2cpp_thread_attach", "pointer", ["pointer"]);
        },
        get threadDetach() {
          return r("il2cpp_thread_detach", "void", ["pointer"]);
        },
        get threadGetAttachedThreads() {
          return r("il2cpp_thread_get_all_attached_threads", "pointer", ["pointer"]);
        },
        get threadGetCurrent() {
          return r("il2cpp_thread_current", "pointer", []);
        },
        get threadIsVm() {
          return r("il2cpp_is_vm_thread", "bool", ["pointer"]);
        },
        get typeEquals() {
          return r("il2cpp_type_equals", "bool", ["pointer", "pointer"]);
        },
        get typeGetClass() {
          return r("il2cpp_class_from_type", "pointer", ["pointer"]);
        },
        get typeGetName() {
          return r("il2cpp_type_get_name", "pointer", ["pointer"]);
        },
        get typeGetObject() {
          return r("il2cpp_type_get_object", "pointer", ["pointer"]);
        },
        get typeGetTypeEnum() {
          return r("il2cpp_type_get_type", "int", ["pointer"]);
        }
      };
      decorate(Il2Cpp3.exports, lazy);
      getter(Il2Cpp3, "memorySnapshotExports", () => new CModule("#include <stdint.h>\n#include <string.h>\n\ntypedef struct Il2CppManagedMemorySnapshot Il2CppManagedMemorySnapshot;\ntypedef struct Il2CppMetadataType Il2CppMetadataType;\n\nstruct Il2CppManagedMemorySnapshot\n{\n  struct Il2CppManagedHeap\n  {\n    uint32_t section_count;\n    void * sections;\n  } heap;\n  struct Il2CppStacks\n  {\n    uint32_t stack_count;\n    void * stacks;\n  } stacks;\n  struct Il2CppMetadataSnapshot\n  {\n    uint32_t type_count;\n    Il2CppMetadataType * types;\n  } metadata_snapshot;\n  struct Il2CppGCHandles\n  {\n    uint32_t tracked_object_count;\n    void ** pointers_to_objects;\n  } gc_handles;\n  struct Il2CppRuntimeInformation\n  {\n    uint32_t pointer_size;\n    uint32_t object_header_size;\n    uint32_t array_header_size;\n    uint32_t array_bounds_offset_in_header;\n    uint32_t array_size_offset_in_header;\n    uint32_t allocation_granularity;\n  } runtime_information;\n  void * additional_user_information;\n};\n\nstruct Il2CppMetadataType\n{\n  uint32_t flags;\n  void * fields;\n  uint32_t field_count;\n  uint32_t statics_size;\n  uint8_t * statics;\n  uint32_t base_or_element_type_index;\n  char * name;\n  const char * assembly_name;\n  uint64_t type_info_address;\n  uint32_t size;\n};\n\nuintptr_t\nil2cpp_memory_snapshot_get_classes (\n    const Il2CppManagedMemorySnapshot * snapshot, Il2CppMetadataType ** iter)\n{\n  const int zero = 0;\n  const void * null = 0;\n\n  if (iter != NULL && snapshot->metadata_snapshot.type_count > zero)\n  {\n    if (*iter == null)\n    {\n      *iter = snapshot->metadata_snapshot.types;\n      return (uintptr_t) (*iter)->type_info_address;\n    }\n    else\n    {\n      Il2CppMetadataType * metadata_type = *iter + 1;\n\n      if (metadata_type < snapshot->metadata_snapshot.types +\n                              snapshot->metadata_snapshot.type_count)\n      {\n        *iter = metadata_type;\n        return (uintptr_t) (*iter)->type_info_address;\n      }\n    }\n  }\n  return 0;\n}\n\nvoid **\nil2cpp_memory_snapshot_get_objects (\n    const Il2CppManagedMemorySnapshot * snapshot, uint32_t * size)\n{\n  *size = snapshot->gc_handles.tracked_object_count;\n  return snapshot->gc_handles.pointers_to_objects;\n}\n"), lazy);
      function r(exportName, retType, argTypes) {
        const handle = Il2Cpp3.$config.exports?.[exportName]?.() ?? Il2Cpp3.module.findExportByName(exportName) ?? Il2Cpp3.memorySnapshotExports[exportName];
        const target = new NativeFunction(handle ?? NULL, retType, argTypes);
        return target.isNull() ? new Proxy(target, {
          get(value, name) {
            const property = value[name];
            return typeof property === "function" ? property.bind(value) : property;
          },
          apply() {
            if (handle == null) {
              raise(`couldn't resolve export ${exportName}`);
            } else if (handle.isNull()) {
              raise(`export ${exportName} points to NULL IL2CPP library has likely been stripped, obfuscated, or customized`);
            }
          }
        }) : target;
      }
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      function is(klass) {
        return (element) => {
          if (element instanceof Il2Cpp3.Class) {
            return klass.isAssignableFrom(element);
          } else {
            return klass.isAssignableFrom(element.class);
          }
        };
      }
      Il2Cpp3.is = is;
      function isExactly(klass) {
        return (element) => {
          if (element instanceof Il2Cpp3.Class) {
            return element.equals(klass);
          } else {
            return element.class.equals(klass);
          }
        };
      }
      Il2Cpp3.isExactly = isExactly;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      Il2Cpp3.gc = {
        /**
         * Gets the heap size in bytes.
         */
        get heapSize() {
          return Il2Cpp3.exports.gcGetHeapSize();
        },
        /**
         * Determines whether the garbage collector is enabled.
         */
        get isEnabled() {
          return !Il2Cpp3.exports.gcIsDisabled();
        },
        /**
         * Determines whether the garbage collector is incremental
         * ([source](https://docs.unity3d.com/Manual/performance-incremental-garbage-collection.html)).
         */
        get isIncremental() {
          return !!Il2Cpp3.exports.gcIsIncremental();
        },
        /**
         * Gets the number of nanoseconds the garbage collector can spend in a
         * collection step.
         */
        get maxTimeSlice() {
          return Il2Cpp3.exports.gcGetMaxTimeSlice();
        },
        /**
         * Gets the used heap size in bytes.
         */
        get usedHeapSize() {
          return Il2Cpp3.exports.gcGetUsedSize();
        },
        /**
         * Enables or disables the garbage collector.
         */
        set isEnabled(value) {
          value ? Il2Cpp3.exports.gcEnable() : Il2Cpp3.exports.gcDisable();
        },
        /**
         *  Sets the number of nanoseconds the garbage collector can spend in
         * a collection step.
         */
        set maxTimeSlice(nanoseconds) {
          Il2Cpp3.exports.gcSetMaxTimeSlice(nanoseconds);
        },
        /**
         * Returns the heap allocated objects of the specified class. \
         * This variant reads GC descriptors.
         */
        choose(klass) {
          const matches = [];
          const callback = (objects, size) => {
            for (let i = 0; i < size; i++) {
              matches.push(new Il2Cpp3.Object(objects.add(i * Process.pointerSize).readPointer()));
            }
          };
          const chooseCallback = new NativeCallback(callback, "void", ["pointer", "int", "pointer"]);
          if (Il2Cpp3.unityVersionIsBelow202120) {
            const onWorld = new NativeCallback(() => {
            }, "void", []);
            const state = Il2Cpp3.exports.livenessCalculationBegin(klass, 0, chooseCallback, NULL, onWorld, onWorld);
            Il2Cpp3.exports.livenessCalculationFromStatics(state);
            Il2Cpp3.exports.livenessCalculationEnd(state);
          } else {
            const realloc = (handle, size) => {
              if (!handle.isNull() && size.compare(0) == 0) {
                Il2Cpp3.free(handle);
                return NULL;
              } else {
                return Il2Cpp3.alloc(size);
              }
            };
            const reallocCallback = new NativeCallback(realloc, "pointer", ["pointer", "size_t", "pointer"]);
            this.stopWorld();
            const state = Il2Cpp3.exports.livenessAllocateStruct(klass, 0, chooseCallback, NULL, reallocCallback);
            Il2Cpp3.exports.livenessCalculationFromStatics(state);
            Il2Cpp3.exports.livenessFinalize(state);
            this.startWorld();
            Il2Cpp3.exports.livenessFreeStruct(state);
          }
          return matches;
        },
        /**
         * Forces a garbage collection of the specified generation.
         */
        collect(generation) {
          Il2Cpp3.exports.gcCollect(generation < 0 ? 0 : generation > 2 ? 2 : generation);
        },
        /**
         * Forces a garbage collection.
         */
        collectALittle() {
          Il2Cpp3.exports.gcCollectALittle();
        },
        /**
         *  Resumes all the previously stopped threads.
         */
        startWorld() {
          return Il2Cpp3.exports.gcStartWorld();
        },
        /**
         * Performs an incremental garbage collection.
         */
        startIncrementalCollection() {
          return Il2Cpp3.exports.gcStartIncrementalCollection();
        },
        /**
         * Stops all threads which may access the garbage collected heap, other
         * than the caller.
         */
        stopWorld() {
          return Il2Cpp3.exports.gcStopWorld();
        }
      };
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Android2) {
      getter(Android2, "apiLevel", () => {
        const value = getProperty("ro.build.version.sdk");
        return value ? parseInt(value) : null;
      }, lazy);
      function getProperty(name) {
        const handle = Process.findModuleByName("libc.so")?.findExportByName("__system_property_get");
        if (handle) {
          const __system_property_get = new NativeFunction(handle, "void", ["pointer", "pointer"]);
          const value = Memory.alloc(92).writePointer(NULL);
          __system_property_get(Memory.allocUtf8String(name), value);
          return value.readCString() ?? void 0;
        }
      }
    })(Android || (Android = {}));
    NativeStruct = class {
      handle;
      constructor(handleOrWrapper) {
        if (handleOrWrapper instanceof NativePointer) {
          this.handle = handleOrWrapper;
        } else {
          this.handle = handleOrWrapper.handle;
        }
      }
      equals(other) {
        return this.handle.equals(other.handle);
      }
      isNull() {
        return this.handle.isNull();
      }
      asNullable() {
        return this.isNull() ? null : this;
      }
    };
    NativePointer.prototype.offsetOf = function(condition, depth) {
      depth ??= 512;
      for (let i = 0; depth > 0 ? i < depth : i < -depth; i++) {
        if (condition(depth > 0 ? this.add(i) : this.sub(i))) {
          return i;
        }
      }
      return null;
    };
    (function(UnityVersion2) {
      const pattern = /(6\d{3}|20\d{2}|\d)\.(\d)\.(\d{1,2})(?:[abcfp]|rc){0,2}\d?/;
      function find(string) {
        return string?.match(pattern)?.[0];
      }
      UnityVersion2.find = find;
      function gte(a, b) {
        return compare3(a, b) >= 0;
      }
      UnityVersion2.gte = gte;
      function lt(a, b) {
        return compare3(a, b) < 0;
      }
      UnityVersion2.lt = lt;
      function compare3(a, b) {
        const aMatches = a.match(pattern);
        const bMatches = b.match(pattern);
        for (let i = 1; i <= 3; i++) {
          const a2 = Number(aMatches?.[i] ?? -1);
          const b2 = Number(bMatches?.[i] ?? -1);
          if (a2 > b2)
            return 1;
          else if (a2 < b2)
            return -1;
        }
        return 0;
      }
    })(UnityVersion || (UnityVersion = {}));
    (function(Il2Cpp3) {
      function alloc2(size = Process.pointerSize) {
        return Il2Cpp3.exports.alloc(size);
      }
      Il2Cpp3.alloc = alloc2;
      function free(pointer) {
        return Il2Cpp3.exports.free(pointer);
      }
      Il2Cpp3.free = free;
      function read2(pointer, type) {
        switch (type.enumValue) {
          case Il2Cpp3.Type.Enum.BOOLEAN:
            return !!pointer.readS8();
          case Il2Cpp3.Type.Enum.BYTE:
            return pointer.readS8();
          case Il2Cpp3.Type.Enum.UBYTE:
            return pointer.readU8();
          case Il2Cpp3.Type.Enum.SHORT:
            return pointer.readS16();
          case Il2Cpp3.Type.Enum.USHORT:
            return pointer.readU16();
          case Il2Cpp3.Type.Enum.INT:
            return pointer.readS32();
          case Il2Cpp3.Type.Enum.UINT:
            return pointer.readU32();
          case Il2Cpp3.Type.Enum.CHAR:
            return pointer.readU16();
          case Il2Cpp3.Type.Enum.LONG:
            return pointer.readS64();
          case Il2Cpp3.Type.Enum.ULONG:
            return pointer.readU64();
          case Il2Cpp3.Type.Enum.FLOAT:
            return pointer.readFloat();
          case Il2Cpp3.Type.Enum.DOUBLE:
            return pointer.readDouble();
          case Il2Cpp3.Type.Enum.NINT:
          case Il2Cpp3.Type.Enum.NUINT:
            return pointer.readPointer();
          case Il2Cpp3.Type.Enum.POINTER:
            return new Il2Cpp3.Pointer(pointer.readPointer(), type.class.baseType);
          case Il2Cpp3.Type.Enum.VALUE_TYPE:
            return new Il2Cpp3.ValueType(pointer, type);
          case Il2Cpp3.Type.Enum.OBJECT:
          case Il2Cpp3.Type.Enum.CLASS:
            return new Il2Cpp3.Object(pointer.readPointer());
          case Il2Cpp3.Type.Enum.GENERIC_INSTANCE:
            return type.class.isValueType ? new Il2Cpp3.ValueType(pointer, type) : new Il2Cpp3.Object(pointer.readPointer());
          case Il2Cpp3.Type.Enum.STRING:
            return new Il2Cpp3.String(pointer.readPointer());
          case Il2Cpp3.Type.Enum.ARRAY:
          case Il2Cpp3.Type.Enum.NARRAY:
            return new Il2Cpp3.Array(pointer.readPointer());
        }
        raise(`couldn't read the value from ${pointer} using an unhandled or unknown type ${type.name} (${type.enumValue}), please file an issue`);
      }
      Il2Cpp3.read = read2;
      function write3(pointer, value, type) {
        switch (type.enumValue) {
          case Il2Cpp3.Type.Enum.BOOLEAN:
            return pointer.writeS8(+value);
          case Il2Cpp3.Type.Enum.BYTE:
            return pointer.writeS8(value);
          case Il2Cpp3.Type.Enum.UBYTE:
            return pointer.writeU8(value);
          case Il2Cpp3.Type.Enum.SHORT:
            return pointer.writeS16(value);
          case Il2Cpp3.Type.Enum.USHORT:
            return pointer.writeU16(value);
          case Il2Cpp3.Type.Enum.INT:
            return pointer.writeS32(value);
          case Il2Cpp3.Type.Enum.UINT:
            return pointer.writeU32(value);
          case Il2Cpp3.Type.Enum.CHAR:
            return pointer.writeU16(value);
          case Il2Cpp3.Type.Enum.LONG:
            return pointer.writeS64(value);
          case Il2Cpp3.Type.Enum.ULONG:
            return pointer.writeU64(value);
          case Il2Cpp3.Type.Enum.FLOAT:
            return pointer.writeFloat(value);
          case Il2Cpp3.Type.Enum.DOUBLE:
            return pointer.writeDouble(value);
          case Il2Cpp3.Type.Enum.NINT:
          case Il2Cpp3.Type.Enum.NUINT:
          case Il2Cpp3.Type.Enum.POINTER:
          case Il2Cpp3.Type.Enum.STRING:
          case Il2Cpp3.Type.Enum.ARRAY:
          case Il2Cpp3.Type.Enum.NARRAY:
            return pointer.writePointer(value);
          case Il2Cpp3.Type.Enum.VALUE_TYPE:
            return Memory.copy(pointer, value, type.class.valueTypeSize), pointer;
          case Il2Cpp3.Type.Enum.OBJECT:
          case Il2Cpp3.Type.Enum.CLASS:
          case Il2Cpp3.Type.Enum.GENERIC_INSTANCE:
            return value instanceof Il2Cpp3.ValueType ? (Memory.copy(pointer, value, type.class.valueTypeSize), pointer) : pointer.writePointer(value);
        }
        raise(`couldn't write value ${value} to ${pointer} using an unhandled or unknown type ${type.name} (${type.enumValue}), please file an issue`);
      }
      Il2Cpp3.write = write3;
      function fromFridaValue(value, type) {
        if (globalThis.Array.isArray(value)) {
          const handle = Memory.alloc(type.class.valueTypeSize);
          const fields = type.class.fields.filter((_) => !_.isStatic);
          for (let i = 0; i < fields.length; i++) {
            const convertedValue = fromFridaValue(value[i], fields[i].type);
            write3(handle.add(fields[i].offset).sub(Il2Cpp3.Object.headerSize), convertedValue, fields[i].type);
          }
          return new Il2Cpp3.ValueType(handle, type);
        } else if (value instanceof NativePointer) {
          if (type.isByReference) {
            return new Il2Cpp3.Reference(value, type);
          }
          switch (type.enumValue) {
            case Il2Cpp3.Type.Enum.POINTER:
              return new Il2Cpp3.Pointer(value, type.class.baseType);
            case Il2Cpp3.Type.Enum.STRING:
              return new Il2Cpp3.String(value);
            case Il2Cpp3.Type.Enum.CLASS:
            case Il2Cpp3.Type.Enum.GENERIC_INSTANCE:
            case Il2Cpp3.Type.Enum.OBJECT:
              return new Il2Cpp3.Object(value);
            case Il2Cpp3.Type.Enum.ARRAY:
            case Il2Cpp3.Type.Enum.NARRAY:
              return new Il2Cpp3.Array(value);
            default:
              return value;
          }
        } else if (type.enumValue == Il2Cpp3.Type.Enum.BOOLEAN) {
          return !!value;
        } else if (type.enumValue == Il2Cpp3.Type.Enum.VALUE_TYPE && type.class.isEnum) {
          return fromFridaValue([value], type);
        } else {
          return value;
        }
      }
      Il2Cpp3.fromFridaValue = fromFridaValue;
      function toFridaValue(value) {
        if (typeof value == "boolean") {
          return +value;
        } else if (value instanceof Il2Cpp3.ValueType) {
          if (value.type.class.isEnum) {
            return value.field("value__").value;
          } else {
            const _ = value.type.class.fields.filter((_2) => !_2.isStatic).map((_2) => toFridaValue(_2.bind(value).value));
            return _.length == 0 ? [0] : _;
          }
        } else {
          return value;
        }
      }
      Il2Cpp3.toFridaValue = toFridaValue;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      getter(Il2Cpp3, "module", () => {
        return tryModule() ?? raise("Could not find IL2CPP module");
      });
      async function initialize(blocking = false) {
        const module = tryModule() ?? await new Promise((resolve) => {
          const [moduleName, fallbackModuleName] = getExpectedModuleNames();
          const timeout = setTimeout(() => {
            warn(`after 10 seconds, IL2CPP module '${moduleName}' has not been loaded yet, is the app running?`);
          }, 1e4);
          const moduleObserver = Process.attachModuleObserver({
            onAdded(module2) {
              if (module2.name == moduleName || fallbackModuleName && module2.name == fallbackModuleName) {
                clearTimeout(timeout);
                setImmediate(() => {
                  resolve(module2);
                  moduleObserver.detach();
                });
              }
            }
          });
        });
        Reflect.defineProperty(Il2Cpp3, "module", { value: module });
        if (Il2Cpp3.exports.getCorlib().isNull()) {
          return await new Promise((resolve) => {
            const interceptor = Interceptor.attach(Il2Cpp3.exports.initialize, {
              onLeave() {
                interceptor.detach();
                blocking ? resolve(true) : setImmediate(() => resolve(false));
              }
            });
          });
        }
        return false;
      }
      Il2Cpp3.initialize = initialize;
      function tryModule() {
        const [moduleName, fallback] = getExpectedModuleNames();
        return Process.findModuleByName(moduleName) ?? Process.findModuleByName(fallback ?? moduleName) ?? (Process.platform == "darwin" ? Process.findModuleByAddress(DebugSymbol.fromName("il2cpp_init").address) : void 0) ?? void 0;
      }
      function getExpectedModuleNames() {
        if (Il2Cpp3.$config.moduleName) {
          return [Il2Cpp3.$config.moduleName];
        }
        switch (Process.platform) {
          case "linux":
            return [Android.apiLevel ? "libil2cpp.so" : "GameAssembly.so"];
          case "windows":
            return ["GameAssembly.dll"];
          case "darwin":
            return ["UnityFramework", "GameAssembly.dylib"];
        }
        raise(`${Process.platform} is not supported yet`);
      }
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      async function perform(block, flag = "bind") {
        let attachedThread = null;
        try {
          const isInMainThread = await Il2Cpp3.initialize(flag == "main");
          if (flag == "main" && !isInMainThread) {
            return perform(() => Il2Cpp3.mainThread.schedule(block), "free");
          }
          if (Il2Cpp3.currentThread == null) {
            attachedThread = Il2Cpp3.domain.attach();
          }
          if (flag == "bind" && attachedThread != null) {
            Script.bindWeak(globalThis, () => attachedThread?.detach());
          }
          const result = block();
          return result instanceof Promise ? await result : result;
        } catch (error) {
          Script.nextTick((_) => {
            throw _;
          }, error);
          return Promise.reject(error);
        } finally {
          if (flag == "free" && attachedThread != null) {
            attachedThread.detach();
          }
        }
      }
      Il2Cpp3.perform = perform;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class Tracer {
        /** @internal */
        #state = {
          depth: 0,
          buffer: [],
          history: /* @__PURE__ */ new Set(),
          flush: () => {
            if (this.#state.depth == 0) {
              const message = `
${this.#state.buffer.join("\n")}
`;
              if (this.#verbose) {
                inform(message);
              } else {
                const hash = cyrb53(message);
                if (!this.#state.history.has(hash)) {
                  this.#state.history.add(hash);
                  inform(message);
                }
              }
              this.#state.buffer.length = 0;
            }
          }
        };
        /** @internal */
        #threadId = Il2Cpp3.mainThread.id;
        /** @internal */
        #verbose = false;
        /** @internal */
        #applier;
        /** @internal */
        #targets = [];
        /** @internal */
        #domain;
        /** @internal */
        #assemblies;
        /** @internal */
        #classes;
        /** @internal */
        #methods;
        /** @internal */
        #assemblyFilter;
        /** @internal */
        #classFilter;
        /** @internal */
        #methodFilter;
        /** @internal */
        #parameterFilter;
        constructor(applier) {
          this.#applier = applier;
        }
        /** */
        thread(thread) {
          this.#threadId = thread.id;
          return this;
        }
        /** Determines whether print duplicate logs. */
        verbose(value) {
          this.#verbose = value;
          return this;
        }
        /** Sets the application domain as the place where to find the target methods. */
        domain() {
          this.#domain = Il2Cpp3.domain;
          return this;
        }
        /** Sets the passed `assemblies` as the place where to find the target methods. */
        assemblies(...assemblies) {
          this.#assemblies = assemblies;
          return this;
        }
        /** Sets the passed `classes` as the place where to find the target methods. */
        classes(...classes) {
          this.#classes = classes;
          return this;
        }
        /** Sets the passed `methods` as the target methods. */
        methods(...methods) {
          this.#methods = methods;
          return this;
        }
        /** Filters the assemblies where to find the target methods. */
        filterAssemblies(filter) {
          this.#assemblyFilter = filter;
          return this;
        }
        /** Filters the classes where to find the target methods. */
        filterClasses(filter) {
          this.#classFilter = filter;
          return this;
        }
        /** Filters the target methods. */
        filterMethods(filter) {
          this.#methodFilter = filter;
          return this;
        }
        /** Filters the target methods. */
        filterParameters(filter) {
          this.#parameterFilter = filter;
          return this;
        }
        /** Commits the current changes by finding the target methods. */
        and() {
          const filterMethod = (method) => {
            if (this.#parameterFilter == void 0) {
              this.#targets.push(method);
              return;
            }
            for (const parameter of method.parameters) {
              if (this.#parameterFilter(parameter)) {
                this.#targets.push(method);
                break;
              }
            }
          };
          const filterMethods = (values) => {
            for (const method of values) {
              filterMethod(method);
            }
          };
          const filterClass = (klass) => {
            if (this.#methodFilter == void 0) {
              filterMethods(klass.methods);
              return;
            }
            for (const method of klass.methods) {
              if (this.#methodFilter(method)) {
                filterMethod(method);
              }
            }
          };
          const filterClasses = (values) => {
            for (const klass of values) {
              filterClass(klass);
            }
          };
          const filterAssembly = (assembly) => {
            if (this.#classFilter == void 0) {
              filterClasses(assembly.image.classes);
              return;
            }
            for (const klass of assembly.image.classes) {
              if (this.#classFilter(klass)) {
                filterClass(klass);
              }
            }
          };
          const filterAssemblies = (assemblies) => {
            for (const assembly of assemblies) {
              filterAssembly(assembly);
            }
          };
          const filterDomain = (domain) => {
            if (this.#assemblyFilter == void 0) {
              filterAssemblies(domain.assemblies);
              return;
            }
            for (const assembly of domain.assemblies) {
              if (this.#assemblyFilter(assembly)) {
                filterAssembly(assembly);
              }
            }
          };
          this.#methods ? filterMethods(this.#methods) : this.#classes ? filterClasses(this.#classes) : this.#assemblies ? filterAssemblies(this.#assemblies) : this.#domain ? filterDomain(this.#domain) : void 0;
          this.#assemblies = void 0;
          this.#classes = void 0;
          this.#methods = void 0;
          this.#assemblyFilter = void 0;
          this.#classFilter = void 0;
          this.#methodFilter = void 0;
          this.#parameterFilter = void 0;
          return this;
        }
        /** Starts tracing. */
        attach() {
          for (const target of this.#targets) {
            if (!target.virtualAddress.isNull()) {
              try {
                this.#applier(target, this.#state, this.#threadId);
              } catch (e) {
                switch (e.message) {
                  case /unable to intercept function at \w+; please file a bug/.exec(e.message)?.input:
                  case "already replaced this function":
                    break;
                  default:
                    throw e;
                }
              }
            }
          }
        }
      }
      Il2Cpp3.Tracer = Tracer;
      function trace(parameters = false) {
        const applier = () => (method, state, threadId) => {
          const paddedVirtualAddress = method.relativeVirtualAddress.toString(16).padStart(8, "0");
          Interceptor.attach(method.virtualAddress, {
            onEnter() {
              if (this.threadId == threadId) {
                state.buffer.push(`\x1B[2m0x${paddedVirtualAddress}\x1B[0m ${`\u2502 `.repeat(state.depth++)}\u250C\u2500\x1B[35m${method.class.type.name}::\x1B[1m${method.name}\x1B[0m\x1B[0m`);
              }
            },
            onLeave() {
              if (this.threadId == threadId) {
                state.buffer.push(`\x1B[2m0x${paddedVirtualAddress}\x1B[0m ${`\u2502 `.repeat(--state.depth)}\u2514\u2500\x1B[33m${method.class.type.name}::\x1B[1m${method.name}\x1B[0m\x1B[0m`);
                state.flush();
              }
            }
          });
        };
        const applierWithParameters = () => (method, state, threadId) => {
          const paddedVirtualAddress = method.relativeVirtualAddress.toString(16).padStart(8, "0");
          const startIndex = +!method.isStatic | +Il2Cpp3.unityVersionIsBelow201830;
          const callback = function(...args) {
            if (this.threadId == threadId) {
              const thisParameter = method.isStatic ? void 0 : new Il2Cpp3.Parameter("this", -1, method.class.type);
              const parameters2 = thisParameter ? [thisParameter].concat(method.parameters) : method.parameters;
              state.buffer.push(`\x1B[2m0x${paddedVirtualAddress}\x1B[0m ${`\u2502 `.repeat(state.depth++)}\u250C\u2500\x1B[35m${method.class.type.name}::\x1B[1m${method.name}\x1B[0m\x1B[0m(${parameters2.map((e) => `\x1B[32m${e.name}\x1B[0m = \x1B[31m${Il2Cpp3.fromFridaValue(args[e.position + startIndex], e.type)}\x1B[0m`).join(", ")})`);
            }
            const returnValue = method.nativeFunction(...args);
            if (this.threadId == threadId) {
              state.buffer.push(`\x1B[2m0x${paddedVirtualAddress}\x1B[0m ${`\u2502 `.repeat(--state.depth)}\u2514\u2500\x1B[33m${method.class.type.name}::\x1B[1m${method.name}\x1B[0m\x1B[0m${returnValue == void 0 ? "" : ` = \x1B[36m${Il2Cpp3.fromFridaValue(returnValue, method.returnType)}`}\x1B[0m`);
              state.flush();
            }
            return returnValue;
          };
          method.revert();
          const nativeCallback = new NativeCallback(callback, method.returnType.fridaAlias, method.fridaSignature);
          Interceptor.replace(method.virtualAddress, nativeCallback);
        };
        return new Il2Cpp3.Tracer(parameters ? applierWithParameters() : applier());
      }
      Il2Cpp3.trace = trace;
      function backtrace(mode) {
        const methods = Il2Cpp3.domain.assemblies.flatMap((_) => _.image.classes.flatMap((_2) => _2.methods.filter((_3) => !_3.virtualAddress.isNull()))).sort((_, __) => _.virtualAddress.compare(__.virtualAddress));
        const searchInsert = (target) => {
          let left = 0;
          let right = methods.length - 1;
          while (left <= right) {
            const pivot = Math.floor((left + right) / 2);
            const comparison = methods[pivot].virtualAddress.compare(target);
            if (comparison == 0) {
              return methods[pivot];
            } else if (comparison > 0) {
              right = pivot - 1;
            } else {
              left = pivot + 1;
            }
          }
          return methods[right];
        };
        const applier = () => (method, state, threadId) => {
          Interceptor.attach(method.virtualAddress, function() {
            if (this.threadId == threadId) {
              const handles = globalThis.Thread.backtrace(this.context, mode);
              handles.unshift(method.virtualAddress);
              for (const handle of handles) {
                if (handle.compare(Il2Cpp3.module.base) > 0 && handle.compare(Il2Cpp3.module.base.add(Il2Cpp3.module.size)) < 0) {
                  const method2 = searchInsert(handle);
                  if (method2) {
                    const offset = handle.sub(method2.virtualAddress);
                    if (offset.compare(4095) < 0) {
                      state.buffer.push(`\x1B[2m0x${method2.relativeVirtualAddress.toString(16).padStart(8, "0")}\x1B[0m\x1B[2m+0x${offset.toString(16).padStart(3, `0`)}\x1B[0m ${method2.class.type.name}::\x1B[1m${method2.name}\x1B[0m`);
                    }
                  }
                }
              }
              state.flush();
            }
          });
        };
        return new Il2Cpp3.Tracer(applier());
      }
      Il2Cpp3.backtrace = backtrace;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class Array2 extends NativeStruct {
        /** Gets the Il2CppArray struct size, possibly equal to `Process.pointerSize * 4`. */
        static get headerSize() {
          return Il2Cpp3.corlib.class("System.Array").instanceSize;
        }
        /** @internal Gets a pointer to the first element of the current array. */
        get elements() {
          const array2 = Il2Cpp3.string("v").object.method("ToCharArray", 0).invoke();
          const offset = array2.handle.offsetOf((_) => _.readS16() == 118) ?? raise("couldn't find the elements offset in the native array struct");
          getter(Il2Cpp3.Array.prototype, "elements", function() {
            return new Il2Cpp3.Pointer(this.handle.add(offset), this.elementType);
          }, lazy);
          return this.elements;
        }
        /** Gets the size of the object encompassed by the current array. */
        get elementSize() {
          return this.elementType.class.arrayElementSize;
        }
        /** Gets the type of the object encompassed by the current array. */
        get elementType() {
          return this.object.class.type.class.baseType;
        }
        /** Gets the total number of elements in all the dimensions of the current array. */
        get length() {
          return Il2Cpp3.exports.arrayGetLength(this);
        }
        /** Gets the encompassing object of the current array. */
        get object() {
          return new Il2Cpp3.Object(this);
        }
        /** Gets the element at the specified index of the current array. */
        get(index) {
          if (index < 0 || index >= this.length) {
            raise(`cannot get element at index ${index} as the array length is ${this.length}`);
          }
          return this.elements.get(index);
        }
        /** Sets the element at the specified index of the current array. */
        set(index, value) {
          if (index < 0 || index >= this.length) {
            raise(`cannot set element at index ${index} as the array length is ${this.length}`);
          }
          this.elements.set(index, value);
        }
        /** */
        toString() {
          return this.isNull() ? "null" : `[${this.elements.read(this.length, 0)}]`;
        }
        /** Iterable. */
        *[Symbol.iterator]() {
          for (let i = 0; i < this.length; i++) {
            yield this.elements.get(i);
          }
        }
      }
      __decorate([
        lazy
      ], Array2.prototype, "elementSize", null);
      __decorate([
        lazy
      ], Array2.prototype, "elementType", null);
      __decorate([
        lazy
      ], Array2.prototype, "length", null);
      __decorate([
        lazy
      ], Array2.prototype, "object", null);
      __decorate([
        lazy
      ], Array2, "headerSize", null);
      Il2Cpp3.Array = Array2;
      function array(klass, lengthOrElements) {
        const length = typeof lengthOrElements == "number" ? lengthOrElements : lengthOrElements.length;
        const array2 = new Il2Cpp3.Array(Il2Cpp3.exports.arrayNew(klass, length));
        if (globalThis.Array.isArray(lengthOrElements)) {
          array2.elements.write(lengthOrElements);
        }
        return array2;
      }
      Il2Cpp3.array = array;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      let Assembly = class Assembly extends NativeStruct {
        /** Gets the image of this assembly. */
        get image() {
          if (Il2Cpp3.exports.assemblyGetImage.isNull()) {
            const runtimeModule = this.object.tryMethod("GetType", 1)?.invoke(Il2Cpp3.string("<Module>"))?.asNullable()?.tryMethod("get_Module")?.invoke() ?? this.object.tryMethod("GetModules", 1)?.invoke(false)?.get(0) ?? raise(`couldn't find the runtime module object of assembly ${this.name}`);
            return new Il2Cpp3.Image(runtimeModule.field("_impl").value);
          }
          return new Il2Cpp3.Image(Il2Cpp3.exports.assemblyGetImage(this));
        }
        /** Gets the name of this assembly. */
        get name() {
          return this.image.name.replace(".dll", "");
        }
        /** Gets the encompassing object of the current assembly. */
        get object() {
          for (const _ of Il2Cpp3.domain.object.method("GetAssemblies", 1).invoke(false)) {
            if (_.field("_mono_assembly").value.equals(this)) {
              return _;
            }
          }
          raise("couldn't find the object of the native assembly struct");
        }
      };
      __decorate([
        lazy
      ], Assembly.prototype, "name", null);
      __decorate([
        lazy
      ], Assembly.prototype, "object", null);
      Assembly = __decorate([
        recycle
      ], Assembly);
      Il2Cpp3.Assembly = Assembly;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      let Class = class Class extends NativeStruct {
        /** Gets the actual size of the instance of the current class. */
        get actualInstanceSize() {
          const SystemString = Il2Cpp3.corlib.class("System.String");
          const offset = SystemString.handle.offsetOf((_) => _.readInt() == SystemString.instanceSize - 2) ?? raise("couldn't find the actual instance size offset in the native class struct");
          getter(Il2Cpp3.Class.prototype, "actualInstanceSize", function() {
            return this.handle.add(offset).readS32();
          }, lazy);
          return this.actualInstanceSize;
        }
        /** Gets the array class which encompass the current class. */
        get arrayClass() {
          return new Il2Cpp3.Class(Il2Cpp3.exports.classGetArrayClass(this, 1));
        }
        /** Gets the size of the object encompassed by the current array class. */
        get arrayElementSize() {
          return Il2Cpp3.exports.classGetArrayElementSize(this);
        }
        /** Gets the name of the assembly in which the current class is defined. */
        get assemblyName() {
          return Il2Cpp3.exports.classGetAssemblyName(this).readUtf8String().replace(".dll", "");
        }
        /** Gets the class that declares the current nested class. */
        get declaringClass() {
          return new Il2Cpp3.Class(Il2Cpp3.exports.classGetDeclaringType(this)).asNullable();
        }
        /** Gets the encompassed type of this array, reference, pointer or enum type. */
        get baseType() {
          return new Il2Cpp3.Type(Il2Cpp3.exports.classGetBaseType(this)).asNullable();
        }
        /** Gets the class of the object encompassed or referred to by the current array, pointer or reference class. */
        get elementClass() {
          return new Il2Cpp3.Class(Il2Cpp3.exports.classGetElementClass(this)).asNullable();
        }
        /** Gets the fields of the current class. */
        get fields() {
          return readNativeIterator((_) => Il2Cpp3.exports.classGetFields(this, _)).map((_) => new Il2Cpp3.Field(_));
        }
        /** Gets the flags of the current class. */
        get flags() {
          return Il2Cpp3.exports.classGetFlags(this);
        }
        /** Gets the full name (namespace + name) of the current class. */
        get fullName() {
          return this.namespace ? `${this.namespace}.${this.name}` : this.name;
        }
        /** Gets the generic class of the current class if the current class is inflated. */
        get genericClass() {
          const klass = this.image.tryClass(this.fullName)?.asNullable();
          return klass?.equals(this) ? null : klass ?? null;
        }
        /** Gets the generics parameters of this generic class. */
        get generics() {
          if (!this.isGeneric && !this.isInflated) {
            return [];
          }
          const types = this.type.object.method("GetGenericArguments").invoke();
          return globalThis.Array.from(types).map((_) => new Il2Cpp3.Class(Il2Cpp3.exports.classFromObject(_)));
        }
        /** Determines whether the GC has tracking references to the current class instances. */
        get hasReferences() {
          return !!Il2Cpp3.exports.classHasReferences(this);
        }
        /** Determines whether ther current class has a valid static constructor. */
        get hasStaticConstructor() {
          const staticConstructor = this.tryMethod(".cctor");
          return staticConstructor != null && !staticConstructor.virtualAddress.isNull();
        }
        /** Gets the image in which the current class is defined. */
        get image() {
          return new Il2Cpp3.Image(Il2Cpp3.exports.classGetImage(this));
        }
        /** Gets the size of the instance of the current class. */
        get instanceSize() {
          return Il2Cpp3.exports.classGetInstanceSize(this);
        }
        /** Determines whether the current class is abstract. */
        get isAbstract() {
          return !!Il2Cpp3.exports.classIsAbstract(this);
        }
        /** Determines whether the current class is blittable. */
        get isBlittable() {
          return !!Il2Cpp3.exports.classIsBlittable(this);
        }
        /** Determines whether the current class is an enumeration. */
        get isEnum() {
          return !!Il2Cpp3.exports.classIsEnum(this);
        }
        /** Determines whether the current class is a generic one. */
        get isGeneric() {
          return !!Il2Cpp3.exports.classIsGeneric(this);
        }
        /** Determines whether the current class is inflated. */
        get isInflated() {
          return !!Il2Cpp3.exports.classIsInflated(this);
        }
        /** Determines whether the current class is an interface. */
        get isInterface() {
          return !!Il2Cpp3.exports.classIsInterface(this);
        }
        /** Determines whether the current class is a struct. */
        get isStruct() {
          return this.isValueType && !this.isEnum;
        }
        /** Determines whether the current class is a value type. */
        get isValueType() {
          return !!Il2Cpp3.exports.classIsValueType(this);
        }
        /** Gets the interfaces implemented or inherited by the current class. */
        get interfaces() {
          return readNativeIterator((_) => Il2Cpp3.exports.classGetInterfaces(this, _)).map((_) => new Il2Cpp3.Class(_));
        }
        /** Gets the methods implemented by the current class. */
        get methods() {
          return readNativeIterator((_) => Il2Cpp3.exports.classGetMethods(this, _)).map((_) => new Il2Cpp3.Method(_));
        }
        /** Gets the name of the current class. */
        get name() {
          return Il2Cpp3.exports.classGetName(this).readUtf8String();
        }
        /** Gets the namespace of the current class. */
        get namespace() {
          return Il2Cpp3.exports.classGetNamespace(this).readUtf8String() || void 0;
        }
        /** Gets the classes nested inside the current class. */
        get nestedClasses() {
          return readNativeIterator((_) => Il2Cpp3.exports.classGetNestedClasses(this, _)).map((_) => new Il2Cpp3.Class(_));
        }
        /** Gets the class from which the current class directly inherits. */
        get parent() {
          return new Il2Cpp3.Class(Il2Cpp3.exports.classGetParent(this)).asNullable();
        }
        /** Gets the pointer class of the current class. */
        get pointerClass() {
          return new Il2Cpp3.Class(Il2Cpp3.exports.classFromObject(this.type.object.method("MakePointerType").invoke()));
        }
        /** Gets the rank (number of dimensions) of the current array class. */
        get rank() {
          let rank = 0;
          const name = this.name;
          for (let i = this.name.length - 1; i > 0; i--) {
            const c = name[i];
            if (c == "]")
              rank++;
            else if (c == "[" || rank == 0)
              break;
            else if (c == ",")
              rank++;
            else
              break;
          }
          return rank;
        }
        /** Gets a pointer to the static fields of the current class. */
        get staticFieldsData() {
          return Il2Cpp3.exports.classGetStaticFieldData(this);
        }
        /** Gets the size of the instance - as a value type - of the current class. */
        get valueTypeSize() {
          return Il2Cpp3.exports.classGetValueTypeSize(this, NULL);
        }
        /** Gets the type of the current class. */
        get type() {
          return new Il2Cpp3.Type(Il2Cpp3.exports.classGetType(this));
        }
        /** Allocates a new object of the current class. */
        alloc() {
          return new Il2Cpp3.Object(Il2Cpp3.exports.objectNew(this));
        }
        /** Gets the field identified by the given name. */
        field(name) {
          return this.tryField(name) ?? raise(`couldn't find field ${name} in class ${this.type.name}`);
        }
        /** Gets the hierarchy of the current class. */
        *hierarchy(options) {
          let klass = options?.includeCurrent ?? true ? this : this.parent;
          while (klass) {
            yield klass;
            klass = klass.parent;
          }
        }
        /** Builds a generic instance of the current generic class. */
        inflate(...classes) {
          if (!this.isGeneric) {
            raise(`cannot inflate class ${this.type.name} as it has no generic parameters`);
          }
          if (this.generics.length != classes.length) {
            raise(`cannot inflate class ${this.type.name} as it needs ${this.generics.length} generic parameter(s), not ${classes.length}`);
          }
          const types = classes.map((_) => _.type.object);
          const typeArray = Il2Cpp3.array(Il2Cpp3.corlib.class("System.Type"), types);
          const inflatedType = this.type.object.method("MakeGenericType", 1).invoke(typeArray);
          return new Il2Cpp3.Class(Il2Cpp3.exports.classFromObject(inflatedType));
        }
        /** Calls the static constructor of the current class. */
        initialize() {
          Il2Cpp3.exports.classInitialize(this);
          return this;
        }
        /** Determines whether an instance of `other` class can be assigned to a variable of the current type. */
        isAssignableFrom(other) {
          return !!Il2Cpp3.exports.classIsAssignableFrom(this, other);
        }
        /** Determines whether the current class derives from `other` class. */
        isSubclassOf(other, checkInterfaces) {
          return !!Il2Cpp3.exports.classIsSubclassOf(this, other, +checkInterfaces);
        }
        /** Gets the method identified by the given name and parameter count. */
        method(name, parameterCount = -1) {
          return this.tryMethod(name, parameterCount) ?? raise(`couldn't find method ${name} in class ${this.type.name}`);
        }
        /** Gets the nested class with the given name. */
        nested(name) {
          return this.tryNested(name) ?? raise(`couldn't find nested class ${name} in class ${this.type.name}`);
        }
        /** Allocates a new object of the current class and calls its default constructor. */
        new() {
          const object = this.alloc();
          const exceptionArray = Memory.alloc(Process.pointerSize);
          Il2Cpp3.exports.objectInitialize(object, exceptionArray);
          const exception = exceptionArray.readPointer();
          if (!exception.isNull()) {
            raise(new Il2Cpp3.Object(exception).toString());
          }
          return object;
        }
        /** Gets the field with the given name. */
        tryField(name) {
          return new Il2Cpp3.Field(Il2Cpp3.exports.classGetFieldFromName(this, Memory.allocUtf8String(name))).asNullable();
        }
        /** Gets the method with the given name and parameter count. */
        tryMethod(name, parameterCount = -1) {
          return new Il2Cpp3.Method(Il2Cpp3.exports.classGetMethodFromName(this, Memory.allocUtf8String(name), parameterCount)).asNullable();
        }
        /** Gets the nested class with the given name. */
        tryNested(name) {
          return this.nestedClasses.find((_) => _.name == name);
        }
        /** */
        toString() {
          const inherited = [this.parent].concat(this.interfaces);
          return `// ${this.assemblyName}
${this.isEnum ? `enum` : this.isStruct ? `struct` : this.isInterface ? `interface` : `class`} ${this.type.name}${inherited ? ` : ${inherited.map((_) => _?.type.name).join(`, `)}` : ``}
{
    ${this.fields.join(`
    `)}
    ${this.methods.join(`
    `)}
}`;
        }
        /** Executes a callback for every defined class. */
        static enumerate(block) {
          const callback = new NativeCallback((_) => block(new Il2Cpp3.Class(_)), "void", ["pointer", "pointer"]);
          return Il2Cpp3.exports.classForEach(callback, NULL);
        }
      };
      __decorate([
        lazy
      ], Class.prototype, "arrayClass", null);
      __decorate([
        lazy
      ], Class.prototype, "arrayElementSize", null);
      __decorate([
        lazy
      ], Class.prototype, "assemblyName", null);
      __decorate([
        lazy
      ], Class.prototype, "declaringClass", null);
      __decorate([
        lazy
      ], Class.prototype, "baseType", null);
      __decorate([
        lazy
      ], Class.prototype, "elementClass", null);
      __decorate([
        lazy
      ], Class.prototype, "fields", null);
      __decorate([
        lazy
      ], Class.prototype, "flags", null);
      __decorate([
        lazy
      ], Class.prototype, "fullName", null);
      __decorate([
        lazy
      ], Class.prototype, "generics", null);
      __decorate([
        lazy
      ], Class.prototype, "hasReferences", null);
      __decorate([
        lazy
      ], Class.prototype, "hasStaticConstructor", null);
      __decorate([
        lazy
      ], Class.prototype, "image", null);
      __decorate([
        lazy
      ], Class.prototype, "instanceSize", null);
      __decorate([
        lazy
      ], Class.prototype, "isAbstract", null);
      __decorate([
        lazy
      ], Class.prototype, "isBlittable", null);
      __decorate([
        lazy
      ], Class.prototype, "isEnum", null);
      __decorate([
        lazy
      ], Class.prototype, "isGeneric", null);
      __decorate([
        lazy
      ], Class.prototype, "isInflated", null);
      __decorate([
        lazy
      ], Class.prototype, "isInterface", null);
      __decorate([
        lazy
      ], Class.prototype, "isValueType", null);
      __decorate([
        lazy
      ], Class.prototype, "interfaces", null);
      __decorate([
        lazy
      ], Class.prototype, "methods", null);
      __decorate([
        lazy
      ], Class.prototype, "name", null);
      __decorate([
        lazy
      ], Class.prototype, "namespace", null);
      __decorate([
        lazy
      ], Class.prototype, "nestedClasses", null);
      __decorate([
        lazy
      ], Class.prototype, "parent", null);
      __decorate([
        lazy
      ], Class.prototype, "pointerClass", null);
      __decorate([
        lazy
      ], Class.prototype, "rank", null);
      __decorate([
        lazy
      ], Class.prototype, "staticFieldsData", null);
      __decorate([
        lazy
      ], Class.prototype, "valueTypeSize", null);
      __decorate([
        lazy
      ], Class.prototype, "type", null);
      Class = __decorate([
        recycle
      ], Class);
      Il2Cpp3.Class = Class;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      function delegate(klass, block) {
        const SystemDelegate = Il2Cpp3.corlib.class("System.Delegate");
        const SystemMulticastDelegate = Il2Cpp3.corlib.class("System.MulticastDelegate");
        if (!SystemDelegate.isAssignableFrom(klass)) {
          raise(`cannot create a delegate for ${klass.type.name} as it's a non-delegate class`);
        }
        if (klass.equals(SystemDelegate) || klass.equals(SystemMulticastDelegate)) {
          raise(`cannot create a delegate for neither ${SystemDelegate.type.name} nor ${SystemMulticastDelegate.type.name}, use a subclass instead`);
        }
        const delegate2 = klass.alloc();
        const key = delegate2.handle.toString();
        const Invoke = delegate2.tryMethod("Invoke") ?? raise(`cannot create a delegate for ${klass.type.name}, there is no Invoke method`);
        delegate2.method(".ctor").invoke(delegate2, Invoke.handle);
        const callback = Invoke.wrap(block);
        delegate2.field("method_ptr").value = callback;
        delegate2.field("invoke_impl").value = callback;
        Il2Cpp3._callbacksToKeepAlive[key] = callback;
        return delegate2;
      }
      Il2Cpp3.delegate = delegate;
      Il2Cpp3._callbacksToKeepAlive = {};
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      let Domain = class Domain extends NativeStruct {
        /** Gets the assemblies that have been loaded into the execution context of the application domain. */
        get assemblies() {
          let handles = readNativeList((_) => Il2Cpp3.exports.domainGetAssemblies(this, _));
          if (handles.length == 0) {
            const assemblyObjects = this.object.method("GetAssemblies").overload().invoke();
            handles = globalThis.Array.from(assemblyObjects).map((_) => _.field("_mono_assembly").value);
          }
          return handles.map((_) => new Il2Cpp3.Assembly(_));
        }
        /** Gets the encompassing object of the application domain. */
        get object() {
          return Il2Cpp3.corlib.class("System.AppDomain").method("get_CurrentDomain").invoke();
        }
        /** Opens and loads the assembly with the given name. */
        assembly(name) {
          return this.tryAssembly(name) ?? raise(`couldn't find assembly ${name}`);
        }
        /** Attached a new thread to the application domain. */
        attach() {
          return new Il2Cpp3.Thread(Il2Cpp3.exports.threadAttach(this));
        }
        /** Opens and loads the assembly with the given name. */
        tryAssembly(name) {
          return new Il2Cpp3.Assembly(Il2Cpp3.exports.domainGetAssemblyFromName(this, Memory.allocUtf8String(name))).asNullable();
        }
      };
      __decorate([
        lazy
      ], Domain.prototype, "assemblies", null);
      __decorate([
        lazy
      ], Domain.prototype, "object", null);
      Domain = __decorate([
        recycle
      ], Domain);
      Il2Cpp3.Domain = Domain;
      getter(Il2Cpp3, "domain", () => {
        return new Il2Cpp3.Domain(Il2Cpp3.exports.domainGet());
      }, lazy);
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class Field extends NativeStruct {
        /** Gets the class in which this field is defined. */
        get class() {
          return new Il2Cpp3.Class(Il2Cpp3.exports.fieldGetClass(this));
        }
        /** Gets the flags of the current field. */
        get flags() {
          return Il2Cpp3.exports.fieldGetFlags(this);
        }
        /** Determines whether this field value is known at compile time. */
        get isLiteral() {
          return (this.flags & 64) != 0;
        }
        /** Determines whether this field is static. */
        get isStatic() {
          return (this.flags & 16) != 0;
        }
        /** Determines whether this field is thread static. */
        get isThreadStatic() {
          const offset = Il2Cpp3.corlib.class("System.AppDomain").field("type_resolve_in_progress").offset;
          getter(Il2Cpp3.Field.prototype, "isThreadStatic", function() {
            return this.offset == offset;
          }, lazy);
          return this.isThreadStatic;
        }
        /** Gets the access modifier of this field. */
        get modifier() {
          switch (this.flags & 7) {
            case 1:
              return "private";
            case 2:
              return "private protected";
            case 3:
              return "internal";
            case 4:
              return "protected";
            case 5:
              return "protected internal";
            case 6:
              return "public";
          }
        }
        /** Gets the name of this field. */
        get name() {
          return Il2Cpp3.exports.fieldGetName(this).readUtf8String();
        }
        /** Gets the offset of this field, calculated as the difference with its owner virtual address. */
        get offset() {
          return Il2Cpp3.exports.fieldGetOffset(this);
        }
        /** Gets the type of this field. */
        get type() {
          return new Il2Cpp3.Type(Il2Cpp3.exports.fieldGetType(this));
        }
        /** Gets the value of this field. */
        get value() {
          if (!this.isStatic) {
            raise(`cannot access instance field ${this.class.type.name}::${this.name} from a class, use an object instead`);
          }
          const handle = Memory.alloc(Process.pointerSize);
          Il2Cpp3.exports.fieldGetStaticValue(this.handle, handle);
          return Il2Cpp3.read(handle, this.type);
        }
        /** Sets the value of this field. Thread static or literal values cannot be altered yet. */
        set value(value) {
          if (!this.isStatic) {
            raise(`cannot access instance field ${this.class.type.name}::${this.name} from a class, use an object instead`);
          }
          if (this.isThreadStatic || this.isLiteral) {
            raise(`cannot write the value of field ${this.name} as it's thread static or literal`);
          }
          const handle = (
            // pointer-like values should be passed as-is, but boxed
            // value types (primitives included) must be unboxed first
            value instanceof Il2Cpp3.Object && this.type.class.isValueType ? value.unbox() : value instanceof NativeStruct ? value.handle : value instanceof NativePointer ? value : Il2Cpp3.write(Memory.alloc(this.type.class.valueTypeSize), value, this.type)
          );
          Il2Cpp3.exports.fieldSetStaticValue(this.handle, handle);
        }
        /** */
        toString() {
          return `${this.isThreadStatic ? `[ThreadStatic] ` : ``}${this.isStatic ? `static ` : ``}${this.type.name} ${this.name}${this.isLiteral ? ` = ${this.type.class.isEnum ? Il2Cpp3.read(this.value.handle, this.type.class.baseType) : this.value}` : ``};${this.isThreadStatic || this.isLiteral ? `` : ` // 0x${this.offset.toString(16)}`}`;
        }
        /**
         * @internal
         * Binds the current field to a {@link Il2Cpp.Object} or a
         * {@link Il2Cpp.ValueType} (also known as *instances*), so that it is
         * possible to retrieve its value - see {@link Il2Cpp.Field.value} for
         * details. \
         * Binding a static field is forbidden.
         */
        bind(instance) {
          if (this.isStatic) {
            raise(`cannot bind static field ${this.class.type.name}::${this.name} to an instance`);
          }
          const offset = this.offset - (instance instanceof Il2Cpp3.ValueType ? Il2Cpp3.Object.headerSize : 0);
          return new Proxy(this, {
            get(target, property) {
              if (property == "value") {
                return Il2Cpp3.read(instance.handle.add(offset), target.type);
              }
              return Reflect.get(target, property);
            },
            set(target, property, value) {
              if (property == "value") {
                Il2Cpp3.write(instance.handle.add(offset), value, target.type);
                return true;
              }
              return Reflect.set(target, property, value);
            }
          });
        }
      }
      __decorate([
        lazy
      ], Field.prototype, "class", null);
      __decorate([
        lazy
      ], Field.prototype, "flags", null);
      __decorate([
        lazy
      ], Field.prototype, "isLiteral", null);
      __decorate([
        lazy
      ], Field.prototype, "isStatic", null);
      __decorate([
        lazy
      ], Field.prototype, "isThreadStatic", null);
      __decorate([
        lazy
      ], Field.prototype, "modifier", null);
      __decorate([
        lazy
      ], Field.prototype, "name", null);
      __decorate([
        lazy
      ], Field.prototype, "offset", null);
      __decorate([
        lazy
      ], Field.prototype, "type", null);
      Il2Cpp3.Field = Field;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class GCHandle {
        handle;
        /** @internal */
        constructor(handle) {
          this.handle = handle;
        }
        /** Gets the object associated to this handle. */
        get target() {
          return new Il2Cpp3.Object(Il2Cpp3.exports.gcHandleGetTarget(this.handle)).asNullable();
        }
        /** Frees this handle. */
        free() {
          return Il2Cpp3.exports.gcHandleFree(this.handle);
        }
      }
      Il2Cpp3.GCHandle = GCHandle;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      let Image = class Image extends NativeStruct {
        /** Gets the assembly in which the current image is defined. */
        get assembly() {
          return new Il2Cpp3.Assembly(Il2Cpp3.exports.imageGetAssembly(this));
        }
        /** Gets the amount of classes defined in this image. */
        get classCount() {
          if (Il2Cpp3.unityVersionIsBelow201830) {
            return this.classes.length;
          } else {
            return Il2Cpp3.exports.imageGetClassCount(this);
          }
        }
        /** Gets the classes defined in this image. */
        get classes() {
          if (Il2Cpp3.unityVersionIsBelow201830) {
            const types = this.assembly.object.method("GetTypes").invoke(false);
            const classes = globalThis.Array.from(types, (_) => new Il2Cpp3.Class(Il2Cpp3.exports.classFromObject(_)));
            const Module = this.tryClass("<Module>");
            if (Module) {
              classes.unshift(Module);
            }
            return classes;
          } else {
            return globalThis.Array.from(globalThis.Array(this.classCount), (_, i) => new Il2Cpp3.Class(Il2Cpp3.exports.imageGetClass(this, i)));
          }
        }
        /** Gets the name of this image. */
        get name() {
          return Il2Cpp3.exports.imageGetName(this).readUtf8String();
        }
        /** Gets the class with the specified name defined in this image. */
        class(name) {
          return this.tryClass(name) ?? raise(`couldn't find class ${name} in assembly ${this.name}`);
        }
        /** Gets the class with the specified name defined in this image. */
        tryClass(name) {
          const dotIndex = name.lastIndexOf(".");
          const classNamespace = Memory.allocUtf8String(dotIndex == -1 ? "" : name.slice(0, dotIndex));
          const className = Memory.allocUtf8String(name.slice(dotIndex + 1));
          return new Il2Cpp3.Class(Il2Cpp3.exports.classFromName(this, classNamespace, className)).asNullable();
        }
      };
      __decorate([
        lazy
      ], Image.prototype, "assembly", null);
      __decorate([
        lazy
      ], Image.prototype, "classCount", null);
      __decorate([
        lazy
      ], Image.prototype, "classes", null);
      __decorate([
        lazy
      ], Image.prototype, "name", null);
      Image = __decorate([
        recycle
      ], Image);
      Il2Cpp3.Image = Image;
      getter(Il2Cpp3, "corlib", () => {
        return new Il2Cpp3.Image(Il2Cpp3.exports.getCorlib());
      }, lazy);
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class MemorySnapshot extends NativeStruct {
        /** Captures a memory snapshot. */
        static capture() {
          return new Il2Cpp3.MemorySnapshot();
        }
        /** Creates a memory snapshot with the given handle. */
        constructor(handle = Il2Cpp3.exports.memorySnapshotCapture()) {
          super(handle);
        }
        /** Gets any initialized class. */
        get classes() {
          return readNativeIterator((_) => Il2Cpp3.exports.memorySnapshotGetClasses(this, _)).map((_) => new Il2Cpp3.Class(_));
        }
        /** Gets the objects tracked by this memory snapshot. */
        get objects() {
          return readNativeList((_) => Il2Cpp3.exports.memorySnapshotGetObjects(this, _)).filter((_) => !_.isNull()).map((_) => new Il2Cpp3.Object(_));
        }
        /** Frees this memory snapshot. */
        free() {
          Il2Cpp3.exports.memorySnapshotFree(this);
        }
      }
      __decorate([
        lazy
      ], MemorySnapshot.prototype, "classes", null);
      __decorate([
        lazy
      ], MemorySnapshot.prototype, "objects", null);
      Il2Cpp3.MemorySnapshot = MemorySnapshot;
      function memorySnapshot(block) {
        const memorySnapshot2 = Il2Cpp3.MemorySnapshot.capture();
        const result = block(memorySnapshot2);
        memorySnapshot2.free();
        return result;
      }
      Il2Cpp3.memorySnapshot = memorySnapshot;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class Method extends NativeStruct {
        /** Gets the class in which this method is defined. */
        get class() {
          return new Il2Cpp3.Class(Il2Cpp3.exports.methodGetClass(this));
        }
        /** Gets the flags of the current method. */
        get flags() {
          return Il2Cpp3.exports.methodGetFlags(this, NULL);
        }
        /** Gets the implementation flags of the current method. */
        get implementationFlags() {
          const implementationFlagsPointer = Memory.alloc(Process.pointerSize);
          Il2Cpp3.exports.methodGetFlags(this, implementationFlagsPointer);
          return implementationFlagsPointer.readU32();
        }
        /** */
        get fridaSignature() {
          const types = [];
          for (const parameter of this.parameters) {
            types.push(parameter.type.fridaAlias);
          }
          if (!this.isStatic || Il2Cpp3.unityVersionIsBelow201830) {
            types.unshift("pointer");
          }
          if (this.isInflated) {
            types.push("pointer");
          }
          return types;
        }
        /** Gets the generic parameters of this generic method. */
        get generics() {
          if (!this.isGeneric && !this.isInflated) {
            return [];
          }
          const types = this.object.method("GetGenericArguments").invoke();
          return globalThis.Array.from(types).map((_) => new Il2Cpp3.Class(Il2Cpp3.exports.classFromObject(_)));
        }
        /** Determines whether this method is external. */
        get isExternal() {
          return (this.implementationFlags & 4096) != 0;
        }
        /** Determines whether this method is generic. */
        get isGeneric() {
          return !!Il2Cpp3.exports.methodIsGeneric(this);
        }
        /** Determines whether this method is inflated (generic with a concrete type parameter). */
        get isInflated() {
          return !!Il2Cpp3.exports.methodIsInflated(this);
        }
        /** Determines whether this method is static. */
        get isStatic() {
          return !Il2Cpp3.exports.methodIsInstance(this);
        }
        /** Determines whether this method is synchronized. */
        get isSynchronized() {
          return (this.implementationFlags & 32) != 0;
        }
        /** Gets the access modifier of this method. */
        get modifier() {
          switch (this.flags & 7) {
            case 1:
              return "private";
            case 2:
              return "private protected";
            case 3:
              return "internal";
            case 4:
              return "protected";
            case 5:
              return "protected internal";
            case 6:
              return "public";
          }
        }
        /** Gets the name of this method. */
        get name() {
          return Il2Cpp3.exports.methodGetName(this).readUtf8String();
        }
        /** @internal */
        get nativeFunction() {
          return new NativeFunction(this.virtualAddress, this.returnType.fridaAlias, this.fridaSignature);
        }
        /** Gets the encompassing object of the current method. */
        get object() {
          return new Il2Cpp3.Object(Il2Cpp3.exports.methodGetObject(this, NULL));
        }
        /** Gets the amount of parameters of this method. */
        get parameterCount() {
          return Il2Cpp3.exports.methodGetParameterCount(this);
        }
        /** Gets the parameters of this method. */
        get parameters() {
          return globalThis.Array.from(globalThis.Array(this.parameterCount), (_, i) => {
            const parameterName = Il2Cpp3.exports.methodGetParameterName(this, i).readUtf8String();
            const parameterType = Il2Cpp3.exports.methodGetParameterType(this, i);
            return new Il2Cpp3.Parameter(parameterName, i, new Il2Cpp3.Type(parameterType));
          });
        }
        /** Gets the relative virtual address (RVA) of this method. */
        get relativeVirtualAddress() {
          return this.virtualAddress.sub(Il2Cpp3.module.base);
        }
        /** Gets the return type of this method. */
        get returnType() {
          return new Il2Cpp3.Type(Il2Cpp3.exports.methodGetReturnType(this));
        }
        /** Gets the virtual address (VA) of this method. */
        get virtualAddress() {
          const FilterTypeName = Il2Cpp3.corlib.class("System.Reflection.Module").initialize().field("FilterTypeName").value;
          const FilterTypeNameMethodPointer = FilterTypeName.field("method_ptr").value;
          const FilterTypeNameMethod = FilterTypeName.field("method").value;
          const offset = FilterTypeNameMethod.offsetOf((_) => _.readPointer().equals(FilterTypeNameMethodPointer)) ?? raise("couldn't find the virtual address offset in the native method struct");
          getter(Il2Cpp3.Method.prototype, "virtualAddress", function() {
            return this.handle.add(offset).readPointer();
          }, lazy);
          Il2Cpp3.corlib.class("System.Reflection.Module").method(".cctor").invoke();
          return this.virtualAddress;
        }
        /** Replaces the body of this method. */
        set implementation(block) {
          try {
            Interceptor.replace(this.virtualAddress, this.wrap(block));
          } catch (e) {
            switch (e.message) {
              case "access violation accessing 0x0":
                raise(`couldn't set implementation for method ${this.name} as it has a NULL virtual address`);
              case /unable to intercept function at \w+; please file a bug/.exec(e.message)?.input:
                warn(`couldn't set implementation for method ${this.name} as it may be a thunk`);
                break;
              case "already replaced this function":
                warn(`couldn't set implementation for method ${this.name} as it has already been replaced by a thunk`);
                break;
              default:
                throw e;
            }
          }
        }
        /** Creates a generic instance of the current generic method. */
        inflate(...classes) {
          if (!this.isGeneric || this.generics.length != classes.length) {
            for (const method of this.overloads()) {
              if (method.isGeneric && method.generics.length == classes.length) {
                return method.inflate(...classes);
              }
            }
            raise(`could not find inflatable signature of method ${this.name} with ${classes.length} generic parameter(s)`);
          }
          const types = classes.map((_) => _.type.object);
          const typeArray = Il2Cpp3.array(Il2Cpp3.corlib.class("System.Type"), types);
          const inflatedMethodObject = this.object.method("MakeGenericMethod", 1).invoke(typeArray);
          return new Il2Cpp3.Method(inflatedMethodObject.field("mhandle").value);
        }
        /** Invokes this method. */
        invoke(...parameters) {
          if (!this.isStatic) {
            raise(`cannot invoke non-static method ${this.name} as it must be invoked throught a Il2Cpp.Object, not a Il2Cpp.Class`);
          }
          return this.invokeRaw(NULL, ...parameters);
        }
        /** @internal */
        invokeRaw(instance, ...parameters) {
          const allocatedParameters = parameters.map(Il2Cpp3.toFridaValue);
          if (!this.isStatic || Il2Cpp3.unityVersionIsBelow201830) {
            allocatedParameters.unshift(instance);
          }
          if (this.isInflated) {
            allocatedParameters.push(this.handle);
          }
          try {
            const returnValue = this.nativeFunction(...allocatedParameters);
            return Il2Cpp3.fromFridaValue(returnValue, this.returnType);
          } catch (e) {
            if (e == null) {
              raise("an unexpected native invocation exception occurred, this is due to parameter types mismatch");
            }
            switch (e.message) {
              case "bad argument count":
                raise(`couldn't invoke method ${this.name} as it needs ${this.parameterCount} parameter(s), not ${parameters.length}`);
              case "expected a pointer":
              case "expected number":
              case "expected array with fields":
                raise(`couldn't invoke method ${this.name} using incorrect parameter types`);
            }
            throw e;
          }
        }
        /** Gets the overloaded method with the given parameter types. */
        overload(...typeNamesOrClasses) {
          const method = this.tryOverload(...typeNamesOrClasses);
          return method ?? raise(`couldn't find overloaded method ${this.name}(${typeNamesOrClasses.map((_) => _ instanceof Il2Cpp3.Class ? _.type.name : _)})`);
        }
        /** @internal */
        *overloads() {
          for (const klass of this.class.hierarchy()) {
            for (const method of klass.methods) {
              if (this.name == method.name) {
                yield method;
              }
            }
          }
        }
        /** Gets the parameter with the given name. */
        parameter(name) {
          return this.tryParameter(name) ?? raise(`couldn't find parameter ${name} in method ${this.name}`);
        }
        /** Restore the original method implementation. */
        revert() {
          Interceptor.revert(this.virtualAddress);
          Interceptor.flush();
        }
        /** Gets the overloaded method with the given parameter types. */
        tryOverload(...typeNamesOrClasses) {
          const minScore = typeNamesOrClasses.length * 1;
          const maxScore = typeNamesOrClasses.length * 2;
          let candidate = void 0;
          loop: for (const method of this.overloads()) {
            if (method.parameterCount != typeNamesOrClasses.length)
              continue;
            let score = 0;
            let i = 0;
            for (const parameter of method.parameters) {
              const desiredTypeNameOrClass = typeNamesOrClasses[i];
              if (desiredTypeNameOrClass instanceof Il2Cpp3.Class) {
                if (parameter.type.is(desiredTypeNameOrClass.type)) {
                  score += 2;
                } else if (parameter.type.class.isAssignableFrom(desiredTypeNameOrClass)) {
                  score += 1;
                } else {
                  continue loop;
                }
              } else if (parameter.type.name == desiredTypeNameOrClass) {
                score += 2;
              } else {
                continue loop;
              }
              i++;
            }
            if (score < minScore) {
              continue;
            } else if (score == maxScore) {
              return method;
            } else if (candidate == void 0 || score > candidate[0]) {
              candidate = [score, method];
            } else if (score == candidate[0]) {
              let i2 = 0;
              for (const parameter of candidate[1].parameters) {
                if (parameter.type.class.isAssignableFrom(method.parameters[i2].type.class)) {
                  candidate = [score, method];
                  continue loop;
                }
                i2++;
              }
            }
          }
          return candidate?.[1];
        }
        /** Gets the parameter with the given name. */
        tryParameter(name) {
          return this.parameters.find((_) => _.name == name);
        }
        /** */
        toString() {
          return `${this.isStatic ? `static ` : ``}${this.returnType.name} ${this.name}${this.generics.length > 0 ? `<${this.generics.map((_) => _.type.name).join(",")}>` : ""}(${this.parameters.join(`, `)});${this.virtualAddress.isNull() ? `` : ` // 0x${this.relativeVirtualAddress.toString(16).padStart(8, `0`)}`}`;
        }
        /**
         * @internal
         * Binds the current method to a {@link Il2Cpp.Object} or a
         * {@link Il2Cpp.ValueType} (also known as *instances*), so that it is
         * possible to invoke it - see {@link Il2Cpp.Method.invoke} for
         * details. \
         * Binding a static method is forbidden.
         */
        bind(instance) {
          if (this.isStatic) {
            raise(`cannot bind static method ${this.class.type.name}::${this.name} to an instance`);
          }
          return new Proxy(this, {
            get(target, property, receiver) {
              switch (property) {
                case "invoke":
                  const handle = instance instanceof Il2Cpp3.ValueType ? target.class.isValueType ? instance.handle.sub(structMethodsRequireObjectInstances() ? Il2Cpp3.Object.headerSize : 0) : raise(`cannot invoke method ${target.class.type.name}::${target.name} against a value type, you must box it first`) : target.class.isValueType ? instance.handle.add(structMethodsRequireObjectInstances() ? 0 : Il2Cpp3.Object.headerSize) : instance.handle;
                  return target.invokeRaw.bind(target, handle);
                case "overloads":
                  return function* () {
                    for (const method of target[property]()) {
                      if (!method.isStatic) {
                        yield method;
                      }
                    }
                  };
                case "inflate":
                case "overload":
                case "tryOverload":
                  const member = Reflect.get(target, property).bind(receiver);
                  return function(...args) {
                    return member(...args)?.bind(instance);
                  };
              }
              return Reflect.get(target, property);
            }
          });
        }
        /** @internal */
        wrap(block) {
          const startIndex = +!this.isStatic | +Il2Cpp3.unityVersionIsBelow201830;
          return new NativeCallback((...args) => {
            const thisObject = this.isStatic ? this.class : this.class.isValueType ? new Il2Cpp3.ValueType(args[0].add(structMethodsRequireObjectInstances() ? Il2Cpp3.Object.headerSize : 0), this.class.type) : new Il2Cpp3.Object(args[0]);
            const parameters = this.parameters.map((_, i) => Il2Cpp3.fromFridaValue(args[i + startIndex], _.type));
            const result = block.call(thisObject, ...parameters);
            return Il2Cpp3.toFridaValue(result);
          }, this.returnType.fridaAlias, this.fridaSignature);
        }
      }
      __decorate([
        lazy
      ], Method.prototype, "class", null);
      __decorate([
        lazy
      ], Method.prototype, "flags", null);
      __decorate([
        lazy
      ], Method.prototype, "implementationFlags", null);
      __decorate([
        lazy
      ], Method.prototype, "fridaSignature", null);
      __decorate([
        lazy
      ], Method.prototype, "generics", null);
      __decorate([
        lazy
      ], Method.prototype, "isExternal", null);
      __decorate([
        lazy
      ], Method.prototype, "isGeneric", null);
      __decorate([
        lazy
      ], Method.prototype, "isInflated", null);
      __decorate([
        lazy
      ], Method.prototype, "isStatic", null);
      __decorate([
        lazy
      ], Method.prototype, "isSynchronized", null);
      __decorate([
        lazy
      ], Method.prototype, "modifier", null);
      __decorate([
        lazy
      ], Method.prototype, "name", null);
      __decorate([
        lazy
      ], Method.prototype, "nativeFunction", null);
      __decorate([
        lazy
      ], Method.prototype, "object", null);
      __decorate([
        lazy
      ], Method.prototype, "parameterCount", null);
      __decorate([
        lazy
      ], Method.prototype, "parameters", null);
      __decorate([
        lazy
      ], Method.prototype, "relativeVirtualAddress", null);
      __decorate([
        lazy
      ], Method.prototype, "returnType", null);
      Il2Cpp3.Method = Method;
      let structMethodsRequireObjectInstances = () => {
        const object = Il2Cpp3.corlib.class("System.Int64").alloc();
        object.field("m_value").value = 3735928559;
        const result = object.method("Equals", 1).overload(object.class).invokeRaw(object, 3735928559);
        return (structMethodsRequireObjectInstances = () => result)();
      };
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class Object2 extends NativeStruct {
        /** Gets the Il2CppObject struct size, possibly equal to `Process.pointerSize * 2`. */
        static get headerSize() {
          return Il2Cpp3.corlib.class("System.Object").instanceSize;
        }
        /**
         * Returns the same object, but having its parent class as class.
         * It basically is the C# `base` keyword, so that parent members can be
         * accessed.
         *
         * **Example** \
         * Consider the following classes:
         * ```csharp
         * class Foo
         * {
         *     int foo()
         *     {
         *          return 1;
         *     }
         * }
         * class Bar : Foo
         * {
         *     new int foo()
         *     {
         *          return 2;
         *     }
         * }
         * ```
         * then:
         * ```ts
         * const Bar: Il2Cpp.Class = ...;
         * const bar = Bar.new();
         *
         * console.log(bar.foo()); // 2
         * console.log(bar.base.foo()); // 1
         * ```
         */
        get base() {
          if (this.class.parent == null) {
            raise(`class ${this.class.type.name} has no parent`);
          }
          return new Proxy(this, {
            get(target, property, receiver) {
              if (property == "class") {
                return Reflect.get(target, property).parent;
              } else if (property == "base") {
                return Reflect.getOwnPropertyDescriptor(Il2Cpp3.Object.prototype, property).get.bind(receiver)();
              }
              return Reflect.get(target, property);
            }
          });
        }
        /** Gets the class of this object. */
        get class() {
          return new Il2Cpp3.Class(Il2Cpp3.exports.objectGetClass(this));
        }
        /** Returns a monitor for this object. */
        get monitor() {
          return new Il2Cpp3.Object.Monitor(this);
        }
        /** Gets the size of the current object. */
        get size() {
          return Il2Cpp3.exports.objectGetSize(this);
        }
        /** Gets the non-static field with the given name of the current class hierarchy. */
        field(name) {
          return this.tryField(name) ?? raise(`couldn't find non-static field ${name} in hierarchy of class ${this.class.type.name}`);
        }
        /** Gets the non-static method with the given name (and optionally parameter count) of the current class hierarchy. */
        method(name, parameterCount = -1) {
          return this.tryMethod(name, parameterCount) ?? raise(`couldn't find non-static method ${name} in hierarchy of class ${this.class.type.name}`);
        }
        /** Creates a reference to this object. */
        ref(pin) {
          return new Il2Cpp3.GCHandle(Il2Cpp3.exports.gcHandleNew(this, +pin));
        }
        /** Gets the correct virtual method from the given virtual method. */
        virtualMethod(method) {
          return new Il2Cpp3.Method(Il2Cpp3.exports.objectGetVirtualMethod(this, method)).bind(this);
        }
        /** Gets the non-static field with the given name of the current class hierarchy, if it exists. */
        tryField(name) {
          const field = this.class.tryField(name);
          if (field?.isStatic) {
            for (const klass of this.class.hierarchy({ includeCurrent: false })) {
              for (const field2 of klass.fields) {
                if (field2.name == name && !field2.isStatic) {
                  return field2.bind(this);
                }
              }
            }
            return void 0;
          }
          return field?.bind(this);
        }
        /** Gets the non-static method with the given name (and optionally parameter count) of the current class hierarchy, if it exists. */
        tryMethod(name, parameterCount = -1) {
          const method = this.class.tryMethod(name, parameterCount);
          if (method?.isStatic) {
            for (const klass of this.class.hierarchy()) {
              for (const method2 of klass.methods) {
                if (method2.name == name && !method2.isStatic && (parameterCount < 0 || method2.parameterCount == parameterCount)) {
                  return method2.bind(this);
                }
              }
            }
            return void 0;
          }
          return method?.bind(this);
        }
        /** */
        toString() {
          return this.isNull() ? "null" : this.method("ToString", 0).invoke().content ?? "null";
        }
        /** Unboxes the value type (either a primitive, a struct or an enum) out of this object. */
        unbox() {
          return this.class.isValueType ? new Il2Cpp3.ValueType(Il2Cpp3.exports.objectUnbox(this), this.class.type) : raise(`couldn't unbox instances of ${this.class.type.name} as they are not value types`);
        }
        /** Creates a weak reference to this object. */
        weakRef(trackResurrection) {
          return new Il2Cpp3.GCHandle(Il2Cpp3.exports.gcHandleNewWeakRef(this, +trackResurrection));
        }
      }
      __decorate([
        lazy
      ], Object2.prototype, "class", null);
      __decorate([
        lazy
      ], Object2.prototype, "size", null);
      __decorate([
        lazy
      ], Object2, "headerSize", null);
      Il2Cpp3.Object = Object2;
      (function(Object3) {
        class Monitor {
          handle;
          /** @internal */
          constructor(handle) {
            this.handle = handle;
          }
          /** Acquires an exclusive lock on the current object. */
          enter() {
            return Il2Cpp3.exports.monitorEnter(this.handle);
          }
          /** Release an exclusive lock on the current object. */
          exit() {
            return Il2Cpp3.exports.monitorExit(this.handle);
          }
          /** Notifies a thread in the waiting queue of a change in the locked object's state. */
          pulse() {
            return Il2Cpp3.exports.monitorPulse(this.handle);
          }
          /** Notifies all waiting threads of a change in the object's state. */
          pulseAll() {
            return Il2Cpp3.exports.monitorPulseAll(this.handle);
          }
          /** Attempts to acquire an exclusive lock on the current object. */
          tryEnter(timeout) {
            return !!Il2Cpp3.exports.monitorTryEnter(this.handle, timeout);
          }
          /** Releases the lock on an object and attempts to block the current thread until it reacquires the lock. */
          tryWait(timeout) {
            return !!Il2Cpp3.exports.monitorTryWait(this.handle, timeout);
          }
          /** Releases the lock on an object and blocks the current thread until it reacquires the lock. */
          wait() {
            return Il2Cpp3.exports.monitorWait(this.handle);
          }
        }
        Object3.Monitor = Monitor;
      })(Object2 = Il2Cpp3.Object || (Il2Cpp3.Object = {}));
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class Parameter {
        /** Name of this parameter. */
        name;
        /** Position of this parameter. */
        position;
        /** Type of this parameter. */
        type;
        constructor(name, position, type) {
          this.name = name;
          this.position = position;
          this.type = type;
        }
        /** */
        toString() {
          return `${this.type.name} ${this.name}`;
        }
      }
      Il2Cpp3.Parameter = Parameter;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class Pointer extends NativeStruct {
        type;
        constructor(handle, type) {
          super(handle);
          this.type = type;
        }
        /** Gets the element at the given index. */
        get(index) {
          return Il2Cpp3.read(this.handle.add(index * this.type.class.arrayElementSize), this.type);
        }
        /** Reads the given amount of elements starting at the given offset. */
        read(length, offset = 0) {
          const values = new globalThis.Array(length);
          for (let i = 0; i < length; i++) {
            values[i] = this.get(i + offset);
          }
          return values;
        }
        /** Sets the given element at the given index */
        set(index, value) {
          Il2Cpp3.write(this.handle.add(index * this.type.class.arrayElementSize), value, this.type);
        }
        /** */
        toString() {
          return this.handle.toString();
        }
        /** Writes the given elements starting at the given index. */
        write(values, offset = 0) {
          for (let i = 0; i < values.length; i++) {
            this.set(i + offset, values[i]);
          }
        }
      }
      Il2Cpp3.Pointer = Pointer;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class Reference extends NativeStruct {
        type;
        constructor(handle, type) {
          super(handle);
          this.type = type;
        }
        /** Gets the element referenced by the current reference. */
        get value() {
          return Il2Cpp3.read(this.handle, this.type);
        }
        /** Sets the element referenced by the current reference. */
        set value(value) {
          Il2Cpp3.write(this.handle, value, this.type);
        }
        /** */
        toString() {
          return this.isNull() ? "null" : `->${this.value}`;
        }
      }
      Il2Cpp3.Reference = Reference;
      function reference(value, type) {
        const handle = Memory.alloc(Process.pointerSize);
        switch (typeof value) {
          case "boolean":
            return new Il2Cpp3.Reference(handle.writeS8(+value), Il2Cpp3.corlib.class("System.Boolean").type);
          case "number":
            switch (type?.enumValue) {
              case Il2Cpp3.Type.Enum.UBYTE:
                return new Il2Cpp3.Reference(handle.writeU8(value), type);
              case Il2Cpp3.Type.Enum.BYTE:
                return new Il2Cpp3.Reference(handle.writeS8(value), type);
              case Il2Cpp3.Type.Enum.CHAR:
              case Il2Cpp3.Type.Enum.USHORT:
                return new Il2Cpp3.Reference(handle.writeU16(value), type);
              case Il2Cpp3.Type.Enum.SHORT:
                return new Il2Cpp3.Reference(handle.writeS16(value), type);
              case Il2Cpp3.Type.Enum.UINT:
                return new Il2Cpp3.Reference(handle.writeU32(value), type);
              case Il2Cpp3.Type.Enum.INT:
                return new Il2Cpp3.Reference(handle.writeS32(value), type);
              case Il2Cpp3.Type.Enum.ULONG:
                return new Il2Cpp3.Reference(handle.writeU64(value), type);
              case Il2Cpp3.Type.Enum.LONG:
                return new Il2Cpp3.Reference(handle.writeS64(value), type);
              case Il2Cpp3.Type.Enum.FLOAT:
                return new Il2Cpp3.Reference(handle.writeFloat(value), type);
              case Il2Cpp3.Type.Enum.DOUBLE:
                return new Il2Cpp3.Reference(handle.writeDouble(value), type);
            }
          case "object":
            if (value instanceof Il2Cpp3.ValueType || value instanceof Il2Cpp3.Pointer) {
              return new Il2Cpp3.Reference(value.handle, value.type);
            } else if (value instanceof Il2Cpp3.Object) {
              return new Il2Cpp3.Reference(handle.writePointer(value), value.class.type);
            } else if (value instanceof Il2Cpp3.String || value instanceof Il2Cpp3.Array) {
              return new Il2Cpp3.Reference(handle.writePointer(value), value.object.class.type);
            } else if (value instanceof NativePointer) {
              switch (type?.enumValue) {
                case Il2Cpp3.Type.Enum.NUINT:
                case Il2Cpp3.Type.Enum.NINT:
                  return new Il2Cpp3.Reference(handle.writePointer(value), type);
              }
            } else if (value instanceof Int64) {
              return new Il2Cpp3.Reference(handle.writeS64(value), Il2Cpp3.corlib.class("System.Int64").type);
            } else if (value instanceof UInt64) {
              return new Il2Cpp3.Reference(handle.writeU64(value), Il2Cpp3.corlib.class("System.UInt64").type);
            }
          default:
            raise(`couldn't create a reference to ${value} using an unhandled type ${type?.name}`);
        }
      }
      Il2Cpp3.reference = reference;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class String2 extends NativeStruct {
        /** Gets the content of this string. */
        get content() {
          return Il2Cpp3.exports.stringGetChars(this).readUtf16String(this.length);
        }
        /** @unsafe Sets the content of this string - it may write out of bounds! */
        set content(value) {
          const offset = Il2Cpp3.string("vfsfitvnm").handle.offsetOf((_) => _.readInt() == 9) ?? raise("couldn't find the length offset in the native string struct");
          globalThis.Object.defineProperty(Il2Cpp3.String.prototype, "content", {
            set(value2) {
              Il2Cpp3.exports.stringGetChars(this).writeUtf16String(value2 ?? "");
              this.handle.add(offset).writeS32(value2?.length ?? 0);
            }
          });
          this.content = value;
        }
        /** Gets the length of this string. */
        get length() {
          return Il2Cpp3.exports.stringGetLength(this);
        }
        /** Gets the encompassing object of the current string. */
        get object() {
          return new Il2Cpp3.Object(this);
        }
        /** */
        toString() {
          return this.isNull() ? "null" : `"${this.content}"`;
        }
      }
      Il2Cpp3.String = String2;
      function string(content) {
        return new Il2Cpp3.String(Il2Cpp3.exports.stringNew(Memory.allocUtf8String(content ?? "")));
      }
      Il2Cpp3.string = string;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class Thread extends NativeStruct {
        /** Gets the native id of the current thread. */
        get id() {
          let get = function() {
            return this.internal.field("thread_id").value.toNumber();
          };
          if (Process.platform != "windows") {
            const currentThreadId = Process.getCurrentThreadId();
            const currentPosixThread = ptr(get.apply(Il2Cpp3.currentThread));
            const offset = currentPosixThread.offsetOf((_) => _.readS32() == currentThreadId, 1024) ?? raise(`couldn't find the offset for determining the kernel id of a posix thread`);
            const _get = get;
            get = function() {
              return ptr(_get.apply(this)).add(offset).readS32();
            };
          }
          getter(Il2Cpp3.Thread.prototype, "id", get, lazy);
          return this.id;
        }
        /** Gets the encompassing internal object (System.Threding.InternalThreead) of the current thread. */
        get internal() {
          return this.object.tryField("internal_thread")?.value ?? this.object;
        }
        /** Determines whether the current thread is the garbage collector finalizer one. */
        get isFinalizer() {
          return !Il2Cpp3.exports.threadIsVm(this);
        }
        /** Gets the managed id of the current thread. */
        get managedId() {
          return this.object.method("get_ManagedThreadId").invoke();
        }
        /** Gets the encompassing object of the current thread. */
        get object() {
          return new Il2Cpp3.Object(this);
        }
        /** @internal */
        get staticData() {
          return this.internal.field("static_data").value;
        }
        /** @internal */
        get synchronizationContext() {
          const get_ExecutionContext = this.object.tryMethod("GetMutableExecutionContext") ?? this.object.method("get_ExecutionContext");
          const executionContext = get_ExecutionContext.invoke();
          const synchronizationContext = executionContext.tryField("_syncContext")?.value ?? executionContext.tryMethod("get_SynchronizationContext")?.invoke() ?? this.tryLocalValue(Il2Cpp3.corlib.class("System.Threading.SynchronizationContext"));
          return synchronizationContext?.asNullable() ?? null;
        }
        /** Detaches the thread from the application domain. */
        detach() {
          return Il2Cpp3.exports.threadDetach(this);
        }
        /** Schedules a callback on the current thread. */
        schedule(block) {
          const Post = this.synchronizationContext?.tryMethod("Post");
          if (Post == null) {
            return Process.runOnThread(this.id, block);
          }
          return new Promise((resolve) => {
            const delegate = Il2Cpp3.delegate(Il2Cpp3.corlib.class("System.Threading.SendOrPostCallback"), () => {
              const result = block();
              setImmediate(() => resolve(result));
            });
            Script.bindWeak(globalThis, () => {
              delegate.field("method_ptr").value = delegate.field("invoke_impl").value = Il2Cpp3.exports.domainGet;
            });
            Post.invoke(delegate, NULL);
          });
        }
        /** @internal */
        tryLocalValue(klass) {
          for (let i = 0; i < 16; i++) {
            const base = this.staticData.add(i * Process.pointerSize).readPointer();
            if (!base.isNull()) {
              const object = new Il2Cpp3.Object(base.readPointer()).asNullable();
              if (object?.class?.isSubclassOf(klass, false)) {
                return object;
              }
            }
          }
        }
      }
      __decorate([
        lazy
      ], Thread.prototype, "internal", null);
      __decorate([
        lazy
      ], Thread.prototype, "isFinalizer", null);
      __decorate([
        lazy
      ], Thread.prototype, "managedId", null);
      __decorate([
        lazy
      ], Thread.prototype, "object", null);
      __decorate([
        lazy
      ], Thread.prototype, "staticData", null);
      __decorate([
        lazy
      ], Thread.prototype, "synchronizationContext", null);
      Il2Cpp3.Thread = Thread;
      getter(Il2Cpp3, "attachedThreads", () => {
        if (Il2Cpp3.exports.threadGetAttachedThreads.isNull()) {
          const currentThreadHandle = Il2Cpp3.currentThread?.handle ?? raise("Current thread is not attached to IL2CPP");
          const pattern = currentThreadHandle.toMatchPattern();
          const threads = [];
          for (const range of Process.enumerateRanges("rw-")) {
            if (range.file == void 0) {
              const matches = Memory.scanSync(range.base, range.size, pattern);
              if (matches.length == 1) {
                while (true) {
                  const handle = matches[0].address.sub(matches[0].size * threads.length).readPointer();
                  if (handle.isNull() || !handle.readPointer().equals(currentThreadHandle.readPointer())) {
                    break;
                  }
                  threads.unshift(new Il2Cpp3.Thread(handle));
                }
                break;
              }
            }
          }
          return threads;
        }
        return readNativeList(Il2Cpp3.exports.threadGetAttachedThreads).map((_) => new Il2Cpp3.Thread(_));
      });
      getter(Il2Cpp3, "currentThread", () => {
        return new Il2Cpp3.Thread(Il2Cpp3.exports.threadGetCurrent()).asNullable();
      });
      getter(Il2Cpp3, "mainThread", () => {
        return Il2Cpp3.attachedThreads[0];
      });
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      let Type = class Type extends NativeStruct {
        /** */
        static get Enum() {
          const _ = (_2, block = (_3) => _3) => block(Il2Cpp3.corlib.class(_2)).type.enumValue;
          const initial = {
            VOID: _("System.Void"),
            BOOLEAN: _("System.Boolean"),
            CHAR: _("System.Char"),
            BYTE: _("System.SByte"),
            UBYTE: _("System.Byte"),
            SHORT: _("System.Int16"),
            USHORT: _("System.UInt16"),
            INT: _("System.Int32"),
            UINT: _("System.UInt32"),
            LONG: _("System.Int64"),
            ULONG: _("System.UInt64"),
            NINT: _("System.IntPtr"),
            NUINT: _("System.UIntPtr"),
            FLOAT: _("System.Single"),
            DOUBLE: _("System.Double"),
            POINTER: _("System.IntPtr", (_2) => _2.field("m_value")),
            VALUE_TYPE: _("System.Decimal"),
            OBJECT: _("System.Object"),
            STRING: _("System.String"),
            CLASS: _("System.Array"),
            ARRAY: _("System.Void", (_2) => _2.arrayClass),
            NARRAY: _("System.Void", (_2) => new Il2Cpp3.Class(Il2Cpp3.exports.classGetArrayClass(_2, 2))),
            GENERIC_INSTANCE: _("System.Int32", (_2) => _2.interfaces.find((_3) => _3.name.endsWith("`1")))
          };
          Reflect.defineProperty(this, "Enum", { value: initial });
          return addFlippedEntries({
            ...initial,
            VAR: _("System.Action`1", (_2) => _2.generics[0]),
            MVAR: _("System.Array", (_2) => _2.method("AsReadOnly", 1).generics[0])
          });
        }
        /** Gets the class of this type. */
        get class() {
          return new Il2Cpp3.Class(Il2Cpp3.exports.typeGetClass(this));
        }
        /** */
        get fridaAlias() {
          function getValueTypeFields(type) {
            const instanceFields = type.class.fields.filter((_) => !_.isStatic);
            return instanceFields.length == 0 ? ["char"] : instanceFields.map((_) => _.type.fridaAlias);
          }
          if (this.isByReference) {
            return "pointer";
          }
          switch (this.enumValue) {
            case Il2Cpp3.Type.Enum.VOID:
              return "void";
            case Il2Cpp3.Type.Enum.BOOLEAN:
              return "bool";
            case Il2Cpp3.Type.Enum.CHAR:
              return "uchar";
            case Il2Cpp3.Type.Enum.BYTE:
              return "int8";
            case Il2Cpp3.Type.Enum.UBYTE:
              return "uint8";
            case Il2Cpp3.Type.Enum.SHORT:
              return "int16";
            case Il2Cpp3.Type.Enum.USHORT:
              return "uint16";
            case Il2Cpp3.Type.Enum.INT:
              return "int32";
            case Il2Cpp3.Type.Enum.UINT:
              return "uint32";
            case Il2Cpp3.Type.Enum.LONG:
              return "int64";
            case Il2Cpp3.Type.Enum.ULONG:
              return "uint64";
            case Il2Cpp3.Type.Enum.FLOAT:
              return "float";
            case Il2Cpp3.Type.Enum.DOUBLE:
              return "double";
            case Il2Cpp3.Type.Enum.NINT:
            case Il2Cpp3.Type.Enum.NUINT:
            case Il2Cpp3.Type.Enum.POINTER:
            case Il2Cpp3.Type.Enum.STRING:
            case Il2Cpp3.Type.Enum.ARRAY:
            case Il2Cpp3.Type.Enum.NARRAY:
              return "pointer";
            case Il2Cpp3.Type.Enum.VALUE_TYPE:
              return this.class.isEnum ? this.class.baseType.fridaAlias : getValueTypeFields(this);
            case Il2Cpp3.Type.Enum.CLASS:
            case Il2Cpp3.Type.Enum.OBJECT:
            case Il2Cpp3.Type.Enum.GENERIC_INSTANCE:
              return this.class.isStruct ? getValueTypeFields(this) : this.class.isEnum ? this.class.baseType.fridaAlias : "pointer";
            default:
              return "pointer";
          }
        }
        /** Determines whether this type is passed by reference. */
        get isByReference() {
          return this.name.endsWith("&");
        }
        /** Determines whether this type is primitive. */
        get isPrimitive() {
          switch (this.enumValue) {
            case Il2Cpp3.Type.Enum.BOOLEAN:
            case Il2Cpp3.Type.Enum.CHAR:
            case Il2Cpp3.Type.Enum.BYTE:
            case Il2Cpp3.Type.Enum.UBYTE:
            case Il2Cpp3.Type.Enum.SHORT:
            case Il2Cpp3.Type.Enum.USHORT:
            case Il2Cpp3.Type.Enum.INT:
            case Il2Cpp3.Type.Enum.UINT:
            case Il2Cpp3.Type.Enum.LONG:
            case Il2Cpp3.Type.Enum.ULONG:
            case Il2Cpp3.Type.Enum.FLOAT:
            case Il2Cpp3.Type.Enum.DOUBLE:
            case Il2Cpp3.Type.Enum.NINT:
            case Il2Cpp3.Type.Enum.NUINT:
              return true;
            default:
              return false;
          }
        }
        /** Gets the name of this type. */
        get name() {
          const handle = Il2Cpp3.exports.typeGetName(this);
          try {
            return handle.readUtf8String();
          } finally {
            Il2Cpp3.free(handle);
          }
        }
        /** Gets the encompassing object of the current type. */
        get object() {
          return new Il2Cpp3.Object(Il2Cpp3.exports.typeGetObject(this));
        }
        /** Gets the {@link Il2Cpp.Type.Enum} value of the current type. */
        get enumValue() {
          return Il2Cpp3.exports.typeGetTypeEnum(this);
        }
        is(other) {
          if (Il2Cpp3.exports.typeEquals.isNull()) {
            return this.object.method("Equals").invoke(other.object);
          }
          return !!Il2Cpp3.exports.typeEquals(this, other);
        }
        /** */
        toString() {
          return this.name;
        }
      };
      __decorate([
        lazy
      ], Type.prototype, "class", null);
      __decorate([
        lazy
      ], Type.prototype, "fridaAlias", null);
      __decorate([
        lazy
      ], Type.prototype, "isByReference", null);
      __decorate([
        lazy
      ], Type.prototype, "isPrimitive", null);
      __decorate([
        lazy
      ], Type.prototype, "name", null);
      __decorate([
        lazy
      ], Type.prototype, "object", null);
      __decorate([
        lazy
      ], Type.prototype, "enumValue", null);
      __decorate([
        lazy
      ], Type, "Enum", null);
      Type = __decorate([
        recycle
      ], Type);
      Il2Cpp3.Type = Type;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    (function(Il2Cpp3) {
      class ValueType extends NativeStruct {
        type;
        constructor(handle, type) {
          super(handle);
          this.type = type;
        }
        /** Boxes the current value type in a object. */
        box() {
          return new Il2Cpp3.Object(Il2Cpp3.exports.valueTypeBox(this.type.class, this));
        }
        /** Gets the non-static field with the given name of the current class hierarchy. */
        field(name) {
          return this.tryField(name) ?? raise(`couldn't find non-static field ${name} in hierarchy of class ${this.type.name}`);
        }
        /** Gets the non-static method with the given name (and optionally parameter count) of the current class hierarchy. */
        method(name, parameterCount = -1) {
          return this.tryMethod(name, parameterCount) ?? raise(`couldn't find non-static method ${name} in hierarchy of class ${this.type.name}`);
        }
        /** Gets the non-static field with the given name of the current class hierarchy, if it exists. */
        tryField(name) {
          const field = this.type.class.tryField(name);
          if (field?.isStatic) {
            for (const klass of this.type.class.hierarchy()) {
              for (const field2 of klass.fields) {
                if (field2.name == name && !field2.isStatic) {
                  return field2.bind(this);
                }
              }
            }
            return void 0;
          }
          return field?.bind(this);
        }
        /** Gets the non-static method with the given name (and optionally parameter count) of the current class hierarchy, if it exists. */
        tryMethod(name, parameterCount = -1) {
          const method = this.type.class.tryMethod(name, parameterCount);
          if (method?.isStatic) {
            for (const klass of this.type.class.hierarchy()) {
              for (const method2 of klass.methods) {
                if (method2.name == name && !method2.isStatic && (parameterCount < 0 || method2.parameterCount == parameterCount)) {
                  return method2.bind(this);
                }
              }
            }
            return void 0;
          }
          return method?.bind(this);
        }
        /** */
        toString() {
          const ToString = this.method("ToString", 0);
          return this.isNull() ? "null" : (
            // If ToString is defined within a value type class, we can
            // avoid a boxing operation.
            ToString.class.isValueType ? ToString.invoke().content ?? "null" : this.box().toString() ?? "null"
          );
        }
      }
      Il2Cpp3.ValueType = ValueType;
    })(Il2Cpp2 || (Il2Cpp2 = {}));
    globalThis.Il2Cpp = Il2Cpp2;
  }
});

// dump-only.js
var require_dump_only = __commonJS({
  "dump-only.js"() {
    init_node_globals();
    init_dist();
    console.log("[*] B\u1EAFt \u0111\u1EA7u AGENT \u0110I\u1EC0U TRA B\u1ED8 NH\u1EDA...");
    function findStringAndReferences(textToFind) {
      console.log(`
[*] B\u1EAFt \u0111\u1EA7u qu\xE9t b\u1ED9 nh\u1EDB cho chu\u1ED7i: "${textToFind}"`);
      const pattern = Buffer2.from(textToFind, "utf16le").toString("hex");
      const matches = [];
      Process.enumerateRanges("rw-").forEach((range) => {
        try {
          const results = Memory.scanSync(range.base, range.size, pattern);
          results.forEach((match) => {
            matches.push(match.address);
          });
        } catch (e) {
        }
      });
      if (matches.length === 0) {
        console.log(`[!] Kh\xF4ng t\xECm th\u1EA5y chu\u1ED7i "${textToFind}" trong b\u1ED9 nh\u1EDB.`);
        return;
      }
      console.log(
        `[+] T\xECm th\u1EA5y ${matches.length} \u0111\u1ECBa ch\u1EC9 ch\u1EE9a chu\u1ED7i "${textToFind}":`
      );
      matches.forEach((addr) => console.log(`    - String at: ${addr}`));
      console.log(`
[*] B\u1EAFt \u0111\u1EA7u qu\xE9t t\xECm c\xE1c con tr\u1ECF tr\u1ECF \u0111\u1EBFn c\xE1c \u0111\u1ECBa ch\u1EC9 tr\xEAn...`);
      const foundReferences = /* @__PURE__ */ new Map();
      Process.enumerateRanges("rw-").forEach((range) => {
        matches.forEach((stringAddress) => {
          try {
            const results = Memory.scanSync(
              range.base,
              range.size,
              stringAddress.toString(16).match(/../g).reverse().join(" ")
            );
            results.forEach((refMatch) => {
              const refAddress = refMatch.address;
              const vtablePtr = refAddress.readPointer();
              const classPtr = vtablePtr.add(Process.pointerSize).readPointer();
              try {
                const klass = new Il2Cpp.Class(classPtr);
                const className = klass.fullName;
                if (!foundReferences.has(className)) {
                  foundReferences.set(className, []);
                }
                foundReferences.get(className).push(refAddress);
              } catch (e) {
              }
            });
          } catch (e) {
          }
        });
      });
      if (foundReferences.size === 0) {
        console.log("[!] Kh\xF4ng t\xECm th\u1EA5y con tr\u1ECF n\xE0o tr\u1ECF t\u1EDBi chu\u1ED7i n\xE0y.");
      } else {
        console.log(
          "[SUCCESS] T\xECm th\u1EA5y c\xE1c \u0111\u1ED1i t\u01B0\u1EE3ng sau c\xF3 kh\u1EA3 n\u0103ng \u0111ang ch\u1EE9a chu\u1ED7i n\xE0y:"
        );
        for (const [className, addresses] of foundReferences.entries()) {
          console.log(`    -> L\u1EDBp: ${className} (${addresses.length} \u0111\u1ED1i t\u01B0\u1EE3ng)`);
          console.log(`       -> M\u1ED9t v\xED d\u1EE5 t\u1EA1i handle: ${addresses[0]}`);
        }
      }
    }
    rpc.exports.scan = function(text) {
      Il2Cpp.perform(() => {
        findStringAndReferences(text);
      });
    };
    Il2Cpp.perform(() => {
      console.log("[+] Agent \u0111\xE3 s\u1EB5n s\xE0ng. Ch\u1EDD l\u1EC7nh qu\xE9t t\u1EEB Python.");
    });
  }
});
export default require_dump_only();
