using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA030 - .
/// </summary>
public class F90CA030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRLNID.
        /// </summary>
        public const string PRLNID = "PRLNID";

        /// <summary>
        /// PRPROFCU1.
        /// </summary>
        public const string PRPROFCU1 = "PRPROFCU1";

        /// <summary>
        /// PRPROFCU2.
        /// </summary>
        public const string PRPROFCU2 = "PRPROFCU2";

        /// <summary>
        /// PRPROFCU3.
        /// </summary>
        public const string PRPROFCU3 = "PRPROFCU3";

        /// <summary>
        /// PRPROFCU4.
        /// </summary>
        public const string PRPROFCU4 = "PRPROFCU4";

        /// <summary>
        /// PRPROFCU5.
        /// </summary>
        public const string PRPROFCU5 = "PRPROFCU5";

        /// <summary>
        /// PRPROFCU6.
        /// </summary>
        public const string PRPROFCU6 = "PRPROFCU6";

        /// <summary>
        /// PRPROFCU7.
        /// </summary>
        public const string PRPROFCU7 = "PRPROFCU7";

        /// <summary>
        /// PRPROFCU8.
        /// </summary>
        public const string PRPROFCU8 = "PRPROFCU8";

        /// <summary>
        /// PRPROFCU9.
        /// </summary>
        public const string PRPROFCU9 = "PRPROFCU9";

        /// <summary>
        /// PRPROFCU10.
        /// </summary>
        public const string PRPROFCU10 = "PRPROFCU10";

        /// <summary>
        /// PRPROFCU11.
        /// </summary>
        public const string PRPROFCU11 = "PRPROFCU11";

        /// <summary>
        /// PRPROFCU12.
        /// </summary>
        public const string PRPROFCU12 = "PRPROFCU12";

        /// <summary>
        /// PRPROFCU13.
        /// </summary>
        public const string PRPROFCU13 = "PRPROFCU13";

        /// <summary>
        /// PRPROFCU14.
        /// </summary>
        public const string PRPROFCU14 = "PRPROFCU14";

        /// <summary>
        /// PRPROFCU15.
        /// </summary>
        public const string PRPROFCU15 = "PRPROFCU15";

        /// <summary>
        /// PRPROFCU16.
        /// </summary>
        public const string PRPROFCU16 = "PRPROFCU16";

        /// <summary>
        /// PRPROFCU17.
        /// </summary>
        public const string PRPROFCU17 = "PRPROFCU17";

        /// <summary>
        /// PRPROFCU18.
        /// </summary>
        public const string PRPROFCU18 = "PRPROFCU18";

        /// <summary>
        /// PRPROFCU19.
        /// </summary>
        public const string PRPROFCU19 = "PRPROFCU19";

        /// <summary>
        /// PRPROFCU20.
        /// </summary>
        public const string PRPROFCU20 = "PRPROFCU20";

        /// <summary>
        /// PRPROFCO1.
        /// </summary>
        public const string PRPROFCO1 = "PRPROFCO1";

        /// <summary>
        /// PRPROFCO2.
        /// </summary>
        public const string PRPROFCO2 = "PRPROFCO2";

        /// <summary>
        /// PRPROFCO3.
        /// </summary>
        public const string PRPROFCO3 = "PRPROFCO3";

        /// <summary>
        /// PRPROFCO4.
        /// </summary>
        public const string PRPROFCO4 = "PRPROFCO4";

        /// <summary>
        /// PRPROFCO5.
        /// </summary>
        public const string PRPROFCO5 = "PRPROFCO5";

        /// <summary>
        /// PRPROFCO6.
        /// </summary>
        public const string PRPROFCO6 = "PRPROFCO6";

        /// <summary>
        /// PRPROFCO7.
        /// </summary>
        public const string PRPROFCO7 = "PRPROFCO7";

        /// <summary>
        /// PRPROFCO8.
        /// </summary>
        public const string PRPROFCO8 = "PRPROFCO8";

        /// <summary>
        /// PRPROFCO9.
        /// </summary>
        public const string PRPROFCO9 = "PRPROFCO9";

        /// <summary>
        /// PRPROFCO10.
        /// </summary>
        public const string PRPROFCO10 = "PRPROFCO10";

        /// <summary>
        /// PRPROFCO11.
        /// </summary>
        public const string PRPROFCO11 = "PRPROFCO11";

        /// <summary>
        /// PRPROFCO12.
        /// </summary>
        public const string PRPROFCO12 = "PRPROFCO12";

        /// <summary>
        /// PRPROFCO13.
        /// </summary>
        public const string PRPROFCO13 = "PRPROFCO13";

        /// <summary>
        /// PRPROFCO14.
        /// </summary>
        public const string PRPROFCO14 = "PRPROFCO14";

        /// <summary>
        /// PRPROFCO15.
        /// </summary>
        public const string PRPROFCO15 = "PRPROFCO15";

        /// <summary>
        /// PRPROFCO16.
        /// </summary>
        public const string PRPROFCO16 = "PRPROFCO16";

        /// <summary>
        /// PRPROFCO17.
        /// </summary>
        public const string PRPROFCO17 = "PRPROFCO17";

        /// <summary>
        /// PRPROFCO18.
        /// </summary>
        public const string PRPROFCO18 = "PRPROFCO18";

        /// <summary>
        /// PRPROFCO19.
        /// </summary>
        public const string PRPROFCO19 = "PRPROFCO19";

        /// <summary>
        /// PRPROFCO20.
        /// </summary>
        public const string PRPROFCO20 = "PRPROFCO20";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRVID.
        /// </summary>
        public const string PRVID = "PRVID";

        /// <summary>
        /// PRUDTTM.
        /// </summary>
        public const string PRUDTTM = "PRUDTTM";

        /// <summary>
        /// PRMKEY.
        /// </summary>
        public const string PRMKEY = "PRMKEY";

        /// <summary>
        /// PRDTEE.
        /// </summary>
        public const string PRDTEE = "PRDTEE";

        /// <summary>
        /// PRENTRD.
        /// </summary>
        public const string PRENTRD = "PRENTRD";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PRLNID", "PRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRPROFCU1", "PRPROFCU1", JdeDataType.String, 20),
        new JdeField("PRPROFCU2", "PRPROFCU2", JdeDataType.String, 20),
        new JdeField("PRPROFCU3", "PRPROFCU3", JdeDataType.String, 20),
        new JdeField("PRPROFCU4", "PRPROFCU4", JdeDataType.String, 20),
        new JdeField("PRPROFCU5", "PRPROFCU5", JdeDataType.String, 20),
        new JdeField("PRPROFCU6", "PRPROFCU6", JdeDataType.String, 20),
        new JdeField("PRPROFCU7", "PRPROFCU7", JdeDataType.String, 20),
        new JdeField("PRPROFCU8", "PRPROFCU8", JdeDataType.String, 20),
        new JdeField("PRPROFCU9", "PRPROFCU9", JdeDataType.String, 20),
        new JdeField("PRPROFCU10", "PRPROFCU10", JdeDataType.String, 20),
        new JdeField("PRPROFCU11", "PRPROFCU11", JdeDataType.String, 20),
        new JdeField("PRPROFCU12", "PRPROFCU12", JdeDataType.String, 20),
        new JdeField("PRPROFCU13", "PRPROFCU13", JdeDataType.String, 20),
        new JdeField("PRPROFCU14", "PRPROFCU14", JdeDataType.String, 20),
        new JdeField("PRPROFCU15", "PRPROFCU15", JdeDataType.String, 20),
        new JdeField("PRPROFCU16", "PRPROFCU16", JdeDataType.String, 100),
        new JdeField("PRPROFCU17", "PRPROFCU17", JdeDataType.String, 100),
        new JdeField("PRPROFCU18", "PRPROFCU18", JdeDataType.String, 100),
        new JdeField("PRPROFCU19", "PRPROFCU19", JdeDataType.String, 100),
        new JdeField("PRPROFCU20", "PRPROFCU20", JdeDataType.String, 100),
        new JdeField("PRPROFCO1", "PRPROFCO1", JdeDataType.String, 20),
        new JdeField("PRPROFCO2", "PRPROFCO2", JdeDataType.String, 20),
        new JdeField("PRPROFCO3", "PRPROFCO3", JdeDataType.String, 20),
        new JdeField("PRPROFCO4", "PRPROFCO4", JdeDataType.String, 20),
        new JdeField("PRPROFCO5", "PRPROFCO5", JdeDataType.String, 20),
        new JdeField("PRPROFCO6", "PRPROFCO6", JdeDataType.String, 20),
        new JdeField("PRPROFCO7", "PRPROFCO7", JdeDataType.String, 20),
        new JdeField("PRPROFCO8", "PRPROFCO8", JdeDataType.String, 20),
        new JdeField("PRPROFCO9", "PRPROFCO9", JdeDataType.String, 20),
        new JdeField("PRPROFCO10", "PRPROFCO10", JdeDataType.String, 20),
        new JdeField("PRPROFCO11", "PRPROFCO11", JdeDataType.String, 20),
        new JdeField("PRPROFCO12", "PRPROFCO12", JdeDataType.String, 20),
        new JdeField("PRPROFCO13", "PRPROFCO13", JdeDataType.String, 20),
        new JdeField("PRPROFCO14", "PRPROFCO14", JdeDataType.String, 20),
        new JdeField("PRPROFCO15", "PRPROFCO15", JdeDataType.String, 20),
        new JdeField("PRPROFCO16", "PRPROFCO16", JdeDataType.String, 100),
        new JdeField("PRPROFCO17", "PRPROFCO17", JdeDataType.String, 100),
        new JdeField("PRPROFCO18", "PRPROFCO18", JdeDataType.String, 100),
        new JdeField("PRPROFCO19", "PRPROFCO19", JdeDataType.String, 100),
        new JdeField("PRPROFCO20", "PRPROFCO20", JdeDataType.String, 100),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRVID", "PRVID", JdeDataType.String, 20),
        new JdeField("PRUDTTM", "PRUDTTM", JdeDataType.Date),
        new JdeField("PRMKEY", "PRMKEY", JdeDataType.String, 30),
        new JdeField("PRDTEE", "PRDTEE", JdeDataType.Date),
        new JdeField("PRENTRD", "PRENTRD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA030_0", "Primary Key on PRAN8, PRLNID", new[] { "PRAN8", "PRLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
