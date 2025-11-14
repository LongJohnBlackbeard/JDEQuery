using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F30W - .
/// </summary>
public class F51F30W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VFUSER.
        /// </summary>
        public const string VFUSER = "VFUSER";

        /// <summary>
        /// VF51FFID.
        /// </summary>
        public const string VF51FFID = "VF51FFID";

        /// <summary>
        /// VFAID.
        /// </summary>
        public const string VFAID = "VFAID";

        /// <summary>
        /// VF51FAA02.
        /// </summary>
        public const string VF51FAA02 = "VF51FAA02";

        /// <summary>
        /// VF51FAAVAR.
        /// </summary>
        public const string VF51FAAVAR = "VF51FAAVAR";

        /// <summary>
        /// VF51FAU02.
        /// </summary>
        public const string VF51FAU02 = "VF51FAU02";

        /// <summary>
        /// VF51FAUVAR.
        /// </summary>
        public const string VF51FAUVAR = "VF51FAUVAR";

        /// <summary>
        /// VF51FPA02.
        /// </summary>
        public const string VF51FPA02 = "VF51FPA02";

        /// <summary>
        /// VF51FPAVAR.
        /// </summary>
        public const string VF51FPAVAR = "VF51FPAVAR";

        /// <summary>
        /// VF51FPU02.
        /// </summary>
        public const string VF51FPU02 = "VF51FPU02";

        /// <summary>
        /// VF51FPUVAR.
        /// </summary>
        public const string VF51FPUVAR = "VF51FPUVAR";

        /// <summary>
        /// VF51FBORGA.
        /// </summary>
        public const string VF51FBORGA = "VF51FBORGA";

        /// <summary>
        /// VF51FBORGU.
        /// </summary>
        public const string VF51FBORGU = "VF51FBORGU";

        /// <summary>
        /// VF51FHA01.
        /// </summary>
        public const string VF51FHA01 = "VF51FHA01";

        /// <summary>
        /// VF51FHA02.
        /// </summary>
        public const string VF51FHA02 = "VF51FHA02";

        /// <summary>
        /// VF51FHAVAR.
        /// </summary>
        public const string VF51FHAVAR = "VF51FHAVAR";

        /// <summary>
        /// VF51FHU01.
        /// </summary>
        public const string VF51FHU01 = "VF51FHU01";

        /// <summary>
        /// VF51FHU02.
        /// </summary>
        public const string VF51FHU02 = "VF51FHU02";

        /// <summary>
        /// VF51FHUVAR.
        /// </summary>
        public const string VF51FHUVAR = "VF51FHUVAR";

        /// <summary>
        /// VF51FAAPA1.
        /// </summary>
        public const string VF51FAAPA1 = "VF51FAAPA1";

        /// <summary>
        /// VF51FAUPU1.
        /// </summary>
        public const string VF51FAUPU1 = "VF51FAUPU1";

        /// <summary>
        /// VF51FREMA1.
        /// </summary>
        public const string VF51FREMA1 = "VF51FREMA1";

        /// <summary>
        /// VF51FREMU1.
        /// </summary>
        public const string VF51FREMU1 = "VF51FREMU1";

        /// <summary>
        /// VF51FPERCP.
        /// </summary>
        public const string VF51FPERCP = "VF51FPERCP";

        /// <summary>
        /// VF51FPERCU.
        /// </summary>
        public const string VF51FPERCU = "VF51FPERCU";

        /// <summary>
        /// VF51FEACA2.
        /// </summary>
        public const string VF51FEACA2 = "VF51FEACA2";

        /// <summary>
        /// VF51FEACAV.
        /// </summary>
        public const string VF51FEACAV = "VF51FEACAV";

        /// <summary>
        /// VF51FEACU2.
        /// </summary>
        public const string VF51FEACU2 = "VF51FEACU2";

        /// <summary>
        /// VF51FEACUV.
        /// </summary>
        public const string VF51FEACUV = "VF51FEACUV";

        /// <summary>
        /// VF51FTBCA2.
        /// </summary>
        public const string VF51FTBCA2 = "VF51FTBCA2";

        /// <summary>
        /// VF51FTBCAV.
        /// </summary>
        public const string VF51FTBCAV = "VF51FTBCAV";

        /// <summary>
        /// VF51FTBCU2.
        /// </summary>
        public const string VF51FTBCU2 = "VF51FTBCU2";

        /// <summary>
        /// VF51FTBCUV.
        /// </summary>
        public const string VF51FTBCUV = "VF51FTBCUV";

        /// <summary>
        /// VF51FETCA2.
        /// </summary>
        public const string VF51FETCA2 = "VF51FETCA2";

        /// <summary>
        /// VF51FETCAV.
        /// </summary>
        public const string VF51FETCAV = "VF51FETCAV";

        /// <summary>
        /// VF51FETCU2.
        /// </summary>
        public const string VF51FETCU2 = "VF51FETCU2";

        /// <summary>
        /// VF51FETCUV.
        /// </summary>
        public const string VF51FETCUV = "VF51FETCUV";

        /// <summary>
        /// VF51FJAHAV.
        /// </summary>
        public const string VF51FJAHAV = "VF51FJAHAV";

        /// <summary>
        /// VF51FJUHUV.
        /// </summary>
        public const string VF51FJUHUV = "VF51FJUHUV";

        /// <summary>
        /// VF51FFBA1.
        /// </summary>
        public const string VF51FFBA1 = "VF51FFBA1";

        /// <summary>
        /// VF51FFBA2.
        /// </summary>
        public const string VF51FFBA2 = "VF51FFBA2";

        /// <summary>
        /// VF51FFBAV.
        /// </summary>
        public const string VF51FFBAV = "VF51FFBAV";

        /// <summary>
        /// VF51FFBU1.
        /// </summary>
        public const string VF51FFBU1 = "VF51FFBU1";

        /// <summary>
        /// VF51FFBU2.
        /// </summary>
        public const string VF51FFBU2 = "VF51FFBU2";

        /// <summary>
        /// VF51FFBUV.
        /// </summary>
        public const string VF51FFBUV = "VF51FFBUV";

        /// <summary>
        /// VF51FPENAV.
        /// </summary>
        public const string VF51FPENAV = "VF51FPENAV";

        /// <summary>
        /// VF51FPENUV.
        /// </summary>
        public const string VF51FPENUV = "VF51FPENUV";

        /// <summary>
        /// VF51FCHGA2.
        /// </summary>
        public const string VF51FCHGA2 = "VF51FCHGA2";

        /// <summary>
        /// VF51FCHGAV.
        /// </summary>
        public const string VF51FCHGAV = "VF51FCHGAV";

        /// <summary>
        /// VF51FCHGU2.
        /// </summary>
        public const string VF51FCHGU2 = "VF51FCHGU2";

        /// <summary>
        /// VF51FCHGUV.
        /// </summary>
        public const string VF51FCHGUV = "VF51FCHGUV";

        /// <summary>
        /// VF51FJA02.
        /// </summary>
        public const string VF51FJA02 = "VF51FJA02";

        /// <summary>
        /// VF51FJAVAR.
        /// </summary>
        public const string VF51FJAVAR = "VF51FJAVAR";

        /// <summary>
        /// VF51FJU02.
        /// </summary>
        public const string VF51FJU02 = "VF51FJU02";

        /// <summary>
        /// VF51FJUVAR.
        /// </summary>
        public const string VF51FJUVAR = "VF51FJUVAR";

        /// <summary>
        /// VF51FFHA.
        /// </summary>
        public const string VF51FFHA = "VF51FFHA";

        /// <summary>
        /// VF51FFHU.
        /// </summary>
        public const string VF51FFHU = "VF51FFHU";

        /// <summary>
        /// VF51FJA03.
        /// </summary>
        public const string VF51FJA03 = "VF51FJA03";

        /// <summary>
        /// VF51FJU03.
        /// </summary>
        public const string VF51FJU03 = "VF51FJU03";

        /// <summary>
        /// VF51FLTVAL.
        /// </summary>
        public const string VF51FLTVAL = "VF51FLTVAL";

        /// <summary>
        /// VF51FLTV2.
        /// </summary>
        public const string VF51FLTV2 = "VF51FLTV2";

        /// <summary>
        /// VF51FLTV3.
        /// </summary>
        public const string VF51FLTV3 = "VF51FLTV3";

        /// <summary>
        /// VF51FLTV4.
        /// </summary>
        public const string VF51FLTV4 = "VF51FLTV4";

        /// <summary>
        /// VF51FLTV5.
        /// </summary>
        public const string VF51FLTV5 = "VF51FLTV5";

        /// <summary>
        /// VF51FLTV6.
        /// </summary>
        public const string VF51FLTV6 = "VF51FLTV6";

        /// <summary>
        /// VF51FLTV7.
        /// </summary>
        public const string VF51FLTV7 = "VF51FLTV7";

        /// <summary>
        /// VF51FLTV8.
        /// </summary>
        public const string VF51FLTV8 = "VF51FLTV8";

        /// <summary>
        /// VF51FLTV9.
        /// </summary>
        public const string VF51FLTV9 = "VF51FLTV9";

        /// <summary>
        /// VF51FLTV10.
        /// </summary>
        public const string VF51FLTV10 = "VF51FLTV10";

        /// <summary>
        /// VF51FFETCA.
        /// </summary>
        public const string VF51FFETCA = "VF51FFETCA";

        /// <summary>
        /// VF51FFETCU.
        /// </summary>
        public const string VF51FFETCU = "VF51FFETCU";

        /// <summary>
        /// VFUKID.
        /// </summary>
        public const string VFUKID = "VFUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F51F30W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VFUSER", "VFUSER", JdeDataType.String, 20, true, true),
        new JdeField("VF51FFID", "VF51FFID", JdeDataType.Numeric, null, true, true),
        new JdeField("VFAID", "VFAID", JdeDataType.String, 16, true, true),
        new JdeField("VF51FAA02", "VF51FAA02", JdeDataType.Numeric),
        new JdeField("VF51FAAVAR", "VF51FAAVAR", JdeDataType.Numeric),
        new JdeField("VF51FAU02", "VF51FAU02", JdeDataType.Numeric),
        new JdeField("VF51FAUVAR", "VF51FAUVAR", JdeDataType.Numeric),
        new JdeField("VF51FPA02", "VF51FPA02", JdeDataType.Numeric),
        new JdeField("VF51FPAVAR", "VF51FPAVAR", JdeDataType.Numeric),
        new JdeField("VF51FPU02", "VF51FPU02", JdeDataType.Numeric),
        new JdeField("VF51FPUVAR", "VF51FPUVAR", JdeDataType.Numeric),
        new JdeField("VF51FBORGA", "VF51FBORGA", JdeDataType.Numeric),
        new JdeField("VF51FBORGU", "VF51FBORGU", JdeDataType.Numeric),
        new JdeField("VF51FHA01", "VF51FHA01", JdeDataType.Numeric),
        new JdeField("VF51FHA02", "VF51FHA02", JdeDataType.Numeric),
        new JdeField("VF51FHAVAR", "VF51FHAVAR", JdeDataType.Numeric),
        new JdeField("VF51FHU01", "VF51FHU01", JdeDataType.Numeric),
        new JdeField("VF51FHU02", "VF51FHU02", JdeDataType.Numeric),
        new JdeField("VF51FHUVAR", "VF51FHUVAR", JdeDataType.Numeric),
        new JdeField("VF51FAAPA1", "VF51FAAPA1", JdeDataType.Numeric),
        new JdeField("VF51FAUPU1", "VF51FAUPU1", JdeDataType.Numeric),
        new JdeField("VF51FREMA1", "VF51FREMA1", JdeDataType.Numeric),
        new JdeField("VF51FREMU1", "VF51FREMU1", JdeDataType.Numeric),
        new JdeField("VF51FPERCP", "VF51FPERCP", JdeDataType.Numeric),
        new JdeField("VF51FPERCU", "VF51FPERCU", JdeDataType.Numeric),
        new JdeField("VF51FEACA2", "VF51FEACA2", JdeDataType.Numeric),
        new JdeField("VF51FEACAV", "VF51FEACAV", JdeDataType.Numeric),
        new JdeField("VF51FEACU2", "VF51FEACU2", JdeDataType.Numeric),
        new JdeField("VF51FEACUV", "VF51FEACUV", JdeDataType.Numeric),
        new JdeField("VF51FTBCA2", "VF51FTBCA2", JdeDataType.Numeric),
        new JdeField("VF51FTBCAV", "VF51FTBCAV", JdeDataType.Numeric),
        new JdeField("VF51FTBCU2", "VF51FTBCU2", JdeDataType.Numeric),
        new JdeField("VF51FTBCUV", "VF51FTBCUV", JdeDataType.Numeric),
        new JdeField("VF51FETCA2", "VF51FETCA2", JdeDataType.Numeric),
        new JdeField("VF51FETCAV", "VF51FETCAV", JdeDataType.Numeric),
        new JdeField("VF51FETCU2", "VF51FETCU2", JdeDataType.Numeric),
        new JdeField("VF51FETCUV", "VF51FETCUV", JdeDataType.Numeric),
        new JdeField("VF51FJAHAV", "VF51FJAHAV", JdeDataType.Numeric),
        new JdeField("VF51FJUHUV", "VF51FJUHUV", JdeDataType.Numeric),
        new JdeField("VF51FFBA1", "VF51FFBA1", JdeDataType.Numeric),
        new JdeField("VF51FFBA2", "VF51FFBA2", JdeDataType.Numeric),
        new JdeField("VF51FFBAV", "VF51FFBAV", JdeDataType.Numeric),
        new JdeField("VF51FFBU1", "VF51FFBU1", JdeDataType.Numeric),
        new JdeField("VF51FFBU2", "VF51FFBU2", JdeDataType.Numeric),
        new JdeField("VF51FFBUV", "VF51FFBUV", JdeDataType.Numeric),
        new JdeField("VF51FPENAV", "VF51FPENAV", JdeDataType.Numeric),
        new JdeField("VF51FPENUV", "VF51FPENUV", JdeDataType.Numeric),
        new JdeField("VF51FCHGA2", "VF51FCHGA2", JdeDataType.Numeric),
        new JdeField("VF51FCHGAV", "VF51FCHGAV", JdeDataType.Numeric),
        new JdeField("VF51FCHGU2", "VF51FCHGU2", JdeDataType.Numeric),
        new JdeField("VF51FCHGUV", "VF51FCHGUV", JdeDataType.Numeric),
        new JdeField("VF51FJA02", "VF51FJA02", JdeDataType.Numeric),
        new JdeField("VF51FJAVAR", "VF51FJAVAR", JdeDataType.Numeric),
        new JdeField("VF51FJU02", "VF51FJU02", JdeDataType.Numeric),
        new JdeField("VF51FJUVAR", "VF51FJUVAR", JdeDataType.Numeric),
        new JdeField("VF51FFHA", "VF51FFHA", JdeDataType.Numeric),
        new JdeField("VF51FFHU", "VF51FFHU", JdeDataType.Numeric),
        new JdeField("VF51FJA03", "VF51FJA03", JdeDataType.Numeric),
        new JdeField("VF51FJU03", "VF51FJU03", JdeDataType.Numeric),
        new JdeField("VF51FLTVAL", "VF51FLTVAL", JdeDataType.Numeric),
        new JdeField("VF51FLTV2", "VF51FLTV2", JdeDataType.Numeric),
        new JdeField("VF51FLTV3", "VF51FLTV3", JdeDataType.Numeric),
        new JdeField("VF51FLTV4", "VF51FLTV4", JdeDataType.Numeric),
        new JdeField("VF51FLTV5", "VF51FLTV5", JdeDataType.Numeric),
        new JdeField("VF51FLTV6", "VF51FLTV6", JdeDataType.Numeric),
        new JdeField("VF51FLTV7", "VF51FLTV7", JdeDataType.Numeric),
        new JdeField("VF51FLTV8", "VF51FLTV8", JdeDataType.Numeric),
        new JdeField("VF51FLTV9", "VF51FLTV9", JdeDataType.Numeric),
        new JdeField("VF51FLTV10", "VF51FLTV10", JdeDataType.Numeric),
        new JdeField("VF51FFETCA", "VF51FFETCA", JdeDataType.Numeric),
        new JdeField("VF51FFETCU", "VF51FFETCU", JdeDataType.Numeric),
        new JdeField("VFUKID", "VFUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F30W_0", "Primary Key on VFUSER, VF51FFID, VFUKID, VFAID", new[] { "VFUSER", "VF51FFID", "VFUKID", "VFAID" }, isUnique: true, isPrimaryKey: true)
    };
}
