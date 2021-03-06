/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace ImpalaSharp.Thrift
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TTypeDesc : TBase
  {

    public List<TTypeEntry> Types { get; set; }

    public TTypeDesc() {
    }

    public TTypeDesc(List<TTypeEntry> types) : this() {
      this.Types = types;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_types = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.List) {
              {
                Types = new List<TTypeEntry>();
                TList _list10 = iprot.ReadListBegin();
                for( int _i11 = 0; _i11 < _list10.Count; ++_i11)
                {
                  TTypeEntry _elem12 = new TTypeEntry();
                  _elem12 = new TTypeEntry();
                  _elem12.Read(iprot);
                  Types.Add(_elem12);
                }
                iprot.ReadListEnd();
              }
              isset_types = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_types)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TTypeDesc");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "types";
      field.Type = TType.List;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.Struct, Types.Count));
        foreach (TTypeEntry _iter13 in Types)
        {
          _iter13.Write(oprot);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TTypeDesc(");
      sb.Append("Types: ");
      sb.Append(Types);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
