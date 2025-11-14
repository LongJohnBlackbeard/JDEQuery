using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E21WF - .
/// </summary>
public class F43E21WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SUUSER.
        /// </summary>
        public const string SUUSER = "SUUSER";

        /// <summary>
        /// SUCOOKIE.
        /// </summary>
        public const string SUCOOKIE = "SUCOOKIE";

        /// <summary>
        /// SULNID.
        /// </summary>
        public const string SULNID = "SULNID";

        /// <summary>
        /// SUITEMURL.
        /// </summary>
        public const string SUITEMURL = "SUITEMURL";
    }

    /// <inheritdoc />
    public override string TableName => "F43E21WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SUUSER", "SUUSER", JdeDataType.String, 20, true, true),
        new JdeField("SUCOOKIE", "SUCOOKIE", JdeDataType.String, 400, true, true),
        new JdeField("SULNID", "SULNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SUITEMURL", "SUITEMURL", JdeDataType.String)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E21WF_0", "Primary Key on SUUSER, SUCOOKIE, SULNID", new[] { "SUUSER", "SUCOOKIE", "SULNID" }, isUnique: true, isPrimaryKey: true)
    };
}
