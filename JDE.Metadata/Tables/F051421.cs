using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051421 - .
/// </summary>
public class F051421 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WIKEYWORD.
        /// </summary>
        public const string WIKEYWORD = "WIKEYWORD";

        /// <summary>
        /// WILNGP.
        /// </summary>
        public const string WILNGP = "WILNGP";

        /// <summary>
        /// WIWORDID.
        /// </summary>
        public const string WIWORDID = "WIWORDID";

        /// <summary>
        /// WIUSER.
        /// </summary>
        public const string WIUSER = "WIUSER";

        /// <summary>
        /// WIPID.
        /// </summary>
        public const string WIPID = "WIPID";

        /// <summary>
        /// WIMKEY.
        /// </summary>
        public const string WIMKEY = "WIMKEY";

        /// <summary>
        /// WIUPMJ.
        /// </summary>
        public const string WIUPMJ = "WIUPMJ";

        /// <summary>
        /// WIUPMT.
        /// </summary>
        public const string WIUPMT = "WIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051421";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WIKEYWORD", "WIKEYWORD", JdeDataType.String, 200, true, true),
        new JdeField("WILNGP", "WILNGP", JdeDataType.String, 4, true, true),
        new JdeField("WIWORDID", "WIWORDID", JdeDataType.Numeric),
        new JdeField("WIUSER", "WIUSER", JdeDataType.String, 20),
        new JdeField("WIPID", "WIPID", JdeDataType.String, 20),
        new JdeField("WIMKEY", "WIMKEY", JdeDataType.String, 30),
        new JdeField("WIUPMJ", "WIUPMJ", JdeDataType.Numeric),
        new JdeField("WIUPMT", "WIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051421_0", "Primary Key on WIKEYWORD, WILNGP", new[] { "WIKEYWORD", "WILNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F051421_2", "Index on WIWORDID, WIKEYWORD, WILNGP", new[] { "WIWORDID", "WIKEYWORD", "WILNGP" })
    };
}
