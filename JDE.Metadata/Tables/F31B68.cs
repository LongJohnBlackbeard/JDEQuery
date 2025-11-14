using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B68 - .
/// </summary>
public class F31B68 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROWOPID.
        /// </summary>
        public const string ROWOPID = "ROWOPID";

        /// <summary>
        /// ROWVID.
        /// </summary>
        public const string ROWVID = "ROWVID";

        /// <summary>
        /// ROWRLNID.
        /// </summary>
        public const string ROWRLNID = "ROWRLNID";

        /// <summary>
        /// ROWOPRC.
        /// </summary>
        public const string ROWOPRC = "ROWOPRC";

        /// <summary>
        /// ROWALOTN.
        /// </summary>
        public const string ROWALOTN = "ROWALOTN";

        /// <summary>
        /// ROUSER.
        /// </summary>
        public const string ROUSER = "ROUSER";

        /// <summary>
        /// ROPID.
        /// </summary>
        public const string ROPID = "ROPID";

        /// <summary>
        /// ROJOBN.
        /// </summary>
        public const string ROJOBN = "ROJOBN";

        /// <summary>
        /// ROUPMJ.
        /// </summary>
        public const string ROUPMJ = "ROUPMJ";

        /// <summary>
        /// ROTDAY.
        /// </summary>
        public const string ROTDAY = "ROTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B68";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROWOPID", "ROWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("ROWVID", "ROWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("ROWRLNID", "ROWRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ROWOPRC", "ROWOPRC", JdeDataType.String, 60),
        new JdeField("ROWALOTN", "ROWALOTN", JdeDataType.String, 60),
        new JdeField("ROUSER", "ROUSER", JdeDataType.String, 20),
        new JdeField("ROPID", "ROPID", JdeDataType.String, 20),
        new JdeField("ROJOBN", "ROJOBN", JdeDataType.String, 20),
        new JdeField("ROUPMJ", "ROUPMJ", JdeDataType.Numeric),
        new JdeField("ROTDAY", "ROTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B68_0", "Primary Key on ROWOPID, ROWVID, ROWRLNID", new[] { "ROWOPID", "ROWVID", "ROWRLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
