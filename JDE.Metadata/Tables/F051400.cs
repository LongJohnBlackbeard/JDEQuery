using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051400 - .
/// </summary>
public class F051400 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SFTBLE.
        /// </summary>
        public const string SFTBLE = "SFTBLE";

        /// <summary>
        /// SFDTAI.
        /// </summary>
        public const string SFDTAI = "SFDTAI";

        /// <summary>
        /// SFCOLSRCH.
        /// </summary>
        public const string SFCOLSRCH = "SFCOLSRCH";

        /// <summary>
        /// SFADSEARCH.
        /// </summary>
        public const string SFADSEARCH = "SFADSEARCH";

        /// <summary>
        /// SFUSER.
        /// </summary>
        public const string SFUSER = "SFUSER";

        /// <summary>
        /// SFPID.
        /// </summary>
        public const string SFPID = "SFPID";

        /// <summary>
        /// SFMKEY.
        /// </summary>
        public const string SFMKEY = "SFMKEY";

        /// <summary>
        /// SFUPMJ.
        /// </summary>
        public const string SFUPMJ = "SFUPMJ";

        /// <summary>
        /// SFUPMT.
        /// </summary>
        public const string SFUPMT = "SFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051400";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SFTBLE", "SFTBLE", JdeDataType.String, 60, true, true),
        new JdeField("SFDTAI", "SFDTAI", JdeDataType.String, 20, true, true),
        new JdeField("SFCOLSRCH", "SFCOLSRCH", JdeDataType.Numeric),
        new JdeField("SFADSEARCH", "SFADSEARCH", JdeDataType.Numeric),
        new JdeField("SFUSER", "SFUSER", JdeDataType.String, 20),
        new JdeField("SFPID", "SFPID", JdeDataType.String, 20),
        new JdeField("SFMKEY", "SFMKEY", JdeDataType.String, 30),
        new JdeField("SFUPMJ", "SFUPMJ", JdeDataType.Numeric),
        new JdeField("SFUPMT", "SFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051400_0", "Primary Key on SFTBLE, SFDTAI", new[] { "SFTBLE", "SFDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
