using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R5010 - .
/// </summary>
public class F74R5010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCCO.
        /// </summary>
        public const string RCCO = "RCCO";

        /// <summary>
        /// RCACL1.
        /// </summary>
        public const string RCACL1 = "RCACL1";

        /// <summary>
        /// RCACL2.
        /// </summary>
        public const string RCACL2 = "RCACL2";

        /// <summary>
        /// RCRVCD.
        /// </summary>
        public const string RCRVCD = "RCRVCD";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCUPMT.
        /// </summary>
        public const string RCUPMT = "RCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R5010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCCO", "RCCO", JdeDataType.String, 10, true, true),
        new JdeField("RCACL1", "RCACL1", JdeDataType.String, 6, true, true),
        new JdeField("RCACL2", "RCACL2", JdeDataType.String, 6, true, true),
        new JdeField("RCRVCD", "RCRVCD", JdeDataType.String, 6),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCUPMT", "RCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R5010_0", "Primary Key on RCCO, RCACL1, RCACL2", new[] { "RCCO", "RCACL1", "RCACL2" }, isUnique: true, isPrimaryKey: true)
    };
}
