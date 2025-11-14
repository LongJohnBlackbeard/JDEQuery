using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0405 - .
/// </summary>
public class F75A0405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZPPDBA.
        /// </summary>
        public const string ZPPDBA = "ZPPDBA";

        /// <summary>
        /// ZPWKSE.
        /// </summary>
        public const string ZPWKSE = "ZPWKSE";

        /// <summary>
        /// ZPUSER.
        /// </summary>
        public const string ZPUSER = "ZPUSER";

        /// <summary>
        /// ZPPID.
        /// </summary>
        public const string ZPPID = "ZPPID";

        /// <summary>
        /// ZPUPMJ.
        /// </summary>
        public const string ZPUPMJ = "ZPUPMJ";

        /// <summary>
        /// ZPUPMT.
        /// </summary>
        public const string ZPUPMT = "ZPUPMT";

        /// <summary>
        /// ZPJOBN.
        /// </summary>
        public const string ZPJOBN = "ZPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZPPDBA", "ZPPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("ZPWKSE", "ZPWKSE", JdeDataType.String, 6, true, true),
        new JdeField("ZPUSER", "ZPUSER", JdeDataType.String, 20),
        new JdeField("ZPPID", "ZPPID", JdeDataType.String, 20),
        new JdeField("ZPUPMJ", "ZPUPMJ", JdeDataType.Numeric),
        new JdeField("ZPUPMT", "ZPUPMT", JdeDataType.Numeric),
        new JdeField("ZPJOBN", "ZPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0405_0", "Primary Key on ZPPDBA, ZPWKSE", new[] { "ZPPDBA", "ZPWKSE" }, isUnique: true, isPrimaryKey: true)
    };
}
