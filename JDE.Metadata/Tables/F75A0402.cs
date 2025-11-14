using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0402 - .
/// </summary>
public class F75A0402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZFWKSE.
        /// </summary>
        public const string ZFWKSE = "ZFWKSE";

        /// <summary>
        /// ZFAUSPTPFI.
        /// </summary>
        public const string ZFAUSPTPFI = "ZFAUSPTPFI";

        /// <summary>
        /// ZFUSER.
        /// </summary>
        public const string ZFUSER = "ZFUSER";

        /// <summary>
        /// ZFPID.
        /// </summary>
        public const string ZFPID = "ZFPID";

        /// <summary>
        /// ZFUPMJ.
        /// </summary>
        public const string ZFUPMJ = "ZFUPMJ";

        /// <summary>
        /// ZFUPMT.
        /// </summary>
        public const string ZFUPMT = "ZFUPMT";

        /// <summary>
        /// ZFJOBN.
        /// </summary>
        public const string ZFJOBN = "ZFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZFWKSE", "ZFWKSE", JdeDataType.String, 6, true, true),
        new JdeField("ZFAUSPTPFI", "ZFAUSPTPFI", JdeDataType.String, 20, true, true),
        new JdeField("ZFUSER", "ZFUSER", JdeDataType.String, 20),
        new JdeField("ZFPID", "ZFPID", JdeDataType.String, 20),
        new JdeField("ZFUPMJ", "ZFUPMJ", JdeDataType.Numeric),
        new JdeField("ZFUPMT", "ZFUPMT", JdeDataType.Numeric),
        new JdeField("ZFJOBN", "ZFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0402_0", "Primary Key on ZFWKSE, ZFAUSPTPFI", new[] { "ZFWKSE", "ZFAUSPTPFI" }, isUnique: true, isPrimaryKey: true)
    };
}
