using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F012504 - .
/// </summary>
public class F012504 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FOAN81.
        /// </summary>
        public const string FOAN81 = "FOAN81";

        /// <summary>
        /// FOMCC.
        /// </summary>
        public const string FOMCC = "FOMCC";

        /// <summary>
        /// FOAN82.
        /// </summary>
        public const string FOAN82 = "FOAN82";

        /// <summary>
        /// FOGREG1.
        /// </summary>
        public const string FOGREG1 = "FOGREG1";

        /// <summary>
        /// FOGREG2.
        /// </summary>
        public const string FOGREG2 = "FOGREG2";

        /// <summary>
        /// FOGNNM.
        /// </summary>
        public const string FOGNNM = "FOGNNM";

        /// <summary>
        /// FOSRNM.
        /// </summary>
        public const string FOSRNM = "FOSRNM";

        /// <summary>
        /// FOATTL.
        /// </summary>
        public const string FOATTL = "FOATTL";

        /// <summary>
        /// FOCPN1.
        /// </summary>
        public const string FOCPN1 = "FOCPN1";

        /// <summary>
        /// FOCTY1.
        /// </summary>
        public const string FOCTY1 = "FOCTY1";

        /// <summary>
        /// FOADDS.
        /// </summary>
        public const string FOADDS = "FOADDS";

        /// <summary>
        /// FOAA20.
        /// </summary>
        public const string FOAA20 = "FOAA20";

        /// <summary>
        /// FOPH1.
        /// </summary>
        public const string FOPH1 = "FOPH1";

        /// <summary>
        /// FOEMAL.
        /// </summary>
        public const string FOEMAL = "FOEMAL";

        /// <summary>
        /// FOEV01.
        /// </summary>
        public const string FOEV01 = "FOEV01";

        /// <summary>
        /// FOADD1.
        /// </summary>
        public const string FOADD1 = "FOADD1";

        /// <summary>
        /// FOADD2.
        /// </summary>
        public const string FOADD2 = "FOADD2";

        /// <summary>
        /// FOADD3.
        /// </summary>
        public const string FOADD3 = "FOADD3";

        /// <summary>
        /// FOADD4.
        /// </summary>
        public const string FOADD4 = "FOADD4";

        /// <summary>
        /// FOADD5.
        /// </summary>
        public const string FOADD5 = "FOADD5";
    }

    /// <inheritdoc />
    public override string TableName => "F012504";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FOAN81", "FOAN81", JdeDataType.Numeric, null, true, true),
        new JdeField("FOMCC", "FOMCC", JdeDataType.String, 144),
        new JdeField("FOAN82", "FOAN82", JdeDataType.Numeric),
        new JdeField("FOGREG1", "FOGREG1", JdeDataType.String, 10),
        new JdeField("FOGREG2", "FOGREG2", JdeDataType.String, 10),
        new JdeField("FOGNNM", "FOGNNM", JdeDataType.String, 50),
        new JdeField("FOSRNM", "FOSRNM", JdeDataType.String, 50),
        new JdeField("FOATTL", "FOATTL", JdeDataType.String, 80),
        new JdeField("FOCPN1", "FOCPN1", JdeDataType.String, 80),
        new JdeField("FOCTY1", "FOCTY1", JdeDataType.String, 50),
        new JdeField("FOADDS", "FOADDS", JdeDataType.String, 6),
        new JdeField("FOAA20", "FOAA20", JdeDataType.String, 40),
        new JdeField("FOPH1", "FOPH1", JdeDataType.String, 40),
        new JdeField("FOEMAL", "FOEMAL", JdeDataType.String, 512),
        new JdeField("FOEV01", "FOEV01", JdeDataType.String, 2),
        new JdeField("FOADD1", "FOADD1", JdeDataType.String, 80),
        new JdeField("FOADD2", "FOADD2", JdeDataType.String, 80),
        new JdeField("FOADD3", "FOADD3", JdeDataType.String, 80),
        new JdeField("FOADD4", "FOADD4", JdeDataType.String, 80),
        new JdeField("FOADD5", "FOADD5", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F012504_0", "Primary Key on FOAN81", new[] { "FOAN81" }, isUnique: true, isPrimaryKey: true)
    };
}
