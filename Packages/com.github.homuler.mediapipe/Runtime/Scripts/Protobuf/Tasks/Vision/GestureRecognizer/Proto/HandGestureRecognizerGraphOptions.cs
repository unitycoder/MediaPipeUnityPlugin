// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/tasks/cc/vision/gesture_recognizer/proto/hand_gesture_recognizer_graph_options.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe.Tasks.Vision.GestureRecognizer.Proto {

  /// <summary>Holder for reflection information generated from mediapipe/tasks/cc/vision/gesture_recognizer/proto/hand_gesture_recognizer_graph_options.proto</summary>
  public static partial class HandGestureRecognizerGraphOptionsReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/tasks/cc/vision/gesture_recognizer/proto/hand_gesture_recognizer_graph_options.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HandGestureRecognizerGraphOptionsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cl5tZWRpYXBpcGUvdGFza3MvY2MvdmlzaW9uL2dlc3R1cmVfcmVjb2duaXpl",
            "ci9wcm90by9oYW5kX2dlc3R1cmVfcmVjb2duaXplcl9ncmFwaF9vcHRpb25z",
            "LnByb3RvEi9tZWRpYXBpcGUudGFza3MudmlzaW9uLmdlc3R1cmVfcmVjb2du",
            "aXplci5wcm90bxokbWVkaWFwaXBlL2ZyYW1ld29yay9jYWxjdWxhdG9yLnBy",
            "b3RvGixtZWRpYXBpcGUvZnJhbWV3b3JrL2NhbGN1bGF0b3Jfb3B0aW9ucy5w",
            "cm90bxowbWVkaWFwaXBlL3Rhc2tzL2NjL2NvcmUvcHJvdG8vYmFzZV9vcHRp",
            "b25zLnByb3RvGlltZWRpYXBpcGUvdGFza3MvY2MvdmlzaW9uL2dlc3R1cmVf",
            "cmVjb2duaXplci9wcm90by9nZXN0dXJlX2NsYXNzaWZpZXJfZ3JhcGhfb3B0",
            "aW9ucy5wcm90bxpXbWVkaWFwaXBlL3Rhc2tzL2NjL3Zpc2lvbi9nZXN0dXJl",
            "X3JlY29nbml6ZXIvcHJvdG8vZ2VzdHVyZV9lbWJlZGRlcl9ncmFwaF9vcHRp",
            "b25zLnByb3RvIt4ECiFIYW5kR2VzdHVyZVJlY29nbml6ZXJHcmFwaE9wdGlv",
            "bnMSPQoMYmFzZV9vcHRpb25zGAEgASgLMicubWVkaWFwaXBlLnRhc2tzLmNv",
            "cmUucHJvdG8uQmFzZU9wdGlvbnMSdAoeZ2VzdHVyZV9lbWJlZGRlcl9ncmFw",
            "aF9vcHRpb25zGAIgASgLMkwubWVkaWFwaXBlLnRhc2tzLnZpc2lvbi5nZXN0",
            "dXJlX3JlY29nbml6ZXIucHJvdG8uR2VzdHVyZUVtYmVkZGVyR3JhcGhPcHRp",
            "b25zEn8KJ2Nhbm5lZF9nZXN0dXJlX2NsYXNzaWZpZXJfZ3JhcGhfb3B0aW9u",
            "cxgDIAEoCzJOLm1lZGlhcGlwZS50YXNrcy52aXNpb24uZ2VzdHVyZV9yZWNv",
            "Z25pemVyLnByb3RvLkdlc3R1cmVDbGFzc2lmaWVyR3JhcGhPcHRpb25zEn8K",
            "J2N1c3RvbV9nZXN0dXJlX2NsYXNzaWZpZXJfZ3JhcGhfb3B0aW9ucxgEIAEo",
            "CzJOLm1lZGlhcGlwZS50YXNrcy52aXNpb24uZ2VzdHVyZV9yZWNvZ25pemVy",
            "LnByb3RvLkdlc3R1cmVDbGFzc2lmaWVyR3JhcGhPcHRpb25zMoEBCgNleHQS",
            "HC5tZWRpYXBpcGUuQ2FsY3VsYXRvck9wdGlvbnMY1PH53AEgASgLMlIubWVk",
            "aWFwaXBlLnRhc2tzLnZpc2lvbi5nZXN0dXJlX3JlY29nbml6ZXIucHJvdG8u",
            "SGFuZEdlc3R1cmVSZWNvZ25pemVyR3JhcGhPcHRpb25zQmMKOWNvbS5nb29n",
            "bGUubWVkaWFwaXBlLnRhc2tzLnZpc2lvbi5nZXN0dXJlcmVjb2duaXplci5w",
            "cm90b0ImSGFuZEdlc3R1cmVSZWNvZ25pemVyR3JhcGhPcHRpb25zUHJvdG8="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, global::Mediapipe.CalculatorOptionsReflection.Descriptor, global::Mediapipe.Tasks.Core.Proto.BaseOptionsReflection.Descriptor, global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptionsReflection.Descriptor, global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureEmbedderGraphOptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.HandGestureRecognizerGraphOptions), global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.HandGestureRecognizerGraphOptions.Parser, new[]{ "BaseOptions", "GestureEmbedderGraphOptions", "CannedGestureClassifierGraphOptions", "CustomGestureClassifierGraphOptions" }, null, null, new pb::Extension[] { global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.HandGestureRecognizerGraphOptions.Extensions.Ext }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HandGestureRecognizerGraphOptions : pb::IMessage<HandGestureRecognizerGraphOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HandGestureRecognizerGraphOptions> _parser = new pb::MessageParser<HandGestureRecognizerGraphOptions>(() => new HandGestureRecognizerGraphOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HandGestureRecognizerGraphOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.HandGestureRecognizerGraphOptionsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HandGestureRecognizerGraphOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HandGestureRecognizerGraphOptions(HandGestureRecognizerGraphOptions other) : this() {
      baseOptions_ = other.baseOptions_ != null ? other.baseOptions_.Clone() : null;
      gestureEmbedderGraphOptions_ = other.gestureEmbedderGraphOptions_ != null ? other.gestureEmbedderGraphOptions_.Clone() : null;
      cannedGestureClassifierGraphOptions_ = other.cannedGestureClassifierGraphOptions_ != null ? other.cannedGestureClassifierGraphOptions_.Clone() : null;
      customGestureClassifierGraphOptions_ = other.customGestureClassifierGraphOptions_ != null ? other.customGestureClassifierGraphOptions_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HandGestureRecognizerGraphOptions Clone() {
      return new HandGestureRecognizerGraphOptions(this);
    }

    /// <summary>Field number for the "base_options" field.</summary>
    public const int BaseOptionsFieldNumber = 1;
    private global::Mediapipe.Tasks.Core.Proto.BaseOptions baseOptions_;
    /// <summary>
    /// Base options for configuring hand gesture recognition subgraph, such as
    /// specifying the TfLite model file with metadata, accelerator options, etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Tasks.Core.Proto.BaseOptions BaseOptions {
      get { return baseOptions_; }
      set {
        baseOptions_ = value;
      }
    }

    /// <summary>Field number for the "gesture_embedder_graph_options" field.</summary>
    public const int GestureEmbedderGraphOptionsFieldNumber = 2;
    private global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureEmbedderGraphOptions gestureEmbedderGraphOptions_;
    /// <summary>
    /// Options for GestureEmbedder.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureEmbedderGraphOptions GestureEmbedderGraphOptions {
      get { return gestureEmbedderGraphOptions_; }
      set {
        gestureEmbedderGraphOptions_ = value;
      }
    }

    /// <summary>Field number for the "canned_gesture_classifier_graph_options" field.</summary>
    public const int CannedGestureClassifierGraphOptionsFieldNumber = 3;
    private global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions cannedGestureClassifierGraphOptions_;
    /// <summary>
    /// Options for GestureClassifier of canned gestures.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions CannedGestureClassifierGraphOptions {
      get { return cannedGestureClassifierGraphOptions_; }
      set {
        cannedGestureClassifierGraphOptions_ = value;
      }
    }

    /// <summary>Field number for the "custom_gesture_classifier_graph_options" field.</summary>
    public const int CustomGestureClassifierGraphOptionsFieldNumber = 4;
    private global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions customGestureClassifierGraphOptions_;
    /// <summary>
    /// Options for GestureClassifier of custom gestures.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions CustomGestureClassifierGraphOptions {
      get { return customGestureClassifierGraphOptions_; }
      set {
        customGestureClassifierGraphOptions_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HandGestureRecognizerGraphOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HandGestureRecognizerGraphOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BaseOptions, other.BaseOptions)) return false;
      if (!object.Equals(GestureEmbedderGraphOptions, other.GestureEmbedderGraphOptions)) return false;
      if (!object.Equals(CannedGestureClassifierGraphOptions, other.CannedGestureClassifierGraphOptions)) return false;
      if (!object.Equals(CustomGestureClassifierGraphOptions, other.CustomGestureClassifierGraphOptions)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (baseOptions_ != null) hash ^= BaseOptions.GetHashCode();
      if (gestureEmbedderGraphOptions_ != null) hash ^= GestureEmbedderGraphOptions.GetHashCode();
      if (cannedGestureClassifierGraphOptions_ != null) hash ^= CannedGestureClassifierGraphOptions.GetHashCode();
      if (customGestureClassifierGraphOptions_ != null) hash ^= CustomGestureClassifierGraphOptions.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (baseOptions_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BaseOptions);
      }
      if (gestureEmbedderGraphOptions_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GestureEmbedderGraphOptions);
      }
      if (cannedGestureClassifierGraphOptions_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CannedGestureClassifierGraphOptions);
      }
      if (customGestureClassifierGraphOptions_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CustomGestureClassifierGraphOptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (baseOptions_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BaseOptions);
      }
      if (gestureEmbedderGraphOptions_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GestureEmbedderGraphOptions);
      }
      if (cannedGestureClassifierGraphOptions_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CannedGestureClassifierGraphOptions);
      }
      if (customGestureClassifierGraphOptions_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CustomGestureClassifierGraphOptions);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (baseOptions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BaseOptions);
      }
      if (gestureEmbedderGraphOptions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GestureEmbedderGraphOptions);
      }
      if (cannedGestureClassifierGraphOptions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CannedGestureClassifierGraphOptions);
      }
      if (customGestureClassifierGraphOptions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomGestureClassifierGraphOptions);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HandGestureRecognizerGraphOptions other) {
      if (other == null) {
        return;
      }
      if (other.baseOptions_ != null) {
        if (baseOptions_ == null) {
          BaseOptions = new global::Mediapipe.Tasks.Core.Proto.BaseOptions();
        }
        BaseOptions.MergeFrom(other.BaseOptions);
      }
      if (other.gestureEmbedderGraphOptions_ != null) {
        if (gestureEmbedderGraphOptions_ == null) {
          GestureEmbedderGraphOptions = new global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureEmbedderGraphOptions();
        }
        GestureEmbedderGraphOptions.MergeFrom(other.GestureEmbedderGraphOptions);
      }
      if (other.cannedGestureClassifierGraphOptions_ != null) {
        if (cannedGestureClassifierGraphOptions_ == null) {
          CannedGestureClassifierGraphOptions = new global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions();
        }
        CannedGestureClassifierGraphOptions.MergeFrom(other.CannedGestureClassifierGraphOptions);
      }
      if (other.customGestureClassifierGraphOptions_ != null) {
        if (customGestureClassifierGraphOptions_ == null) {
          CustomGestureClassifierGraphOptions = new global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions();
        }
        CustomGestureClassifierGraphOptions.MergeFrom(other.CustomGestureClassifierGraphOptions);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (baseOptions_ == null) {
              BaseOptions = new global::Mediapipe.Tasks.Core.Proto.BaseOptions();
            }
            input.ReadMessage(BaseOptions);
            break;
          }
          case 18: {
            if (gestureEmbedderGraphOptions_ == null) {
              GestureEmbedderGraphOptions = new global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureEmbedderGraphOptions();
            }
            input.ReadMessage(GestureEmbedderGraphOptions);
            break;
          }
          case 26: {
            if (cannedGestureClassifierGraphOptions_ == null) {
              CannedGestureClassifierGraphOptions = new global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions();
            }
            input.ReadMessage(CannedGestureClassifierGraphOptions);
            break;
          }
          case 34: {
            if (customGestureClassifierGraphOptions_ == null) {
              CustomGestureClassifierGraphOptions = new global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions();
            }
            input.ReadMessage(CustomGestureClassifierGraphOptions);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (baseOptions_ == null) {
              BaseOptions = new global::Mediapipe.Tasks.Core.Proto.BaseOptions();
            }
            input.ReadMessage(BaseOptions);
            break;
          }
          case 18: {
            if (gestureEmbedderGraphOptions_ == null) {
              GestureEmbedderGraphOptions = new global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureEmbedderGraphOptions();
            }
            input.ReadMessage(GestureEmbedderGraphOptions);
            break;
          }
          case 26: {
            if (cannedGestureClassifierGraphOptions_ == null) {
              CannedGestureClassifierGraphOptions = new global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions();
            }
            input.ReadMessage(CannedGestureClassifierGraphOptions);
            break;
          }
          case 34: {
            if (customGestureClassifierGraphOptions_ == null) {
              CustomGestureClassifierGraphOptions = new global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.GestureClassifierGraphOptions();
            }
            input.ReadMessage(CustomGestureClassifierGraphOptions);
            break;
          }
        }
      }
    }
    #endif

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the HandGestureRecognizerGraphOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.HandGestureRecognizerGraphOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.HandGestureRecognizerGraphOptions>(463370452, pb::FieldCodec.ForMessage(3706963618, global::Mediapipe.Tasks.Vision.GestureRecognizer.Proto.HandGestureRecognizerGraphOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
