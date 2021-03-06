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


#if !SILVERLIGHT
[Serializable]
#endif
public partial class RegisterToBrokerReq : TBase
{
  private int _nodeType;
  private string _strServiceName;

  public int NodeType
  {
    get
    {
      return _nodeType;
    }
    set
    {
      __isset.nodeType = true;
      this._nodeType = value;
    }
  }

  public string StrServiceName
  {
    get
    {
      return _strServiceName;
    }
    set
    {
      __isset.strServiceName = true;
      this._strServiceName = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool nodeType;
    public bool strServiceName;
  }

  public RegisterToBrokerReq() {
  }

  public void Read (TProtocol iprot)
  {
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
          if (field.Type == TType.I32) {
            NodeType = iprot.ReadI32();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.String) {
            StrServiceName = iprot.ReadString();
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
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("RegisterToBrokerReq");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    if (__isset.nodeType) {
      field.Name = "nodeType";
      field.Type = TType.I32;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32(NodeType);
      oprot.WriteFieldEnd();
    }
    if (StrServiceName != null && __isset.strServiceName) {
      field.Name = "strServiceName";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(StrServiceName);
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder sb = new StringBuilder("RegisterToBrokerReq(");
    sb.Append("NodeType: ");
    sb.Append(NodeType);
    sb.Append(",StrServiceName: ");
    sb.Append(StrServiceName);
    sb.Append(")");
    return sb.ToString();
  }

}

