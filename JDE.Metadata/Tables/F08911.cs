using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08911 - .
/// </summary>
public class F08911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HVPAN8.
        /// </summary>
        public const string HVPAN8 = "HVPAN8";

        /// <summary>
        /// HVQE1.
        /// </summary>
        public const string HVQE1 = "HVQE1";

        /// <summary>
        /// HVQD1.
        /// </summary>
        public const string HVQD1 = "HVQD1";

        /// <summary>
        /// HVAN8.
        /// </summary>
        public const string HVAN8 = "HVAN8";

        /// <summary>
        /// HVRPA8.
        /// </summary>
        public const string HVRPA8 = "HVRPA8";

        /// <summary>
        /// HVREL.
        /// </summary>
        public const string HVREL = "HVREL";

        /// <summary>
        /// HVSTSP.
        /// </summary>
        public const string HVSTSP = "HVSTSP";

        /// <summary>
        /// HVDCLS.
        /// </summary>
        public const string HVDCLS = "HVDCLS";

        /// <summary>
        /// HVQDM1.
        /// </summary>
        public const string HVQDM1 = "HVQDM1";

        /// <summary>
        /// HVDCE.
        /// </summary>
        public const string HVDCE = "HVDCE";

        /// <summary>
        /// HVDEXP.
        /// </summary>
        public const string HVDEXP = "HVDEXP";

        /// <summary>
        /// HVDCST.
        /// </summary>
        public const string HVDCST = "HVDCST";

        /// <summary>
        /// HVDCX.
        /// </summary>
        public const string HVDCX = "HVDCX";

        /// <summary>
        /// HVDWV.
        /// </summary>
        public const string HVDWV = "HVDWV";

        /// <summary>
        /// HVDTC.
        /// </summary>
        public const string HVDTC = "HVDTC";

        /// <summary>
        /// HVTRSC.
        /// </summary>
        public const string HVTRSC = "HVTRSC";

        /// <summary>
        /// HVCVP.
        /// </summary>
        public const string HVCVP = "HVCVP";
    }

    /// <inheritdoc />
    public override string TableName => "F08911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HVPAN8", "HVPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HVQE1", "HVQE1", JdeDataType.String, 4, true, true),
        new JdeField("HVQD1", "HVQD1", JdeDataType.Numeric, null, true, true),
        new JdeField("HVAN8", "HVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HVRPA8", "HVRPA8", JdeDataType.Numeric),
        new JdeField("HVREL", "HVREL", JdeDataType.String, 2),
        new JdeField("HVSTSP", "HVSTSP", JdeDataType.String, 6),
        new JdeField("HVDCLS", "HVDCLS", JdeDataType.Numeric),
        new JdeField("HVQDM1", "HVQDM1", JdeDataType.Numeric),
        new JdeField("HVDCE", "HVDCE", JdeDataType.Numeric),
        new JdeField("HVDEXP", "HVDEXP", JdeDataType.Numeric),
        new JdeField("HVDCST", "HVDCST", JdeDataType.Numeric),
        new JdeField("HVDCX", "HVDCX", JdeDataType.Numeric),
        new JdeField("HVDWV", "HVDWV", JdeDataType.Numeric),
        new JdeField("HVDTC", "HVDTC", JdeDataType.Numeric),
        new JdeField("HVTRSC", "HVTRSC", JdeDataType.String, 4),
        new JdeField("HVCVP", "HVCVP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08911_0", "Primary Key on HVPAN8, HVQE1, HVQD1, HVAN8", new[] { "HVPAN8", "HVQE1", "HVQD1", "HVAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
