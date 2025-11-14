using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085574 - .
/// </summary>
public class F085574 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MIEVET.
        /// </summary>
        public const string MIEVET = "MIEVET";

        /// <summary>
        /// MIDIVC.
        /// </summary>
        public const string MIDIVC = "MIDIVC";

        /// <summary>
        /// MISBGR.
        /// </summary>
        public const string MISBGR = "MISBGR";

        /// <summary>
        /// MIPLAN.
        /// </summary>
        public const string MIPLAN = "MIPLAN";

        /// <summary>
        /// MIAOPT.
        /// </summary>
        public const string MIAOPT = "MIAOPT";

        /// <summary>
        /// MIICRAMT.
        /// </summary>
        public const string MIICRAMT = "MIICRAMT";

        /// <summary>
        /// MIUSER.
        /// </summary>
        public const string MIUSER = "MIUSER";

        /// <summary>
        /// MIPID.
        /// </summary>
        public const string MIPID = "MIPID";

        /// <summary>
        /// MIJOBN.
        /// </summary>
        public const string MIJOBN = "MIJOBN";

        /// <summary>
        /// MIUPMJ.
        /// </summary>
        public const string MIUPMJ = "MIUPMJ";

        /// <summary>
        /// MIUPMT.
        /// </summary>
        public const string MIUPMT = "MIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F085574";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MIEVET", "MIEVET", JdeDataType.Numeric, null, true, true),
        new JdeField("MIDIVC", "MIDIVC", JdeDataType.String, 12, true, true),
        new JdeField("MISBGR", "MISBGR", JdeDataType.String, 20, true, true),
        new JdeField("MIPLAN", "MIPLAN", JdeDataType.String, 16, true, true),
        new JdeField("MIAOPT", "MIAOPT", JdeDataType.String, 6, true, true),
        new JdeField("MIICRAMT", "MIICRAMT", JdeDataType.Numeric),
        new JdeField("MIUSER", "MIUSER", JdeDataType.String, 20),
        new JdeField("MIPID", "MIPID", JdeDataType.String, 20),
        new JdeField("MIJOBN", "MIJOBN", JdeDataType.String, 20),
        new JdeField("MIUPMJ", "MIUPMJ", JdeDataType.Numeric),
        new JdeField("MIUPMT", "MIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085574_0", "Primary Key on MIEVET, MIDIVC, MISBGR, MIPLAN, MIAOPT", new[] { "MIEVET", "MIDIVC", "MISBGR", "MIPLAN", "MIAOPT" }, isUnique: true, isPrimaryKey: true)
    };
}
