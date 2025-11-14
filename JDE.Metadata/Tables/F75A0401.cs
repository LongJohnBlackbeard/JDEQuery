using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0401 - .
/// </summary>
public class F75A0401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZTAUSPTSED.
        /// </summary>
        public const string ZTAUSPTSED = "ZTAUSPTSED";

        /// <summary>
        /// ZTAUSPTEED.
        /// </summary>
        public const string ZTAUSPTEED = "ZTAUSPTEED";

        /// <summary>
        /// ZTWKSE.
        /// </summary>
        public const string ZTWKSE = "ZTWKSE";

        /// <summary>
        /// ZTAUSPTMTR.
        /// </summary>
        public const string ZTAUSPTMTR = "ZTAUSPTMTR";

        /// <summary>
        /// ZTAUSPTTRS.
        /// </summary>
        public const string ZTAUSPTTRS = "ZTAUSPTTRS";

        /// <summary>
        /// ZTAUSPTRTE.
        /// </summary>
        public const string ZTAUSPTRTE = "ZTAUSPTRTE";

        /// <summary>
        /// ZTAUSPTMTM.
        /// </summary>
        public const string ZTAUSPTMTM = "ZTAUSPTMTM";

        /// <summary>
        /// ZTAUSPTATM.
        /// </summary>
        public const string ZTAUSPTATM = "ZTAUSPTATM";

        /// <summary>
        /// ZTUSER.
        /// </summary>
        public const string ZTUSER = "ZTUSER";

        /// <summary>
        /// ZTPID.
        /// </summary>
        public const string ZTPID = "ZTPID";

        /// <summary>
        /// ZTUPMJ.
        /// </summary>
        public const string ZTUPMJ = "ZTUPMJ";

        /// <summary>
        /// ZTUPMT.
        /// </summary>
        public const string ZTUPMT = "ZTUPMT";

        /// <summary>
        /// ZTJOBN.
        /// </summary>
        public const string ZTJOBN = "ZTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZTAUSPTSED", "ZTAUSPTSED", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTAUSPTEED", "ZTAUSPTEED", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTWKSE", "ZTWKSE", JdeDataType.String, 6, true, true),
        new JdeField("ZTAUSPTMTR", "ZTAUSPTMTR", JdeDataType.Numeric),
        new JdeField("ZTAUSPTTRS", "ZTAUSPTTRS", JdeDataType.Numeric),
        new JdeField("ZTAUSPTRTE", "ZTAUSPTRTE", JdeDataType.Numeric),
        new JdeField("ZTAUSPTMTM", "ZTAUSPTMTM", JdeDataType.Numeric),
        new JdeField("ZTAUSPTATM", "ZTAUSPTATM", JdeDataType.Numeric),
        new JdeField("ZTUSER", "ZTUSER", JdeDataType.String, 20),
        new JdeField("ZTPID", "ZTPID", JdeDataType.String, 20),
        new JdeField("ZTUPMJ", "ZTUPMJ", JdeDataType.Numeric),
        new JdeField("ZTUPMT", "ZTUPMT", JdeDataType.Numeric),
        new JdeField("ZTJOBN", "ZTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0401_0", "Primary Key on ZTAUSPTSED, ZTAUSPTEED, ZTWKSE", new[] { "ZTAUSPTSED", "ZTAUSPTEED", "ZTWKSE" }, isUnique: true, isPrimaryKey: true)
    };
}
