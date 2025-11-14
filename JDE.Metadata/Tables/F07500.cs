using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07500 - .
/// </summary>
public class F07500 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GCSCOD.
        /// </summary>
        public const string GCSCOD = "GCSCOD";

        /// <summary>
        /// GCTARA.
        /// </summary>
        public const string GCTARA = "GCTARA";

        /// <summary>
        /// GCDL01.
        /// </summary>
        public const string GCDL01 = "GCDL01";

        /// <summary>
        /// GCSTRNH.
        /// </summary>
        public const string GCSTRNH = "GCSTRNH";

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

        /// <summary>
        /// GCUSER.
        /// </summary>
        public const string GCUSER = "GCUSER";

        /// <summary>
        /// GCPID.
        /// </summary>
        public const string GCPID = "GCPID";
    }

    /// <inheritdoc />
    public override string TableName => "F07500";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GCSCOD", "GCSCOD", JdeDataType.String, 6, true, true),
        new JdeField("GCTARA", "GCTARA", JdeDataType.String, 20),
        new JdeField("GCDL01", "GCDL01", JdeDataType.String, 60),
        new JdeField("GCSTRNH", "GCSTRNH", JdeDataType.String, 2),
        new JdeField("GCUPMJ", "GCUPMJ", JdeDataType.Numeric),
        new JdeField("GCUPMT", "GCUPMT", JdeDataType.Numeric),
        new JdeField("GCJOBN", "GCJOBN", JdeDataType.String, 20),
        new JdeField("GCUSER", "GCUSER", JdeDataType.String, 20),
        new JdeField("GCPID", "GCPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07500_0", "Primary Key on GCSCOD", new[] { "GCSCOD" }, isUnique: true, isPrimaryKey: true)
    };
}
