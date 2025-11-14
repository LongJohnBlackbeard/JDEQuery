using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N0300 - .
/// </summary>
public class FD3N0300 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APDTI1.
        /// </summary>
        public const string APDTI1 = "APDTI1";

        /// <summary>
        /// APDSE.
        /// </summary>
        public const string APDSE = "APDSE";

        /// <summary>
        /// APDEE.
        /// </summary>
        public const string APDEE = "APDEE";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N0300";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APDTI1", "APDTI1", JdeDataType.String, 20, true, true),
        new JdeField("APDSE", "APDSE", JdeDataType.Numeric),
        new JdeField("APDEE", "APDEE", JdeDataType.Numeric),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N0300_0", "Primary Key on APDTI1", new[] { "APDTI1" }, isUnique: true, isPrimaryKey: true)
    };
}
