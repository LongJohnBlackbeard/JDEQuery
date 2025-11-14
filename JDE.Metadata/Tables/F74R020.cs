using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R020 - .
/// </summary>
public class F74R020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GCSY.
        /// </summary>
        public const string GCSY = "GCSY";

        /// <summary>
        /// GCR74IPGC.
        /// </summary>
        public const string GCR74IPGC = "GCR74IPGC";

        /// <summary>
        /// GCUSER.
        /// </summary>
        public const string GCUSER = "GCUSER";

        /// <summary>
        /// GCPID.
        /// </summary>
        public const string GCPID = "GCPID";

        /// <summary>
        /// GCUPMJ.
        /// </summary>
        public const string GCUPMJ = "GCUPMJ";

        /// <summary>
        /// GCUPMT.
        /// </summary>
        public const string GCUPMT = "GCUPMT";

        /// <summary>
        /// GCJOBN.
        /// </summary>
        public const string GCJOBN = "GCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74R020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GCSY", "GCSY", JdeDataType.String, 8, true, true),
        new JdeField("GCR74IPGC", "GCR74IPGC", JdeDataType.Numeric),
        new JdeField("GCUSER", "GCUSER", JdeDataType.String, 20),
        new JdeField("GCPID", "GCPID", JdeDataType.String, 20),
        new JdeField("GCUPMJ", "GCUPMJ", JdeDataType.Numeric),
        new JdeField("GCUPMT", "GCUPMT", JdeDataType.Numeric),
        new JdeField("GCJOBN", "GCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R020_0", "Primary Key on GCSY", new[] { "GCSY" }, isUnique: true, isPrimaryKey: true)
    };
}
