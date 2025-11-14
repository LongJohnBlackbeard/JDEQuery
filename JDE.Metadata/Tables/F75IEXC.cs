using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IEXC - .
/// </summary>
public class F75IEXC : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QZYEXU.
        /// </summary>
        public const string QZYEXU = "QZYEXU";

        /// <summary>
        /// QZYRM.
        /// </summary>
        public const string QZYRM = "QZYRM";

        /// <summary>
        /// QZMNTH.
        /// </summary>
        public const string QZMNTH = "QZMNTH";

        /// <summary>
        /// QZUSER.
        /// </summary>
        public const string QZUSER = "QZUSER";

        /// <summary>
        /// QZJOBN.
        /// </summary>
        public const string QZJOBN = "QZJOBN";

        /// <summary>
        /// QZUPMJ.
        /// </summary>
        public const string QZUPMJ = "QZUPMJ";

        /// <summary>
        /// QZTDAY.
        /// </summary>
        public const string QZTDAY = "QZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75IEXC";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QZYEXU", "QZYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("QZYRM", "QZYRM", JdeDataType.Numeric, null, true, true),
        new JdeField("QZMNTH", "QZMNTH", JdeDataType.Numeric, null, true, true),
        new JdeField("QZUSER", "QZUSER", JdeDataType.String, 20),
        new JdeField("QZJOBN", "QZJOBN", JdeDataType.String, 20),
        new JdeField("QZUPMJ", "QZUPMJ", JdeDataType.Numeric),
        new JdeField("QZTDAY", "QZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IEXC_0", "Primary Key on QZYEXU, QZYRM, QZMNTH", new[] { "QZYEXU", "QZYRM", "QZMNTH" }, isUnique: true, isPrimaryKey: true)
    };
}
