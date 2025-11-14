using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09E110 - .
/// </summary>
public class F09E110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASPOLICY.
        /// </summary>
        public const string ASPOLICY = "ASPOLICY";

        /// <summary>
        /// ASRULENUM.
        /// </summary>
        public const string ASRULENUM = "ASRULENUM";

        /// <summary>
        /// ASFROMRNG.
        /// </summary>
        public const string ASFROMRNG = "ASFROMRNG";

        /// <summary>
        /// ASTHRURNG.
        /// </summary>
        public const string ASTHRURNG = "ASTHRURNG";

        /// <summary>
        /// ASPERCSEL.
        /// </summary>
        public const string ASPERCSEL = "ASPERCSEL";

        /// <summary>
        /// ASARDISP.
        /// </summary>
        public const string ASARDISP = "ASARDISP";

        /// <summary>
        /// ASEFTB.
        /// </summary>
        public const string ASEFTB = "ASEFTB";

        /// <summary>
        /// ASUSER.
        /// </summary>
        public const string ASUSER = "ASUSER";

        /// <summary>
        /// ASPID.
        /// </summary>
        public const string ASPID = "ASPID";

        /// <summary>
        /// ASJOBN.
        /// </summary>
        public const string ASJOBN = "ASJOBN";

        /// <summary>
        /// ASUPMJ.
        /// </summary>
        public const string ASUPMJ = "ASUPMJ";

        /// <summary>
        /// ASUPMT.
        /// </summary>
        public const string ASUPMT = "ASUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09E110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASPOLICY", "ASPOLICY", JdeDataType.String, 10, true, true),
        new JdeField("ASRULENUM", "ASRULENUM", JdeDataType.Numeric, null, true, true),
        new JdeField("ASFROMRNG", "ASFROMRNG", JdeDataType.Numeric, null, true, true),
        new JdeField("ASTHRURNG", "ASTHRURNG", JdeDataType.Numeric),
        new JdeField("ASPERCSEL", "ASPERCSEL", JdeDataType.Numeric),
        new JdeField("ASARDISP", "ASARDISP", JdeDataType.String, 2),
        new JdeField("ASEFTB", "ASEFTB", JdeDataType.Numeric),
        new JdeField("ASUSER", "ASUSER", JdeDataType.String, 20),
        new JdeField("ASPID", "ASPID", JdeDataType.String, 20),
        new JdeField("ASJOBN", "ASJOBN", JdeDataType.String, 20),
        new JdeField("ASUPMJ", "ASUPMJ", JdeDataType.Numeric),
        new JdeField("ASUPMT", "ASUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09E110_0", "Primary Key on ASPOLICY, ASRULENUM, ASFROMRNG", new[] { "ASPOLICY", "ASRULENUM", "ASFROMRNG" }, isUnique: true, isPrimaryKey: true)
    };
}
