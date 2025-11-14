using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8021 - .
/// </summary>
public class F76A8021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCSY.
        /// </summary>
        public const string LCSY = "LCSY";

        /// <summary>
        /// LCSVAL.
        /// </summary>
        public const string LCSVAL = "LCSVAL";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCJOBN.
        /// </summary>
        public const string LCJOBN = "LCJOBN";

        /// <summary>
        /// LCTDAY.
        /// </summary>
        public const string LCTDAY = "LCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCSY", "LCSY", JdeDataType.String, 8, true, true),
        new JdeField("LCSVAL", "LCSVAL", JdeDataType.String, 2),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCJOBN", "LCJOBN", JdeDataType.String, 20),
        new JdeField("LCTDAY", "LCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8021_0", "Primary Key on LCSY", new[] { "LCSY" }, isUnique: true, isPrimaryKey: true)
    };
}
