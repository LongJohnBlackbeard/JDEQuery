using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08474 - .
/// </summary>
public class F08474 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JBNURC.
        /// </summary>
        public const string JBNURC = "JBNURC";

        /// <summary>
        /// JBPSTNO.
        /// </summary>
        public const string JBPSTNO = "JBPSTNO";

        /// <summary>
        /// JBPID.
        /// </summary>
        public const string JBPID = "JBPID";

        /// <summary>
        /// JBUSER.
        /// </summary>
        public const string JBUSER = "JBUSER";

        /// <summary>
        /// JBMKEY.
        /// </summary>
        public const string JBMKEY = "JBMKEY";

        /// <summary>
        /// JBUPMJ.
        /// </summary>
        public const string JBUPMJ = "JBUPMJ";

        /// <summary>
        /// JBUPMT.
        /// </summary>
        public const string JBUPMT = "JBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08474";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JBNURC", "JBNURC", JdeDataType.Numeric, null, true, true),
        new JdeField("JBPSTNO", "JBPSTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("JBPID", "JBPID", JdeDataType.String, 20),
        new JdeField("JBUSER", "JBUSER", JdeDataType.String, 20),
        new JdeField("JBMKEY", "JBMKEY", JdeDataType.String, 30),
        new JdeField("JBUPMJ", "JBUPMJ", JdeDataType.Numeric),
        new JdeField("JBUPMT", "JBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08474_0", "Primary Key on JBNURC, JBPSTNO", new[] { "JBNURC", "JBPSTNO" }, isUnique: true, isPrimaryKey: true)
    };
}
