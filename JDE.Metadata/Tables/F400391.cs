using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F400391 - .
/// </summary>
public class F400391 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DEDCT.
        /// </summary>
        public const string DEDCT = "DEDCT";

        /// <summary>
        /// DEMCU.
        /// </summary>
        public const string DEMCU = "DEMCU";

        /// <summary>
        /// DEEIHU.
        /// </summary>
        public const string DEEIHU = "DEEIHU";

        /// <summary>
        /// DEUSER.
        /// </summary>
        public const string DEUSER = "DEUSER";

        /// <summary>
        /// DEUPMJ.
        /// </summary>
        public const string DEUPMJ = "DEUPMJ";

        /// <summary>
        /// DEUPMT.
        /// </summary>
        public const string DEUPMT = "DEUPMT";

        /// <summary>
        /// DEJOBN.
        /// </summary>
        public const string DEJOBN = "DEJOBN";

        /// <summary>
        /// DEMKEY.
        /// </summary>
        public const string DEMKEY = "DEMKEY";

        /// <summary>
        /// DEPID.
        /// </summary>
        public const string DEPID = "DEPID";
    }

    /// <inheritdoc />
    public override string TableName => "F400391";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DEDCT", "DEDCT", JdeDataType.String, 4, true, true),
        new JdeField("DEMCU", "DEMCU", JdeDataType.String, 24, true, true),
        new JdeField("DEEIHU", "DEEIHU", JdeDataType.String, 2),
        new JdeField("DEUSER", "DEUSER", JdeDataType.String, 20),
        new JdeField("DEUPMJ", "DEUPMJ", JdeDataType.Numeric),
        new JdeField("DEUPMT", "DEUPMT", JdeDataType.Numeric),
        new JdeField("DEJOBN", "DEJOBN", JdeDataType.String, 20),
        new JdeField("DEMKEY", "DEMKEY", JdeDataType.String, 30),
        new JdeField("DEPID", "DEPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F400391_0", "Primary Key on DEDCT, DEMCU", new[] { "DEDCT", "DEMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
