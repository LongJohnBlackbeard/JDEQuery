using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F95611 - .
/// </summary>
public class F95611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FTFRPTMPL.
        /// </summary>
        public const string FTFRPTMPL = "FTFRPTMPL";

        /// <summary>
        /// FTFRPTRNSL.
        /// </summary>
        public const string FTFRPTRNSL = "FTFRPTRNSL";

        /// <summary>
        /// FTFRPFUS1.
        /// </summary>
        public const string FTFRPFUS1 = "FTFRPFUS1";

        /// <summary>
        /// FTFRPFUC1.
        /// </summary>
        public const string FTFRPFUC1 = "FTFRPFUC1";

        /// <summary>
        /// FTFRPFUM1.
        /// </summary>
        public const string FTFRPFUM1 = "FTFRPFUM1";

        /// <summary>
        /// FTFRPFUD1.
        /// </summary>
        public const string FTFRPFUD1 = "FTFRPFUD1";

        /// <summary>
        /// FTPID.
        /// </summary>
        public const string FTPID = "FTPID";

        /// <summary>
        /// FTUSER.
        /// </summary>
        public const string FTUSER = "FTUSER";

        /// <summary>
        /// FTMKEY.
        /// </summary>
        public const string FTMKEY = "FTMKEY";

        /// <summary>
        /// FTUPMJ.
        /// </summary>
        public const string FTUPMJ = "FTUPMJ";

        /// <summary>
        /// FTUPMT.
        /// </summary>
        public const string FTUPMT = "FTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F95611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FTFRPTMPL", "FTFRPTMPL", JdeDataType.String, 200, true, true),
        new JdeField("FTFRPTRNSL", "FTFRPTRNSL", JdeDataType.String, 200, true, true),
        new JdeField("FTFRPFUS1", "FTFRPFUS1", JdeDataType.String, 60),
        new JdeField("FTFRPFUC1", "FTFRPFUC1", JdeDataType.String, 2),
        new JdeField("FTFRPFUM1", "FTFRPFUM1", JdeDataType.Numeric),
        new JdeField("FTFRPFUD1", "FTFRPFUD1", JdeDataType.Numeric),
        new JdeField("FTPID", "FTPID", JdeDataType.String, 20),
        new JdeField("FTUSER", "FTUSER", JdeDataType.String, 20),
        new JdeField("FTMKEY", "FTMKEY", JdeDataType.String, 30),
        new JdeField("FTUPMJ", "FTUPMJ", JdeDataType.Numeric),
        new JdeField("FTUPMT", "FTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F95611_0", "Primary Key on FTFRPTMPL, FTFRPTRNSL", new[] { "FTFRPTMPL", "FTFRPTRNSL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F95611_2", "Index on FTFRPTMPL", new[] { "FTFRPTMPL" }),
        new JdeIndex("F95611_3", "Index on FTFRPTRNSL", new[] { "FTFRPTRNSL" })
    };
}
